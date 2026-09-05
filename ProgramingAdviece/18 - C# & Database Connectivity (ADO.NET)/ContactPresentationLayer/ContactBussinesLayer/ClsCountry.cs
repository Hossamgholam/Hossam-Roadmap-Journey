using ContactDataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using static ContactDataAccessLayer.ClsCountryDataAccess;


namespace ContactBussinesLayer
{
    public class ClsCountry
    {
        private enum enMode { add,update}
        public int CountryID { get;private set; }
        public string CountryName { get; set; }
        public string CountryCode { get; set; }
        public string PhoneCode {  get; set; }
        private enMode mode;
        //for add
        public ClsCountry()
        {
            CountryID = -1;
            CountryName="";
            CountryCode="";
            PhoneCode="";
            mode = enMode.add;
        }
        //for find update 
        private ClsCountry(int countryID, string countryName,string countryCode,string phonecode)
        {
            CountryID=countryID;
            CountryName=countryName;
            CountryCode=countryCode;
            PhoneCode=phonecode;
            mode = enMode.update;
        }

        public static ClsCountry? Find(int countryID)
        {
            StCountryModel model = new StCountryModel();
            if (ClsCountryDataAccess.FindByID(countryID, ref model)) {
                return new ClsCountry(model.CountryID, model.CountryName,model.CountryCode,model.PhoneCode);
            }
            else
            {
                return null;
            }


        }
        public static ClsCountry? Find(string CountryName)
        {
            StCountryModel model = new StCountryModel();
            if (ClsCountryDataAccess.FindByname(CountryName, ref model))
            {
                return new ClsCountry(model.CountryID, model.CountryName, model.CountryCode, model.PhoneCode);
            }
            else
            {
                return null;
            }


        }

        private bool _AddNewCountry()
        {
            //it git all initial value for ClsCountry()  constractor  becuse
            //object that call save he initialize by ClsCountry() constractor
            StCountryModel countryModel = new StCountryModel()
            {
                CountryID=this.CountryID,
                CountryName=this.CountryName,
                CountryCode=this.CountryCode,
                PhoneCode=this.PhoneCode,

            };
            this.CountryID = ClsCountryDataAccess.AddNewCountry(countryModel);
            /*
             * why -1 becuse when i creat country by nonparmter and initial value in it is -1 
             * i map it in stcountrymodel and add to addnew country in database 
             * if it found he assign for it and if it not found he back -1 as it
            */
            return (this.CountryID!=-1);
        }
        private bool _UpdateCountry()
        {
            StCountryModel countryModel = new StCountryModel
            {
                CountryID=this.CountryID,
                CountryName=this.CountryName,
                CountryCode=this.CountryCode,
                PhoneCode=this.PhoneCode,
            };
            return ClsCountryDataAccess.UpdateCountry(countryModel);
        }
        public bool Save()
        {
            switch (mode)
            {
                case enMode.add:
                    if (_AddNewCountry())
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                case enMode.update:
                    return _UpdateCountry();

                 default: return false;
            }
        }

        public static bool DeleteCountry(int countryID)
        {
            return ClsCountryDataAccess.DeleteCountry(countryID);
        }
        public static DataTable GetAllCountry()
        {
            return ClsCountryDataAccess.GetAllCountry();
        }

        public static bool IsExsit(int countryId)
        {
            return ClsCountryDataAccess.IsExsitById(countryId);
        }
        public static bool IsExsit(string countryName)
        {
            return ClsCountryDataAccess.IsExsitByName(countryName);
        }




































































































    }
}
