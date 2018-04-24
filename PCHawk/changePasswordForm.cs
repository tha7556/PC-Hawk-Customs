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
    /// <summary>
    /// 
    /// </summary>
    public partial class changePasswordForm : Form
    {
        /// <summary>
        /// 
        /// </summary>
        public changePasswordForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bttnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void passShowChkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (passShowChkBox.Checked == true)
            {

                passTxtBox.PasswordChar = '*';
                passTxtBox.Refresh();
            }
            else
            {

                passTxtBox.PasswordChar = '\0';
                passTxtBox.Refresh();
            }
            passTxtBox.Refresh();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked == true)
            {
                
                passwordVerifyTxt.PasswordChar = '*';
                passwordVerifyTxt.Refresh();
            }
            else
            {
               
                passwordVerifyTxt.PasswordChar = '\0';
                passwordVerifyTxt.Refresh();
            }
            passwordVerifyTxt.Refresh();
        }

        private void bttnConfirm_Click(object sender, EventArgs e)
        {
            string a = passTxtBox.Text;
            string b = passwordVerifyTxt.Text;
            if(a.Equals(b))
            {
                MyStaticClass.customer.ChangePassword(a);
                const string message = "Password Change Successful!";
                const string caption = "!";
                var result = MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                if(result == DialogResult.OK)
                {
                    this.Close();
                }
            }
            else
            {
                const string message = "Passwords do not match!";
                const string caption = "Error Error Error!";
                var result = MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
