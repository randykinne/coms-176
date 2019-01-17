using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projectone
{
    public partial class frmInformation : Form
    {
        public frmInformation()
        {
            InitializeComponent();
        }

        // Note about label: I would be more descriptive(labelMessage or something) but this is a simple program

        private void buttonExit_Click(object sender, EventArgs e)
        {
            // On click, close the program
            Close();
        }

        private void pictureLF_Click(object sender, EventArgs e)
        {
            // On click of LF logo, display text about Lake Fenton
            lblDescription.Text = "Randy Kinne graduated from Lake Fenton High School in 2017. He was a multi-year engineering student and was the recipient of the Engineering Award of Excellence in 2016.";
        }

        private void pictureMott_Click(object sender, EventArgs e)
        {
            // On click of Mott logo, display text about Mott
            lblDescription.Text = "Randy Kinne is currently attending Mott Community College. He is majoring in Computer Information Systems and is a full time student.";
        }

        private void pictureNexly_Click(object sender, EventArgs e)
        {
            // On click of Nexly logo, display text about Nexly
            lblDescription.Text = "Randy Kinne is currently a software engineer, systems administrator, and database administrator at Nexly Network, a new technology startup providing an online gaming network.";
        }
    }
}
