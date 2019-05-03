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
    public partial class frmCookieAccounts : Form
    {
        public frmCookieAccounts()
        {
            InitializeComponent();
        }

        public void updateTable()
        {
            this.tableAdapterManager.UpdateAll(this.accountsDataSet);
        }

        private void frmCookieAccounts_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'accountsDataSet.Accounts' table. You can move, or remove it, as needed.
            this.accountsTableAdapter.Fill(this.accountsDataSet.Accounts);
        }

        public void accountsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.accountsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.accountsDataSet);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            /*if (accountsDataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a single user to edit!");
                return;
            }*/

            // Create new form, give it the ID value of the selected row
            frmEditAccount form = new frmEditAccount(int.Parse(accountsDataGridView.CurrentRow.Cells[0].Value.ToString()));

            // Show the form
            form.ShowDialog();

            // Refresh..
            this.accountsTableAdapter.Fill(this.accountsDataSet.Accounts);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            // Execute FillByName query
            this.accountsTableAdapter.FillByName(this.accountsDataSet.Accounts, tboSearch.Text);
        }

        private void btnDisplayAll_Click(object sender, EventArgs e)
        {
            // Execute normal Fill query
            this.accountsTableAdapter.Fill(this.accountsDataSet.Accounts);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmEditAccount form = new frmEditAccount(59);
            form.ShowDialog();
        }

        // Like my custom live-update search? No need to click any buttons, just start typing.
        // This would likely stress the SQL server with queries if the database was large, but local cookie scouts are unlikely to need more than 1000 records
        private void tboSearch_TextChanged(object sender, EventArgs e)
        {
            // If the text is not the placeholder text, execute search
            if (tboSearch.Text != "Search By Name")
            {
                // Search via FillByName query
                this.accountsTableAdapter.FillByName(this.accountsDataSet.Accounts, tboSearch.Text);
            }
        }

        // Custom 'Enter' event
        private void tboSearch_Enter(object sender, EventArgs e)
        {
            // If it is placeholder text, remove and change text color to black
            if (tboSearch.Text == "Search By Name")
            {
                tboSearch.Text = "";
                tboSearch.ForeColor = Color.Black;
            } else
            {
                // There's already text there, start searching
                this.accountsTableAdapter.FillByName(this.accountsDataSet.Accounts, tboSearch.Text);
            }
        }

        // Custom 'Leave' event
        private void tboSearch_Leave(object sender, EventArgs e)
        {
            // If it is empty, it needs placeholder, otherwise do nothing
            if (tboSearch.Text == "")
            {
                // Add placeholder text, change color to silver
                tboSearch.Text = "Search By Name";
                tboSearch.ForeColor = Color.InactiveCaption;
            }
        }
    }
}
