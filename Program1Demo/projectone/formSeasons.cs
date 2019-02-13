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
    public partial class formSeasons : Form
    {
        public formSeasons()
        {
            InitializeComponent();
        }

        private void labelMessage_Click(object sender, EventArgs e)
        {

        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            // On click of exit button :)
            Close();
        }

        private void pictureCold_Click(object sender, EventArgs e)
        {
            // On click of picture cold, show message about cold climate
            labelMessage.Text = "That picture is very cold. I like mountains and snow too.";
        }

        private void pictureWarm_Click(object sender, EventArgs e)
        {
            labelMessage.Text = "That picture is very warm. I like beaches too.";
        }
    }
}
