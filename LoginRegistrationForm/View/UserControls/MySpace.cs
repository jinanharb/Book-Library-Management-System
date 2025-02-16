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
    public partial class MySpace : UserControl
    {
        private int LoggedInUserId { get; set; }
        private SqlConnection Connect { get; set; }

        public MySpace()
        {
            InitializeComponent();
        }

        public MySpace(int CurrentUserId, SqlConnection conn)
        {
            InitializeComponent();
            Connect = conn;
            LoggedInUserId = CurrentUserId;
            MyBooks mybks = new MyBooks(LoggedInUserId, Connect);
            addUserControl(mybks);
            mybks.DisplayBooks();
        }

        public void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(userControl);
            userControl.BringToFront();
        }
    }
}
