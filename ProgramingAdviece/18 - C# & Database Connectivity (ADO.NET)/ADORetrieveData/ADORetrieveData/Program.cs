using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace ADORetrieveData
{
    internal class Program
    {
        public struct Contacts
        {
           public int contactId { get; set; }
           public string firstname { get; set; }
           public string lastname { get; set; }
           public string email {  get; set; }
           public string phone {  get; set; }
           public string address {  get; set; }
           public int countryId {  get; set; }
       }
        static Contacts ConvertDataReaderToStruct(SqlDataReader adapter)
        {
            Contacts contacts=new Contacts();
            
             contacts.contactId = (int)adapter[0];
             contacts. firstname = (string)adapter[1];
             contacts. lastname = (string)adapter[2];
             contacts. email = (string)adapter[3];
             contacts. phone = (string)adapter[4];
             contacts. address = (string)adapter[5];
             contacts.countryId = (int)adapter[6];
            return contacts;
            
            
        }
        static void PrintContactInfo(Contacts contacts)
        {
            Console.WriteLine("==========================");
            Console.WriteLine($"id:{contacts.contactId}");
            Console.WriteLine($"fristname:{contacts.firstname}");
            Console.WriteLine($"Last name:{contacts.lastname}");
            Console.WriteLine($"Email:{contacts.email}");
            Console.WriteLine($"Phone:{contacts.phone}");
            Console.WriteLine($"Addres:{contacts.address}");
        }




        static string ConnectionString = "Data Source=.;Initial Catalog=ContactsDB;User ID=sa;Password=sa123456";
        
        //1-get all contact
        static void PrinatAllContacts()
        {

        SqlConnection conn=new SqlConnection(ConnectionString);
        string query = "select* from Contacts";

        SqlCommand cmd=new SqlCommand (query, conn);
            try
            {
                conn.Open ();
                SqlDataReader reader=cmd.ExecuteReader ();
                while (reader.Read())
                {
                    int contacid = (int)reader[0];
                    string firstname = (string)reader[1];
                    string lastname= (string)reader[2];
                    string email = (string)reader[3];
                    string phone = (string)reader[4];
                    string addres = (string)reader[5];

                    Console.WriteLine("==========================");
                    Console.WriteLine($"id:{contacid}");
                    Console.WriteLine($"fristname:{firstname}");
                    Console.WriteLine($"Last name:{lastname}");
                    Console.WriteLine($"Email:{email}");
                    Console.WriteLine($"Phone:{phone}");
                    Console.WriteLine($"Addres:{addres}");

                }

                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("erro"+ex.Message);
            }
                conn.Close();
        }

        //2-Parameterized Query 
        static void prinatAllContactWithFirstName(string firstName)
        {
            SqlConnection con=new SqlConnection(ConnectionString);
            string query = "select*from Contacts where FirstName=@firstName";

            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@firstName", firstName);

            try
            {
                con.Open();
                SqlDataReader reader=cmd.ExecuteReader();

                if (reader.HasRows)
                {

                    while (reader.Read())
                    {
                        int contacid = (int)reader[0];
                        string firstname = (string)reader[1];
                        string lastname = (string)reader[2];
                        string email = (string)reader[3];
                        string phone = (string)reader[4];
                        string addres = (string)reader[5];

                        Console.WriteLine("==========================");
                        Console.WriteLine($"id:{contacid}");
                        Console.WriteLine($"fristname:{firstname}");
                        Console.WriteLine($"Last name:{lastname}");
                        Console.WriteLine($"Email:{email}");
                        Console.WriteLine($"Phone:{phone}");
                        Console.WriteLine($"Addres:{addres}");
                    }
              
                }
                else { Console.WriteLine("not exsit"); }
                reader.Close ();

            }catch(Exception ex)
            {
                Console.WriteLine(ex);
            }
            con.Close();
        }
       
        static void prinatAllContactWithFirstNameCountry(string firstName,int countryId)
        {
            SqlConnection conn=new SqlConnection(ConnectionString);

            string quer = "select*from Contacts where FirstName=@firstName and CountryID=@CountryId";

            SqlCommand command = new SqlCommand(quer, conn);
            command.Parameters.AddWithValue("@firstName", firstName);
            command.Parameters.AddWithValue("@CountryId", countryId);

            try
            {
                conn.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {

                     while (reader.Read())
                     {
                         int contacid = (int)reader[0];
                         string firstname = (string)reader[1];
                         string lastname = (string)reader[2];
                         string email = (string)reader[3];
                         string phone = (string)reader[4];
                         string addres = (string)reader[5];
                     
                         Console.WriteLine("==========================");
                         Console.WriteLine($"id:{contacid}");
                         Console.WriteLine($"fristname:{firstname}");
                         Console.WriteLine($"Last name:{lastname}");
                         Console.WriteLine($"Email:{email}");
                         Console.WriteLine($"Phone:{phone}");
                         Console.WriteLine($"Addres:{addres}");
                     }
                       reader.Close();
                }
                else
                {
                    Console.WriteLine("not exist");
                }
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            conn.Close();

        }

        //3-Parameterized Query With "Like"
        static void PriantAllContactSartWith(string start)
        {
            SqlConnection conn = new SqlConnection(ConnectionString);
            string query = "select * from Contacts where FirstName like '' +@Sart+ '%'";

            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@Sart", start);

            try
            {
                conn.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Contacts contct = ConvertDataReaderToStruct(reader);
                        PrintContactInfo(contct);
                    }
                   
                    
                    reader.Close();
                }
                else
                {
                    Console.WriteLine("Not Exsit:");
                }
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
            conn.Close();
        }
        static void PriantAllContactEndWith(string End)
        {
            SqlConnection conn = new SqlConnection(ConnectionString);
            string query = "select * from Contacts where FirstName like +'%'+@End";

            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@End", End);

            try
            {
                conn.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Contacts contct = ConvertDataReaderToStruct(reader);
                        PrintContactInfo(contct);
                    }


                    reader.Close();
                }
                else
                {
                    Console.WriteLine("Not Exsit:");
                }
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
            conn.Close();
        }

        static void searchContactsContains(string contains)
        {
            SqlConnection conn = new SqlConnection(ConnectionString);
            string query = "select * from Contacts where FirstName like +'%'+@contains+'%'";

            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@contains", contains);

            try
            {
                conn.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Contacts contct = ConvertDataReaderToStruct(reader);
                        PrintContactInfo(contct);
                    }


                    reader.Close();
                }
                else
                {
                    Console.WriteLine("Not Exsit:");
                }
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
            conn.Close();
        }

        //4-Excute scalary
        static string getFirstName(int id)
        {
            string FirstName = "";

            SqlConnection conn = new SqlConnection(ConnectionString);
            string query = "select FirstName from Contacts where ContactID=@id";

            SqlCommand command = new SqlCommand(query, conn);
            command.Parameters.AddWithValue("@id", id);

            try
            {
                conn.Open();
                object result= command.ExecuteScalar();
                if (result != null)
                {
                    FirstName = result.ToString();
                }
                else
                {
                    FirstName="";
                }
                conn.Close();

            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
            return FirstName;
        }

        //5-get find single contact
        static bool FindContactById(int id,ref Contacts contact)
        {
            bool found= false;
            SqlConnection conn = new SqlConnection(ConnectionString);
            string query = "select* from Contacts where ContactID=@id";

            SqlCommand command = new SqlCommand(query, conn);
            command.Parameters.AddWithValue("@id", id);

            try
            {
                conn.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    

                    while (reader.Read())
                    {
                       contact= ConvertDataReaderToStruct(reader);
                        found=true;
                    }
                }
                else
                {
                    found=false;
                }
                reader.Close();
                conn.Close();

            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
            return found;
        }
        static void Main(string[] args)
        {
            //PrinatAllContacts();

            //prinatAllContactWithFirstName("Jane");

            //prinatAllContactWithFirstNameCountry("1", 1);

           // PriantAllContactEndWith("e");

           // searchContactsContains("an");

           // Console.WriteLine( getFirstName(1));


            Contacts contacts  = new Contacts();
            bool found = FindContactById(100, ref contacts);
            if (found)
            {
                PrintContactInfo(contacts);
            }
            else
            {
                Console.WriteLine("not exsit:");
            }

        }
    }
}
