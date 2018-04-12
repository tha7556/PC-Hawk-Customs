namespace PCHawk
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
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxTotal = new System.Windows.Forms.TextBox();
            this.searchTxtBox = new System.Windows.Forms.TextBox();
            this.searchResultTxtBox = new System.Windows.Forms.RichTextBox();
            this.labelS = new System.Windows.Forms.Label();
            this.priceSortchk = new System.Windows.Forms.CheckBox();
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
            this.bttnHome.Image = global::PCHawk.Properties.Resources.home__1_;
            this.bttnHome.Location = new System.Drawing.Point(791, 106);
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
            this.bttnAccount.Image = global::PCHawk.Properties.Resources.user;
            this.bttnAccount.Location = new System.Drawing.Point(902, 106);
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
            this.bttnLogout.Image = global::PCHawk.Properties.Resources.exit;
            this.bttnLogout.Location = new System.Drawing.Point(999, 106);
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
            this.bttnExit.Image = global::PCHawk.Properties.Resources.power_button__2_;
            this.bttnExit.Location = new System.Drawing.Point(999, 15);
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
            this.bttnCart.Image = global::PCHawk.Properties.Resources.shopping_cart__2_;
            this.bttnCart.Location = new System.Drawing.Point(897, 15);
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
            this.btnHelp.Image = global::PCHawk.Properties.Resources.info;
            this.btnHelp.Location = new System.Drawing.Point(782, 15);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(76, 66);
            this.btnHelp.TabIndex = 3;
            this.toolTipHelp.SetToolTip(this.btnHelp, "Help");
            this.btnHelp.UseVisualStyleBackColor = false;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PCHawk.Properties.Resources.banner;
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
            this.panel2.Size = new System.Drawing.Size(1083, 20);
            this.panel2.TabIndex = 1;
            // 
            // partDescriptionBox
            // 
            this.partDescriptionBox.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.partDescriptionBox.Location = new System.Drawing.Point(12, 289);
            this.partDescriptionBox.Name = "partDescriptionBox";
            this.partDescriptionBox.Size = new System.Drawing.Size(370, 250);
            this.partDescriptionBox.TabIndex = 6;
            this.partDescriptionBox.Text = "Part Description";
            // 
            // partBox
            // 
            this.partBox.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.partBox.FormattingEnabled = true;
            this.partBox.Location = new System.Drawing.Point(12, 255);
            this.partBox.Name = "partBox";
            this.partBox.Size = new System.Drawing.Size(368, 28);
            this.partBox.TabIndex = 7;
            this.partBox.Text = "Part";
            this.partBox.SelectedIndexChanged += new System.EventHandler(this.partBox_SelectedIndexChanged);
            // 
            // partTypeBox
            // 
            this.partTypeBox.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.partTypeBox.FormattingEnabled = true;
            this.partTypeBox.Items.AddRange(new object[] {
            "CPU",
            "Case",
            "Cooling",
            "Graphics Card",
            "Power Supply",
            "Motherboard",
            "Memory",
            "Storage"});
            this.partTypeBox.Location = new System.Drawing.Point(12, 221);
            this.partTypeBox.Name = "partTypeBox";
            this.partTypeBox.Size = new System.Drawing.Size(160, 28);
            this.partTypeBox.TabIndex = 8;
            this.partTypeBox.Text = "Part Type";
            this.partTypeBox.SelectedIndexChanged += new System.EventHandler(this.partTypeBox_SelectedIndexChanged);
            // 
            // bttnAddPart
            // 
            this.bttnAddPart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnAddPart.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnAddPart.ForeColor = System.Drawing.Color.White;
            this.bttnAddPart.Location = new System.Drawing.Point(181, 544);
            this.bttnAddPart.Name = "bttnAddPart";
            this.bttnAddPart.Size = new System.Drawing.Size(202, 44);
            this.bttnAddPart.TabIndex = 9;
            this.bttnAddPart.Text = "Add To Build";
            this.bttnAddPart.UseVisualStyleBackColor = true;
            this.bttnAddPart.Click += new System.EventHandler(this.bttnAddPart_Click);
            // 
            // priceTxtBox
            // 
            this.priceTxtBox.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceTxtBox.Location = new System.Drawing.Point(15, 562);
            this.priceTxtBox.Name = "priceTxtBox";
            this.priceTxtBox.ReadOnly = true;
            this.priceTxtBox.Size = new System.Drawing.Size(160, 26);
            this.priceTxtBox.TabIndex = 10;
            // 
            // buildNameBox
            // 
            this.buildNameBox.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buildNameBox.Location = new System.Drawing.Point(698, 221);
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
            this.buildListBox.Location = new System.Drawing.Point(698, 255);
            this.buildListBox.Name = "buildListBox";
            this.buildListBox.Size = new System.Drawing.Size(370, 284);
            this.buildListBox.TabIndex = 12;
            // 
            // bttnAddCart
            // 
            this.bttnAddCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnAddCart.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnAddCart.ForeColor = System.Drawing.Color.Yellow;
            this.bttnAddCart.Location = new System.Drawing.Point(864, 544);
            this.bttnAddCart.Name = "bttnAddCart";
            this.bttnAddCart.Size = new System.Drawing.Size(204, 44);
            this.bttnAddCart.TabIndex = 13;
            this.bttnAddCart.Text = "Add To Cart";
            this.bttnAddCart.UseVisualStyleBackColor = true;
            this.bttnAddCart.Click += new System.EventHandler(this.bttnAddCart_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Yellow;
            this.label6.Location = new System.Drawing.Point(12, 541);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 18);
            this.label6.TabIndex = 18;
            this.label6.Text = "Price:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(685, 541);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 18);
            this.label1.TabIndex = 19;
            this.label1.Text = "Total Price:";
            // 
            // txtBoxTotal
            // 
            this.txtBoxTotal.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxTotal.Location = new System.Drawing.Point(698, 562);
            this.txtBoxTotal.Name = "txtBoxTotal";
            this.txtBoxTotal.ReadOnly = true;
            this.txtBoxTotal.Size = new System.Drawing.Size(160, 26);
            this.txtBoxTotal.TabIndex = 20;
            // 
            // searchTxtBox
            // 
            this.searchTxtBox.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchTxtBox.Location = new System.Drawing.Point(394, 257);
            this.searchTxtBox.Name = "searchTxtBox";
            this.searchTxtBox.Size = new System.Drawing.Size(269, 26);
            this.searchTxtBox.TabIndex = 21;
            this.searchTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // searchResultTxtBox
            // 
            this.searchResultTxtBox.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchResultTxtBox.Location = new System.Drawing.Point(394, 289);
            this.searchResultTxtBox.Name = "searchResultTxtBox";
            this.searchResultTxtBox.Size = new System.Drawing.Size(269, 250);
            this.searchResultTxtBox.TabIndex = 22;
            this.searchResultTxtBox.Text = "Part Description";
            // 
            // labelS
            // 
            this.labelS.AutoSize = true;
            this.labelS.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelS.ForeColor = System.Drawing.Color.White;
            this.labelS.Location = new System.Drawing.Point(390, 235);
            this.labelS.Name = "labelS";
            this.labelS.Size = new System.Drawing.Size(135, 19);
            this.labelS.TabIndex = 23;
            this.labelS.Text = "Manual Search: ";
            // 
            // priceSortchk
            // 
            this.priceSortchk.AutoSize = true;
            this.priceSortchk.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceSortchk.ForeColor = System.Drawing.Color.White;
            this.priceSortchk.Location = new System.Drawing.Point(181, 224);
            this.priceSortchk.Name = "priceSortchk";
            this.priceSortchk.Size = new System.Drawing.Size(117, 24);
            this.priceSortchk.TabIndex = 24;
            this.priceSortchk.Text = "Sort By Price";
            this.priceSortchk.UseVisualStyleBackColor = true;
            // 
            // freeBuildForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1080, 622);
            this.Controls.Add(this.priceSortchk);
            this.Controls.Add(this.labelS);
            this.Controls.Add(this.searchResultTxtBox);
            this.Controls.Add(this.searchTxtBox);
            this.Controls.Add(this.txtBoxTotal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
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
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoxTotal;
        private System.Windows.Forms.TextBox searchTxtBox;
        private System.Windows.Forms.RichTextBox searchResultTxtBox;
        private System.Windows.Forms.Label labelS;
        private System.Windows.Forms.CheckBox priceSortchk;
    }
}