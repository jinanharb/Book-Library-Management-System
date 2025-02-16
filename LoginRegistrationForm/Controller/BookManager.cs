using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginRegistrationForm.Model
{
    internal class BookManager
    {
        SqlConnection Connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Jinan\Desktop\SEM V\OOP\PROJECT\LoginData.mdf;Integrated Security=True;Connect Timeout=30");
        private static BookManager instance;
        public List<Book> Books { get; private set; }

        private BookManager()
        {
            Books = new List<Book>();
        }

        public static BookManager Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new BookManager();
                }
                return instance;
            }
        }

        public void AddBook(Book book)
        {
            //ensuring books are not duplicated
            if (!Books.Any(b => b.BookId == book.BookId))
            {
                Books.Add(book);
            }
        }

        public void MarkBookAsBorrowed(int bookId, int userId)
        {
            Book book = Books.FirstOrDefault(b => b.BookId == bookId);
            if (book != null)
            {
                book.BorrowerId = userId;
                book.IsBorrowed = true;
            }
        }
        public void MarkBookAsReturned(int bookId)
        {
            Book book = Books.FirstOrDefault(b => b.BookId == bookId);
            if (book != null)
            {
                book.BorrowerId = 0;
                book.IsBorrowed = false;
                book.IsOverdue = false;
            }
        }
        public void MarkBookAsFav(int bookId)
        {
            Book book = Books.FirstOrDefault(b => b.BookId == bookId);
            if (book != null)
            {
                book.IsFavorite = true;
            }
        }
        public void MarkBookAsUnfav(int bookId)
        {
            Book book = Books.FirstOrDefault(b => b.BookId == bookId);
            if (book != null)
            {
                book.IsFavorite = false;
            }
        }

        // Function to check if a book is marked as favorite by the logged-in user
        public bool IsBookFavorite(int bookId, int userId)
        {
            string query = "SELECT COUNT(*) FROM FavBooks WHERE BookId = @bookId AND UserId = @userId";
            using (SqlCommand cmd = new SqlCommand(query, Connect))
            {
                cmd.Parameters.AddWithValue("@bookId", bookId);
                cmd.Parameters.AddWithValue("@userId", userId);
                Connect.Open();
                int count = (int)cmd.ExecuteScalar();
                Connect.Close();
                return count > 0;
            }
        }
        public bool IsBookOverdue(int bookId, int userId)
        {
            string query = "SELECT COUNT(*) FROM Borrowed WHERE BookId = @bookId AND UserId = @userId AND DueDate < GETDATE()";

            using (SqlCommand cmd = new SqlCommand(query, Connect))
            {
                cmd.Parameters.AddWithValue("@bookId", bookId);
                cmd.Parameters.AddWithValue("@userId", userId);

                Connect.Open();
                int count = (int)cmd.ExecuteScalar();
                Connect.Close();

                return count > 0; 
            }
        }


        public List<Book> GetAllBooks()
        {
            return Books;
        }
    }
}
