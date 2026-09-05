using ContactBusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContactWindowsFormLayer
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource=ClsContact.GetContactDataTable();
        }

        private void BtnAddContact_Click(object sender, EventArgs e)
        {
            Form frm=new FrmAddEditContact(-1);
            
            frm.ShowDialog();
            dataGridView1.DataSource=ClsContact.GetContactDataTable();

        }

        private void editeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int contactId=(int)dataGridView1.CurrentRow.Cells[0].Value;
            Form frm = new FrmAddEditContact(contactId);
            frm.ShowDialog();
            dataGridView1.DataSource =ClsContact.GetContactDataTable();

        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int contactId = (int)dataGridView1.CurrentRow.Cells[0].Value;

            DialogResult result = MessageBox.Show("Are you sure you want to  delete", "confirm Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (result == DialogResult.OK)
            {
                if (ClsContact.DeleteContact(contactId))
                {
                    MessageBox.Show("is delete", "delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("not delete", "delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("operation cancal", "delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            dataGridView1.DataSource =ClsContact.GetContactDataTable();
        }
    }
}
