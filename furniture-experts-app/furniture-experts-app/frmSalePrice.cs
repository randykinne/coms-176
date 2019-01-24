using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace furniture_experts_app
{
    public partial class formFurniture : Form
    {
        public formFurniture()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // Self explanatory, but this function closes the application
            Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            /* Init default text variable, saves writing it out every time
             * Also if it were to be changed in the future, it would be easier
             * The underscore in the name is to avoid complication with the 'default' keyword
             */
            string _default = "$0.00";

            // Reset everything that displays output or input data from user
            txtPrice.Text = "";
            txtDiscount.Text = "";
            lblSalePriceOutput.Text = _default;
            lblSalesTaxOutput.Text = _default;
            lblDeliveryOutput.Text = _default;
            lblTotalDueOutput.Text = _default;
            lblError.Text = ""; // 'Hide' the label by giving it no message

            // Set focus
            txtPrice.Focus();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // Init variables and assign them
            double dblSalesTaxPercent = 0.06; // 6%
            double dblDeliveryFee = 99.00;
            double dblProductPrice = 0;
            double dblDisountPercent = 0;

            // Init these variables but don't assign
            double dblSalePrice;
            double dblSalesTaxAmount;
            double dblGrandTotal;

            // Try-catch to prevent application from closing with error
            try
            {
                dblProductPrice = double.Parse(txtPrice.Text);
                dblDisountPercent = (double.Parse(txtDiscount.Text) / 100); // Get as a percent
            }
            catch (FormatException exception)
            {
                Console.WriteLine("FormatException thrown: " + exception.Message);
                // Display error to user via hidden label
                lblError.Text = "Please input a valid number!";
            }

            // Calculate
            dblSalePrice = (dblProductPrice - (dblProductPrice * dblDisountPercent));
            dblSalesTaxAmount = dblSalePrice * dblSalesTaxPercent;
            dblGrandTotal = dblSalePrice + dblDeliveryFee + dblSalesTaxAmount;

            // Display and format to 2 decimal places
            string prefix = "$";
            lblSalePriceOutput.Text = prefix + dblSalePrice.ToString("N2");
            lblSalesTaxOutput.Text = prefix + dblSalesTaxAmount.ToString("N2");
            lblDeliveryOutput.Text = prefix + dblDeliveryFee.ToString("N2");
            lblTotalDueOutput.Text = prefix + dblGrandTotal.ToString("N2");
        }
    }
}
