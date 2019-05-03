using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program9
{
    public partial class frmEditAccount : Form
    {

        private int id;

        public frmEditAccount(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void frmEditAccount_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'accountsDataSet.Accounts' table. You can move, or remove it, as needed.
            this.accountsTableAdapter.FillByID(this.accountsDataSet.Accounts, id);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            // Input validation
            if (firstNameTextBox.Text == "")
            {
                MessageBox.Show("First Name cannot be empty!");
                firstNameTextBox.Focus();
                return;
            }

            if (lastNameTextBox.Text == "")
            {
                MessageBox.Show("Last Name cannot be empty!");
                lastNameTextBox.Focus();
                return;
            }

            if (streetTextBox.Text == "" || streetTextBox.Text.Length < 5)
            {
                MessageBox.Show("Please enter a valid address!");
                streetTextBox.Focus();
                return;
            }

            if (cityTextBox.Text == "")
            {
                MessageBox.Show("City name cannot be empty!");
                cityTextBox.Focus();
                return;
            }

            if (stateTextBox.Text == "")
            {
                MessageBox.Show("Please enter a valid state!");
                stateTextBox.Focus();
                return;
            }

            if (zipTextBox.Text == "" || zipTextBox.Text.Length < 5)
            {
                MessageBox.Show("Please enter a valid ZIP code");
                zipTextBox.Focus();
                return;
            }

            this.Validate();
            this.accountsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.accountsDataSet);

            // Close the form
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
