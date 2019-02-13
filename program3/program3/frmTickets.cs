using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace program3
{
    public partial class frmTickets : Form
    {
        // Init variables
        private const double dblAdultPrice = 49.00;
        private const double dblChildPrice = 42.00;
        private const double dblParkingPrice = 15.00;
        private const double dblDiscountPercent = 0.1; // 10%
        private const double dblSecondDayPrice = 25.00;
        private int intAdults = 0;
        private int intChildren = 0;
        private int intDays = 1;
        private double dblTotalPrice = 0.00;

        public frmTickets()
        {
            InitializeComponent();
            // Set Single day checked to true
            rdoSingle.Checked = true;
            // Set selected items
            lstAdult.SelectedIndex = 0;
            lstChildren.SelectedIndex = 0;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnAdvance_Click(object sender, EventArgs e)
        {
            // Toggle color when user clicks button
            if (btnAdvance.BackColor == Color.LimeGreen)
            {
                btnAdvance.BackColor = Color.Orange;
            } else
            {
                btnAdvance.BackColor = Color.LimeGreen;
            }
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // Calculate costs for each adult and child selected
            dblTotalPrice = intAdults * dblAdultPrice;
            dblTotalPrice += intChildren * dblChildPrice;

            // If user is paying for parking
            if (ChkParking.Checked)
            {
                dblTotalPrice += dblParkingPrice;
            }

            // If user is paying for two days
            if (rdoTwo.Checked)
            {
                dblTotalPrice += ((intAdults + intChildren) * dblSecondDayPrice);
                // If user is also paying for parking pass for two days
                if (ChkParking.Checked)
                {
                    dblTotalPrice += dblParkingPrice;
                }
            }

            // If user is paying in advance, give the discount
            if (btnAdvance.BackColor == Color.LimeGreen)
            {
                dblTotalPrice *= (1 - dblDiscountPercent); // 100% - 10%
            }

            // Set the label to display the total price to the user
            lblTotal.Text = dblTotalPrice.ToString("N2");
        }

        private void lstAdult_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Parse value of the selected index
            intAdults = int.Parse(lstAdult.Text);
        }

        private void lstChildren_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Parse value of the selected index
            intChildren = int.Parse(lstChildren.Text);
        }

        private void rdoTwo_CheckedChanged(object sender, EventArgs e)
        {
            // Set number of days depending on the status of radio 2
            if (rdoTwo.Checked)
            {
                intDays = 2;
            } else
            {
                intDays = 1;
            }
        }
    }
}
