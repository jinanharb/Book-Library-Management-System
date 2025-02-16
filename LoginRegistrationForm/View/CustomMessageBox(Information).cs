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
    public partial class CustomMessageBox_Information_ : Form
    {
        public CustomMessageBox_Information_(string Message)
        {
            InitializeComponent();
            MsgBox.Text = Message;
        }



        private void CustomMessageBox_Information__Load(object sender, EventArgs e)
        {
        }

        private void OkBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public static void Show(string message)
        {
            CustomMessageBox_Information_ messageBox = new CustomMessageBox_Information_(message);
            messageBox.ShowDialog();
        }

        private void MsgBox_Click(object sender, EventArgs e)
        {

        }
    }
}
