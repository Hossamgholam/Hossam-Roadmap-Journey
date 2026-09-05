using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DataTable1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*conclusion:
             * steps to use data table
               1- create data table object
               2- add column to data table by using columns collection and specify the name of column and type of data
               3- add row to data table by using rows collection and specify the value of each column in the row
               4- use compute method to calculate the sum, avg, min, max of salary for all data
               5-print the result
             */
            /*
            #region DataTable
            DataTable EmployeeList =new DataTable();
            EmployeeList.Columns.Add("ID", typeof(int));
            EmployeeList.Columns.Add("Name",typeof(string));
            EmployeeList.Columns.Add("Salary",typeof(double));
            EmployeeList.Columns.Add("Country",typeof (string));
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

            //dataTable exmpl
            int numberOfRow=EmployeeList.Rows.Count;

            double sumOfSalary = Convert.ToDouble(EmployeeList.Compute("Sum(Salary)", string.Empty));
            if (!double.TryParse(EmployeeList.Compute("avg(Salary)", string.Empty).ToString(), out double avgSalary))
            {
                Console.WriteLine("not convert to duble(avg)");
            }
            double minSalary = (double)EmployeeList.Compute("min(Salary)", string.Empty);
            double maxSalary = (double)EmployeeList.Compute("max(Salary)", string.Empty);

            foreach (DataRow row in EmployeeList.Rows)
            {
                Console.WriteLine($"my name is {row["Name"]} my data is {row["Date"]}");
            }
            Console.WriteLine("=====================================");
            Console.WriteLine("number of employee:{0}", numberOfRow);
            Console.WriteLine("sum of employee salary:{0}", sumOfSalary);
            Console.WriteLine("avg of employee salary:{0}", avgSalary);
            Console.WriteLine("min of employee salary:{0}", minSalary);
            Console.WriteLine("max of employee salary:{0}", maxSalary);

            #endregion

            */


            /*conclusion ;
            steps
             1- filter the data by using select method and put the result in array of data row
             2- use compute method to calculate the sum, avg, min, max of salary for the filter data
             3- print the result

            */
            #region   filtering on Data table
            /*

            Console.WriteLine("==============================================================");
            Console.WriteLine("                 filtering by country                         ");
            Console.WriteLine("==============================================================");

            DataRow[] filterByCountry;

            filterByCountry=EmployeeList.Select("Country='Jordan'");

            numberOfRow=filterByCountry.Count();
            sumOfSalary=Convert.ToDouble(EmployeeList.Compute("Sum(Salary)", "Country='Jordan'"));
            avgSalary=Convert.ToDouble(EmployeeList.Compute("Avg(Salary)", "Country='Jordan'"));
            minSalary=Convert.ToDouble(EmployeeList.Compute("Min(Salary)", "Country='Jordan'"));
            maxSalary=Convert.ToDouble(EmployeeList.Compute("Max(Salary)", "Country='Jordan'"));

            foreach (DataRow row in filterByCountry)
            {
                Console.WriteLine($"my name is {row["Name"]} my salary {row["Salary"]} my data is {row["Date"]}");
            }

            Console.WriteLine("=====================================");
            Console.WriteLine("number of employee:{0}", numberOfRow);
            Console.WriteLine("sum of employee salary:{0}", sumOfSalary);
            Console.WriteLine("avg of employee salary:{0}", avgSalary);
            Console.WriteLine("min of employee salary:{0}", minSalary);
            Console.WriteLine("max of employee salary:{0}\n\n", maxSalary);





            Console.WriteLine("==============================================================");
            Console.WriteLine("                 filtering by Two country                         ");
            Console.WriteLine("==============================================================");

            filterByCountry=EmployeeList.Select("Country='Jordan' or Country='Egypt'");

            numberOfRow=filterByCountry.Count();
            sumOfSalary=Convert.ToDouble(EmployeeList.Compute("Sum(Salary)", "Country='Jordan' or Country='Egypt'"));
            avgSalary=Convert.ToDouble(EmployeeList.Compute("Avg(Salary)", "Country='Jordan' or Country='Egypt'"));
            minSalary=Convert.ToDouble(EmployeeList.Compute("min(salary)", "Country='Jordan' or Country='Egypt'"));
            maxSalary=Convert.ToDouble(EmployeeList.Compute("max(salary)", "Country='Jordan' or Country='Egypt'"));


            foreach (DataRow row in filterByCountry)
            {
                Console.WriteLine($"my name is {row["Name"]} my salary {row["Salary"]} my data is {row["Date"]}");
            }

            Console.WriteLine("=====================================");
            Console.WriteLine("number of employee:{0}", numberOfRow);
            Console.WriteLine("sum of employee salary:{0}", sumOfSalary);
            Console.WriteLine("avg of employee salary:{0}", avgSalary);
            Console.WriteLine("min of employee salary:{0}", minSalary);
            Console.WriteLine("max of employee salary:{0}\n\n", maxSalary);




            Console.WriteLine("==============================================================");
            Console.WriteLine("                 filtering by Two country                         ");
            Console.WriteLine("==============================================================");

            DataRow[] filterByID = EmployeeList.Select("ID IN (1, 3, 5)");

            numberOfRow = filterByID.Count();
            sumOfSalary=Convert.ToDouble(EmployeeList.Compute("sum(Salary)", "ID IN (1, 3, 5)"));
            avgSalary=Convert.ToDouble(EmployeeList.Compute("Avg(Salary)", "ID IN (1, 3, 5)"));
            minSalary=Convert.ToDouble(EmployeeList.Compute("min(Salary)", "ID IN (1, 3, 5)"));
            maxSalary=Convert.ToDouble(EmployeeList.Compute("max(Salary)", "ID IN (1, 3, 5)"));

            foreach (DataRow row in filterByID)
            {
                Console.WriteLine($"my name is {row["Name"]} my salary {row["Salary"]} my data is {row["Date"]}");
            }
            Console.WriteLine("=====================================");
            Console.WriteLine("number of employee:{0}", numberOfRow);
            Console.WriteLine("sum of employee salary:{0}", sumOfSalary);
            Console.WriteLine("avg of employee salary:{0}", avgSalary);
            Console.WriteLine("min of employee salary:{0}", minSalary);
            Console.WriteLine("max of employee salary:{0}\n\n", maxSalary);

            */
            #endregion



            #region sorting,delete,update datatable
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

            Console.WriteLine("===================================================");
            Console.WriteLine("               sorting asc by name                 ");
            Console.WriteLine("===================================================");
            
            EmployeeList.DefaultView.Sort="Name asc";
            EmployeeList=EmployeeList.DefaultView.ToTable();
            foreach (DataRow row in EmployeeList.Rows)
            {
                Console.WriteLine($"my ID is {row["ID"]}     my name is {row["Name"]}       my salary {row["Salary"]}        my data is {row["Date"]}");
            }

            Console.WriteLine("===================================================");
            Console.WriteLine("               sorting desc by id                 ");
            Console.WriteLine("===================================================");
            EmployeeList.DefaultView.Sort="ID DESC";
            EmployeeList=EmployeeList.DefaultView.ToTable();
            foreach (DataRow row in EmployeeList.Rows)
            {
                Console.WriteLine($"my ID is {row["ID"]}     my name is {row["Name"]}       my salary {row["Salary"]}        my data is {row["Date"]}");

            }


            Console.WriteLine("===================================================");
            Console.WriteLine("               Delete                  ");
            Console.WriteLine("===================================================");
            EmployeeList.Rows[0].Delete();

            DataRow[] rowsDelete = EmployeeList.Select("ID in (2,3)");
            foreach (DataRow row in rowsDelete)
            {
                row.Delete();
            }
            //print after delete
            foreach (DataRow row in EmployeeList.Rows)
            {
                Console.WriteLine($"my ID is {row["ID"]}     my name is {row["Name"]}       my salary {row["Salary"]}        my data is {row["Date"]}");

            }

            //EmployeeList.AcceptChanges();

            Console.WriteLine("===================================================");
            Console.WriteLine("               update                  ");
            Console.WriteLine("===================================================");


            DataRow[] rowsUpdate = EmployeeList.Select("ID=1");
  
            foreach (DataRow row in rowsUpdate)
                {
                    row["ID"]=1;
                    row["Name"]="Name";
                    row["Salary"]=20000;
                }
           
            foreach (DataRow row in EmployeeList.Rows)
            {
                Console.WriteLine($"my ID is {row["ID"]}     my name is {row["Name"]}       my salary {row["Salary"]}        my data is {row["Date"]}");

            }



            */

            #endregion



            #region primary Key
            /*
            DataTable EmployeeList = new DataTable();
            
            EmployeeList.Columns.Add("ID", typeof(int));
            EmployeeList.Columns.Add("Name", typeof(string));
            EmployeeList.Columns.Add("Salary", typeof(double));
            EmployeeList.Columns.Add("Country", typeof(string));
            EmployeeList.Columns.Add("Date", typeof(DateTime));

            DataColumn[] PrimaryKeys = new DataColumn[1];
            PrimaryKeys[0] = EmployeeList.Columns["ID"];
            EmployeeList.PrimaryKey = PrimaryKeys;

            EmployeeList.Rows.Add(1, "Hossam", 3000, "Jordan", "2/5/2004");
            EmployeeList.Rows.Add(2, "Ali", 4000, "Saudi Arabia", "6/12/1999");
            EmployeeList.Rows.Add(3, "Mohamed", 5000, "Jordan", "8/25/2001");
            EmployeeList.Rows.Add(4, "Ahmed", 6000, "Jordan", "2/3/2000");
            EmployeeList.Rows.Add(5, "Sara", 4500, "Egypt", "5/10/1998");
         


            // EmployeeList.Rows.Add(1, "Hossam", 3000, "Jordan", "2/5/2004");

            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine(" another way for creating coulmn                  ");
            Console.WriteLine("====================================================");



            DataTable studentList = new DataTable();
            DataColumn studenCoulm;

            studenCoulm = new DataColumn();
            studenCoulm.ColumnName = "ID";
            studenCoulm.Caption="StudentID";
            studenCoulm.DataType=typeof(int);
            studenCoulm.AutoIncrement=true;
            studenCoulm.AutoIncrementSeed=1;
            studenCoulm.AutoIncrementStep=1;
            studenCoulm.ReadOnly=true;
            studenCoulm.Unique=true;
            studentList.Columns.Add(studenCoulm);

            studenCoulm=new DataColumn();
            studenCoulm.ColumnName="Name";
            studenCoulm.Caption="Name of student";
            studenCoulm.DataType = typeof(string);
            studenCoulm.AutoIncrement=false;
            studenCoulm.ReadOnly=false;
            studenCoulm.Unique = false;
            studentList.Columns.Add(studenCoulm);

            studenCoulm=new DataColumn();
            studenCoulm.ColumnName="Age";
            studenCoulm.Caption="Age of Studnet";
            studenCoulm.DataType=typeof(short);
            studenCoulm.AutoIncrement = false;
            studenCoulm.ReadOnly = false;
            studenCoulm.Unique=false;
            studentList.Columns.Add(studenCoulm);

            studenCoulm=new DataColumn();
            studenCoulm.ColumnName="GPA";
            studenCoulm.Caption="Degree of studen";
            studenCoulm.DataType=typeof(double);
            studentList.Columns.Add(studenCoulm);



            DataColumn[] PrimaryKeys2 = new DataColumn[1];
            PrimaryKeys2[0]=studentList.Columns["ID"];
            studentList.PrimaryKey = PrimaryKeys2;

            studentList.Rows.Add(null, "Hossam", 21, 3.4);
            studentList.Rows.Add(null, "Ali", 22, 3.1);
            studentList.Rows.Add(null, "Mohamed", 20, 3.8);
            studentList.Rows.Add(null, "Sara", 23, 3.9);

            foreach (DataRow row in studentList.Rows)
            {
                Console.WriteLine(
                    $"ID: {row["ID"]}, Name: {row["Name"]}, Age: {row["Age"]}, GPA: {row["GPA"]}");
            }



            */

            #endregion


            #region
            DataTable Product=new DataTable();
            DataColumn column;

            //create table
            column=new DataColumn();
            column.ColumnName="ID";
            column.Caption="Product ID";
            column.DataType=typeof(int);
            column.AutoIncrement=true;
            column.AutoIncrementSeed=100;
            column.AutoIncrementStep=1;
            column.Unique=true;
            column.ReadOnly=true;
            Product.Columns.Add(column);

            column=new DataColumn();
            column.ColumnName="Name";
            column.Caption="Product Name";
            column.DataType=typeof(string);
            column.AllowDBNull=false;
            Product.Columns.Add(column );

            column=new DataColumn();
            column.ColumnName="price";
            column.Caption="Product Price";
            column.DataType=typeof(double);
            column.AllowDBNull=false;
            Product.Columns.Add(column);

            column=new DataColumn();
            column.ColumnName="quantity";
            column.Caption="Product quantity";
            column.DataType=typeof(double);
            column.AllowDBNull=false;
            Product.Columns.Add(column);


            column=new DataColumn();
            column.ColumnName="Category";
            column.Caption="Product Category";
            column.DataType=typeof(string);
            column.AllowDBNull=false;
            Product.Columns.Add(column);

            DataColumn[] PrimaryKey = new DataColumn[] {
                Product.Columns["ID"]
            };
            Product.PrimaryKey= PrimaryKey;

            //insert rows
            Product.Rows.Add(null, "Laptop", 15000, 5, "Electronics");
            Product.Rows.Add(null, "Mouse", 250, 20, "Accessories");
            Product.Rows.Add(null, "Keyboard", 500, 15, "Accessories");
            Product.Rows.Add(null, "Phone", 8000, 10, "Electronics");
            Product.Rows.Add(null, "Printer", 3000, 3, "Office");
            Product.Rows.Add(null, "Desk", 2000, 7, "Furniture");

            //print all product
            foreach(DataRow row in Product.Rows)
            {
                Console.WriteLine($"Product is {row["Name"]} price is {row["Price"]} ");
            }

            //make sume statistic
            double numberOfProduct=Product.Rows.Count;
            double sumOrPrices = Convert.ToDouble(Product.Compute("sum(Price)", string.Empty));
            double avgOrPrices = Convert.ToDouble(Product.Compute("avg(Price)", string.Empty));
            double maxOrPrices = Convert.ToDouble(Product.Compute("Max(Price)", string.Empty));
            double minOrPrices = Convert.ToDouble(Product.Compute("min(Price)", string.Empty));

            Console.WriteLine($"number of product:{numberOfProduct}");
            Console.WriteLine($"total price {sumOrPrices}");
            Console.WriteLine($"averg price {avgOrPrices}");
            Console.WriteLine($"max : min price {maxOrPrices} : {minOrPrices}");

            //filtering
            Console.WriteLine("\n\n============================================================");
            Console.WriteLine("                         filtering by category    ");
            Console.WriteLine("============================================================");

            
            DataRow[] productWhereCategory = Product.Select("Category='Electronics'");
            foreach (DataRow row in productWhereCategory)
            {
                Console.WriteLine($"Product is {row["Name"]} price is {row["Price"]} ");
            }

            Console.WriteLine("\n\n============================================================");
            Console.WriteLine("                         sorting by price   ");
            Console.WriteLine("============================================================");
            Product.DefaultView.Sort="Price asc";
            Product=Product.DefaultView.ToTable();
            foreach (DataRow row in Product.Rows)
            {
                Console.WriteLine($"Product is {row["Name"]} price is {row["Price"]} ");
            }

            Console.WriteLine("\n\n============================================================");
            Console.WriteLine("                         update price by incerece 10%    ");
            Console.WriteLine("===============================================================");
            foreach (DataRow row in Product.Rows)
            {
               row["price"]= (double)row["price"]*1.1;
            }
            foreach (DataRow row in Product.Rows)
            {
                Console.WriteLine($"Product is {row["Name"]} price is {row["Price"]} ");
            }


            
            #endregion
        }
    }
}
