using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginRegistrationForm.View
{
    public partial class CustomMessageBox_Error_ : Form
    {
        public CustomMessageBox_Error_(string Message)
        {
            InitializeComponent();
            MsgBox.Text = Message;
        }

        private void OkBtn_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        public static void Show(string message)
        {
            CustomMessageBox_Error_ messageBox = new CustomMessageBox_Error_(message);
            messageBox.ShowDialog();
        }
    }
}
