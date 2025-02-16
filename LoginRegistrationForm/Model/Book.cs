using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace LoginRegistrationForm.Model
{
    public class Book
    {
        public string Title { get; set; }
        public string AuthorName { get; set; }
        public string ISBN { get; set; }
        public int BookId { get; set; }
        public int BorrowerId { get; set; }
        public Image BookImage { get; set; }
        public bool IsBorrowed { get; set; }
        public bool IsFavorite { get; set; }
        public bool IsOverdue { get; set; }

        public Book(string title, string authorName, string isbn, int bookId, int borrowerId, Image image, bool isFavorite, bool isBorrowed, bool isOverdue)
        {
            Title = title;
            AuthorName = authorName;
            ISBN = isbn;
            BookId = bookId;
            BorrowerId = borrowerId;
            BookImage = image;
            IsBorrowed = isBorrowed;
            IsFavorite = isFavorite;    
            IsOverdue = isOverdue;
        }
    }
}

