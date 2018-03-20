namespace PChawk
{
    partial class frmHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHome));
            this.banner = new System.Windows.Forms.Splitter();
            this.bttnLogin = new System.Windows.Forms.Button();
            this.bttnSign = new System.Windows.Forms.Button();
            this.bttnHome = new System.Windows.Forms.Button();
            this.bttnCart = new System.Windows.Forms.Button();
            this.bttnHelp = new System.Windows.Forms.Button();
            this.bttnFree = new System.Windows.Forms.Button();
            this.bttnPre = new System.Windows.Forms.Button();
            this.rTxtBoxHome = new System.Windows.Forms.RichTextBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.picBoxHome = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxHome)).BeginInit();
            this.SuspendLayout();
            // 
            // banner
            // 
            this.banner.BackColor = System.Drawing.SystemColors.InfoText;
            this.banner.Dock = System.Windows.Forms.DockStyle.Top;
            this.banner.Location = new System.Drawing.Point(0, 0);
            this.banner.Margin = new System.Windows.Forms.Padding(2);
            this.banner.Name = "banner";
            this.banner.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.banner.Size = new System.Drawing.Size(1184, 195);
            this.banner.TabIndex = 0;
            this.banner.TabStop = false;
            // 
            // bttnLogin
            // 
            this.bttnLogin.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bttnLogin.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnLogin.Location = new System.Drawing.Point(911, 105);
            this.bttnLogin.Margin = new System.Windows.Forms.Padding(2);
            this.bttnLogin.Name = "bttnLogin";
            this.bttnLogin.Size = new System.Drawing.Size(129, 61);
            this.bttnLogin.TabIndex = 2;
            this.bttnLogin.Text = "Login";
            this.bttnLogin.UseVisualStyleBackColor = true;
            this.bttnLogin.Click += new System.EventHandler(this.bttnLogin_Click);
            // 
            // bttnSign
            // 
            this.bttnSign.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnSign.Location = new System.Drawing.Point(1044, 105);
            this.bttnSign.Margin = new System.Windows.Forms.Padding(2);
            this.bttnSign.Name = "bttnSign";
            this.bttnSign.Size = new System.Drawing.Size(129, 61);
            this.bttnSign.TabIndex = 3;
            this.bttnSign.Text = "Sign Up";
            this.bttnSign.UseVisualStyleBackColor = true;
            this.bttnSign.Click += new System.EventHandler(this.bttnSign_Click);
            // 
            // bttnHome
            // 
            this.bttnHome.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bttnHome.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnHome.Location = new System.Drawing.Point(954, 20);
            this.bttnHome.Margin = new System.Windows.Forms.Padding(2);
            this.bttnHome.Name = "bttnHome";
            this.bttnHome.Size = new System.Drawing.Size(70, 69);
            this.bttnHome.TabIndex = 4;
            this.bttnHome.Text = "Home";
            this.bttnHome.UseVisualStyleBackColor = true;
            // 
            // bttnCart
            // 
            this.bttnCart.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bttnCart.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnCart.Location = new System.Drawing.Point(1028, 20);
            this.bttnCart.Margin = new System.Windows.Forms.Padding(2);
            this.bttnCart.Name = "bttnCart";
            this.bttnCart.Size = new System.Drawing.Size(70, 69);
            this.bttnCart.TabIndex = 5;
            this.bttnCart.Text = "Cart";
            this.bttnCart.UseVisualStyleBackColor = true;
            // 
            // bttnHelp
            // 
            this.bttnHelp.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bttnHelp.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnHelp.Location = new System.Drawing.Point(1102, 20);
            this.bttnHelp.Margin = new System.Windows.Forms.Padding(2);
            this.bttnHelp.Name = "bttnHelp";
            this.bttnHelp.Size = new System.Drawing.Size(71, 69);
            this.bttnHelp.TabIndex = 6;
            this.bttnHelp.Text = "Help";
            this.bttnHelp.UseVisualStyleBackColor = true;
            this.bttnHelp.Click += new System.EventHandler(this.bttnHelp_Click);
            // 
            // bttnFree
            // 
            this.bttnFree.Font = new System.Drawing.Font("Segoe UI Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnFree.Location = new System.Drawing.Point(680, 736);
            this.bttnFree.Margin = new System.Windows.Forms.Padding(2);
            this.bttnFree.Name = "bttnFree";
            this.bttnFree.Size = new System.Drawing.Size(400, 100);
            this.bttnFree.TabIndex = 8;
            this.bttnFree.Text = "Free Build";
            this.bttnFree.UseVisualStyleBackColor = true;
            this.bttnFree.Click += new System.EventHandler(this.bttnFree_Click);
            // 
            // bttnPre
            // 
            this.bttnPre.Font = new System.Drawing.Font("Segoe UI Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnPre.Location = new System.Drawing.Point(80, 736);
            this.bttnPre.Margin = new System.Windows.Forms.Padding(2);
            this.bttnPre.Name = "bttnPre";
            this.bttnPre.Size = new System.Drawing.Size(400, 100);
            this.bttnPre.TabIndex = 9;
            this.bttnPre.Text = "Pre-built";
            this.bttnPre.UseVisualStyleBackColor = true;
            // 
            // rTxtBoxHome
            // 
            this.rTxtBoxHome.BackColor = System.Drawing.SystemColors.Info;
            this.rTxtBoxHome.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rTxtBoxHome.Location = new System.Drawing.Point(80, 215);
            this.rTxtBoxHome.Margin = new System.Windows.Forms.Padding(2);
            this.rTxtBoxHome.Name = "rTxtBoxHome";
            this.rTxtBoxHome.Size = new System.Drawing.Size(1000, 500);
            this.rTxtBoxHome.TabIndex = 10;
            this.rTxtBoxHome.Text = "WELCOME \nINFORMATION\nAND \nOTHER\nSTUFF";
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 195);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 666);
            this.splitter1.TabIndex = 12;
            this.splitter1.TabStop = false;
            // 
            // picBoxHome
            // 
            this.picBoxHome.BackColor = System.Drawing.SystemColors.InfoText;
            this.picBoxHome.Image = ((System.Drawing.Image)(resources.GetObject("picBoxHome.Image")));
            this.picBoxHome.Location = new System.Drawing.Point(51, 5);
            this.picBoxHome.Margin = new System.Windows.Forms.Padding(2);
            this.picBoxHome.Name = "picBoxHome";
            this.picBoxHome.Size = new System.Drawing.Size(775, 190);
            this.picBoxHome.TabIndex = 1;
            this.picBoxHome.TabStop = false;
            this.picBoxHome.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(1184, 861);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.rTxtBoxHome);
            this.Controls.Add(this.bttnPre);
            this.Controls.Add(this.bttnFree);
            this.Controls.Add(this.bttnHelp);
            this.Controls.Add(this.bttnCart);
            this.Controls.Add(this.bttnHome);
            this.Controls.Add(this.bttnSign);
            this.Controls.Add(this.bttnLogin);
            this.Controls.Add(this.picBoxHome);
            this.Controls.Add(this.banner);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmHome";
            this.Text = "Welcome!";
            ((System.ComponentModel.ISupportInitialize)(this.picBoxHome)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Splitter banner;
        private System.Windows.Forms.PictureBox picBoxHome;
        private System.Windows.Forms.Button bttnLogin;
        private System.Windows.Forms.Button bttnSign;
        private System.Windows.Forms.Button bttnHome;
        private System.Windows.Forms.Button bttnCart;
        private System.Windows.Forms.Button bttnHelp;
        private System.Windows.Forms.Button bttnFree;
        private System.Windows.Forms.Button bttnPre;
        private System.Windows.Forms.RichTextBox rTxtBoxHome;
        private System.Windows.Forms.Splitter splitter1;
    }
}

