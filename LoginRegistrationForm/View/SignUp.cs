using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using LoginRegistrationForm.View;

namespace LoginRegistrationForm
{
    public partial class SignUp : Form
    {
        //Connecting to the database
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Jinan\Desktop\SEM V\OOP\PROJECT\LoginData.mdf;Integrated Security=True;Connect Timeout=30");
        public SignUp()
        {
            InitializeComponent();
        }

        private void SignUp_Load(object sender, EventArgs e)
        {

        }

        private void signup_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void signup_loginHere_Click(object sender, EventArgs e)
        {
            LoginForm newForm = new LoginForm();
            newForm.Show();
            this.Hide();
        }

        private void signup_btn_Click(object sender, EventArgs e)
        {
            if(signup_email.Text == "" || signup_username.Text == "" || signup_password.Text == "")
            {
                CustomMessageBox_Information_.Show("Please fill all blank fields");                          
            }
            else
            {
                if (connect.State != ConnectionState.Open)
                {
                    try
                    {
                        connect.Open();
                        //sql query(written inside a string to be referenced in Sqlcommand) to check below if username already exists 
                        string checkUsername = "SELECT * FROM users WHERE username = '"
                            + signup_username.Text.Trim() + "'" + "OR email='" + signup_email.Text.Trim() + "'";


                        using (SqlCommand checkUser = new SqlCommand(checkUsername, connect))
                        {
                            //using adapter to fill table only if the user exists
                            SqlDataAdapter adapter = new SqlDataAdapter(checkUser);
                            DataTable table = new DataTable();
                            adapter.Fill(table);

                            if (table.Rows.Count >= 1)
                            {
                                CustomMessageBox_Error_.Show("Email or username already exists");
                            }
                            else
                            {
                                string insertData = "INSERT INTO users(email, username, password, date_created) " +
                                    "VALUES(@email, @username, @pass, @date)"; //Values here are placeholders

                                DateTime date = DateTime.Today;

                                using (SqlCommand cmd = new SqlCommand(insertData, connect))
                                {
                                    cmd.Parameters.AddWithValue("@email", signup_email.Text.Trim());
                                    cmd.Parameters.AddWithValue("@username", signup_username.Text.Trim());
                                    cmd.Parameters.AddWithValue("@pass", signup_password.Text.Trim());
                                    cmd.Parameters.AddWithValue("@date", date);


                                    //Filling the new user into users by executing the command
                                    cmd.ExecuteNonQuery();

                                    CustomMessageBox_Information_.Show("Registered successfully");

                                    //Switching to login after registering
                                    LoginForm newForm = new LoginForm();
                                    newForm.Show();
                                    this.Hide();
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
                        connect.Close();
                    }
                }
            }
        }
            

        private void signup_showPass_CheckedChanged(object sender, EventArgs e)
        {
            if(signup_showPass.Checked) 
            {
                signup_password.PasswordChar = '\0';
            }
            else
            {
                signup_password.PasswordChar = '*';
            }
        }
    }
}
