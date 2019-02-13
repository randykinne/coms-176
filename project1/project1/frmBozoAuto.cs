using System;
using Microsoft.VisualBasic;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project1
{
    public partial class frmBozoAuto : Form
    {
        // Initialize and assign variables
        private double income = 0.00;
        private double rent = 0.00;
        private double otherPayments = 0.00;
        private double interestRate = 0.19; // 19%
        private double monthlyCarPayment = 0.00;
        private double maxCarValue = 0.00;
        private int years = 6;

        public frmBozoAuto()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Set defaults on app load
            rdoOKCredit.Checked = true;
            lstYears.SelectedIndex = 0;
            txtBoxIncome.Focus();
        }

        /**
         * Text boxes that handle income, rent, and other expenses
         **/

        private void txtBoxIncome_TextChanged(object sender, EventArgs e)
        {
            try
            {
                // Set income to the value in the text box
                income = double.Parse(txtBoxIncome.Text);
            } catch (FormatException exception)
            {
                Console.WriteLine("FormatException thrown: " + exception.Message);
            }
        }

        private void txtBoxRent_TextChanged(object sender, EventArgs e)
        {
            try
            {
                // Set income to the value in the text box
                rent = double.Parse(txtBoxRent.Text);
            }
            catch (FormatException exception)
            {
                Console.WriteLine("FormatException thrown: " + exception.Message);
            }
        }

        private void txtOtherPayments_TextChanged(object sender, EventArgs e)
        {
            try
            {
                // Set income to the value in the text box
                otherPayments = double.Parse(txtOtherPayments.Text);
            }
            catch (FormatException exception)
            {
                Console.WriteLine("FormatException thrown: " + exception.Message);
            }
        }

        /**
         * Radio buttons that handle credit/interest rate
         **/

        private void rdoGoodCredit_CheckedChanged(object sender, EventArgs e)
        {
            interestRate = 0.08; // 8%
        }

        private void rdoOKCredit_CheckedChanged(object sender, EventArgs e)
        {
            interestRate = 0.16; // 16%
        }

        private void rdoBadCredit_CheckedChanged(object sender, EventArgs e)
        {
            interestRate = 0.19; // 19%
        }

        /**
         * Calculate Button that handles..... calculating
         **/

        private void btnCalculate_Click(object sender, EventArgs e)
        { 
            // Set montly payment var to the equation listed in the resource doc
            monthlyCarPayment = (income * 0.36) - rent - otherPayments;
            // Check if the monthly car payment is greater than 0, if not, the payment exceeds 36% or something else may be wrong
            if (monthlyCarPayment > 0)
            {
                // Display in to user
                lblAllowablePayment.Text = monthlyCarPayment.ToString("N2");

                // PV equation as listed in docs, negative because the equation returns a negative value, so this is actually a positive
                maxCarValue = -Financial.PV((interestRate / 12), (years * 12), monthlyCarPayment);
                // Display to user
                lblMaxCarValue.Text = maxCarValue.ToString("N2");
            } else
            {
                // Monthly car payment exceeds debt load of 36% of their gross monthly income
                lblAllowablePayment.Text = "Payment denied! Exceeds 36%";
            }
        }

        /**
         * Year selection list
         **/

        private void lstYears_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Set to years, no exception handling necessary because the value will always be an integer
            years = int.Parse(lstYears.Text);
        }
    }
}
