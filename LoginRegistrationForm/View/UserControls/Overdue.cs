using LoginRegistrationForm.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginRegistrationForm.View.UserControls
{
    public partial class Overdue : UserControl
    {
        private int LoggedInUserId { get; set; }
        private SqlConnection Connect { get; set; }

        public Overdue()
        {
            InitializeComponent();
        }

        public Overdue(int CurrentUserId, SqlConnection conn)
        {
            InitializeComponent();
            Connect = conn;
            LoggedInUserId = CurrentUserId;
        }

        public void DisplayBooks()
        {
            panelContainer.Controls.Clear();

            List<Book> favoriteBooks = BookManager.Instance.Books
                .Where(book => book.IsOverdue)
                .ToList();

            foreach (Book book in favoriteBooks)
            {
                BookItem bookItem = new BookItem
                (
                    book,
                    LoggedInUserId
                );

                bookItem.OnBookReturned += (sender, bookId) =>
                {
                    RemoveBookFromOverdue(bookId, bookItem);
                };

                panelContainer.Controls.Add(bookItem);
            }

            panelContainer.Refresh();
        }


        private void RemoveBookFromOverdue(int bookId, BookItem bookItem)
        {
            panelContainer.Controls.Remove(bookItem);
            bookItem.Dispose();

            BookManager.Instance.MarkBookAsReturned(bookId);
        }

    }

}
