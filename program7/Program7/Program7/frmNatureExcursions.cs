using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program7
{
    public partial class frmNatureExcursions : Form
    {
        public frmNatureExcursions()
        {
            InitializeComponent();
        }

        // Initialize struct
        private struct Profile
        {
            public String firstName;
            public String lastName;
            public String fullName;
            public Preference preference;
            public String comment;
        }

        // Init enum
        private enum Preference
        {
            NATURE_TRAIL,
            KAYAK_TOUR,
            BOAT_EXCURSION
        }

        // Init + assign a list to hold the profiles
        private List<Profile> profiles = new List<Profile>();

        // Loop through and find profile in list, if not found, create new one
        private Profile getOrCreateProfile(String name)
        {
            foreach (Profile profile in profiles) {
                if (string.Equals(name, profile.fullName, StringComparison.OrdinalIgnoreCase)) {
                    return profile;
                }
            }

            Profile newProfile = new Profile();
            newProfile.firstName = name.Split(',')[1].Replace(" ", "");
            newProfile.lastName = name.Split(',')[0].Replace(" ", "");
            newProfile.fullName = name;
            return newProfile;
        }

        // Add profile to list
        private void addProfile(Profile profile)
        {
            // Prevent duplicates
            if (profiles.Contains(profile))
            {
                profiles.Remove(profile);
            }

            // Add to list
            profiles.Add(profile);

            // Order by last name, then first name
            profiles = profiles.OrderBy(c => c.lastName).ThenBy(c => c.firstName).ToList();

            // Clear cbx, then add all items in profiles to list after it's sorted
            cbxCustomers.Items.Clear();
            foreach (Profile x in profiles)
            {
                cbxCustomers.Items.Add(x.lastName + ", " + x.firstName);
            }
        }

        // Remove profile from list
        private void removeProfile(Profile profile)
        {
            profiles.Remove(profile);
            cbxCustomers.Items.Remove(profile.fullName);
        }

        // Clear the visible entry to user
        private void clearEntry()
        {
            tbxFirstName.Clear();
            tbxLastName.Clear();
            rdoBoatExcursion.Checked = false;
            rdoKayakTour.Checked = false;
            rdoNatureTrail.Checked = false;
            tbxComment.Text = "";
            gbxProfile.Enabled = false;
        }

        // Show an entry to user
        private void showEntry(Profile profile)
        {
            clearEntry();

            tbxFirstName.Text = profile.firstName;
            tbxLastName.Text = profile.lastName;

            switch (profile.preference)
            {
                case Preference.NATURE_TRAIL: rdoNatureTrail.Checked = true; break;
                case Preference.KAYAK_TOUR: rdoKayakTour.Checked = true; break;
                case Preference.BOAT_EXCURSION: rdoBoatExcursion.Checked = true; break;
            }

            tbxComment.Text = profile.comment;
        }

        // Save button event
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (tbxFirstName.Text == "" || tbxLastName.Text == "")
            {
                MessageBox.Show("Customer name must be completed!");
                return;
            }

            Profile profile = getOrCreateProfile(tbxLastName.Text + ", " + tbxFirstName.Text);

            if (rdoNatureTrail.Checked)
            {
                profile.preference = Preference.NATURE_TRAIL;
            } else if (rdoKayakTour.Checked)
            {
                profile.preference = Preference.KAYAK_TOUR;
            } else if (rdoBoatExcursion.Checked)
            {
                profile.preference = Preference.BOAT_EXCURSION;
            } else
            {
                MessageBox.Show("Select a preference!");
                return;
            }

            profile.comment = tbxComment.Text;

            addProfile(profile);
            
            clearEntry();
        }

        // Cancel button event
        private void btnCancel_Click(object sender, EventArgs e)
        {
            clearEntry();
        }

        // Delete button event
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (cbxCustomers.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a customer to delete!");
            } else
            {
                removeProfile(getOrCreateProfile(cbxCustomers.Text));
            }
        }

        // Edit button event
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (cbxCustomers.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a customer to edit!");
            } else
            {
                showEntry(profiles[cbxCustomers.SelectedIndex]);
                gbxProfile.Enabled = true;
            }
        }

        // Add button event
        private void btnAdd_Click(object sender, EventArgs e)
        {
            clearEntry();
            gbxProfile.Enabled = true;
            tbxFirstName.Focus();
        }

        // Customer gets selected
        private void cbxCustomers_SelectedIndexChanged(object sender, EventArgs e)
        {
            showEntry(getOrCreateProfile(cbxCustomers.Text));
        }
    }
}
