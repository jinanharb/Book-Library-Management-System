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
    public partial class AuthorsInside : UserControl
    {
        public MainForm ParentFormInstance { get; set; }
        private string AuthName { get; set; }
        private SqlConnection Connect { get; set; }

        public AuthorsInside()
        {
            InitializeComponent();
        }

        public AuthorsInside(string authname, SqlConnection conn, MainForm parentform)
        {
            InitializeComponent();
            AuthName = authname;
            Connect = conn;
            ParentFormInstance = parentform;
            LoadAuthorsBooks();
        }

        private void GoBackBtn_Click(object sender, EventArgs e)
        {
            AuthorsMain authors = new AuthorsMain(Connect,ParentFormInstance);
            ParentFormInstance.addUserControl(authors);
            authors.populateItems();
        }

        public void LoadAuthorsBooks()
        {
            try
            {
                panelContainer.Controls.Clear();

                List<Book> authorsBooks = BookManager.Instance.Books
                    .Where(book => book.AuthorName == AuthName)
                    .ToList();

                AuthorName.Text = AuthName;

                foreach (Book book in authorsBooks)
                {
                    BookItem bookItem = new BookItem
                    (
                        book,
                        ParentFormInstance.LoggedInUserId
                    );

                    bookItem.UpdateButtonState();

                    panelContainer.Controls.Add(bookItem);
                }

                panelContainer.Refresh(); 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Loading Author's Books: " + ex.Message);
            }
        }
    }
}
