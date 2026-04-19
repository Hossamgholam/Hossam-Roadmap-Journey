using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pizza_project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        float calculateSizePrice()
        {
            float price = 0;
            if (rbSmall.Checked)
            {
                price=Convert.ToSingle(rbSmall.Tag);
            }
            else if (rbMeduim.Checked)
            {
                price= Convert.ToSingle(rbMeduim.Tag);
            }
            else if(rbLarg.Checked) {

                price=Convert.ToSingle(rbLarg.Tag);
            }
            return price;
        }
        float calculateToppingsPrice()
        {
            float price = 0;
            if (chkChees.Checked) {
                price+=Convert.ToSingle(chkChees.Tag);
            }
            if (chkGreenPeppers.Checked)
            {
                price+=Convert.ToSingle(chkGreenPeppers.Tag);
            }
            if (chkMushrooms.Checked)
            {
                price+=Convert.ToSingle(chkMushrooms.Tag);
            }
            if (chkOlives.Checked) {
                price+=Convert.ToSingle(chkOlives.Tag);
            }
            if (chkOnion.Checked)
            {
                price+=Convert.ToSingle(chkOnion.Tag);
            }
            if(chkTomatoes.Checked)
            {
                price+=Convert.ToSingle(chkTomatoes.Tag);

            }
            return price;
        }
        float CaculateCrustTupe()
        {
            if (rbThin.Checked)
            {
                return Convert.ToSingle(rbThin.Tag);
            }
            else 
            {
                return Convert.ToSingle(rbThink.Tag);
            }
        }
        float calculateTotalPrice()
        {
            return calculateSizePrice()+calculateToppingsPrice()+CaculateCrustTupe(); 
        }
        void updateTotalPrice()
        {
            lbTotalPrice.Text="$"+calculateTotalPrice().ToString();
        }

        //update lable of size and total price
        void updateSize()
        {
            updateTotalPrice();

            if (rbSmall.Checked)
            {
                lbSize.Text=rbSmall.Text;
            }
            else if (rbMeduim.Checked)
            {
                lbSize.Text = rbMeduim.Text;
            }
            else { 
                lbSize.Text=rbLarg.Text;
            }
        }
        private void rbSmall_CheckedChanged(object sender, EventArgs e)
        {
            updateSize();
        }
        private void rbMeduim_CheckedChanged(object sender, EventArgs e)
        {
            updateSize();
        }
        private void rbLarg_CheckedChanged(object sender, EventArgs e)
        {
            updateSize();
        }

        //update curst type label text and total price 
        void updateCurstType()
        {
            updateTotalPrice();
            if (rbThin.Checked)
            {
                lbCurstType.Text=rbThin.Text;
            }
            else
            {
                lbCurstType.Text = rbThink.Text;
            }
        }
        private void rbThin_CheckedChanged(object sender, EventArgs e)
        {
            updateCurstType();
        }
        private void rbThink_CheckedChanged(object sender, EventArgs e)
        {
            updateCurstType();
        }

        //update label of toppings and price every once you check 
        void updateToppings() {
            updateTotalPrice();

            string toppings = "";
            if (chkChees.Checked)
            {
                toppings+=","+chkChees.Text;
            }
            if (chkGreenPeppers.Checked)
            {
                toppings+=  ","+chkGreenPeppers.Text;
            }
            if (chkMushrooms.Checked)
            {
                toppings+=","+chkMushrooms.Text;
            }
            if (chkOlives.Checked)
            {
                toppings+="," + chkOlives.Text;
            }
            if (chkOnion.Checked)
            {
                toppings+="," + chkOnion.Text;
            }
            if (chkTomatoes.Checked)
            {
                toppings+="," + chkTomatoes.Text;

            }
            if (toppings.StartsWith(",")){
                toppings=toppings.Substring(1,toppings.Length-1);
            }
            if (toppings=="")
            {
                toppings="No chooice";
            }
            
            lbToppings.Text = toppings;
        }
        private void chkChees_CheckedChanged(object sender, EventArgs e)
        {
            updateToppings();
        }
        private void chkOnion_CheckedChanged(object sender, EventArgs e)
        {
            updateToppings();
        }
        private void chkMushrooms_CheckedChanged(object sender, EventArgs e)
        {
            updateToppings();
        }
        private void chkOlives_CheckedChanged(object sender, EventArgs e)
        {
            updateToppings();
        }
        private void chkTomatoes_CheckedChanged(object sender, EventArgs e)
        {
            updateToppings();
        }
        private void chkGreenPeppers_CheckedChanged(object sender, EventArgs e)
        {
            updateToppings();
        }

       
        void updateWhereToEat()
        {
            if (rbEatIn.Checked)
            {
                lbWhereToEat.Text= rbEatIn.Text;
            }
            else if (rbTakeOut.Checked)
            {
                lbWhereToEat.Text = rbTakeOut.Text;
            }
            else
            {
                lbWhereToEat.Text="no chooice";
            }
        }
        private void rbEatIn_CheckedChanged(object sender, EventArgs e)
        {
            updateWhereToEat();
        }
        private void rbTakeOut_CheckedChanged(object sender, EventArgs e)
        {
            updateWhereToEat();
        }

        //whene click on order pizz it make scrren enable
        private void btnOrderPizza_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("confirm order", "confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)==DialogResult.OK)
            {
                MessageBox.Show("order confirm:", "message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnOrderPizza.Enabled = false;
                gbSize.Enabled = false;
                gbCrustType.Enabled = false;
                gbToppings.Enabled = false;
                gbWhereToEat.Enabled = false;
            }
            else
            {
                MessageBox.Show("update order", "update", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        //whene click reset button 
        private void btnResetFrom_Click(object sender, EventArgs e)
        {
            btnOrderPizza.Enabled=true;
            gbSize.Enabled=true;
            gbCrustType.Enabled=true;
            gbToppings.Enabled=true;
            gbWhereToEat.Enabled=true;

            //default chooice
            rbMeduim.Checked=true;

            //default crust type
            rbThin.Checked=true;

            //default where to Eat
            rbEatIn.Checked=true;
            
            //default topping no chooice
            chkChees.Checked=false;
            chkOlives.Checked=false;
            chkMushrooms.Checked=false;
            chkOnion.Checked=false;
            chkTomatoes.Checked=false;
            chkGreenPeppers.Checked=false;

            //calculate default chooess price
            updateTotalPrice();

            
        }

        //whene form load
        private void Form1_Load(object sender, EventArgs e)
        {
            updateSize();
            updateCurstType();
            updateToppings();
            updateWhereToEat();
            
        }

        
    }

}
