using LoginRegistrationForm.Model;
using LoginRegistrationForm.View;
using LoginRegistrationForm.View.UserControls;
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

namespace LoginRegistrationForm
{
    public partial class MainForm : Form
    {
        SqlConnection Connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Jinan\Desktop\SEM V\OOP\PROJECT\LoginData.mdf;Integrated Security=True;Connect Timeout=30");
        public int LoggedInUserId { get; set; }

        public MainForm()
        {
            InitializeComponent();
        }

        public MainForm(int userId)  
        {
            InitializeComponent();
            LoggedInUserId = userId; // Store logged-in user ID to send when borrowing

            HomePage hmpg = new HomePage(LoggedInUserId, Connect);
            addUserControl(hmpg);
            LoadBooksFromDatabase();
            hmpg.DisplayBooks();
        }

        public void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            MySpaceContainer.Controls.Clear();
            MySpaceContainer.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadBooksFromDatabase();

            AdminPanel adm = new AdminPanel(LoggedInUserId, Connect);
            adm.DisplayBooks();

            // Show the admin button only if the logged-in user ID is 5 (admin's id is 5)
            if (LoggedInUserId != 5)
            {
                adminBtn.Visible = false;
                pnAdmin.Visible = false;
            }
        }


        private void HomePageBtn_Click(object sender, EventArgs e)
        {
            HomePage hmpg = new HomePage(LoggedInUserId, Connect);
            addUserControl(hmpg);
            hmpg.DisplayBooks();
        }

        private void MySpaceBtn_Click(object sender, EventArgs e)
        {
            MySpaceTransition.Start();
        }

        private void AuthorsBtn_Click(object sender, EventArgs e)
        {
            AuthorsMain auths = new AuthorsMain(Connect, this);
            addUserControl(auths);
            auths.populateItems();
        }

        private void adminBtn_Click(object sender, EventArgs e)
        {
            AdminPanel adm = new AdminPanel(LoggedInUserId, Connect);
            addUserControl(adm);
            adm.DisplayBooks();
        }

        private void LogoutBtn_Click(object sender, EventArgs e)
        {
            LoginForm newForm = new LoginForm();
            newForm.Show();
            this.Hide();
        }

        public void LoadBooksFromDatabase()
        {
            if (Connect.State != ConnectionState.Open)
            {
                Connect.Open();
            }

            BookManager.Instance.Books.Clear();

            string Query = "SELECT * FROM Books";
            SqlDataAdapter adapter = new SqlDataAdapter(Query, Connect);
            SqlCommandBuilder Builder = new SqlCommandBuilder(adapter);
            var ds = new DataSet();
            adapter.Fill(ds);

            foreach (DataRow row in ds.Tables[0].Rows)
            {
                Image bookImage = null;
                if (row["BookImage"] != DBNull.Value)
                {
                    byte[] imgBytes = (byte[])row["BookImage"];
                    using (MemoryStream ms = new MemoryStream(imgBytes))
                    {
                        bookImage = Image.FromStream(ms);
                    }
                }

                Book book = new Book(
                    row["Title"].ToString(),
                    row["AuthorName"].ToString(),
                    row["ISBN"].ToString(),
                    Convert.ToInt32(row["BookId"]),
                    row["BorrowerId"] == DBNull.Value ? 0 : Convert.ToInt32(row["BorrowerId"]),
                    bookImage,
                    BookManager.Instance.IsBookFavorite(Convert.ToInt32(row["BookId"]), LoggedInUserId),
                    Convert.ToInt32(row["BorrowerId"]) != 0,
                    BookManager.Instance.IsBookOverdue(Convert.ToInt32(row["BookId"]), LoggedInUserId)
                );

                BookManager.Instance.AddBook(book);
            }

            Connect.Close();
        }


        bool MySpaceExpand = false;

        private void MySpaceTransition_Tick(object sender, EventArgs e)
        {
            if (MySpaceExpand == false)
            {
                MySpaceCont.Height += 2;
                if(MySpaceCont.Height >= 240)
                {
                    MySpaceTransition.Stop();
                    MySpaceExpand = true;
                }
            }
            else
            {
                MySpaceCont.Height -= 2;
                if (MySpaceCont.Height <= 55)
                {
                    MySpaceTransition.Stop();
                    MySpaceExpand = false;
                }
            }
        }

        bool sidebarExpand = true;

        private void SidebarTransition_Tick(object sender, EventArgs e)
        {
            if(sidebarExpand)
            {
                sidebar.Width -= 5;
                if (sidebar.Width <= 40)
                {
                    sidebarExpand = false;
                    SidebarTransition.Stop();
                }
            }
            else
            {
                sidebar.Width += 5;
                if (sidebar.Width >= 192) 
                {
                    sidebarExpand = true;
                    SidebarTransition.Stop();
                }
            }
        }

        private void menuBtn_Click(object sender, EventArgs e)
        {
            SidebarTransition.Start();
        }

        private void MyBooksBtn_Click(object sender, EventArgs e)
        {
            MyBooks mybks = new MyBooks(LoggedInUserId, Connect);
            addUserControl(mybks);
            mybks.DisplayBooks();
        }

        private void OverdueBtn_Click(object sender, EventArgs e)
        {
            Overdue ovrd = new Overdue(LoggedInUserId, Connect);
            addUserControl(ovrd);
            ovrd.DisplayBooks();
        }

        private void FavBtn_Click(object sender, EventArgs e)
        {
            FavBooks favbks = new FavBooks(LoggedInUserId, Connect);
            addUserControl(favbks);
            favbks.DisplayBooks();
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
