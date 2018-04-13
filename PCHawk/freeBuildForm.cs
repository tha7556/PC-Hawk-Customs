using System;
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
    public partial class freeBuildForm : Form
    {
        public freeBuildForm()
        {
            InitializeComponent();
            
        }
        /// <summary>
        /// allows user to view their cart
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bttnCart_Click(object sender, EventArgs e)
        {
            Queries.Log(Queries.LogLevel.DEBUG, "Cart Button clicked");
            cartForm cart = new cartForm();
            cart.Show();
            this.Close();
        }
        /// <summary>
        /// allows user to exit the application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bttnExit_Click(object sender, EventArgs e)
        {
            Queries.Log(Queries.LogLevel.DEBUG, "Exit Button clicked");
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
        /// allws user to view the help form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnHelp_Click(object sender, EventArgs e)
        {
            Queries.Log(Queries.LogLevel.DEBUG, "Help Button clicked");
            helpForm help = new helpForm();
            help.Show();
        }
        /// <summary>
        /// allows user to logout of the application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bttnLogout_Click(object sender, EventArgs e)
        {
            Queries.Log(Queries.LogLevel.DEBUG, "Logout Button clicked");
            const string message = "Are you sure that you would like to logout?";
            const string caption = "Logging Out!";
            var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes) { 
                this.Close();
                SignInForm signIn = new SignInForm();
                signIn.Show();
            }
        }
        /// <summary>
        /// brings user to the home page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bttnHome_Click(object sender, EventArgs e)
        {
            Queries.Log(Queries.LogLevel.DEBUG, "Home Button clicked");
            frmHome home = new frmHome();
            home.Show();
            this.Close();
        }
        /// <summary>
        /// brings user to their account page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bttnAccount_Click(object sender, EventArgs e)
        {
            Queries.Log(Queries.LogLevel.DEBUG, "Account Button clicked");
            accountForm account = new accountForm();
            account.Show();
            this.Close();
        }
        /// <summary>
        /// adds selected part to the current build
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bttnAddPart_Click(object sender, EventArgs e)
        {
            if (MyStaticClass.computer == null)
                MyStaticClass.computer = new Computer();
            MyStaticClass.computer.AddPart((Part)partBox.SelectedItem);
            Queries.Log(Queries.LogLevel.DEBUG, "Adding: "+partBox.SelectedItem.GetType().Name + " to build");
            buildListBox.DataSource = MyStaticClass.computer.GetAttributes();
            txtBoxTotal.Text = "$"+MyStaticClass.computer.price;

        }
        /// <summary>
        /// adds build to users cart
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bttnAddCart_Click(object sender, EventArgs e)
        {
            Queries.Log(Queries.LogLevel.DEBUG, "Add to Cart Button clicked");
            //also how we do dis
        }
        /// <summary>
        /// action that occurs when the user chooses a part type. will set the collection/datasource of the part dropdown menu to those that match
        /// the users selection. will also populate the description box.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void partTypeBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            String test = partTypeBox.SelectedItem.ToString();
            Queries.Log(Queries.LogLevel.DEBUG, "Selected : " + test);
            string attribs = "";
            if (test == "CPU")
            {
                partBox.DataSource = CPU.GetAll();
                attribs = ((CPU)partBox.SelectedItem).GetAttributes();

            }else if(test == "Cooling")
            {
                partBox.DataSource = Fan.GetAll();
                attribs = ((Fan)partBox.SelectedItem).GetAttributes();
            }
            else if (test == "Case")
            {
                partBox.DataSource = Case.GetAll();
                attribs = ((Case)partBox.SelectedItem).GetAttributes();
            }
            else if (test == "Memory")
            {
                partBox.DataSource = Memory.GetAll();
                attribs = ((Memory)partBox.SelectedItem).GetAttributes();
            }
            else if (test == "Power Supply")
            {
                partBox.DataSource = PowerSupply.GetAll();
                attribs = ((PowerSupply)partBox.SelectedItem).GetAttributes();
            }
            else if (test == "Storage")
            {
                partBox.DataSource = Storage.GetAll();
                attribs = ((Storage)partBox.SelectedItem).GetAttributes();
            }
            else if (test == "Graphics Card")
            {
                partBox.DataSource = GraphicsCard.GetAll();
                attribs = ((GraphicsCard)partBox.SelectedItem).GetAttributes();
            }
            else if (test == "Motherboard")
            {
                partBox.DataSource = MOBO.GetAll();
                attribs = ((MOBO)partBox.SelectedItem).GetAttributes();
            }
            partDescriptionBox.Text = attribs;
            priceTxtBox.Text = "$" + ((Part)partBox.SelectedItem).price;

        }
        /// <summary>
        /// Change that occurs when the user selects a part. When a part is selected its attributes are selected and used to populate the 
        /// description box and price box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void partBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            String test = partTypeBox.SelectedItem.ToString();
            Queries.Log(Queries.LogLevel.DEBUG, "Selected "+test+": " + ((Part)partBox.SelectedItem));
            string attribs = "";
            if (test == "CPU")
            {
                
                attribs = ((CPU)partBox.SelectedItem).GetAttributes();

            }
            else if (test == "Cooling")
            {
                
                attribs = ((Fan)partBox.SelectedItem).GetAttributes();
            }
            else if (test == "Case")
            {
                
                attribs = ((Case)partBox.SelectedItem).GetAttributes();
            }
            else if (test == "Memory")
            {
                
                attribs = ((Memory)partBox.SelectedItem).GetAttributes();
            }
            else if (test == "Power Supply")
            {
                
                attribs = ((PowerSupply)partBox.SelectedItem).GetAttributes();
            }
            else if (test == "Storage")
            {
                
                attribs = ((Storage)partBox.SelectedItem).GetAttributes();
            }
            else if (test == "Graphics Card")
            {
                
                attribs = ((GraphicsCard)partBox.SelectedItem).GetAttributes();
            }
            else if (test == "Motherboard")
            {
                
                attribs = ((MOBO)partBox.SelectedItem).GetAttributes();
            }
            partDescriptionBox.Text = attribs;
            priceTxtBox.Text = "$"+((Part)partBox.SelectedItem).price.ToString();
        }
        /// <summary>
        /// When clicked searches for all occurences of the string in the manual search text box and populates parts in a corresponding list box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void searchBoxbttn_Click(object sender, EventArgs e)
        {
            String userSearch = searchTxtBox.Text;
            List<Part> results = Part.Search(userSearch);
           
            searchResultsBox.DataSource = results;
            
        }
    }
}
