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

    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();
        }
        /// <summary>
        /// takes user to the free build page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bttnFreeBuild_Click(object sender, EventArgs e)
        {
            freeBuildForm free = new freeBuildForm();
            free.Show();
            this.Close();
        }
        /// <summary>
        /// exits the application
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
        /// logs user out of the applicatiion
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            const string message = "Are you sure that you would like to logout?";
            const string caption = "Logging Out!";
            var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Hide();
                SignInForm signIn = new SignInForm();
                signIn.Show();
                this.Close();
            }
        }
        /// <summary>
        /// shows help menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnHelp_Click(object sender, EventArgs e)
        {
            helpForm help = new helpForm();
            help.Show();
        }
        /// <summary>
        /// takes user to the preBuild page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bttnPreBuild_Click(object sender, EventArgs e)
        {
            preBuildForm prebuild = new preBuildForm();
            prebuild.Show();
            this.Close();

        }
        /// <summary>
        /// view user account
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
        /// view user cart
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bttnCart_Click(object sender, EventArgs e)
        {
            cartForm cart = new cartForm();
            cart.Show();
            this.Close();
        }
    }
}
