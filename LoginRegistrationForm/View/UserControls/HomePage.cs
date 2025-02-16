using LoginRegistrationForm.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginRegistrationForm.View.UserControls
{
    public partial class HomePage : UserControl
    {
        private int LoggedInUserId { get; set; }
        private SqlConnection Connect { get; set; }

        public HomePage()
        {
            InitializeComponent();
        }

        public HomePage(int CurrentUserId, SqlConnection conn)
        {
            InitializeComponent();
            Connect = conn;
            LoggedInUserId = CurrentUserId;
        }

        public void DisplayBooks(string filter = "All")
        {
            panelContainer.Controls.Clear();

            // Get books from BookManager (already populated from the database)
            List<Book> books = BookManager.Instance.GetAllBooks();

            // Apply filter based on the given parameter
            switch (filter)
            {
                case "Borrowed":
                    books = books.Where(b => b.IsBorrowed).ToList();
                    break;
                case "MyBooks":
                    books = books.Where(b => b.BorrowerId == LoggedInUserId).ToList();
                    break;
                case "All":
                default:
                    break; 
            }

            foreach (Book book in books)
            {
                // Create a BookItem instance for UI display
                BookItem bookItem = new BookItem
                (
                    book,
                    LoggedInUserId
                );

                panelContainer.Controls.Add(bookItem);
            }
        }

        public void SearchBooks(string searchQuery)
        {
            panelContainer.Controls.Clear();
            List<Book> filteredBooks = BookManager.Instance.Books
                .Where(book => book.Title.IndexOf(searchQuery, StringComparison.OrdinalIgnoreCase) >= 0 ||
                               book.AuthorName.IndexOf(searchQuery, StringComparison.OrdinalIgnoreCase) >= 0)
                .ToList();

            foreach (Book book in filteredBooks)
            {
                BookItem bookItem = new BookItem(book, LoggedInUserId);
                panelContainer.Controls.Add(bookItem);
            }

            panelContainer.Refresh();
        }


        private void SearchBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string searchQuery = SearchBox.Text.Trim();

                if (string.IsNullOrWhiteSpace(searchQuery))
                {
                    DisplayBooks();
                }
                else
                {
                    SearchBooks(searchQuery);
                }
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error); //fix this
            }
        }
    }
}
