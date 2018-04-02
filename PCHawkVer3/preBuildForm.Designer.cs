namespace PCHawkVer3
{
    partial class preBuildForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.btnHelp = new System.Windows.Forms.Button();
            this.bttnCart = new System.Windows.Forms.Button();
            this.bttnExit = new System.Windows.Forms.Button();
            this.bannerBox = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.needsBox = new System.Windows.Forms.ComboBox();
            this.priceRngBox = new System.Windows.Forms.ComboBox();
            this.DescriptionBox = new System.Windows.Forms.RichTextBox();
            this.componentsBox = new System.Windows.Forms.RichTextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.bttnAddCart = new System.Windows.Forms.Button();
            this.toolTipHelp = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipCart = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipExit = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipHome = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipAccount = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipLogout = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bannerBox)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.bttnHome);
            this.panel1.Controls.Add(this.bttnAccount);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnHelp);
            this.panel1.Controls.Add(this.bttnCart);
            this.panel1.Controls.Add(this.bttnExit);
            this.panel1.Controls.Add(this.bannerBox);
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
            this.bttnHome.Location = new System.Drawing.Point(637, 108);
            this.bttnHome.Name = "bttnHome";
            this.bttnHome.Size = new System.Drawing.Size(67, 66);
            this.bttnHome.TabIndex = 4;
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
            this.bttnAccount.Location = new System.Drawing.Point(725, 108);
            this.bttnAccount.Name = "bttnAccount";
            this.bttnAccount.Size = new System.Drawing.Size(65, 66);
            this.bttnAccount.TabIndex = 2;
            this.toolTipAccount.SetToolTip(this.bttnAccount, "View Account");
            this.bttnAccount.UseVisualStyleBackColor = false;
            this.bttnAccount.Click += new System.EventHandler(this.bttnAccount_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = global::PCHawkVer3.Properties.Resources.exit;
            this.button1.Location = new System.Drawing.Point(806, 108);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(69, 66);
            this.button1.TabIndex = 3;
            this.toolTipLogout.SetToolTip(this.button1, "Log Out");
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.BackColor = System.Drawing.Color.Black;
            this.btnHelp.FlatAppearance.BorderSize = 0;
            this.btnHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHelp.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHelp.ForeColor = System.Drawing.Color.White;
            this.btnHelp.Image = global::PCHawkVer3.Properties.Resources.info;
            this.btnHelp.Location = new System.Drawing.Point(637, 15);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(66, 66);
            this.btnHelp.TabIndex = 2;
            this.toolTipHelp.SetToolTip(this.btnHelp, "Help");
            this.btnHelp.UseVisualStyleBackColor = false;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // bttnCart
            // 
            this.bttnCart.BackColor = System.Drawing.Color.Black;
            this.bttnCart.FlatAppearance.BorderSize = 0;
            this.bttnCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnCart.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnCart.ForeColor = System.Drawing.Color.White;
            this.bttnCart.Image = global::PCHawkVer3.Properties.Resources.shopping_cart__2_;
            this.bttnCart.Location = new System.Drawing.Point(720, 12);
            this.bttnCart.Name = "bttnCart";
            this.bttnCart.Size = new System.Drawing.Size(70, 66);
            this.bttnCart.TabIndex = 2;
            this.toolTipCart.SetToolTip(this.bttnCart, "View Cart");
            this.bttnCart.UseVisualStyleBackColor = false;
            this.bttnCart.Click += new System.EventHandler(this.bttnCart_Click);
            // 
            // bttnExit
            // 
            this.bttnExit.BackColor = System.Drawing.Color.Black;
            this.bttnExit.FlatAppearance.BorderSize = 0;
            this.bttnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnExit.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnExit.ForeColor = System.Drawing.Color.White;
            this.bttnExit.Image = global::PCHawkVer3.Properties.Resources.power_button__2_;
            this.bttnExit.Location = new System.Drawing.Point(806, 15);
            this.bttnExit.Name = "bttnExit";
            this.bttnExit.Size = new System.Drawing.Size(69, 66);
            this.bttnExit.TabIndex = 2;
            this.toolTipExit.SetToolTip(this.bttnExit, "Exit Application");
            this.bttnExit.UseVisualStyleBackColor = false;
            this.bttnExit.Click += new System.EventHandler(this.bttnExit_Click);
            // 
            // bannerBox
            // 
            this.bannerBox.Image = global::PCHawkVer3.Properties.Resources.banner;
            this.bannerBox.Location = new System.Drawing.Point(3, 15);
            this.bannerBox.Name = "bannerBox";
            this.bannerBox.Size = new System.Drawing.Size(496, 159);
            this.bannerBox.TabIndex = 0;
            this.bannerBox.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Teal;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1168, 18);
            this.panel2.TabIndex = 1;
            // 
            // needsBox
            // 
            this.needsBox.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.needsBox.FormattingEnabled = true;
            this.needsBox.Location = new System.Drawing.Point(50, 258);
            this.needsBox.Name = "needsBox";
            this.needsBox.Size = new System.Drawing.Size(168, 28);
            this.needsBox.TabIndex = 3;
            this.needsBox.SelectedIndexChanged += new System.EventHandler(this.needsBox_SelectedIndexChanged);
            // 
            // priceRngBox
            // 
            this.priceRngBox.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceRngBox.FormattingEnabled = true;
            this.priceRngBox.Items.AddRange(new object[] {
            "$0-500",
            "$500-1000",
            "$1000-1500",
            "$1500-2000",
            "$2000-Higher"});
            this.priceRngBox.Location = new System.Drawing.Point(50, 292);
            this.priceRngBox.Name = "priceRngBox";
            this.priceRngBox.Size = new System.Drawing.Size(168, 28);
            this.priceRngBox.TabIndex = 4;
            this.priceRngBox.Text = "Price Range";
            // 
            // DescriptionBox
            // 
            this.DescriptionBox.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescriptionBox.Location = new System.Drawing.Point(50, 327);
            this.DescriptionBox.Name = "DescriptionBox";
            this.DescriptionBox.Size = new System.Drawing.Size(257, 238);
            this.DescriptionBox.TabIndex = 5;
            this.DescriptionBox.Text = "Product Description";
            // 
            // componentsBox
            // 
            this.componentsBox.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.componentsBox.Location = new System.Drawing.Point(390, 290);
            this.componentsBox.Name = "componentsBox";
            this.componentsBox.Size = new System.Drawing.Size(314, 225);
            this.componentsBox.TabIndex = 6;
            this.componentsBox.Text = "Components";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(390, 258);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(313, 26);
            this.textBox1.TabIndex = 7;
            this.textBox1.Text = "Build Name";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bttnAddCart
            // 
            this.bttnAddCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnAddCart.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnAddCart.ForeColor = System.Drawing.Color.White;
            this.bttnAddCart.Location = new System.Drawing.Point(390, 521);
            this.bttnAddCart.Name = "bttnAddCart";
            this.bttnAddCart.Size = new System.Drawing.Size(314, 44);
            this.bttnAddCart.TabIndex = 8;
            this.bttnAddCart.Text = "Add To Cart";
            this.bttnAddCart.UseVisualStyleBackColor = true;
            // 
            // preBuildForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(885, 590);
            this.Controls.Add(this.bttnAddCart);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.componentsBox);
            this.Controls.Add(this.DescriptionBox);
            this.Controls.Add(this.priceRngBox);
            this.Controls.Add(this.needsBox);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "preBuildForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "preBuildForm";
            this.Load += new System.EventHandler(this.preBuildForm_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bannerBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox bannerBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button bttnExit;
        private System.Windows.Forms.Button bttnCart;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Button bttnAccount;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox needsBox;
        private System.Windows.Forms.ComboBox priceRngBox;
        private System.Windows.Forms.RichTextBox DescriptionBox;
        private System.Windows.Forms.Button bttnHome;
        private System.Windows.Forms.RichTextBox componentsBox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button bttnAddCart;
        private System.Windows.Forms.ToolTip toolTipHome;
        private System.Windows.Forms.ToolTip toolTipAccount;
        private System.Windows.Forms.ToolTip toolTipLogout;
        private System.Windows.Forms.ToolTip toolTipHelp;
        private System.Windows.Forms.ToolTip toolTipCart;
        private System.Windows.Forms.ToolTip toolTipExit;
    }
}