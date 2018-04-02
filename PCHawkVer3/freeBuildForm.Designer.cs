namespace PCHawkVer3
{
    partial class freeBuildForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bttnHome = new System.Windows.Forms.Button();
            this.bttnAccount = new System.Windows.Forms.Button();
            this.bttnLogout = new System.Windows.Forms.Button();
            this.bttnExit = new System.Windows.Forms.Button();
            this.bttnCart = new System.Windows.Forms.Button();
            this.btnHelp = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.partDescriptionBox = new System.Windows.Forms.RichTextBox();
            this.partBox = new System.Windows.Forms.ComboBox();
            this.partTypeBox = new System.Windows.Forms.ComboBox();
            this.bttnAddPart = new System.Windows.Forms.Button();
            this.priceTxtBox = new System.Windows.Forms.TextBox();
            this.buildNameBox = new System.Windows.Forms.TextBox();
            this.buildListBox = new System.Windows.Forms.ListBox();
            this.bttnAddCart = new System.Windows.Forms.Button();
            this.toolTipHelp = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipCart = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipExit = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipHome = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipAccount = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipLogOut = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.bttnHome);
            this.panel1.Controls.Add(this.bttnAccount);
            this.panel1.Controls.Add(this.bttnLogout);
            this.panel1.Controls.Add(this.bttnExit);
            this.panel1.Controls.Add(this.bttnCart);
            this.panel1.Controls.Add(this.btnHelp);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1152, 192);
            this.panel1.TabIndex = 0;
            // 
            // bttnHome
            // 
            this.bttnHome.BackColor = System.Drawing.Color.Black;
            this.bttnHome.FlatAppearance.BorderSize = 0;
            this.bttnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnHome.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnHome.ForeColor = System.Drawing.Color.White;
            this.bttnHome.Image = global::PCHawkVer3.Properties.Resources.home__1_;
            this.bttnHome.Location = new System.Drawing.Point(610, 106);
            this.bttnHome.Name = "bttnHome";
            this.bttnHome.Size = new System.Drawing.Size(67, 66);
            this.bttnHome.TabIndex = 8;
            this.toolTipHome.SetToolTip(this.bttnHome, "Home");
            this.bttnHome.UseVisualStyleBackColor = false;
            this.bttnHome.Click += new System.EventHandler(this.bttnHome_Click);
            // 
            // bttnAccount
            // 
            this.bttnAccount.BackColor = System.Drawing.Color.Black;
            this.bttnAccount.FlatAppearance.BorderSize = 0;
            this.bttnAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnAccount.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnAccount.ForeColor = System.Drawing.Color.White;
            this.bttnAccount.Image = global::PCHawkVer3.Properties.Resources.user;
            this.bttnAccount.Location = new System.Drawing.Point(707, 106);
            this.bttnAccount.Name = "bttnAccount";
            this.bttnAccount.Size = new System.Drawing.Size(65, 66);
            this.bttnAccount.TabIndex = 7;
            this.toolTipAccount.SetToolTip(this.bttnAccount, "View Account");
            this.bttnAccount.UseVisualStyleBackColor = false;
            this.bttnAccount.Click += new System.EventHandler(this.bttnAccount_Click);
            // 
            // bttnLogout
            // 
            this.bttnLogout.BackColor = System.Drawing.Color.Black;
            this.bttnLogout.FlatAppearance.BorderSize = 0;
            this.bttnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnLogout.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnLogout.ForeColor = System.Drawing.Color.White;
            this.bttnLogout.Image = global::PCHawkVer3.Properties.Resources.exit;
            this.bttnLogout.Location = new System.Drawing.Point(799, 106);
            this.bttnLogout.Name = "bttnLogout";
            this.bttnLogout.Size = new System.Drawing.Size(69, 66);
            this.bttnLogout.TabIndex = 6;
            this.toolTipLogOut.SetToolTip(this.bttnLogout, "Log Out");
            this.bttnLogout.UseVisualStyleBackColor = false;
            this.bttnLogout.Click += new System.EventHandler(this.bttnLogout_Click);
            // 
            // bttnExit
            // 
            this.bttnExit.BackColor = System.Drawing.Color.Black;
            this.bttnExit.FlatAppearance.BorderSize = 0;
            this.bttnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnExit.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnExit.ForeColor = System.Drawing.Color.White;
            this.bttnExit.Image = global::PCHawkVer3.Properties.Resources.power_button__2_;
            this.bttnExit.Location = new System.Drawing.Point(799, 15);
            this.bttnExit.Name = "bttnExit";
            this.bttnExit.Size = new System.Drawing.Size(69, 66);
            this.bttnExit.TabIndex = 5;
            this.toolTipExit.SetToolTip(this.bttnExit, "Exit Application");
            this.bttnExit.UseVisualStyleBackColor = false;
            this.bttnExit.Click += new System.EventHandler(this.bttnExit_Click);
            // 
            // bttnCart
            // 
            this.bttnCart.BackColor = System.Drawing.Color.Black;
            this.bttnCart.FlatAppearance.BorderSize = 0;
            this.bttnCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnCart.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnCart.ForeColor = System.Drawing.Color.White;
            this.bttnCart.Image = global::PCHawkVer3.Properties.Resources.shopping_cart__2_;
            this.bttnCart.Location = new System.Drawing.Point(702, 15);
            this.bttnCart.Name = "bttnCart";
            this.bttnCart.Size = new System.Drawing.Size(70, 66);
            this.bttnCart.TabIndex = 4;
            this.toolTipCart.SetToolTip(this.bttnCart, "View Cart");
            this.bttnCart.UseVisualStyleBackColor = false;
            this.bttnCart.Click += new System.EventHandler(this.bttnCart_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.BackColor = System.Drawing.Color.Black;
            this.btnHelp.FlatAppearance.BorderSize = 0;
            this.btnHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHelp.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHelp.ForeColor = System.Drawing.Color.White;
            this.btnHelp.Image = global::PCHawkVer3.Properties.Resources.info;
            this.btnHelp.Location = new System.Drawing.Point(610, 15);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(76, 66);
            this.btnHelp.TabIndex = 3;
            this.toolTipHelp.SetToolTip(this.btnHelp, "Help");
            this.btnHelp.UseVisualStyleBackColor = false;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PCHawkVer3.Properties.Resources.banner;
            this.pictureBox1.Location = new System.Drawing.Point(12, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(503, 157);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Teal;
            this.panel2.Location = new System.Drawing.Point(0, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(878, 20);
            this.panel2.TabIndex = 1;
            // 
            // partDescriptionBox
            // 
            this.partDescriptionBox.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.partDescriptionBox.Location = new System.Drawing.Point(50, 289);
            this.partDescriptionBox.Name = "partDescriptionBox";
            this.partDescriptionBox.Size = new System.Drawing.Size(301, 249);
            this.partDescriptionBox.TabIndex = 6;
            this.partDescriptionBox.Text = "Part Description";
            // 
            // partBox
            // 
            this.partBox.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.partBox.FormattingEnabled = true;
            this.partBox.Items.AddRange(new object[] {
            "$0-500",
            "$500-1000",
            "$1000-1500",
            "$1500-2000",
            "$2000-Higher"});
            this.partBox.Location = new System.Drawing.Point(50, 255);
            this.partBox.Name = "partBox";
            this.partBox.Size = new System.Drawing.Size(168, 28);
            this.partBox.TabIndex = 7;
            this.partBox.Text = "Part";
            // 
            // partTypeBox
            // 
            this.partTypeBox.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.partTypeBox.FormattingEnabled = true;
            this.partTypeBox.Items.AddRange(new object[] {
            "$0-500",
            "$500-1000",
            "$1000-1500",
            "$1500-2000",
            "$2000-Higher"});
            this.partTypeBox.Location = new System.Drawing.Point(50, 221);
            this.partTypeBox.Name = "partTypeBox";
            this.partTypeBox.Size = new System.Drawing.Size(168, 28);
            this.partTypeBox.TabIndex = 8;
            this.partTypeBox.Text = "Part Type";
            // 
            // bttnAddPart
            // 
            this.bttnAddPart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnAddPart.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnAddPart.ForeColor = System.Drawing.Color.White;
            this.bttnAddPart.Location = new System.Drawing.Point(216, 544);
            this.bttnAddPart.Name = "bttnAddPart";
            this.bttnAddPart.Size = new System.Drawing.Size(135, 44);
            this.bttnAddPart.TabIndex = 9;
            this.bttnAddPart.Text = "Add To Build";
            this.bttnAddPart.UseVisualStyleBackColor = true;
            this.bttnAddPart.Click += new System.EventHandler(this.bttnAddPart_Click);
            // 
            // priceTxtBox
            // 
            this.priceTxtBox.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceTxtBox.Location = new System.Drawing.Point(50, 544);
            this.priceTxtBox.Name = "priceTxtBox";
            this.priceTxtBox.Size = new System.Drawing.Size(160, 26);
            this.priceTxtBox.TabIndex = 10;
            this.priceTxtBox.Text = "Price";
            // 
            // buildNameBox
            // 
            this.buildNameBox.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buildNameBox.Location = new System.Drawing.Point(480, 223);
            this.buildNameBox.Name = "buildNameBox";
            this.buildNameBox.Size = new System.Drawing.Size(269, 26);
            this.buildNameBox.TabIndex = 11;
            this.buildNameBox.Text = "<Build Name>";
            this.buildNameBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buildListBox
            // 
            this.buildListBox.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buildListBox.FormattingEnabled = true;
            this.buildListBox.ItemHeight = 20;
            this.buildListBox.Location = new System.Drawing.Point(480, 255);
            this.buildListBox.Name = "buildListBox";
            this.buildListBox.Size = new System.Drawing.Size(345, 284);
            this.buildListBox.TabIndex = 12;
            // 
            // bttnAddCart
            // 
            this.bttnAddCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnAddCart.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnAddCart.ForeColor = System.Drawing.Color.White;
            this.bttnAddCart.Location = new System.Drawing.Point(480, 544);
            this.bttnAddCart.Name = "bttnAddCart";
            this.bttnAddCart.Size = new System.Drawing.Size(345, 44);
            this.bttnAddCart.TabIndex = 13;
            this.bttnAddCart.Text = "Add To Cart";
            this.bttnAddCart.UseVisualStyleBackColor = true;
            this.bttnAddCart.Click += new System.EventHandler(this.bttnAddCart_Click);
            // 
            // freeBuildForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(875, 600);
            this.Controls.Add(this.bttnAddCart);
            this.Controls.Add(this.buildListBox);
            this.Controls.Add(this.buildNameBox);
            this.Controls.Add(this.priceTxtBox);
            this.Controls.Add(this.bttnAddPart);
            this.Controls.Add(this.partTypeBox);
            this.Controls.Add(this.partBox);
            this.Controls.Add(this.partDescriptionBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "freeBuildForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "freeBuildForm";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Button bttnCart;
        private System.Windows.Forms.Button bttnExit;
        private System.Windows.Forms.Button bttnLogout;
        private System.Windows.Forms.Button bttnAccount;
        private System.Windows.Forms.Button bttnHome;
        private System.Windows.Forms.RichTextBox partDescriptionBox;
        private System.Windows.Forms.ComboBox partBox;
        private System.Windows.Forms.ComboBox partTypeBox;
        private System.Windows.Forms.Button bttnAddPart;
        private System.Windows.Forms.TextBox priceTxtBox;
        private System.Windows.Forms.TextBox buildNameBox;
        private System.Windows.Forms.ListBox buildListBox;
        private System.Windows.Forms.ToolTip toolTipHome;
        private System.Windows.Forms.ToolTip toolTipAccount;
        private System.Windows.Forms.ToolTip toolTipLogOut;
        private System.Windows.Forms.ToolTip toolTipExit;
        private System.Windows.Forms.ToolTip toolTipCart;
        private System.Windows.Forms.ToolTip toolTipHelp;
        private System.Windows.Forms.Button bttnAddCart;
    }
}