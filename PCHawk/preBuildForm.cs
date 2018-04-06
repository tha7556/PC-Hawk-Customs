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
    public partial class preBuildForm : Form
    {
        
        public preBuildForm()
        {
            InitializeComponent();
            
            List<prodDescription> pd = new List<prodDescription>();
            pd.Add(new prodDescription() { name = "Computing Needs", descrip = "Product Description" });
            pd.Add(new prodDescription() { name = "Gaming", descrip = "A Computer designed for gaming.\nThese computers" +
                " will be focused around high end performance." });
            pd.Add(new prodDescription() { name = "Home Office", descrip = "A home office computer setup. This is for those who are looking\n" +
                "for a simple home computer to use for work and casual use." });
            pd.Add(new prodDescription() { name = "Home Theatre", descrip = "A Home theatre computer setup (HTPC). This is a build\n" +
                "designed for use as an entertainment system." });
            needsBox.DataSource = pd;
            needsBox.DisplayMember = "name";

        }

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

        private void btnHelp_Click(object sender, EventArgs e)
        {
            helpForm help = new helpForm();
            help.Show();
        }

        //logout
        private void button1_Click(object sender, EventArgs e)
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

        private void needsBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            prodDescription pd1 = needsBox.SelectedItem as prodDescription;
            DescriptionBox.Text = Convert.ToString(pd1.descrip);
        }

        private void bttnHome_Click(object sender, EventArgs e)
        {
            frmHome home = new frmHome();
            home.Show();
            this.Close();
        }

        private void preBuildForm_Load(object sender, EventArgs e)
        {

        }

        private void bttnAccount_Click(object sender, EventArgs e)
        {
            accountForm account = new accountForm();
            account.Show();
            this.Close();
        }

        private void bttnCart_Click(object sender, EventArgs e)
        {
            cartForm cart = new cartForm();
            cart.Show();
            this.Close();
        }
    }
}
