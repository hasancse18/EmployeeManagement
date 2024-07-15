using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;
namespace EmployeeManagement
{
    internal class SalaryData
    {
        public string id {  get; set; }
        public string name {  get; set; }
        public string gender {  get; set; }
        public string contact {  get; set; }
        public string position {  get; set; }
        public int salary {  get; set; }

        SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\hasan\\Documents\\employee.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=True");

        public List<SalaryData> employeeSalary()
        {
            List<SalaryData> listdata = new List<SalaryData>();

            try
            {
                conn.Open();

                string selectdata = "select * from employees where status = 'Active' and delete_date is null";
                using(SqlCommand cmd = new SqlCommand(selectdata,conn))
                {
                    SqlDataReader reader = cmd.ExecuteReader();
                    while(reader.Read())
                    {
                        SalaryData sd = new SalaryData();
                        sd.id = reader["employee_id"].ToString();//0
                        sd.name = reader["full_name"].ToString();//1
                        sd.gender = reader["gender"].ToString();//2
                        sd.contact = reader["contact_number"].ToString();//3
                        sd.position = reader["position"].ToString();//4
                        sd.salary =(int) reader["salary"];//5
                        listdata.Add(sd);
                    }
                    

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }





            return listdata;
        }


    }
}
