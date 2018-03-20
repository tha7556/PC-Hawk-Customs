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
    public partial class signUpForm : Form
    {
        public signUpForm()
        {
            InitializeComponent();
        }

        
        private void bttnHome_Click(object sender, EventArgs e)
        {
            //message box that prompts user about fubar sign up form 
            const string message = "Are you sure that you would like to leave the form? Your entrys will nto be save if you exit!";
            const string caption = "Leaving Form!";
            var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(result == DialogResult.Yes)
            {
                this.Hide();
                this.txtBoxFirstName.ResetText(); txtBoxFirstName.Text = "First Name";
                this.txtBoxLastName.ResetText(); txtBoxLastName.Text = "Last Name";
                this.txtBoxEmail.ResetText(); txtBoxEmail.Text = "Email";
                this.txtBoxPassword.ResetText(); txtBoxPassword.Text = "Password";
                

            }
            
            

            
       
        }

        private void bttnCreate_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.txtBoxFirstName.ResetText(); txtBoxFirstName.Text = "First Name";
            this.txtBoxLastName.ResetText(); txtBoxLastName.Text = "Last Name";
            this.txtBoxEmail.ResetText(); txtBoxEmail.Text = "Email";
            this.txtBoxPassword.ResetText(); txtBoxPassword.Text = "Password";
        }

        private void bttnCart_Click(object sender, EventArgs e)
        {
            const string message = "Are you sure that you would like to leave the form? Your entrys will nto be save if you exit!";
            const string caption = "Leaving Form!";
            var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Hide();
                this.txtBoxFirstName.ResetText(); txtBoxFirstName.Text = "First Name";
                this.txtBoxLastName.ResetText(); txtBoxLastName.Text = "Last Name";
                this.txtBoxEmail.ResetText(); txtBoxEmail.Text = "Email";
                this.txtBoxPassword.ResetText(); txtBoxPassword.Text = "Password";

            }

        }

        private void bttnHelp_Click(object sender, EventArgs e)
        {
            //opens up help form. help form will be small FAQ that will not close/hide current active form
            help helpForm = new help();
            helpForm.Show();
        }
    }
}
