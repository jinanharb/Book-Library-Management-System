using LoginRegistrationForm.View;
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

namespace LoginRegistrationForm
{
    public partial class AuthorItem : UserControl
    {
        public event EventHandler<string> LoadBooksClicked;

        public AuthorItem()
        {
            InitializeComponent();
        }

        public AuthorItem(string name, string count)
        {
            AuthName = name;
            Count = count;
        }

        //Defining the properties to be filled from the database in the Authors form displaying
        #region Properties

        private string _name;
        private string _count;

        [Category("Custom Props")]
        public string AuthName
        {
            get { return _name; }
            set { _name = value; authName.Text = value; }
        }


        [Category("Custom Props")]
        public string Count
        {
            get { return _count; }
            set { _count = value; BookCount.Text = value; }
        }

        #endregion

        //Move to the auhor's books page
        private void LoadBooks_Click(object sender, EventArgs e)
        {
            LoadBooksClicked?.Invoke(this, AuthName);
        }
    }
}
