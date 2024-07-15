using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeManagement
{
    public partial class Dashboard : UserControl
    {
        SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\hasan\\Documents\\employee.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=True");

        public Dashboard()
        {
            InitializeComponent();

            display_TE();
            display_AE();
            display_IE();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void dash_board_TE_Click(object sender, EventArgs e)
        {
           
        }

        public void display_TE()
        {
            try
            {
                conn.Open();
                string data = "select count(id) from employees where delete_date is null";
                using (SqlCommand cmd = new SqlCommand(data, conn))
                {
                    int n = (int)cmd.ExecuteScalar();
                    string s = n.ToString();
                    dash_board_TE.Text = s;
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
        public void display_AE()
        {
            try
            {
                conn.Open();
                string data = "select count(id) from employees where status ='Active' and delete_date is null";
                using (SqlCommand cmd = new SqlCommand(data, conn))
                {
                    int n = (int)cmd.ExecuteScalar();
                    string s = n.ToString();
                    dash_board_AE.Text = s;
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
        public void display_IE()
        {
            try
            {
                conn.Open();
                string data = "select count(id) from employees where status ='Absent' and delete_date is null";
                using (SqlCommand cmd = new SqlCommand(data, conn))
                {
                    int n = (int)cmd.ExecuteScalar();
                    string s = n.ToString();
                    dash_board_TE.Text = s;
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
