using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PCHawk
{
    public partial class cartForm : Form
    {
        public cartForm()
        {
            //intialization of the form
            InitializeComponent();
        }
        /*
         * Function: Allows the user to exit the application. Will prompt user before proceding.
         *           Application will exit and shut down when exit messege is accepted.
         */
        private void bttnExit_Click(object sender, EventArgs e)
        {
            const string message = "Are you sure that you would like to leave the Application?";
            const string caption = "Quiting Application!";
            var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Hide();
                Application.Exit();
            }
        }
        /*
         * Function: Allow user to logout of the application. Will prompt user before proceding.
         *           Upon user logout, application will return to the login page.
         */
        private void bttnLogout_Click(object sender, EventArgs e)
        {
            const string message = "Are you sure that you would like to logout?";
            const string caption = "Logging Out!";
            var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
                SignInForm signIn = new SignInForm();
                signIn.Show();
            }
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            helpForm help = new helpForm();
            help.Show();
        }
        /*
         * Function: Takes user to their account page
         */
        private void bttnAccount_Click(object sender, EventArgs e)
        {
            accountForm account = new accountForm();
            account.Show();
            this.Close();
        }
        /*
         * Function: Returns the user to the home page of the application
         */
        private void bttnHome_Click(object sender, EventArgs e)
        {
            frmHome home = new frmHome();
            home.Show();
            this.Close();
        }
        /*
         *Function: allow user to continue shooping/browse app after viewing their cart 
         */
        private void bttnContinue_Click(object sender, EventArgs e)
        {
            //returns user to home page. how to return to pre-build or free build???????
            frmHome home = new frmHome();
            home.Show();
            this.Close();

        }
        /*
         * Function: clears users cart when selected. Will prompt user if they wish to procede.
         * 
        */
        private void bttnClear_Click(object sender, EventArgs e)
        {
            const string message = "Are you sure you want to empty your cart?";
            const string caption = "Empty Cart!";
            var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                
            }
        }
        /// <summary>
        /// brings user to checkout page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bttnCheckOut_Click(object sender, EventArgs e)
        {
            checkOutForm checkOut = new checkOutForm();
            checkOut.Show();
            this.Close();
        }
    }
}
