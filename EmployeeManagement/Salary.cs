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
using Microsoft.Data.SqlClient;

namespace EmployeeManagement
{
    public partial class Salary : UserControl
    {
        SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\hasan\\Documents\\employee.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=True");
        public Salary()
        {
            InitializeComponent();
            dataValidate();
            displaySalary();
        }
        public void dataValidate()
        {
            salary_emp_id.Enabled = false;
            salary_full_name.Enabled = false;
            salary_emp_position.Enabled = false;
        }

        public void displaySalary()
        {
            SalaryData salaryData = new SalaryData();
            List<SalaryData> sd = salaryData.employeeSalary();
            dataGridView1.DataSource = sd;


        }
        public void clearData()
        {
            salary_emp_id.Text = "";
            salary_full_name.Text = "";
            salary_emp_position.Text = "";
            salary_data.Text = "";

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                salary_emp_id.Text = row.Cells[0].Value.ToString();
                salary_full_name.Text = row.Cells[1].Value.ToString();

                salary_emp_position.Text = row.Cells[4].Value.ToString();
                salary_data.Text = row.Cells[5].Value.ToString();
            }
        }

        private void salary_update_btn_Click(object sender, EventArgs e)
        {
            if (salary_emp_id.Text == "" ||
                salary_full_name.Text == "" ||
                salary_emp_position.Text == "" ||
                salary_data.Text == "")
            {
                MessageBox.Show("Please Fill all the Blanks");
            }
            else
            {
                DialogResult dialog = MessageBox.Show("Are You Sure You Want to Update the Employee Id: " + salary_emp_id.Text.Trim(), "Confirmation Message",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dialog == DialogResult.Yes)
                {
                    try
                    {
                        conn.Open();
                        DateTime today = DateTime.Today;
                        string salaryUpdate = "update employees set salary= @salary_data,update_date=@today where employee_id=@employeeId and delete_date is null";
                        using (SqlCommand cmd = new SqlCommand(salaryUpdate, conn))
                        {
                            cmd.Parameters.AddWithValue("@employeeId", salary_emp_id.Text.Trim());

                            cmd.Parameters.AddWithValue("@salary_data", salary_data.Text.Trim());
                            cmd.Parameters.AddWithValue("@today", today);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Employee Data Update Successfully");
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

        private void salary_clear_btn_Click(object sender, EventArgs e)
        {
            clearData();
        }
    }
}
