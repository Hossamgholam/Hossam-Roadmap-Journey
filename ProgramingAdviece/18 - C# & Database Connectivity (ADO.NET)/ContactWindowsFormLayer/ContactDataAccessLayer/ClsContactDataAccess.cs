using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactDataAccessLayer
{
    public struct StContactModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int CountryId { get; set; }
        public string ImagePath { get; set; }
    }
    public class ClsContactDataAccess
    {

        public static bool FindContactById(int id, ref StContactModel Contact)
        {
            bool found = false;

            SqlConnection conn = new SqlConnection(ClsDataAccessSetting.ConnectionString);
            string query = "select*from Contacts where ContactID=@ID";

            SqlCommand command = new SqlCommand(query, conn);
            command.Parameters.AddWithValue("@ID", id);

            try
            {
                conn.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read() == true)
                {
                    found =true;
                    Contact = new StContactModel()
                    {
                        Id=(int)reader[0],
                        FirstName= reader.IsDBNull(1) ? "" : (string)reader[1],
                        LastName= reader.IsDBNull(2) ? "" : (string)reader[2],
                        Email= reader.IsDBNull(3) ? "" : (string)reader[3],
                        Phone= reader.IsDBNull(4) ? "" : (string)reader[4],
                        Address= reader.IsDBNull(5) ? "" : (string)reader[5],
                        DateOfBirth= reader.IsDBNull(6) ? default(DateTime) : (DateTime)reader[6],
                        CountryId=(int)reader[7],
                        ImagePath= reader.IsDBNull(8) ? "" : (string)reader[8]
                    };
                }
                else
                {
                    found = false;
                }


            }
            catch (Exception ex)
            {
                found=false;
            }
            finally
            {
                conn.Close();
            }
            return found;
        }

        public static int AddNewContact(StContactModel Contact)
        {
            SqlConnection conn = new SqlConnection(ClsDataAccessSetting.ConnectionString);
            string query = "insert into Contacts values(@FirstName,@LastName,@Email,@Phone,@Address," +
                "@DateOfBirth,@CountryID,@ImagePath);" +
                "SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, conn);
            command.Parameters.AddWithValue("@FirstName", Contact.FirstName);
            command.Parameters.AddWithValue("@LastName", Contact.LastName);
            command.Parameters.AddWithValue("@Email", Contact.Email);
            command.Parameters.AddWithValue("@Phone", Contact.Phone);
            command.Parameters.AddWithValue("@Address", Contact.Address);
            command.Parameters.AddWithValue("@DateOfBirth", Contact.DateOfBirth);
            command.Parameters.AddWithValue("@CountryID", Contact.CountryId);

            if (Contact.ImagePath!="")
            {
                command.Parameters.AddWithValue("@ImagePath", Contact.ImagePath);
            }
            else
            {
                command.Parameters.AddWithValue("@ImagePath", System.DBNull.Value);
            }

            try
            {
                conn.Open();
                object resutl = command.ExecuteScalar();
                if (resutl!=null&& int.TryParse(resutl.ToString(), out int courrentId))
                {
                    Contact.Id= courrentId;
                }

            }
            catch (Exception ex)
            {
                Contact.Id=-1;
            }
            finally
            {
                conn.Close();
            }
            return Contact.Id;
        }

        public static bool UpdateContact(StContactModel NewModelDate)
        {
            int RowAffect = 0;
            SqlConnection conn = new SqlConnection(ClsDataAccessSetting.ConnectionString);
            string query = "UPDATE Contacts SET FirstName = @FirstName, " +
                "LastName = @LastName, Email = @Email, " +
                "Phone = @Phone, Address = @Address, DateOfBirth = @DateOfBirth, " +
                "CountryID = @CountryID, ImagePath = @ImagePath WHERE ContactID = @ID;";

            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@FirstName", NewModelDate.FirstName);
            cmd.Parameters.AddWithValue("@LastName", NewModelDate.LastName);
            cmd.Parameters.AddWithValue("@Email", NewModelDate.Email);
            cmd.Parameters.AddWithValue("@Phone", NewModelDate.Phone);
            cmd.Parameters.AddWithValue("@Address", NewModelDate.Address);
            cmd.Parameters.AddWithValue("@DateOfBirth", NewModelDate.DateOfBirth);
            cmd.Parameters.AddWithValue("@CountryID", NewModelDate.CountryId);
            if (NewModelDate.ImagePath != "")
            {
                cmd.Parameters.AddWithValue("@ImagePath", NewModelDate.ImagePath);
            }
            else
            {
                cmd.Parameters.AddWithValue("@ImagePath", System.DBNull.Value);
            }
            cmd.Parameters.AddWithValue("@ID", NewModelDate.Id);

            try
            {
                conn.Open();
                RowAffect = cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                conn.Close();
            }
            return (RowAffect>0);
        }

        public static bool DeleteContact(int ContactId)
        {
            int RawAffect = 0;
            SqlConnection conn = new SqlConnection(ClsDataAccessSetting.ConnectionString);
            string query = "delete Contacts where ContactID=@ContactId";

            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@ContactId", ContactId);

            try
            {
                conn.Open();
                RawAffect = cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                conn.Close();
            }
            return (RawAffect>0);

        }

        public static DataTable GetAllContact()
        {
            DataTable ContactList = new DataTable();

            SqlConnection conn = new SqlConnection(ClsDataAccessSetting.ConnectionString);
            string query = "select* from Contacts";

            SqlCommand command = new SqlCommand(query, conn);
            try
            {
                conn.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    ContactList.Load(reader);
                }

            }
            catch (Exception ex)
            {
                throw new Exception("Error retrieving contacts", ex);
            }
            finally
            {
                conn.Close();
            }
            return ContactList;
        }

        public static bool IsExsit(int ContactID)
        {
            bool exsit = false;
            SqlConnection conn = new SqlConnection(ClsDataAccessSetting.ConnectionString);
            string query = "Select 1 from Contacts where ContactID=@ContactID";

            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@ContactID", ContactID);

            try
            {
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                exsit=reader.HasRows;
            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                conn.Close();
            }
            return exsit;
        }


    }
}
