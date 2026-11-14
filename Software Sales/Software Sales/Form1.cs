using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Software_Sales
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int quantity;
            decimal price;

            if (!int.TryParse(txtNumberOfPackages.Text, out quantity) ||
                !decimal.TryParse(txtPricePerrPackages.Text, out price) ||
                quantity <= 0 || price < 0)
            {
                MessageBox.Show("Please enter a valid quantity and price.");
                return;
            }

            decimal subtotal = quantity * price;
            decimal discountRate;

            if (quantity >= 100)
            {
                discountRate = 0.30m;
            }
            else if (quantity >= 50)
            {
                discountRate = 0.15m;
            }
            else if (quantity >= 20)
            {
                discountRate = 0.30m;
            }
            else if (quantity >= 10)
            {
                discountRate = 0.05m;
            }
            else
            {
                discountRate = 0m;
            }
            

            decimal discountAmount = subtotal * discountRate;
            decimal totalAmount = subtotal - discountAmount;

            PurchaseResults.Items.Clear();

            PurchaseResults.Items.Add(
                "Quantity of Packages: " + quantity);

            PurchaseResults.Items.Add(
                "Price per Package: " + price.ToString("C2"));

            PurchaseResults.Items.Add(
                "Subtotal Before Discount: " + subtotal.ToString("C2"));

            PurchaseResults.Items.Add(
                "Discount Rate: " + (discountRate * 100) + "%");

            PurchaseResults.Items.Add(
                "Discount Amount: " + discountAmount.ToString("C2"));

            PurchaseResults.Items.Add(
                "Total Amount After Discount: " +
                totalAmount.ToString("C2"));
        }
    }
}
