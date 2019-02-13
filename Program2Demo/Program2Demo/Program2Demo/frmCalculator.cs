using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program2Demo
{
    public partial class frmCalculator : Form
    {
        public frmCalculator()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            // Close application
            Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // Clear all text boxes
            txtInput.Clear();
            lblTaxOutput.Text = "$0.00";
            lblTipOutput.Text = "$0.00";
            lblGrandTotalOutput.Text = "$0.00";
            lblError.Text = ""; // Purposefully empty to 'hide' the label
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // Init + assign variables
            double tipRate = 0.15;
            double taxRate = 0.06;

            double subTotal = 0.0;
            double tipAmount;
            double taxAmount;
            double grandTotal;

            // Set subTotal to input after parse
            // If exception gets thrown, set hidden error label text
            try
            {
                subTotal = double.Parse(txtInput.Text);
            } catch (Exception exception)
            {
                lblError.Text = "Please enter a valid number!";
            }

            // Calculate amounts
            tipAmount = subTotal * tipRate;
            taxAmount = subTotal * taxRate;
            grandTotal = subTotal + tipAmount + taxAmount;

            // Display amounts
            displayAmounts(tipAmount, taxAmount, grandTotal);
        }

        private void displayAmounts(double tipAmount, double taxAmount, double grandTotal)
        {
            // Assign prefix to simplify and enhance readability
            string prefix = "$";
            lblTipOutput.Text = prefix + tipAmount.ToString("N2");
            lblTaxOutput.Text = prefix + taxAmount.ToString("N2");
            lblGrandTotalOutput.Text = prefix + grandTotal.ToString("N2");
            
        }
    }
}
