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
        /// occurs when user cancles password change
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bttnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// hide/shows password
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
        /// <summary>
        /// hides/shows password
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        /// <summary>
        /// actions to occur when user clicks confirm
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        /// <summary>
        /// hides password char's on load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void changePasswordForm_Load(object sender, EventArgs e)
        {
            passTxtBox.PasswordChar = '*';
            passwordVerifyTxt.PasswordChar = '*';
        }
    }
}
