using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp1
{
    public partial class frmStudentGroupSelector : Form
    {
        public frmStudentGroupSelector()
        {
            InitializeComponent();
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            // Try to handle possible file errors
            try
            {
                // Clear home box to get a fresh slate
                listBoxHome.Items.Clear();
                // Open pre-specified file
                StreamReader file = File.OpenText("studentlist.txt");
                // Init string variable 'line' for use in while
                string line;
                // while the file has characters on the next line
                while ((line = file.ReadLine()) != null) {
                    // Add to home box
                    listBoxHome.Items.Add(line);
                }
                // Close the file
                file.Close();
            } catch (Exception ex)
            {
                // Pop up to user if there was a file error
                MessageBox.Show(ex.Message);
            }

        }

        private void btnDisplayGroups_Click(object sender, EventArgs e)
        {
            // Clear both lists to get a fresh slate
            listBoxGroup1.Items.Clear();
            listBoxGroup2.Items.Clear();

            // Hide the home box
            groupBoxHome.Hide();

            // Instantiate a Random object, important to only instantiate it once as it goes by system clock
            Random random = new Random();

            // Get pseudo "max size" of groups based on just dividing the overall count by 2
            int maxSize = listBoxHome.Items.Count / 2;

            // For each person in the list box home
            foreach (string person in listBoxHome.Items)
            {
                // Only add users to group 1 if the random allows and the max size has not been reached
                if (random.Next(0, 10) <= 5 && listBoxGroup1.Items.Count <= maxSize)
                {
                    listBoxGroup1.Items.Add(person);
                } else
                {
                    listBoxGroup2.Items.Add(person);
                }

                // Sometimes (rarely, but sometimes) due to the random number, users will be sent to group 2 too much, 
                // beyond the max size, so this just checks for that and sends them to 1 instead
                if (listBoxGroup2.Items.Count > maxSize)
                {
                    listBoxGroup1.Items.Add(person);
                    listBoxGroup2.Items.Remove(person);
                }
            }

            // After groups have been sorted, show the box to user
            groupBoxDisplay.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            // Close the app
            Close();
        }

        private void frmClassGroupHelper_Load(object sender, EventArgs e)
        {
            // Hide the group display groupBox when the form loads
            groupBoxDisplay.Hide();
        }

        private void groupBoxDisplay_Enter(object sender, EventArgs e)
        {
            // I accidentally clicked the groupbox so it created the method, unsure of how to remove successfully
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            // On return, hide the display box, show the home box
            groupBoxDisplay.Hide();
            groupBoxHome.Show();
        }
    }
}
