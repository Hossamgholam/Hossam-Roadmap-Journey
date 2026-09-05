using ContactDataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactBusinessLayer
{
    public class ClsContact
    {
        private enum enMode { AddNew, Update }

        public int Id { get; private set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public DateTime DateOfBirth { get; set; }
        public int CountryId { get; set; }
        public string ImagePath { get; set; } = string.Empty;

        private enMode mode;

        //for add new becuse he shoudl not have id
        public ClsContact()
        {

            Id =-1;
            FirstName = string.Empty;
            LastName = string.Empty;
            Email = string.Empty;
            Phone = string.Empty;
            Address = string.Empty;
            DateOfBirth = DateTime.MinValue;
            CountryId = -1;
            ImagePath = string.Empty;

            mode = enMode.AddNew;
        }

        //for update and find becuse he shoudl have id
        private ClsContact(int id, string FirstName, string LastName, string Email, string Phone, string Address, DateTime DateOfBirth, int CountryId, string ImagePath)
        {
            this.Id = id;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Email = Email;
            this.Phone = Phone;
            this.Address = Address;
            this.DateOfBirth = DateOfBirth;
            this.CountryId = CountryId;
            this.ImagePath = ImagePath;

            this.mode=enMode.Update;
        }

        public static ClsContact Find(int ContactID)
        {
            StContactModel model = new StContactModel()
            {
                Id = 0,
                FirstName = string.Empty,
                LastName = string.Empty,
                Email = string.Empty,
                Phone = string.Empty,
                Address = string.Empty,
                DateOfBirth = DateTime.Now,
                CountryId = 0,
                ImagePath = string.Empty
            };

            if (ClsContactDataAccess.FindContactById(ContactID, ref model))
            {
                return new ClsContact(model.Id, model.FirstName, model.LastName,
                    model.Email, model.Phone, model.Address, model.DateOfBirth,
                    model.CountryId, model.ImagePath);

            }
            else
            {
                return null;
            }


        }

        private bool _AddNewContact()
        {
            StContactModel contact = new StContactModel()
            {
                Id = this.Id,
                FirstName=this.FirstName,
                LastName=this.LastName,
                Email=this.Email,
                Phone = this.Phone,
                Address = this.Address,
                DateOfBirth = this.DateOfBirth,
                CountryId = this.CountryId,
                ImagePath = this.ImagePath

            };

            this.Id=ClsContactDataAccess.AddNewContact(contact);
            return (this.Id!=-1);


        }
        public bool _UpdateContact()
        {
            StContactModel contact = new StContactModel()
            {
                Id = this.Id,
                FirstName=this.FirstName,
                LastName=this.LastName,
                Email=this.Email,
                Phone = this.Phone,
                Address = this.Address,
                DateOfBirth = this.DateOfBirth,
                CountryId = this.CountryId,
                ImagePath = this.ImagePath

            };
            bool result = ClsContactDataAccess.UpdateContact(contact);
            return result;
        }
        public bool save()
        {
            switch (mode)
            {
                case enMode.AddNew:
                    if (_AddNewContact())
                    {
                        mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;

                    }

                case enMode.Update:

                    return _UpdateContact();

                default:
                    return false;


            }
        }

        public static bool DeleteContact(int ContactID)
        {

            return ClsContactDataAccess.DeleteContact(ContactID);
        }

        public static DataTable GetContactDataTable()
        {
            return ClsContactDataAccess.GetAllContact();
        }

        public static bool IsContactExsit(int ContactID)
        {
            return ClsContactDataAccess.IsExsit(ContactID);
        }
    }
}
