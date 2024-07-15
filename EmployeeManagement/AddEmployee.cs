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
using System.IO;

namespace EmployeeManagement
{
    public partial class AddEmployee : UserControl
    {
        SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\hasan\\Documents\\employee.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=True");
        public AddEmployee()
        {
            InitializeComponent();
            displayEmployeeData();
        }
        public void displayEmployeeData()
        {
            EmployeeData empData = new EmployeeData();
            List<EmployeeData> listData = empData.employeeListData();
            dataGridView1.DataSource = listData;
        }
        private void emp_add_btn_Click(object sender, EventArgs e)
        {
            if (conn.State != ConnectionState.Open)
            {
                try
                {
                    conn.Open();
                    DateTime today = DateTime.Today;
                    string insertData = "insert into employees " +
                        "( employee_id,full_name,gender,contact_number,position,image,salary,insert_date,status )" +
                        "values (@employee_id, @fullname, @gender, @contact,@position,@image,@salary,@insertdate,@status)";

                    string path = Path.Combine(@"C:\\Users\\hasan\\source\\repos\\EmployeeManagement\\EmployeeManagement\\Directory\\"
                    + employee_id.Text.Trim() + ".jpg");
                    string directoryPath = Path.GetDirectoryName(path);
                    if (!Directory.Exists(directoryPath))
                    {
                        Directory.CreateDirectory(directoryPath);
                    }
                    File.Copy(employee_picture.ImageLocation, path, true);
                    //start from here


                    using (SqlCommand cmd = new SqlCommand(insertData, conn))
                    {
                        cmd.Parameters.AddWithValue("@employee_id", employee_id.Text.Trim());
                        cmd.Parameters.AddWithValue("@fullname", employee_name.Text.Trim());
                        cmd.Parameters.AddWithValue("@gender", gender.Text.Trim());
                        cmd.Parameters.AddWithValue("@contact", employee_phone.Text.Trim());
                        cmd.Parameters.AddWithValue("@position", emp_position.Text.Trim());
                        cmd.Parameters.AddWithValue("@image", path);
                        cmd.Parameters.AddWithValue("@salary", 0);
                        cmd.Parameters.AddWithValue("@insertdate", today);
                        cmd.Parameters.AddWithValue("@status", status.Text.Trim());
                        cmd.ExecuteNonQuery();
                        displayEmployeeData();
                        MessageBox.Show("Add Successfully");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    conn.Close();
                    clearFields();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)//import button
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "Image Files(*.jpg;*.png)|*.jpg;*.png";
                string imagepath = "";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    imagepath = dialog.FileName;
                    employee_picture.ImageLocation = imagepath;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        void clearFields()
        {
            employee_id.Text = "";
            employee_name.Text = "";
            gender.SelectedIndex = -1;
            employee_phone.Text = "";
            emp_position.SelectedIndex = -1;
            employee_picture.Image = null;
            status.SelectedIndex = -1;


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void emp_clear_btn_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private void emp_update_btn_Click(object sender, EventArgs e)
        {
            if (employee_id.Text == "" ||
            employee_name.Text == "" ||
            gender.Text == "" ||
            employee_phone.Text == "" ||
            emp_position.Text == "" ||
            employee_picture.Image == null ||
            status.Text == "")
            {
                MessageBox.Show("Please Fill All the Field", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult check = MessageBox.Show("Are You Sure You Want to Update" +
                    "Employee Id " + employee_id.Text.Trim() + "?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if ((check == DialogResult.Yes))
                {
                    try
                    {
                        conn.Open();
                        DateTime today = DateTime.Today;

                        string updateData = "update employees set full_name = @fullname ," +
                            "gender = @gender,contact_number = @contact, position = @position," +
                            "update_date = @updateDate, status = @status where employee_id = @employeeId";
                        using (SqlCommand cmd = new SqlCommand(updateData, conn))
                        {

                            cmd.Parameters.AddWithValue("@fullname", employee_name.Text.Trim());
                            cmd.Parameters.AddWithValue("@gender", gender.Text.Trim());
                            cmd.Parameters.AddWithValue("@contact", employee_phone.Text.Trim());
                            cmd.Parameters.AddWithValue("@position", emp_position.Text.Trim());
                            cmd.Parameters.AddWithValue("@updateDate", today);
                            cmd.Parameters.AddWithValue("@status", status.Text.Trim());
                            cmd.Parameters.AddWithValue("@employeeId", employee_id.Text.Trim());



                            cmd.ExecuteNonQuery();
                            displayEmployeeData();
                            MessageBox.Show("Update SuccessFully");
                            clearFields();

                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error Message");
                    }
                    finally
                    {
                        conn.Close();
                    }
                }
            }
        }

        private void emp_delete_btn_Click(object sender, EventArgs e)
        {
            if (employee_id.Text == "" ||
           employee_name.Text == "" ||
           gender.Text == "" ||
           employee_phone.Text == "" ||
           emp_position.Text == "" ||
           // employee_picture.Image == null ||
           status.Text == "")
            {
                MessageBox.Show("Fill all the Blanks", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult dialog = MessageBox.Show("You want to Delete Employee Id: " + employee_id, "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (dialog == DialogResult.Yes)
                {
                    try
                    {
                        conn.Open();
                        DateTime today = DateTime.Today;
                        string deletData = "update employees set delete_date = @deletedate where employee_id = @employeeId";
                        using (SqlCommand cmd = new SqlCommand(deletData, conn))
                        {
                            cmd.Parameters.AddWithValue("@deletedate", today);
                            cmd.Parameters.AddWithValue("@employeeId", employee_id.Text.Trim());
                            cmd.ExecuteNonQuery();
                            displayEmployeeData();
                            clearFields();
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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                employee_id.Text = row.Cells[1].Value.ToString();
                employee_name.Text = row.Cells[2].Value.ToString();
                gender.Text = row.Cells[3].Value.ToString();
                employee_phone.Text = row.Cells[4].Value.ToString();
                emp_position.Text = row.Cells[5].Value.ToString();
                string imagepath = row.Cells[6].Value.ToString();

                if (imagepath != null)
                {
                    employee_picture.Image = Image.FromFile(imagepath);
                }
                else
                {
                    employee_picture.Image = null;
                }




                status.Text = row.Cells[8].Value.ToString();

            }
        }
    }
}
