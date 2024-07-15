

using Microsoft.Data.SqlClient;
//using System.Data.SqlClient;
namespace EmployeeManagement
{
    public partial class Form1 : Form
    {
        SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\hasan\\Documents\\employee.mdf;Integrated Security=True;Connect Timeout=30");


        public Form1()
        {
            InitializeComponent();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void register_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Register register = new Register();
            register.Show();
        }

        private void login_check_CheckedChanged(object sender, EventArgs e)
        {
            login_password.PasswordChar = login_check.Checked ? '\0' : '*';
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            if(login_username.Text!="" && login_password.Text!="")
            {
                try
                {
                    connection.Open();
                    string query = "select count(id) from users where username = @username and password = @password";

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@username", login_username.Text.Trim());
                        cmd.Parameters.AddWithValue("@password", login_password.Text.Trim());
                        int c = (int)cmd.ExecuteScalar();
                        if (c > 0)
                        {
                            MessageBox.Show("Login Successfull");
                            MainForm mf = new MainForm();
                            mf.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Invalid");
                        }
                    }
                }
                catch (Exception ex) { 
                MessageBox.Show(ex.Message);
                }
                finally { 
                    connection.Close();
                }
            }
            else
            {
                MessageBox.Show("Please Fill ALl the Value");
            }
        }
    }
}
