using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PrimaryQueries;

namespace PCHawkVer3
{
    public partial class freeBuildForm : Form
    {
        public freeBuildForm()
        {
            InitializeComponent();
            
        }
        /// <summary>
        /// allows user to view their cart
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bttnCart_Click(object sender, EventArgs e)
        {
            cartForm cart = new cartForm();
            cart.Show();
            this.Close();
        }
        /// <summary>
        /// allows user to exit the application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        /// <summary>
        /// allws user to view the help form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnHelp_Click(object sender, EventArgs e)
        {
            helpForm help = new helpForm();
            help.Show();
        }
        /// <summary>
        /// allows user to logout of the application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bttnLogout_Click(object sender, EventArgs e)
        {
            const string message = "Are you sure that you would like to logout?";
            const string caption = "Logging Out!";
            var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes) { 
                this.Close();
                SignInForm signIn = new SignInForm();
                signIn.Show();
            }
        }
        /// <summary>
        /// brings user to the home page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bttnHome_Click(object sender, EventArgs e)
        {
            frmHome home = new frmHome();
            home.Show();
            this.Close();
        }
        /// <summary>
        /// brings user to their account page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bttnAccount_Click(object sender, EventArgs e)
        {
            accountForm account = new accountForm();
            account.Show();
            this.Close();
        }
        /// <summary>
        /// adds selected part to the current build
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bttnAddPart_Click(object sender, EventArgs e)
        {
            //How we do dis

        }
        /// <summary>
        /// adds build to users cart
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bttnAddCart_Click(object sender, EventArgs e)
        {
            //also how we do dis
        }

        private void partTypeBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Queries.Log(Queries.LogLevel.DEBUG, "help");
            String test = partTypeBox.SelectedText;
            if (test == "CPU")
            {
                 

            }
        }
    }
}
