using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Electricity_Bill_Calculator_ASSIGMENT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lblPricePerUnit_Click(object sender, EventArgs e)
        {

        }

        private void btnCalculateBill_Click(object sender, EventArgs e)
        {
            //Get Customer name from the TextBox
            string CustomerName = txtCustomer.Text;

            // Get Previous meter reading
            double PreviousReading = double.Parse(txtPrevious.Text);

            //Get Current meter reading
            double CurrentReading = double.Parse(txtCurrent.Text);

            //Get Price per Unit
            double PricePerUnit = double.Parse(txtUnitPrice.Text);

            //Calculate the number of units used
            double UnitsUsed = CurrentReading - PreviousReading;

            //Calculate electricity charge
            double ElectricityCharge = UnitsUsed * PricePerUnit;

            //Set the fixed charge
            double FixedCharge = 5.00;

            //Calculate 5% tax
            double tax = ElectricityCharge * 0.07;

            //calculate the Total bill
            double TotalBill = ElectricityCharge + FixedCharge + tax;

            //Display the bill details

            lblOutput.Text = "Customer:" + CustomerName +
            " Units Used:" + UnitsUsed.ToString("0.00") +
            " Tax (7%): $" + tax.ToString("0.00") +
            " Total Bill: $" + TotalBill.ToString("0.00");
               
               

        }
    }
}
