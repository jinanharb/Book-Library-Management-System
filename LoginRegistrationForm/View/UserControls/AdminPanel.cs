using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LoginRegistrationForm.Model;

namespace LoginRegistrationForm.View.UserControls
{
    public partial class AdminPanel : UserControl
    {
        private int LoggedInUserId { get; set; }
        private SqlConnection Connect { get; set; }

        public AdminPanel()
        {
            InitializeComponent();
        }

        public AdminPanel(int CurrentUserId, SqlConnection conn)
        {
            InitializeComponent();
            Connect = conn;
            LoggedInUserId = CurrentUserId;
        }

        private void AdminPanel_Load(object sender, EventArgs e)
        {
            DisplayBooks();
        }

        public void DisplayBooks()
        {
            BooksDGV.DataSource = null; 
            BooksDGV.DataSource = BookManager.Instance.Books.ToList();
            BooksDGV.Refresh(); 
        }

        private void Clear()
        {
            BookNameTb.Text = "";
            IsbnTb.Text = "";
            AuthorNameTb.Text = "";
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            //First adding the book to books database
            if (BookNameTb.Text == "" || IsbnTb.Text == "" || AuthorNameTb.Text == "")
            {
                CustomMessageBox_Error_.Show("Missing Information");
            }
            else
            {
                if (string.IsNullOrWhiteSpace(BookNameTb.Text))
                {
                    throw new Exception("Title can't be empty");
                }
                else if (BookNameTb.Text.Length > 255)
                {
                    throw new Exception("Title is too long; the maximum allowed is 255 characters.");
                }
                if (string.IsNullOrWhiteSpace(AuthorNameTb.Text))
                {
                    throw new Exception("Author can't be empty");
                }
                else if (AuthorNameTb.Text.Length > 255)
                {
                    throw new Exception("Author is too long; the maximum allowed is 255 characters.");
                }
                if (string.IsNullOrWhiteSpace(IsbnTb.Text))
                {
                    throw new Exception("ISBN can't be empty");
                }
                try
                {
                    Connect.Open();
                    // Convert the image to a byte array
                    byte[] imageBytes = null;
                    Image bookImage = null;

                    if (BookImagePb.Image != null)
                    {
                        using (MemoryStream ms = new MemoryStream())
                        {
                            BookImagePb.Image.Save(ms, ImageFormat.Jpeg);
                            imageBytes = ms.ToArray();
                        }
                        bookImage = BookImagePb.Image; // Keep image for Book object
                    }

                    // Insert book into the database
                    string insertData = "INSERT INTO Books (Title, AuthorName, ISBN, BookImage) " +
                                        "VALUES (@title, @author, @isbn, @image)";

                    using (SqlCommand cmd = new SqlCommand(insertData, Connect))
                    {
                        cmd.Parameters.AddWithValue("@title", BookNameTb.Text.Trim());
                        cmd.Parameters.AddWithValue("@author", AuthorNameTb.Text.Trim());
                        cmd.Parameters.AddWithValue("@isbn", IsbnTb.Text.Trim());

                        cmd.Parameters.Add("@image", SqlDbType.VarBinary, -1).Value =
                            (imageBytes != null) ? imageBytes : (object)DBNull.Value;

                        cmd.ExecuteNonQuery();
                    }


                    CustomMessageBox_Information_.Show("Book added successfully!");

                    // Fetch the newly inserted book's ID
                    int newBookId = 0;
                    string getIdQuery = "SELECT CAST(SCOPE_IDENTITY() AS INT)"; // Ensure INT type

                    using (SqlCommand idCommand = new SqlCommand(getIdQuery, Connect))
                    {
                        object result = idCommand.ExecuteScalar();
                        if (result != null && result != DBNull.Value)
                        {
                            newBookId = Convert.ToInt32(result);
                        }
                    }

                    // Add the book to the global BookManager list
                    Book newBook = new Book(
                             BookNameTb.Text.Trim(),
                             AuthorNameTb.Text.Trim(),
                             IsbnTb.Text.Trim(),
                             newBookId,
                             0, // Borrower ID (default)
                             bookImage,
                             false, 
                             false,
                             false
                             );


                    BookManager.Instance.AddBook(newBook);

                    DisplayBooks();

                    //Now updating Authors table

                    string checkAuthor = "SELECT BooksCount FROM Authors WHERE AuthorName = @author";
                    string insertAuthor = "INSERT INTO Authors (AuthorName, BooksCount) VALUES (@author, @bookscount)";
                    string updateAuthor = "UPDATE Authors SET BooksCount = BooksCount + 1 WHERE AuthorName = @author";

                    using (SqlCommand cmd = new SqlCommand(checkAuthor, Connect))
                    {
                        cmd.Parameters.AddWithValue("@author", AuthorNameTb.Text.Trim());
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            //If Author already exists
                            if (reader.HasRows)
                            {
                                reader.Close();
                                using (SqlCommand updateCmd = new SqlCommand(updateAuthor, Connect))
                                {
                                    updateCmd.Parameters.AddWithValue("@author", AuthorNameTb.Text.Trim());
                                    updateCmd.ExecuteNonQuery();
                                }
                            }
                            //Author doesn't exist
                            else
                            {
                                reader.Close();
                                using (SqlCommand insertCmd = new SqlCommand(insertAuthor, Connect))
                                {
                                    insertCmd.Parameters.AddWithValue("@author", AuthorNameTb.Text.Trim());
                                    insertCmd.Parameters.AddWithValue("@bookscount", 1);
                                    insertCmd.ExecuteNonQuery();
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error connecting Database: " + ex, "ErrorMessage", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    Clear();
                    Connect.Close();
                }
            }
        }

        int key = 0;
        //Making the click on a table row display its content
        private void BooksDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = BooksDGV.Rows[e.RowIndex];

                BookNameTb.Text = selectedRow.Cells["Title"].Value?.ToString();
                IsbnTb.Text = selectedRow.Cells["ISBN"].Value?.ToString();
                AuthorNameTb.Text = selectedRow.Cells["AuthorName"].Value?.ToString();

                // Assign the key from the unique identifier (BookId)
                key = Convert.ToInt32(selectedRow.Cells["BookId"].Value);
            }
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (key == 0)
            {
                CustomMessageBox_Information_.Show("Select a book");
            }
            else
            {
                try
                {
                    // Retrieve the old author name from the selected row
                    string oldAuthor = null;
                    string query = "SELECT AuthorName FROM Books WHERE BookID = @bookId";

                    Connect.Open();
                    using (SqlCommand cmd = new SqlCommand(query, Connect))
                    {
                        cmd.Parameters.AddWithValue("@bookId", key);
                        var result = cmd.ExecuteScalar();
                        if (result != null)
                        {
                            oldAuthor = result.ToString();
                        }
                        else
                        {
                            CustomMessageBox_Error_.Show("No author found for the given BookID.");
                        }
                    }
                    Connect.Close();

                    // Update the book details
                    string updateData = "UPDATE Books SET Title = @title, AuthorName = @author, ISBN = @isbn WHERE BookId = @bookid";

                    Connect.Open();
                    using (SqlCommand cmd = new SqlCommand(updateData, Connect))
                    {
                        cmd.Parameters.AddWithValue("@bookid", key);
                        cmd.Parameters.AddWithValue("@title", BookNameTb.Text.Trim());
                        cmd.Parameters.AddWithValue("@isbn", IsbnTb.Text.Trim());
                        cmd.Parameters.AddWithValue("@author", AuthorNameTb.Text.Trim());
                        cmd.ExecuteNonQuery();

                        CustomMessageBox_Information_.Show("Book Updated!");
                    }

                    //Now updating the authors table
                    if (oldAuthor != AuthorNameTb.Text)
                    {
                        // Handle the old author
                        string decrementBooksCount = "UPDATE Authors SET BooksCount = BooksCount - 1 WHERE AuthorName = @oldAuthor";
                        string deleteOldAuthor = "DELETE FROM Authors WHERE AuthorName = @oldAuthor AND BooksCount <= 0";

                        using (SqlCommand cmd = new SqlCommand(decrementBooksCount, Connect))
                        {
                            cmd.Parameters.AddWithValue("@oldAuthor", oldAuthor);
                            cmd.ExecuteNonQuery();
                        }
                        using (SqlCommand cmd = new SqlCommand(deleteOldAuthor, Connect))
                        {
                            cmd.Parameters.AddWithValue("@oldAuthor", oldAuthor);
                            cmd.ExecuteNonQuery();
                        }

                        // Handle the new author
                        string checkNewAuthor = "SELECT BooksCount FROM Authors WHERE AuthorName = @newAuthor";
                        string insertNewAuthor = "INSERT INTO Authors (AuthorName, BooksCount) VALUES (@newAuthor, @booksCount)";
                        string incrementBooksCount = "UPDATE Authors SET BooksCount = BooksCount + 1 WHERE AuthorName = @newAuthor";

                        using (SqlCommand cmd = new SqlCommand(checkNewAuthor, Connect))
                        {
                            cmd.Parameters.AddWithValue("@newAuthor", AuthorNameTb.Text.Trim());
                            using (SqlDataReader reader = cmd.ExecuteReader())
                            {
                                if (reader.HasRows)
                                {
                                    reader.Close();
                                    using (SqlCommand updateCmd = new SqlCommand(incrementBooksCount, Connect))
                                    {
                                        updateCmd.Parameters.AddWithValue("@newAuthor", AuthorNameTb.Text.Trim());
                                        updateCmd.ExecuteNonQuery();
                                    }
                                }
                                else
                                {
                                    reader.Close();
                                    using (SqlCommand insertCmd = new SqlCommand(insertNewAuthor, Connect))
                                    {
                                        insertCmd.Parameters.AddWithValue("@newAuthor", AuthorNameTb.Text.Trim());
                                        insertCmd.Parameters.AddWithValue("@booksCount", 1);
                                        insertCmd.ExecuteNonQuery();
                                    }
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error connecting Database: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    Clear();
                    Connect.Close();
                }
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (key == 0)
            {
                CustomMessageBox_Information_.Show("Select a book");
                return;
            }
            else
            {
                try
                {
                    // Retrieve the author name for the book being deleted
                    string author = null;
                    string query = "SELECT AuthorName FROM Books WHERE BookId = @bookid";

                    Connect.Open();
                    using (SqlCommand cmd = new SqlCommand(query, Connect))
                    {
                        cmd.Parameters.AddWithValue("@bookid", key);
                        var result = cmd.ExecuteScalar();
                        if (result != null)
                        {
                            author = result.ToString();
                        }
                        else
                        {
                            CustomMessageBox_Error_.Show("No author found for the given BookID.");
                        }
                        Connect.Close();
                    }


                    //Deleting from Books table
                    Connect.Open();
                    string deleteData = "delete from Books Where BookId = @Bookid";

                    using (SqlCommand cmd = new SqlCommand(deleteData, Connect))
                    {
                        cmd.Parameters.AddWithValue("@bookid", key);
                        cmd.ExecuteNonQuery();
                        CustomMessageBox_Information_.Show("Book deleted!");
                    }

                    //Updating the authors table
                    string decrementBooksCount = "UPDATE Authors SET BooksCount = BooksCount - 1 WHERE AuthorName = @author";
                    string deleteAuthor = "DELETE FROM Authors WHERE AuthorName = @author AND BooksCount <= 0";

                    using (SqlCommand cmd = new SqlCommand(decrementBooksCount, Connect))
                    {
                        cmd.Parameters.AddWithValue("@author", author);
                        cmd.ExecuteNonQuery();
                    }
                    using (SqlCommand cmd = new SqlCommand(deleteAuthor, Connect))
                    {
                        cmd.Parameters.AddWithValue("@author", author);
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error connecting Database: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    Clear();
                    Connect.Close();
                }
            }
        }

        private void AddImgBtn_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                { 
                    BookImagePb.Image = Image.FromFile(openFileDialog.FileName);
                }
            }
        }
    }
}
