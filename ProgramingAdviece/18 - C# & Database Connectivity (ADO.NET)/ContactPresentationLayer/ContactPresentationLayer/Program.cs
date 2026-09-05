using ContactBussinesLayer;
using System.Data;
using System.Diagnostics.Metrics;

namespace ContactPresentationLayer
{
    internal class Program
    {
        #region ContactTestFucntion
        static void TestFind(int contactID)
        {

            ClsContact? contact = ClsContact.Find(contactID);
            if (contact != null)
            {
                Console.WriteLine($"First Name: {contact.FirstName}");
                Console.WriteLine($"Last Name: {contact.LastName}");
                Console.WriteLine($"Email: {contact.Email}");
                Console.WriteLine($"Phone: {contact.Phone}");
                Console.WriteLine($"Address: {contact.Address}");
                Console.WriteLine($"Date of Birth: {contact.DateOfBirth.ToShortDateString()}");
                Console.WriteLine($"Country ID: {contact.CountryId}");
                Console.WriteLine($"Image Path: {contact.ImagePath}");
            }
            else
            {
                Console.WriteLine("Contact not found.");
            }
        }
        static void AddNewContact()
        {
            ClsContact contact = new ClsContact();
            contact.FirstName= "jake";
            contact.LastName= "Doe";
            contact.Email= "jake.doe@example.com";
            contact.Phone= "123-456-7890";
            contact.Address= "123 Main St, Anytown, USA";
            contact.DateOfBirth= new DateTime(1990, 1, 1);
            contact.CountryId= 1;
            contact.ImagePath= "";

            if (contact.save())
            {
                Console.WriteLine($"Contact saved successfully. ID: {contact.Id}");
            }
            else
            {
                Console.WriteLine("Failed to save contact.");
            }
        }
        static void testUpdateContact(int id)
        {
            ClsContact? contact = ClsContact.Find(id);
            if (contact != null)
            {
                contact.FirstName="Jane";
                contact.LastName="Smith";
                contact.Email="jane.smith@example.com";
                contact.Phone="987-654-3210";
                contact.Address="456 Elm St, Othertown, USA";
                contact.DateOfBirth=new DateTime(1992, 2, 2);
                contact.CountryId=2;
                contact.ImagePath="path/to/newimage.jpg";
                if (contact.save())
                {
                    Console.WriteLine("Contact updated successfully.");
                }
                else
                {
                    Console.WriteLine("Failed to update contact.");
                }

            }
            else
            {
                Console.WriteLine("object not exsit");
            }
        }
        static void testDeleteContact(int id)
        {
            if (ClsContact.DeleteContact(id))
            {
                Console.WriteLine("Delete successed");
            }
            else
            {
                Console.WriteLine("not successed");
            }
        }

        static void testGetAllContact()
        {
            DataTable dataTable = ClsContact.GetContactDataTable();
            foreach (DataRow row in dataTable.Rows)
            {
                Console.WriteLine($"ID: {row[0]}, First Name: {row["FirstName"]}, Last Name: {row["LastName"]}, Email: {row["Email"]}, Phone: {row["Phone"]}");
            }
        }

        static void testIsExist(int id)
        {
            if (ClsContact.IsContactExsit(id))
            {
                Console.WriteLine("exsit");
            }
            else
            {
                Console.WriteLine("not exsit");
            }
        }
        #endregion

        #region country test function
        static void TestFindCountry(int countryId)
        {
            ClsCountry? country = ClsCountry.Find(countryId);
            if(country == null)
            {
                Console.WriteLine("not found");
            }
            else
            {
                Console.WriteLine($"country name is:{country.CountryName} counrty Code:{country.CountryCode}" +
                    $" country Phone code:{country.PhoneCode} ");
            }

        }

        static void TestFindCounrtyByName(string countryName)
        {
            ClsCountry? country = ClsCountry.Find(countryName);
            if (country==null)
            {
                Console.WriteLine("not Exsit");
            }
            else
            {
                Console.WriteLine($"country name is:{country.CountryName} counrty Code:{country.CountryCode}" +
                    $" country Phone code:{country.PhoneCode} ");
            }
        }
        static void TestAddNewCountry()
        {
            ClsCountry country = new ClsCountry();
            country.CountryName="China";
            country.CountryCode="CHN";
            country.PhoneCode="86";
            if (country.Save())
            {
                Console.WriteLine("Country add ");
            }
            else { Console.WriteLine("not add"); }
        }
        static void TestUpdateCountry(int countryId)
        {
            ClsCountry? country=ClsCountry.Find(countryId);
            if (country == null)
            {
                Console.WriteLine("counrty note exsit to update");
            }
            else
            {


                country.CountryName="Nu";
                country.CountryCode="Nu";
                country.PhoneCode="Nu";
                if (country.Save())
                {
                    Console.WriteLine("update success");
                }
                else
                {
                    Console.WriteLine("not success");
                }
            }
        }

        static void TestDeleteCountry(int countryId)
        {
            /*
             * when i delete country i will change the country id of all contact that have this country id
             * to Country id =8 that i will use it as default country id for all contact that have country id not exsit in country table
             */
            if (ClsCountry.IsExsit(countryId))
            {
                if (ClsCountry.DeleteCountry(countryId))
                {
                    Console.WriteLine("Delete successed");
                }
                else
                {
                    Console.WriteLine("not successed");
                }
            }
            else
            {
                Console.WriteLine("not exsit");
            }
           
            
        }
        static void testGetAllcountry()
        {
            DataTable dataTable = ClsCountry.GetAllCountry();
            foreach (DataRow row in dataTable.Rows)
            {
                Console.WriteLine($"country name is:{row["CountryName"]} counrty Code:{row["Code"]}" +
                   $" country Phone code:{row["PhoneCode"]} ");

            }
        }
        static void testIsCounryExsitById(int id)
        {
            if (ClsCountry.IsExsit(id))
            {
                Console.WriteLine("exsit");
            }
            else
            {
                Console.WriteLine("not exsit");
            }
        }

       

        static void testIsCounryExsitByname(string counryName)
        {
            if (ClsCountry.IsExsit(counryName))
            {
                Console.WriteLine("exsit");
            }
            else
            {
                Console.WriteLine("not exsit");
            }
        }

        


        #endregion
        static void Main(string[] args)
        {
            #region Contact functions test  
            //TestFind(2);

            //AddNewContact();

            //testUpdateContact(1);

            //testDeleteContact(1016);

            // testGetAllContact();

            // testIsExist(1);
            #endregion


            //TestFindCountry(6);

            //TestFindCounrtyByName("Egp");

            // TestAddNewCountry();

             //TestUpdateCountry(8);

            //TestDeleteCountry(2);

             testGetAllcountry();

            //testIsCounryExsitById(8);



            //testIsCounryExsitByname("egp");

          

        }
    }
}
