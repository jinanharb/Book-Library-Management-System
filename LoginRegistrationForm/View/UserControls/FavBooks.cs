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
using System.Web.Util;
using System.Windows.Forms;

namespace LoginRegistrationForm.View.UserControls
{
    public partial class FavBooks : UserControl
    {
        private int LoggedInUserId { get; set; }
        private SqlConnection Connect { get; set; }

        public FavBooks()
        {
            InitializeComponent();
        }

        public FavBooks(int CurrentUserId, SqlConnection conn)
        {
            InitializeComponent();
            Connect = conn;
            LoggedInUserId = CurrentUserId;
        }

        public void DisplayBooks()
        {
            panelContainer.Controls.Clear();

            List<Book> favoriteBooks = BookManager.Instance.Books
                .Where(book => book.IsFavorite)
                .ToList();

            foreach (Book book in favoriteBooks)
            {
                BookItem bookItem = new BookItem
                (
                    book,
                    LoggedInUserId
                );
                
                bookItem.OnBookDisliked += (sender, bookId) =>
                {
                    RemoveBookFromFavBooks(bookId, bookItem);
                };

                panelContainer.Controls.Add(bookItem);
            }

            panelContainer.Refresh();
        }

        private void RemoveBookFromFavBooks(int bookId, BookItem bookItem)
        {
            panelContainer.Controls.Remove(bookItem);
            bookItem.Dispose();
        }
    }
}
