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
            string[] result = Queries.Query("SELECT m.email , e.email, m.state FROM customer e JOIN customer m ON m.state = e.state AND NOT e.email = m.email AND m.email < e.email ORDER BY m.state");
            displayBox.DataSource = result;
        }


        private void bttnTwoTable_Click(object sender, EventArgs e) {
            string[] result = Queries.Query("call twoTable()");
        }

        private void bttnThreeTable_Click(object sender, EventArgs e) {
            string[] result = Queries.Query("call threeTable()");
            for (int i = 0; i < result.Length; i++) {
                string temp = "";
                foreach (string s in result[i].Split('\0'))
                    temp += s + " ";
                result[i] = temp;
            }
            displayBox.DataSource = result;
        }

        private void partBox_SelectedIndexChanged(object sender, EventArgs e) {
            string[] tables = new string[] {"cpu","`pc case`","fan","graphicscard","powersupply","motherboard","memory","storage" };
            int index = partBox.SelectedIndex;
            string[] result = Queries.Query("SELECT AVG(price) FROM "+tables[index]);
            result[0] = result[0].Split('\0')[0];
            displayBox.DataSource = result;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) {
            int index = comboBox1.SelectedIndex;
            string[] parts = new string[] { "cpu", "pcCase", "fan", "graphicsCard", "powerSupply", "motherboard", "memory", "storage" };
            string[] result = Order.DuplicateFinder(parts[index]);
            for(int i = 0; i < result.Length; i++) {
                string temp = "";
                foreach (string s in result[i].Split('\0'))
                    temp += s + " ";
                result[i] = temp;
            }
            displayBox.DataSource = result;
        }
    }
}
