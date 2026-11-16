using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fat_Percentage_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            = 0;
             = 0;

            // Labada sanduuq waa khasab.
            if (string.IsNullOrWhiteSpace(txtcolory.Text) ||
                string.IsNullOrWhiteSpace(txtfat.Text))
            {
                chkLowFat.Checked = false;
                return false;
            }

            bool validCalories = double.TryParse(
                txtcolory.Text, NumberStyles.Number,
                CultureInfo.CurrentCulture, out calories);

            bool validFat = double.TryParse(
                txtfat.Text, NumberStyles.Number,
                CultureInfo.CurrentCulture, out fatGrams);

            if (!validCalories || !validFat || calories <= 0 || fatGrams < 0)
            {
                chkLowFat.Checked = false;
                return false;
            }

            // 1 garaam oo dufan ah = 9 calories.
            double fatCalories = fatGrams * 9;

            // Kalooriyada dufanku kama badnaan karaan kalooriyada guud.
            if (fatCalories > calories)
            {
                chkLowFat.Checked = false;
                return false;
            }

            return true;
        }

        private void Inputs_TextChanged(object sender, EventArgs e)
        {
            if (TryGetValues(out double calories, out double fatGrams))
            {
                double fatPercentage = (fatGrams * 9 / calories) * 100;
                chkLowFat.Checked = fatPercentage < 30;
            }
            else
            {
                chkLowFat.Checked = false;
            }
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (!TryGetValues(out double calories, out double fatGrams))
            {
                MessageBox.Show(
                    "Geli calories sax ah iyo fat grams sax ah. " +
                    "Calories-ku waa inay ka weyn yihiin 0, " +
                    "kalooriyada dufankuna kama badnaan karaan calories-ka guud.",
                    "Hubi xogta",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            double fatCalories = fatGrams * 9;
            double fatPercentage = (fatCalories / calories) * 100;

            chkLowFat.Checked = fatPercentage < 30;

            MessageBox.Show(
                $"Fat calories: {fatCalories:F1}\n" +
                $"Fat percentage: {fatPercentage:F1}%",
                "Natiijada");
        }
    }
}
    }
}
