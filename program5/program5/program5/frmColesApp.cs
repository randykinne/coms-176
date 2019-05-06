using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace program5
{
    public partial class frmColesApp : Form
    {
        public frmColesApp()
        {
            InitializeComponent();
        }

        // Reset the reciept text to the default values
        private void reset()
        {
            lblSubTotal.Text = "0.00";
            lblTax.Text = "0.00";
            lblTotal.Text = "0.00";
            lblSavings.Text = "0.00";
        }

        // Get savings from a subtotal
        private double getSavings(double subTotal, double total)
        {
            return subTotal - total;
        }

        // Get discount taken off subtotal
        private double getDiscount(double percent, double subTotal)
        {
            return subTotal * (1 - percent);
        }

        // Get tax, default 6%
        private double getTax(double subTotal)
        {
            return subTotal * 0.06;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmColesApp_Load(object sender, EventArgs e)
        {
            reset();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // Set the subtotal label to the selected subtotal
            lblSubTotal.Text = nudSubtotal.Text;

            // Parse these values and init+assign variables
            double total = double.Parse(nudSubtotal.Text);
            double salePercent = double.Parse(nudSalePercent.Text)/100;
            double extraPercent = double.Parse(nudExtraDiscount.Text)/100;

            // Run getDiscount() twice to hit both sale percentage and extra discount percentage
            total = getDiscount(salePercent, total);
            total = getDiscount(extraPercent, total);

            // Set tax label to getTax()
            lblTax.Text = getTax(total).ToString("N2");

            // Display before tax is added, otherwise value is incorrect
            lblSavings.Text = getSavings(double.Parse(lblSubTotal.Text), total).ToString("N2");

            // Actually add tax to total
            total += getTax(total);

            // Display final value to reciept
            lblTotal.Text = total.ToString("N2");
        }
    }
}
