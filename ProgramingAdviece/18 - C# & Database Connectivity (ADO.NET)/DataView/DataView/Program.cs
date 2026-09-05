using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataViews
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region dataView
            /*
            DataTable EmployeeList = new DataTable();
            EmployeeList.Columns.Add("ID", typeof(int));
            EmployeeList.Columns.Add("Name", typeof(string));
            EmployeeList.Columns.Add("Salary", typeof(double));
            EmployeeList.Columns.Add("Country", typeof(string));
            EmployeeList.Columns.Add("Date", typeof(DateTime));

            EmployeeList.Rows.Add(1, "Hossam", 3000, "Jordan", "2/5/2004");
            EmployeeList.Rows.Add(2, "Ali", 4000, "Saudi Arabia", "6/12/1999");
            EmployeeList.Rows.Add(3, "Mohamed", 5000, "Jordan", "8/25/2001");
            EmployeeList.Rows.Add(4, "Ahmed", 6000, "Jordan", "2/3/2000");
            EmployeeList.Rows.Add(5, "Sara", 4500, "Egypt", "5/10/1998");
            EmployeeList.Rows.Add(6, "Mona", 7200, "Saudi Arabia", "11/15/1995");
            EmployeeList.Rows.Add(7, "Youssef", 3800, "Kuwait", "8/22/2002");
            EmployeeList.Rows.Add(8, "Khaled", 9100, "Jordan", "1/7/1993");
            EmployeeList.Rows.Add(9, "Nour", 5300, "Egypt", "6/18/1997");
            EmployeeList.Rows.Add(10, "Omar", 6700, "Kuwait", "9/30/1996");
            EmployeeList.Rows.Add(11, "Laila", 4800, "Jordan", "4/12/2003");
            EmployeeList.Rows.Add(12, "Karim", 8500, "Egypt", "7/25/1994");
            EmployeeList.Rows.Add(13, "Aya", 3900, "Jordan", "12/1/2001");
            EmployeeList.Rows.Add(14, "Mostafa", 10000, "Egypt", "3/14/1990");

            foreach (DataRow row in EmployeeList.Rows)
            {
                Console.WriteLine($"ID: {row["ID"]}, Name: {row["Name"]}, Salary: {row["Salary"]}, Country: {row["Country"]}, Date: {row["Date"]}");
            }

            Console.WriteLine("====================================================");
            Console.WriteLine("Data view");
            Console.WriteLine("======================================================");
            DataView dv = EmployeeList.DefaultView;
            for (int i = 0; i<dv.Count; i++)
            {
                Console.WriteLine($"ID : {dv[i][0]} Name: {dv[i][1]} salary :{dv[i][2]}");
            }


            Console.WriteLine("====================================================");
            Console.WriteLine("Data filter");
            Console.WriteLine("======================================================");
            dv.RowFilter="Country='Jordan'";
            
            for (int i = 0; i<dv.Count; i++)
            {
                Console.WriteLine($"ID : {dv[i][0]} Name: {dv[i][1]} salary :{dv[i][2]} Country: {dv[i][3]}");
            }
            Console.WriteLine("======================================================");
            dv.RowFilter="Salary>5000";
            for (int i = 0; i<dv.Count; i++)
            {
                Console.WriteLine($"ID : {dv[i][0]} Name: {dv[i][1]} salary :{dv[i][2]} Country: {dv[i][3]}");
            }


            Console.WriteLine("====================================================");
            Console.WriteLine("Data sort");
            Console.WriteLine("======================================================");

            dv.Sort="Salary asc";
            for (int i = 0; i<dv.Count; i++)
            {
                Console.WriteLine($"ID : {dv[i][0]} Name: {dv[i][1]} salary :{dv[i][2]} Country: {dv[i][3]}");
            }

*/

            /*
            DataTable dt =new DataTable();
            dt.Columns.Add("ID", typeof(int));
            dt.Columns.Add("Name",typeof(string));
            dt.Columns.Add("Grade" ,typeof(int));

            dt.Rows.Add(1, "Ahmed", 95);
            dt.Rows.Add(2, "Sara", 88);
            dt.Rows.Add(3, "Omar", 76);
            dt.Rows.Add(4, "Mona", 91);
            dt.Rows.Add(5, "Ali", 67);
            dt.Rows.Add(6, "Nour", 84);
            dt.Rows.Add(7, "Khaled", 73);
            dt.Rows.Add(8, "Laila", 99);

            DataView dv = dt.DefaultView;

            dv.RowFilter="Grade>80";
            for (int i = 0; i<dv.Count; i++)
            {
                Console.WriteLine($"Name {dv[i][1]} Grade {dv[i][2]}");

            }

            dv.Sort="Name Asc";
            for (int i = 0; i<dv.Count; i++)
            {
                Console.WriteLine($"Name {dv[i][1]} Grade {dv[i][2]}");

            }

            dv.Sort="Grade desc";
            for (int i = 0; i<dv.Count; i++)
            {
                Console.WriteLine($"Name {dv[i][1]} Grade {dv[i][2]}");


            }
            Console.WriteLine("===================================");
            dv.RowFilter="Grade>=80 and Name like 'A%'";
            for (int i = 0; i<dv.Count; i++)
            {
                Console.WriteLine($"Name {dv[i][1]} Grade {dv[i][2]}");

            }
            */

            #endregion

            #region  Dataset
            /*
            Console.WriteLine("===================================");
            DataTable dt = new DataTable("Employee");
            dt.Columns.Add("ID", typeof(int));  
            dt.Columns.Add("Name",typeof(string));
            dt.Columns.Add("Salary", typeof(double));
            dt.Columns.Add("Country", typeof(string));
            dt.Columns.Add("date",typeof(DateTime));

            dt.Rows.Add(1, "Hossam", 3000, "Jordan", "2/5/2004");
            dt.Rows.Add(2, "Ali", 4000, "Saudi Arabia", "6/12/1999");
            dt.Rows.Add(3, "Mohamed", 5000, "Jordan", "8/25/2001");
            dt.Rows.Add(4, "Ahmed", 6000, "Jordan", "2/3/2000");
            dt.Rows.Add(5, "Sara", 4500, "Egypt", "5/10/1998");
            
            foreach (DataRow row in dt.Rows)
            {
                Console.WriteLine($"ID: {row["ID"]}, Name: {row["Name"]}, Salary: {row["Salary"]}, Country: {row["Country"]}, Date: {row["Date"]}");
            }

            Console.WriteLine("===================================");

            DataTable Department= new DataTable("Department");
            Department.Columns.Add("ID", typeof(int));
            Department.Columns.Add("DepartmentName", typeof(string));

            Department.Rows.Add(1, "IT");
            Department.Rows.Add(2, "HR");
            Department.Rows.Add(3, "Finance");
            foreach (DataRow row in Department.Rows)
            {
                Console.WriteLine($"ID: {row["ID"]}, Name: {row["DepartmentName"]}");
            }

            Console.WriteLine("===================================");
            DataSet dataSet = new DataSet();
            dataSet.Tables.Add(dt);
            dataSet.Tables.Add(Department);

            foreach (DataRow row in dataSet.Tables["Employee"].Rows)
            {
                Console.WriteLine($"ID: {row["ID"]}, Name: {row["Name"]}, Salary: {row["Salary"]}, Country: {row["Country"]}, Date: {row["Date"]}");

            }
            Console.WriteLine("===================================");
            foreach (DataRow row in dataSet.Tables["Department"].Rows)
            {
                Console.WriteLine($"ID: {row["ID"]}, Name: {row["DepartmentName"]}");

            }


            */
            #endregion

            #region dataAdapter
            //make connection string  open it ,make query,use dataAdapter to excuite query in specific connnetion
            //open and get data,but in dataset,close 
            string connectionString = "Data Source=.;Initial Catalog=EmployeesDB;Integrated Security=True";


            SqlConnection connection = new SqlConnection(connectionString);
            string query = "Select* from Employees";

            SqlDataAdapter da=new SqlDataAdapter(query, connection);
            

            DataSet ds=new DataSet();

            connection.Open();
            da.SelectCommand.Connection = connection;
            da.Fill(ds, "Employee");

            connection.Close();

            DataTable dt = ds.Tables["Employee"];
            foreach (DataRow row in dt.Rows)
            {
                Console.WriteLine($"ID:{row["EmployeeID"]} name:{row["Name"]} salary: {row["salary"]} ");
            }


            //make data view to get employee that his name start A
            DataView dv=new DataView(dt);
            dv.RowFilter="Name like 'A%'";
            //add 500 to salary for employee his name start A
            foreach (DataRowView rowView in dv)
            {
                double salary=Convert.ToDouble( rowView["Salary"])+500;
                rowView["Salary"]=(object)salary;
            }
            foreach (DataRowView row in dv)
            {
                Console.WriteLine($"ID:{row["EmployeeID"]} name:{row["Name"]} salary: {row["salary"]} ");
            }

            da.UpdateCommand.Connection = connection;
            


            #endregion


        }
    }
}
