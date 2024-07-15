using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;

namespace EmployeeManagement
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\hasan\\Documents\\employee.mdf;Integrated Security=True;Connect Timeout=30");
        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 login = new Form1();
            login.Show();
        }

        private void signup_check_CheckedChanged(object sender, EventArgs e)
        {
            register_pass.PasswordChar = signup_check.Checked ? '\0' : '*';
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (register_name.Text != "" && register_pass.Text != "")
            {
                try
                {
                    connection.Open();
                    string query = "select count(id) from users where username = @user";
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@user",register_name.Text.Trim());
                        int c = (int)cmd.ExecuteScalar();
                        if (c > 0) {
                            MessageBox.Show("UserName Already Exist");
                        }
                        else
                        {
                            DateTime dt = DateTime.Today;
                            string insertData = "insert into users" +
                                "(username,password,date_register)" +
                                "values(@username, @password, @datereg)";
                            using (SqlCommand insert = new SqlCommand(insertData,connection))
                            {
                                insert.Parameters.AddWithValue("@username",register_name.Text.Trim());
                                insert.Parameters.AddWithValue("@password", register_pass.Text.Trim());
                                insert.Parameters.AddWithValue("@datereg", dt);
                                insert.ExecuteNonQuery();
                                MessageBox.Show("Registration Successfull");
                                
                                Form1 login = new Form1();
                                login.Show();
                                this.Hide();
                            }
                        }
                    }

                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {

                    connection.Close(); 
                }
            }
            else
            {
                MessageBox.Show("Please fill All");
            }
        }
    }
}
