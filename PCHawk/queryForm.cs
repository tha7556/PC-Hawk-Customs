using PrimaryQueries;
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
    public partial class queryForm : Form
    {
        /// <summary>
        /// 
        /// </summary>
        public queryForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bttnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e) {
            string[] result = Queries.Query("SELECT DISTINCT m.email , e.email, m.state FROM customer e JOIN customer m ON m.state = e.state AND NOT e.email = m.email AND m.email < e.email ORDER BY m.state");           
                for (int i = 0; i < result.Length; i++) {
                    string temp = "";
                    foreach (string s in result[i].Split('\0'))
                        temp += s + " ";
                    result[i] = temp;

                }
                displayBox.DataSource = result;
        }


        private void bttnTwoTable_Click(object sender, EventArgs e) {
            string[] result = Queries.Query("call twoTable()");
            for (int i = 0; i < result.Length; i++) {
                string temp = "";
                foreach (string s in result[i].Split('\0'))
                    temp += s + " ";
                result[i] = temp;

            }
            displayBox.DataSource = result;
        }

        private void bttnThreeTable_Click(object sender, EventArgs e) {
            string[] result = Queries.Query("call threeTable()");

        }

        private void partBox_SelectedIndexChanged(object sender, EventArgs e) {
            int index = partBox.SelectedIndex;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) {
            int index = comboBox1.SelectedIndex;
        }
    }
}
