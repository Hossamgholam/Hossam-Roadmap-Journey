using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcuteNonQuery
{
    internal class Program
    {
        static string connectionString = "Data Source=.;Initial Catalog=ContactsDB;User ID=sa;Password=sa123456;";
        
        public struct stContact{
            public string FirstName { get; set; }
            public string LastName {  get; set; }
            public string Email { get; set; }
            public string PhoneNumber { get; set; }
            public string Adress { get; set; }
            public int CountryID { get; set; }
        }
      
        //insert into
        static void AddContact(stContact contact)
        {
            SqlConnection conn = new SqlConnection(connectionString);

            string query = "insert into Contacts values(@FirstName,@LastName,@Email,@Phone,@address,@countryId)";

            SqlCommand command=new SqlCommand(query, conn);
            command.Parameters.AddWithValue("@FirstName", contact.FirstName);
            command.Parameters.AddWithValue("@LastName", contact.LastName);
            command.Parameters.AddWithValue("@Email", contact.Email);
            command.Parameters.AddWithValue("@Phone", contact.PhoneNumber);
            command.Parameters.AddWithValue("@address", contact.Adress);
            command.Parameters.AddWithValue("@countryId", contact.CountryID);

            try
            {
                conn.Open();
                int AffectRow=command.ExecuteNonQuery();
                if (AffectRow > 0)
                {
                    Console.WriteLine("contact add sueccessful:");
                }
                else 
                {
                    Console.WriteLine("not add");
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


        }

        static void AddContactAndGetID(stContact contact)
        {
            SqlConnection conn = new SqlConnection(connectionString);

            string query = "insert into Contacts values(@FirstName,@LastName,@Email,@Phone,@address,@countryId);" +
                "select SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, conn);
            command.Parameters.AddWithValue("@FirstName", contact.FirstName);
            command.Parameters.AddWithValue("@LastName", contact.LastName);
            command.Parameters.AddWithValue("@Email", contact.Email);
            command.Parameters.AddWithValue("@Phone", contact.PhoneNumber);
            command.Parameters.AddWithValue("@address", contact.Adress);
            command.Parameters.AddWithValue("@countryId", contact.CountryID);

            try
            {
                conn.Open();
                object result = command.ExecuteScalar();
                if (result!=null&&int.TryParse(result.ToString(), out int insertId)){
                    Console.WriteLine($"inser sucess and new id is :{insertId}");
                }
                else
                {
                    Console.WriteLine("not sucess:");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


        }

        //update
        static void UpdateContact(int contactId,stContact contact)
        {
            SqlConnection conn = new SqlConnection(connectionString);

            string query = "update Contacts set FirstName=@FirstName,LastName=@LastName,Email=@Email,Phone=@Phone,Address='@address',CountryID=@countryId" +
                " where ContactID=@contactId";

            SqlCommand command = new SqlCommand(query, conn);
            command.Parameters.AddWithValue("@FirstName", contact.FirstName);
            command.Parameters.AddWithValue("@LastName", contact.LastName);
            command.Parameters.AddWithValue("@Email", contact.Email);
            command.Parameters.AddWithValue("@Phone", contact.PhoneNumber);
            command.Parameters.AddWithValue("@address", contact.Adress);
            command.Parameters.AddWithValue("@countryId", contact.CountryID);

            command.Parameters.AddWithValue("@contactId", contactId);

            try
            {
                conn.Open();
                int AffectRow = command.ExecuteNonQuery();
                if (AffectRow > 0)
                {
                    Console.WriteLine("contact update sueccessful:");
                }
                else
                {
                    Console.WriteLine("not update");
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


        }
        
        //delete
        static void DeleteContact(int contactId)
        {
            SqlConnection conn = new SqlConnection(connectionString);

            string query = "delete from Contacts where ContactID=@contactId";

            SqlCommand command = new SqlCommand(query, conn);
            

            command.Parameters.AddWithValue("@contactId", contactId);

            try
            {
                conn.Open();
                int AffectRow = command.ExecuteNonQuery();
                if (AffectRow > 0)
                {
                    Console.WriteLine("contact delete sueccessful:");
                }
                else
                {
                    Console.WriteLine("not dlelte");
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


        }

        //handilang in 
        static void updateContactIn(string contactIn)
        {
            SqlConnection conn = new SqlConnection(connectionString);

            string query = "update  Contacts set  Address='Cairo st' where ContactID in ("+contactIn+");";

            SqlCommand command = new SqlCommand(query, conn);
            


            

            try
            {
                conn.Open();
                int AffectRow = command.ExecuteNonQuery();
                if (AffectRow > 0)
                {
                    Console.WriteLine("contact update sueccessful:");
                }
                else
                {
                    Console.WriteLine("not update");
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


        }


        static void Main(string[] args)
        {
            #region insert statment
            /*
            stContact contact = new stContact()
            {
                FirstName="hossam",
                LastName="Gholam",
                Email="hossamgholam@.com",
                PhoneNumber="01021832326",
                Adress="kom_Alcarpernter",
                CountryID=1
            };
            AddContact(contact);

            stContact contact2 = new stContact()
            {
                FirstName="ali",
                LastName="Gholam",
                Email="aliMohamed@.com",
                PhoneNumber="01021832326",
                Adress="kom_Alcarpernter",
                CountryID=2
            };
            AddContactAndGetID(contact2);
            */
            #endregion

            #region UpdateStatment
            /*
            stContact contact = new stContact()
            {
                FirstName="hossam",
                LastName="Gholam",
                Email="hossamgholam@.com",
                PhoneNumber="01021832326",
                Adress="kom_Alcarpernter",
                CountryID=1
            };
            UpdateContact(1,contact);
            */
            #endregion

            #region deleteStatment

            //DeleteContact(12);

            #endregion

            updateContactIn("1,2,3");

        }
    }
}
