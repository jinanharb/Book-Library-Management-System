using LoginRegistrationForm.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginRegistrationForm.View.UserControls
{
    public partial class MyBooks : UserControl
    {
        private int LoggedInUserId { get; set; }
        private SqlConnection Connect { get; set; }

        public MyBooks()
        {
            InitializeComponent();
        }

        public MyBooks(int CurrentUserId, SqlConnection conn)
        {
            InitializeComponent();
            Connect = conn;
            LoggedInUserId = CurrentUserId;
        }

        public void DisplayBooks()
        {
            panelContainer.Controls.Clear(); 

            List<Book> myBooks = BookManager.Instance.Books
                .Where(book => book.BorrowerId == LoggedInUserId) // Filter borrowed books
                .ToList();

            foreach (Book book in myBooks)
            {
                BookItem bookItem = new BookItem
                (
                    book,
                    LoggedInUserId
                );
                
                bookItem.OnBookReturned += (sender, bookId) =>
                {
                    RemoveBookFromMyBooks(bookId, bookItem);
                };

                panelContainer.Controls.Add(bookItem);
            }
        }

        //Method to remove returned books
        private void RemoveBookFromMyBooks(int bookId, BookItem bookItem)
        {
            panelContainer.Controls.Remove(bookItem);
            bookItem.Dispose();

            BookManager.Instance.MarkBookAsReturned(bookId);
        }
    }
}
