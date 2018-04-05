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
    public partial class signUpForm : Form
    {
        public signUpForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// creates user account
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bttnCreateAcc_Click(object sender, EventArgs e)
        {
            String first = txtBoxFirst.Text;
            String last = txtBoxLast.Text;
            String email = txtBoxEmail.Text;
            String pass = txtBoxPass.Text;
            String street = txtBoxAddress.Text;
            String city = txtBoxCity.Text;
            String state = txtBoxState.Text;
            int zip = Convert.ToInt32(txtBoxZip.Text);
            Customer newCustomer = new Customer(first, last, email, street, city, state, zip, pass);
            newCustomer.AddToDatabase();
            MyStaticClass.customer = Customer.Get(email);
            this.Hide();
            frmHome home = new frmHome();
            home.Show();

        }
        /// <summary>
        /// leaving application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void button1_Click(object sender, EventArgs e)
        {
            //message box that prompts user about fubar sign up form 
            const string message = "Are you sure that you would like to leave the Application? Your entrys will not be saved if you exit!";
            const string caption = "Quiting Application!";
            var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
                Application.Exit();


            }
        }
        /// <summary>
        /// Displays the help screen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bttnHelp_Click(object sender, EventArgs e)
        {
            helpForm help = new helpForm();
            help.Show();
        }
        /// <summary>
        /// yeah dont delete this either made this on accident and need to find location in source code to properly remove
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtBoxFirst_TextChanged(object sender, EventArgs e)
        {

        }

        private void chkBoxPass_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBoxPass.Checked == true)
            {

                txtBoxPass.PasswordChar = '*';
                txtBoxPass.Refresh();
            }
            else
            {

                txtBoxPass.PasswordChar = '\0';
                txtBoxPass.Refresh();
            }
            txtBoxPass.Refresh();
        }

        private void signUpForm_Load(object sender, EventArgs e)
        {
            txtBoxPass.PasswordChar = '*';
        }
    }
}
