using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactDataAccessLayer
{
        public struct StCountryModel
        {

            public int CountryID { get; set; }
            public string CountryName { get; set; }
            public string CountryCode { get; set; }
            public string PhoneCode { get; set; }

        };

    public class ClsCountryDataAccess
    {


        public static bool FindByID(int CountryID, ref StCountryModel countryModel)
        {
            bool found = false;
            //sql connection
            SqlConnection conn = new SqlConnection(ClsDataAccessSetting.ConnectionString);

            //query string 
            string query = "Select* from Countries where CountryID=@CountryID";


            //sqlcommmand 
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@CountryID", CountryID);


            //open connectiion and execute reader
            try
            {
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    found=true;
                    countryModel.CountryID=(int)reader["CountryID"];
                    countryModel.CountryName=(string)reader["CountryName"];
                    countryModel.CountryCode=(string)reader["Code"];
                    countryModel.PhoneCode=(string)reader["PhoneCode"];

                }

            }
            catch (Exception ex)
            {
                return found;
            }
            finally
            {
                conn.Close();
            }
            return found;
        }
        public static bool FindByname(string CountryName, ref StCountryModel countryModel)
        {
            bool found = false;
            //sql connection
            SqlConnection conn = new SqlConnection(ClsDataAccessSetting.ConnectionString);

            //query string 
            string query = "Select* from Countries where UPPER( CountryName)=UPPER(@CountryName)";


            //sqlcommmand 
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@CountryName", CountryName);


            //open connectiion and execute reader
            try
            {
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    found=true;
                    countryModel.CountryID=(int)reader["CountryID"];
                    countryModel.CountryName=(string)reader["CountryName"];
                    countryModel.CountryCode=(string)reader["Code"];
                    countryModel.PhoneCode=(string)reader["PhoneCode"];

                }

            }
            catch (Exception ex)
            {
                return found;
            }
            finally
            {
                conn.Close();
            }
            return found;
        }


        //addnew
        public static int AddNewCountry(StCountryModel countryModel)
        {

            SqlConnection conn = new SqlConnection(ClsDataAccessSetting.ConnectionString);
            string query = "insert into Countries Values(@CountryName,@Code,@PhoneCode);" +
                "select SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, conn);
            command.Parameters.AddWithValue("@CountryName", countryModel.CountryName);
            command.Parameters.AddWithValue("@Code", countryModel.CountryCode);
            command.Parameters.AddWithValue("@PhoneCode", countryModel.PhoneCode);






            try
            {
                conn.Open();
                object resutl = command.ExecuteScalar();
                if (resutl!=null&& int.TryParse(resutl.ToString(), out int courrentId))
                {
                    countryModel.CountryID= courrentId;
                }

            }
            catch (Exception ex)
            {
                countryModel.CountryID=-1;
            }
            finally
            {
                conn.Close();
            }
            return countryModel.CountryID;
        }


        //updatenew
        public static bool UpdateCountry(StCountryModel countryModel)
        {
            int RowAffect = 0;
            SqlConnection conn = new SqlConnection(ClsDataAccessSetting.ConnectionString);
            string query = "update Countries set CountryName=@CountryName," +
                "Code=@Code,PhoneCode=@PhoneCode where CountryID = @CountryID";

            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@CountryID", countryModel.CountryID);
            cmd.Parameters.AddWithValue("@CountryName", countryModel.CountryName);
            cmd.Parameters.AddWithValue("@Code", countryModel.CountryCode);
            cmd.Parameters.AddWithValue("@PhoneCode", countryModel.PhoneCode);



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


        //delete 
        public static bool DeleteCountry(int CountryID)
        {
            int RawAffection = 0;
            SqlConnection conn = new SqlConnection(ClsDataAccessSetting.ConnectionString);
            string query = "update Contacts set CountryID=8 where CountryID=@CountryID;" +
                "Delete Countries where CountryID=@CountryID ";

            SqlCommand command = new SqlCommand(query, conn);
            command.Parameters.AddWithValue("@CountryID", CountryID);

            try
            {
                conn.Open();
                RawAffection=command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                conn.Close();
            }
            return (RawAffection>0);

        }


        //get all
        public static DataTable GetAllCountry()
        {
            DataTable CountryList = new DataTable();

            SqlConnection conn = new SqlConnection(ClsDataAccessSetting.ConnectionString);
            string query = "Select* from Countries";

            SqlCommand command = new SqlCommand(query, conn);
            try
            {
                conn.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    CountryList.Load(reader);
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
            return CountryList;
        }


        //is exsitbyid
        public static bool IsExsitById(int CountryID)
        {
            bool exsit = false;
            SqlConnection conn = new SqlConnection(ClsDataAccessSetting.ConnectionString);
            string query = "Select 1 from Countries where CountryID=@CountryID";

            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@CountryID", CountryID);

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


        //is exsitby name
        public static bool IsExsitByName(string CountryName)
        {
            bool exsit = false;
            SqlConnection conn = new SqlConnection(ClsDataAccessSetting.ConnectionString);
            string query = "Select 1 from Countries where UPPER( CountryName)=UPPER(@CountryName)";

            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@CountryName", CountryName);

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
