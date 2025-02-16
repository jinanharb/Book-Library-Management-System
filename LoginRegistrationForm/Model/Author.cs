using LoginRegistrationForm.View.UserControls;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace LoginRegistrationForm.Model
{
    internal class Author
    {
        public string AuthorName { get; set; }
        public int AuthId { get; set; }
        public string BooksCount { get; set; }

        public Author(string name, string booksCount)
        {
            AuthorName = name;
            BooksCount = booksCount;
        }
    }
}
