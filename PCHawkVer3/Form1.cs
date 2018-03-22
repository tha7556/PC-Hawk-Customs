using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PCHawkVer3
{
    public partial class SignInForm : Form
    {
        public SignInForm()
        {
            InitializeComponent();
        }

        private void bttnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void txtBoxPass_TextChanged(object sender, EventArgs e)
        {
            if (chkBoxPass.Checked == true)
            {
                txtBoxPass.Refresh();
                txtBoxPass.PasswordChar = '*';
            }
            else
            {
                txtBoxPass.Refresh();
                txtBoxPass.PasswordChar = '\0';
            }
            //txtBoxPassword.PasswordChar = '*';
        }

        private void chkBoxPass_CheckedChanged(object sender, EventArgs e)
        {
            txtBoxPass.Refresh();
        }

        private void bttnLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmHome home = new frmHome();
            home.Show();
        }

        private void bttnSignUp_Click(object sender, EventArgs e)
        {
            this.Hide();
            signUpForm signUp = new signUpForm();
            signUp.Show();
        }

        private void bttnHelp_Click(object sender, EventArgs e)
        {
            helpForm help = new helpForm();
            help.Show();
        }
    }
 }
