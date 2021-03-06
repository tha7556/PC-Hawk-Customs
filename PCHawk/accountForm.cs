﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PrimaryQueries;

namespace PCHawk
{
    /// <summary>
    /// the login form class
    /// </summary>
    public partial class accountForm : Form
    {
        Order[] orders = MyStaticClass.customer.GetOrders();
        List<string> orderNames = new List<string>();

        /// <summary>
        /// initialization of form
        /// </summary>
        public accountForm()
        {
            InitializeComponent();
            //setting account
            txtBoxEmail.Text = MyStaticClass.customer.email;
            txtBoxFirst.Text = MyStaticClass.customer.firstName;
            txtBoxLast.Text = MyStaticClass.customer.lastName;
            txtBoxAddress.Text = MyStaticClass.customer.streetAddress;
            txtBoxCity.Text = MyStaticClass.customer.city;
            txtBoxState.Text = MyStaticClass.customer.state;
            txtBoxZip.Text = MyStaticClass.customer.zipcode.ToString();
            if(orders.Length != 0)
            {
                for (int i = 0; i < orders.Length; i++)
                {
                    string o = orders[i].ToString();
                    orderNames.Add(o);
                }
                historyBox.DataSource = orderNames;
            }

        }
        /// <summary>
        /// Allows user to exit the application
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
        /// Allows user to return to the home page
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
        /// Allows user to logout of the application. Returns user to login page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        /// <summary>
        /// Displays the help screen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnHelp_Click(object sender, EventArgs e)
        {
            helpForm help = new helpForm();
            help.Show();
        }
        /// <summary>
        /// Actions that occur when the form loads. sets all text fields to read only.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void accountForm_Load(object sender, EventArgs e)
        {
            txtBoxFirst.ReadOnly = true;
            txtBoxLast.ReadOnly = true;
            txtBoxEmail.ReadOnly = true;
            txtBoxAddress.ReadOnly = true;
            txtBoxCity.ReadOnly = true;
            txtBoxState.ReadOnly = true;
            txtBoxZip.ReadOnly = true;
        }
        /// <summary>
        /// Allows user to change their info, sets all text fields to !readonly 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bttnChangeInfo_Click(object sender, EventArgs e)
        {
            txtBoxFirst.ReadOnly = false;
            txtBoxLast.ReadOnly = false;
            txtBoxEmail.ReadOnly = false;
            txtBoxAddress.ReadOnly = false;
            txtBoxCity.ReadOnly = false;
            txtBoxState.ReadOnly = false;
            txtBoxZip.ReadOnly = false;
            bttnSave.Enabled = true;
            
            

        }
        /// <summary>
        /// saves changes use makes to their info, sets all text fields to read only
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bttnSave_Click(object sender, EventArgs e)
        {
            const string message = "Are you sure that you want to save these changes?";
            const string caption = "Changing Info!";
            var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                txtBoxFirst.ReadOnly = true; MyStaticClass.customer.ChangeName(txtBoxFirst.Text, txtBoxLast.Text);
                txtBoxLast.ReadOnly = true; 
                txtBoxEmail.ReadOnly = true; MyStaticClass.customer.ChangeEmail(txtBoxEmail.Text);
                txtBoxAddress.ReadOnly = true; String street = txtBoxAddress.Text;
                txtBoxCity.ReadOnly = true; String city = txtBoxCity.Text;
                txtBoxState.ReadOnly = true; String State = txtBoxState.Text;
                bttnSave.Enabled = false; 
                txtBoxZip.ReadOnly = true; int value = Convert.ToInt32(txtBoxZip.Text);
                MyStaticClass.customer.ChangeAddress(street, city, State, value);

            }
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
        /// another fubar function lol
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtBoxZip_TextChanged(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bttnPassChange_Click(object sender, EventArgs e)
        {
            changePasswordForm change = new changePasswordForm();
            change.Show();
        }
    }
}
