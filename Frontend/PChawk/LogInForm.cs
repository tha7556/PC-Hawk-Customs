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
    public partial class LogInForm : Form
    {
        public LogInForm()
        {
            InitializeComponent();
        }

        private void bttnCA_Click(object sender, EventArgs e)
        {
            this.Hide();

            this.txtBoxEmail.ResetText(); txtBoxEmail.Text = "Email";
            this.txtBoxPassword.ResetText(); txtBoxPassword.Text = "Password";

            signUpForm signUp = new signUpForm();
            signUp.Show();
        }

        private void bttnHomeli_Click(object sender, EventArgs e)
        {
            this.Hide();
            
            this.txtBoxEmail.ResetText(); txtBoxEmail.Text = "Email";
            this.txtBoxPassword.ResetText(); txtBoxPassword.Text = "Password";
        }

        private void bttnHelpli_Click(object sender, EventArgs e)
        {
            help helpForm = new help();
            helpForm.Show();
        }
    }
}
