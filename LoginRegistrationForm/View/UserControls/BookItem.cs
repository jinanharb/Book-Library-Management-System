using LoginRegistrationForm.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;
using System.Web.Management;
using System.Web.Util;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ScrollBar;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace LoginRegistrationForm.View
{
    public partial class BookItem : UserControl
    {
        SqlConnection Connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Jinan\Desktop\SEM V\OOP\PROJECT\LoginData.mdf;Integrated Security=True;Connect Timeout=30");
        
        public BookItem()
        {
            InitializeComponent();
            UpdateButtonState();
            UpdateFavBtnState();    
        }

        public BookItem(Book BOOK, int loggedInUserId)
        {
            InitializeComponent();
            book = BOOK;
            CurrentUserId = loggedInUserId;
            BookTitle.Text = book.Title;
            BookAuthName.Text = "Author: " + book.AuthorName;
            BookImg.Image = book.BookImage;

            UpdateButtonState();
            UpdateFavBtnState();
        }


        //Defining the properties to be filled from the database into the MainForm displaying
        #region Properties

        private Book book;
        private int CurrentUserId;
        private Image _image;

        public event EventHandler<int> OnBookReturned;
        public event EventHandler<int> OnBookDisliked;

        [Category("Custom Props")]
        public Image Image
        {
            get { return _image; }
            set { _image = value; BookImg.Image = value; }
        }

        #endregion

        private void LoadBookImage()
        {
            try
            {
                Connect.Open();

                // Query to fetch the image as a byte array
                string query = "SELECT Image FROM Books WHERE BookId = @BookId";
                using (SqlCommand cmd = new SqlCommand(query, Connect))
                {
                    cmd.Parameters.AddWithValue("@BookId", book.BookId);

                    var result = cmd.ExecuteScalar();
                    if (result != DBNull.Value)
                    {
                        byte[] imageBytes = (byte[])result;
                        using (MemoryStream ms = new MemoryStream(imageBytes))
                        {
                            BookImg.Image = Image.FromStream(ms); 
                        }
                    }
                    else
                    {
                        BookImg.Image = null; 
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading image: " + ex.Message);
            }
            finally
            {
                Connect.Close();
            }
        }



        private void BookItem_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.Purple;
        }

        private void BookItem_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
        }

        public bool IsBorrowed { get; set; }


        private void BorrowBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Connect.Open();

                if (!book.IsBorrowed) // Only borrow if not already borrowed
                {
                    //Updating the book database
                    string query = "UPDATE Books SET BorrowerId = @BorrowerId WHERE BookId = @BookId";
                    using (SqlCommand cmd = new SqlCommand(query, Connect))
                    {
                        cmd.Parameters.AddWithValue("@BorrowerId", CurrentUserId);
                        cmd.Parameters.AddWithValue("@BookId", book.BookId);
                        cmd.ExecuteNonQuery();
                    }


                    //Adding a new record for a borrowed book
                    string insertBorrowedQuery = "INSERT INTO Borrowed (BookId, UserId, BorrowedDate, DueDate) VALUES (@BookId, @UserId, @BorrowedDate, @DueDate)";
                    using (SqlCommand cmd = new SqlCommand(insertBorrowedQuery, Connect))
                    {
                        cmd.Parameters.AddWithValue("@BookId", book.BookId);
                        cmd.Parameters.AddWithValue("@UserId", CurrentUserId);
                        cmd.Parameters.AddWithValue("@BorrowedDate", DateTime.Now);
                        //Modify Due date later to be set in UI!!!!!!!
                        cmd.Parameters.AddWithValue("@DueDate", DateTime.Now.AddDays(50));
                        cmd.ExecuteNonQuery();
                    }

                    CustomMessageBox_Information_.Show("Book borrowed successfully!");
                    book.BorrowerId = CurrentUserId;
                    book.IsBorrowed = true;
                    BookManager.Instance.MarkBookAsBorrowed(book.BookId, CurrentUserId);
                    UpdateButtonState();

                }
                else
                {
                    //Updating the book database
                    string query = "UPDATE Books SET BorrowerId = @BorrowerId WHERE BookId = @BookId";
                    using (SqlCommand cmd = new SqlCommand(query, Connect))
                    {
                        cmd.Parameters.AddWithValue("@BorrowerId", 0);
                        cmd.Parameters.AddWithValue("@BookId", book.BookId);
                        cmd.ExecuteNonQuery();
                    }


                    //Removing the record of this book from borrowed
                    string removeBorrowedQuery = "DELETE FROM Borrowed WHERE BookId = @BookId AND UserId = @UserId";
                    using (SqlCommand cmd = new SqlCommand(removeBorrowedQuery, Connect))
                    {
                        cmd.Parameters.AddWithValue("@BookId", book.BookId);
                        cmd.Parameters.AddWithValue("@UserId", CurrentUserId);

                        cmd.ExecuteNonQuery();
                    }

                    book.BorrowerId = 0;
                    book.IsBorrowed = false;
                    BookManager.Instance.MarkBookAsReturned(book.BookId);
                    UpdateButtonState();
                    CustomMessageBox_Information_.Show("Book Returned!");
                    OnBookReturned?.Invoke(this, book.BookId);
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                Connect.Close();
            }
        }

        private void LikeBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Connect.Open();

                    if (!book.IsFavorite)
                    {
                        string insertQuery = "INSERT INTO FavBooks (BookId, UserId) VALUES (@BookId, @UserId)";

                        using (SqlCommand insertCmd = new SqlCommand(insertQuery, Connect))
                        {
                            insertCmd.Parameters.AddWithValue("@BookId", book.BookId);
                            insertCmd.Parameters.AddWithValue("@UserId", CurrentUserId);
                            insertCmd.ExecuteNonQuery();
                        }
                        book.IsFavorite = true;
                        BookManager.Instance.MarkBookAsFav(book.BookId);
                        MessageBox.Show("Liked.");
                    }
                    else
                    {
                        string deleteQuery = "DELETE FROM FavBooks WHERE BookId = @BookId AND UserId = @UserId";

                        using (SqlCommand deleteCmd = new SqlCommand(deleteQuery, Connect))
                        {
                            deleteCmd.Parameters.AddWithValue("@BookId", book.BookId);
                            deleteCmd.Parameters.AddWithValue("@UserId", CurrentUserId);
                            deleteCmd.ExecuteNonQuery();
                        }
                        book.IsFavorite = false;
                        BookManager.Instance.MarkBookAsUnfav(book.BookId);
                        MessageBox.Show("Unliked.");
                        OnBookDisliked?.Invoke(this, book.BookId);
                    }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {

                if (Connect.State == ConnectionState.Open)
                {
                    Connect.Close();
                }
            }

            UpdateFavBtnState();
            Refresh();
            Parent?.Refresh();
        }


        public void UpdateButtonState()
        {
            if (!book.IsBorrowed)
            {
                BorrowBtn.Enabled = true;
                BorrowBtn.Text = "Borrow";
                BorrowBtn.BackColor = Color.Green;
                BorrowBtn.ForeColor = Color.White;
            }
            else if (book.BorrowerId == CurrentUserId)
            {
                BorrowBtn.Enabled = true;
                BorrowBtn.Text = "Return";
                BorrowBtn.BackColor = Color.Red;
                BorrowBtn.ForeColor = Color.White;
            }
            else
            {
                BorrowBtn.Enabled = false;
                BorrowBtn.Text = "Unavailable";
                BorrowBtn.BackColor = Color.Gray;
                BorrowBtn.ForeColor = Color.White;
            }
        }

        public void UpdateFavBtnState()
        {
            if (book.IsFavorite) 
            {
                LikeBtn.Image = Properties.Resources.FilledHeart;
            }
            else
            {
                LikeBtn.Image = Properties.Resources.EmptyHeart;
            }
            LikeBtn.Refresh();
        }
    }
}
