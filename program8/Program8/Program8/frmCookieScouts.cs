using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program8
{
    public partial class frmCookieScouts : Form
    {
        public frmCookieScouts()
        {
            InitializeComponent();
            
            // Set up default values on program load
            addCookie(new CookieData("Peppermint Flatties", decimal.Parse(4.99.ToString()), 8));
            addCookie(new CookieData("Chocolate Chippers", decimal.Parse(4.76.ToString()), 17));
            addCookie(new CookieData("Pecan Paradise", decimal.Parse(6.82.ToString()), 9));
            addCookie(new CookieData("Sugary Shortcake", decimal.Parse(5.99.ToString()), 12));

            // Select 1st item in cookie list
            lbxCookies.SelectedIndex = 0;
        }

        // Init + assign new list for cookies to hold all of the cookie data
        // Like a cookie jar
        List<CookieData> cookies = new List<CookieData>();

        // Method to find cookie data by name
        private CookieData getCookie(String name)
        {
            // Go through all the cookies
            foreach (CookieData cookie in cookies)
            {
                // Find the cookie in the cookie jar and pull it out
                if (cookie.CookieName == name)
                {
                    return cookie;
                }
            }

            // Cookie not found
            // Luckily this shouldn't happen as this method is only called on SelectedIndexChange and Update, and in Update there will always be a selected cookie name
            return null;
        }
        
        // Add a cookie to the real jar that holds the actual cookie data and the fake jar that the user sees
        private void addCookie(CookieData data)
        {
            cookies.Add(data);
            lbxCookies.Items.Add(data.CookieName);
        }

        // Display cookie data to user
        private void displayCookieData(CookieData data)
        {
            lblName.Text = data.CookieName;
            lblPrice.Text = data.CookiePrice.ToString();
            lblInventory.Text = data.CookieCount.ToString();
            lblValue.Text = data.CookieValue.ToString();
        }

        // Event for listbox selected index change
        private void lbxCookies_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Display the cookie retrieved by name from the cookie jar
            displayCookieData(getCookie(lbxCookies.Text));
        }

        // Update button click
        private void button1_Click(object sender, EventArgs e)
        {
            // Get the cookie by name
            CookieData cookie = getCookie(lbxCookies.Text);

            // Ensure that there's enough cookies in stock to complete the sale
            if (cookie.CookieCount - nudSold.Value < 0)
            {
                MessageBox.Show("Not enough items in stock to confirm this sale!");
                return;
            }

            // Show the sale amount to the user
            MessageBox.Show("Total Sale: $" + (cookie.CookiePrice * nudSold.Value).ToString("N2"));

            // Subract the sold amount from the amount in stock
            cookie.CookieCount -= int.Parse(nudSold.Value.ToString());

            // Display the updated cookie data (works just like 'invoke the selectedindexchanged')
            displayCookieData(cookie);

            // Reset the sold value to 0 to get ready for the next sale
            nudSold.Value = 0;
        }
    }

    // COOKIE
    class CookieData
    {
        // The public name of the cookie, isn't changed
        public String CookieName { get; set; }

        // Private var containing the hidden cookie price
        private Decimal cookiePrice;

        // Public property using custom setter that calls updateValue()
        public Decimal CookiePrice
        {
            get { return cookiePrice; }
            set
            {
                cookiePrice = value;
                updateValue();
            }
        }

        // Private var containing the hidden cookie count
        private int cookieCount;

        // Public property using custom setter that calls updateValue()
        public int CookieCount {
            get { return cookieCount;  }
            set
            {
                cookieCount = value;
                updateValue();
            }
        }

        // Public property using private set to ensure that the value is only changed from within this class 
        public Decimal CookieValue { get; private set; }

        // Private method to set cookievalue, can only be called within the class and is only called in CookieCount and CookiePrice setters
        private void updateValue()
        {
            CookieValue = CookiePrice * CookieCount;
        }

        // Initializer requires values because it would be bad if any of them were null
        public CookieData(String name, Decimal price, int inventoryCount)
        {
            CookieName = name;
            CookiePrice = price;
            CookieCount = inventoryCount;
        }
    }
}
