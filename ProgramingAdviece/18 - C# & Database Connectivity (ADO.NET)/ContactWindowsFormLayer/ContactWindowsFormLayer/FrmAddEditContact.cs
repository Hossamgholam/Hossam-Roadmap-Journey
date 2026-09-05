using ContactBusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContactWindowsFormLayer
{
    public partial class FrmAddEditContact : Form
    {
        private enum enMode { Add=0, Update=1,NotExsit=2}
        private enMode _mode;
        private int _ContactId;

        private ClsContact _contact;


        public FrmAddEditContact(int ContactID)
        {
            InitializeComponent();
            _ContactId = ContactID;
            if (ContactID ==-1)
            {
                _mode=enMode.Add;
            }
            else
            {
                _contact=ClsContact.Find(ContactID);
                if (_contact!=null)
                {
                    _mode = enMode.Update;
                }
                else
                {
                    _mode = enMode.NotExsit;
                }
            }
        }
        private void _loadDate()
        {
            //we can load contact lik this 
            //load country from datatbase
            DataTable dt = ClsCountry.GetAllCountry();
            foreach (DataRow row in dt.Rows)
            {
                CBCountry.Items.Add(row["CountryName"].ToString());
            }
            /*
             * there is to condation and in to condation i fill form with its info and create contact 
             */
            if (_mode==enMode.Add)
            {
                TBID.Text="??";

               CBCountry.SelectedIndex = 0;

               BtnRemoveImage.Visible= false;

                _contact = new ClsContact();

            }
            else if (_mode==enMode.Update)
            {
                LbAddOEdite.Text="Update Exsit Contact";

                TBID.Text=_ContactId.ToString();

                
                

                    TBFirstName.Text=_contact.FirstName;
                    TBLastName.Text=_contact.LastName;
                    TBEmail.Text=_contact.Email;
                    TBPhone.Text=_contact.Phone;

                    CBCountry.SelectedIndex=CBCountry.FindString(ClsCountry.Find(_contact.CountryId).CountryName);

                    TBAddress.Text=_contact.Address;
                    DTPDOF.Value=_contact.DateOfBirth;

                    try
                    {
                        if (!string.IsNullOrEmpty(_contact.ImagePath) && File.Exists(_contact.ImagePath))
                        {
                            PbContact.Load(_contact.ImagePath);
                        }
                        else
                        {
                            PbContact.Image = null;
                            BtnRemoveImage.Visible= false;
                    }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        PbContact.Image = null;
                    }
            }
            else
            {
                    MessageBox.Show("Contact not Exsit", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                
            }
            
        }

        private void FrmAddEditContact_Load(object sender, EventArgs e)
        {
            _loadDate();
        }

        private void BtnSetImage_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory=@"H:\desktop picture\Images";
            openFileDialog1.Title="open";

            openFileDialog1.Filter =
                   "JPEG Files|*.jpg;*.jpeg|" +
                   "PNG Files|*.png|" +
                   "Bitmap Files|*.bmp|" +
                   "GIF Files|*.gif|" +
                   "All Files|*.*";
            openFileDialog1.FilterIndex=2;
            if (openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                PbContact.Load(openFileDialog1.FileName);
            }
        }

        private void BtnRemoveImage_Click(object sender, EventArgs e)
        {
            PbContact.ImageLocation=null;
            BtnRemoveImage.Visible=false;
        }

        private void BtnSaveContac_Click(object sender, EventArgs e)
        {
            _contact.FirstName=TBFirstName.Text;
            _contact.LastName=TBLastName.Text;
            _contact.Email=TBEmail.Text;
            _contact.Phone=TBPhone.Text;
            _contact.CountryId=ClsCountry.Find(CBCountry.Text).CountryID;
            _contact.DateOfBirth=DTPDOF.Value;
            _contact.Address=TBAddress.Text;

            if (PbContact.ImageLocation!=null)
            {
                _contact.ImagePath=PbContact.ImageLocation.ToString();
            }
            else
            {
                _contact.ImagePath="";
            }


            if (_contact.save())
            {
                MessageBox.Show("Contact save","Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("not save", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            _mode = enMode.Update;
            LbAddOEdite.Text = "Edit Contact ID  ";
            TBID.Text = _contact.Id.ToString();
        }

        private void BtnCloseContact_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
