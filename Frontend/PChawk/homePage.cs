using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PChawk
{
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();
        }

        private void txtBoxHome_TextChanged(object sender, EventArgs e)
        {

        }

        LogInForm logIn = new LogInForm();
        private void bttnLogin_Click(object sender, EventArgs e)
        {
            logIn.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        freeBuildPage buildPage = new freeBuildPage();
        private void bttnFree_Click(object sender, EventArgs e) =>
            //freeBuildPage newMDIChild = new freeBuildPage();
            // Set the Parent Form of the Child window.  
            //newMDIChild.MdiParent = this;
            // Display the new form.  
            //newMDIChild.Show(); 
            buildPage.Show();
        signUpForm signUp = new signUpForm();
        private void bttnSign_Click(object sender, EventArgs e)
        {
            
            signUp.Show();
           
        }

        private void bttnHelp_Click(object sender, EventArgs e)
        {
            help helpForm = new help();
            helpForm.Show();
        }
    }
}
