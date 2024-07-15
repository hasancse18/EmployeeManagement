using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Data.SqlClient;
namespace EmployeeManagement
{
    internal class EmployeeData
    {
        public int ID { get; set; }
        public string EmployeeID { get; set; }
        public string Name { get; set; }
        public string Gender {  get; set; }
        public string Contact { get; set; }
        public string Position {  get; set; }
        public string Image { get; set; }
        public int Salary { get; set; }
        public string Status { get; set; }
        
       







        SqlConnection connect = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\hasan\\Documents\\employee.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=True");

        public List<EmployeeData> employeeListData()
        {
            List<EmployeeData> listdata = new List<EmployeeData>();
            if (connect.State != ConnectionState.Open)
            {
                try
                {
                    connect.Open();
                    string selectdata = "select * from employees where delete_date is null";
                    using(SqlCommand cmd = new SqlCommand(selectdata,connect))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            EmployeeData ed = new EmployeeData();
                            ed.ID = (int)reader["id"];//0
                            ed.EmployeeID = reader["employee_id"].ToString();//1
                            ed.Name = reader["full_name"].ToString();//2
                            ed.Gender = reader["gender"].ToString();//3
                            ed.Contact = reader["contact_number"].ToString();//4
                            ed.Position = reader["position"].ToString();//5
                            ed.Image = reader["image"].ToString();//6
                            ed.Salary = (int)reader["salary"];//7
                            ed.Status = reader["status"].ToString();//8

                            listdata.Add(ed);
                        }
                    }
                }
                catch (Exception ex) 
                {
                    MessageBox.Show(ex.Message);
                }
                finally 
                { 
                    connect.Close();
                }
            }
            return listdata;
        }
    }
}
