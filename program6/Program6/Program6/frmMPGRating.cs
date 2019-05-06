using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program6
{
    public partial class frmMPGRating : Form
    {
        public frmMPGRating()
        {
            InitializeComponent();
        }

        // Init and assign variable
        private List<Double> ratings = new List<Double>();

        // Functions

        // Calculate and display MPG on screen, called on update of values
        private void calcMPG()
        {
            // Init and assign variables
            decimal start = nudMileageStart.Value;
            decimal end = nudMileageEnd.Value;

            decimal result = new decimal(0.0);

            // Thanks for the help
            try
            {
                // This equation is as displayed in the program documentation
                result = (end - start) / nudGallonsUsed.Value;
            } catch (DivideByZeroException ex)
            {
                // If we're calling calcMPG() after very value update, gallons is gonna be 0 alot before the user is able to enter it, this would be annoying to show to user every time.
                // Thus, if we're not printing to console or showing message box, why not just use an if statement to avoid throwing the exception
                // MessageBox.Show(ex.Message);

                //Printing to console because empty exception handling is bad practice
                Console.WriteLine("Surprise! " + ex.Message);
            }

            // Display result to user
            tbxCurrentMPG.Text = result.ToString("N1");
        }

        private void getResults()
        {
            // Init and assign variable
            double[] results = new double[3];
            // Fancy for method that doesn't use numbers, numbers are more useful if we need the index
            foreach (double mpg in ratings)
            {
                // Add all mpg's together to divide at end
                results[0] += mpg;

                // Set lowest mpg, if the result == 0.0, then the lowest mpg hasn't been set yet
                // Lowest will never = 0.0 unless it hasn't been set as the add button won't let you add a 0.0
                if (mpg < results[1] || results[1] == 0.0)
                {
                    results[1] = mpg;
                }

                // Set highest mpg
                if (mpg > results[2])
                {
                    results[2] = mpg;
                }
            }

            // Divide by the number of ratings to get the average
            results[0] /= ratings.Count();
            // Displayyy
            displayResults(results);
        }

        private void displayResults(double[] results)
        {
            // We already know the size of the array
            tbxOverallMPG.Text = results[0].ToString();
            tbxLowestMPG.Text = results[1].ToString();
            tbxHighestMPG.Text = results[2].ToString();
        }

        private void addRating(double rating)
        {
            // Add those MPG ratings to the lists
            ratings.Add(rating);
            lbxRatings.Items.Add(rating.ToString());
        }

        private void resetInput()
        {
            // Set the inputs to the default values
            nudMileageStart.Text = "0.0";
            nudMileageEnd.Text = "0.0";
            nudGallonsUsed.Text = "0.00";
        }

        // Events

        private void btnExit_Click(object sender, EventArgs e)
        {
            // I feel that we shouldn't have to comment such obvious code, but I'll follow along
            // This closes the program
            Close();
        }

        private void nudMileageStart_ValueChanged(object sender, EventArgs e)
        {
            // Call calcMPG() after the values get changed to update it to the user
            calcMPG();
        }

        private void nudMileageEnd_ValueChanged(object sender, EventArgs e)
        {
            // Call calcMPG() after the values get changed to update it to the user
            calcMPG();
        }

        private void nudGallonsUsed_ValueChanged(object sender, EventArgs e)
        {
            // Call calcMPG() after the values get changed to update it to the user
            calcMPG();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Prevent the user from breaking the program with bad math
            if (double.Parse(nudMileageStart.Text) > double.Parse(nudMileageEnd.Text))
            {
                MessageBox.Show("Starting mileage can not be greater than ending mileage!");
                // Return because we don't want to do anything else in this function after the user messed up
                return;
            }

            // Prevent the user from adding a MPG of 0.0 to the list
            if (double.Parse(tbxCurrentMPG.Text) == 0.0)
            {
                MessageBox.Show("MPG cannot be 0.0");
                // Same as above, user doesn't get to finish this method
                return;
            }

            // User cleared the validation checks, add the ratings to the lists
            addRating(double.Parse(tbxCurrentMPG.Text));
            // Get the results to update the average, lowest, and highest
            getResults();
            // Reset the numbers of the input to 0
            resetInput();
        }
    }
}
