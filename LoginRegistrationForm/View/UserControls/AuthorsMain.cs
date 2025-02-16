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
    public partial class AuthorsMain : UserControl
    {
        public MainForm ParentFormInstance { get; set; }
        private SqlConnection Connect { get; set; }

        public AuthorsMain()
        {
            InitializeComponent();
        }

        public AuthorsMain(SqlConnection conn, MainForm parentform)
        {
            InitializeComponent();
            Connect = conn;
            ParentFormInstance = parentform;
        }

        public void populateItems()
        {
            List<Author> Authors = new List<Author>();

            try
            {
                Connect.Open();
                string selectData = "SELECT * FROM Authors";

                using (SqlCommand cmd = new SqlCommand(selectData, Connect))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Author author = new Author(
                                reader["AuthorName"].ToString(),
                                reader["BooksCount"].ToString()
                                );
                            Authors.Add(author);

                            AuthorItem authorItem = new AuthorItem
                            {
                                AuthName = author.AuthorName,
                                Count = author.BooksCount,
                            };

                            authorItem.LoadBooksClicked += AuthorItem_LoadBooksClicked;
                            flowLayoutPanel1.Controls.Add(authorItem);
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
                Connect.Close();
            }
        }

        private void AuthorItem_LoadBooksClicked(object sender, string AuthName)
        {
            AuthorsInside author = new AuthorsInside(AuthName, Connect, ParentFormInstance);
            ParentFormInstance.addUserControl(author);
        }
    }
}
