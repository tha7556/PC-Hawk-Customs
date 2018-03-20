namespace PChawk
{
    partial class signUpForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(signUpForm));
            this.signUpBanner = new System.Windows.Forms.Splitter();
            this.signUpPicBox = new System.Windows.Forms.PictureBox();
            this.bttnHome = new System.Windows.Forms.Button();
            this.bttnCart = new System.Windows.Forms.Button();
            this.bttnHelp = new System.Windows.Forms.Button();
            this.bttnLogin = new System.Windows.Forms.Button();
            this.bttnSign = new System.Windows.Forms.Button();
            this.txtBoxFirstName = new System.Windows.Forms.TextBox();
            this.txtBoxLastName = new System.Windows.Forms.TextBox();
            this.txtBoxEmail = new System.Windows.Forms.TextBox();
            this.txtBoxPassword = new System.Windows.Forms.TextBox();
            this.bttnCreate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.signUpPicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // signUpBanner
            // 
            this.signUpBanner.BackColor = System.Drawing.SystemColors.InfoText;
            this.signUpBanner.Dock = System.Windows.Forms.DockStyle.Top;
            this.signUpBanner.Location = new System.Drawing.Point(0, 0);
            this.signUpBanner.Name = "signUpBanner";
            this.signUpBanner.Size = new System.Drawing.Size(1184, 195);
            this.signUpBanner.TabIndex = 0;
            this.signUpBanner.TabStop = false;
            // 
            // signUpPicBox
            // 
            this.signUpPicBox.BackColor = System.Drawing.SystemColors.InfoText;
            this.signUpPicBox.Image = global::PChawk.Properties.Resources.pchlogo1;
            this.signUpPicBox.Location = new System.Drawing.Point(52, 0);
            this.signUpPicBox.Name = "signUpPicBox";
            this.signUpPicBox.Size = new System.Drawing.Size(775, 190);
            this.signUpPicBox.TabIndex = 1;
            this.signUpPicBox.TabStop = false;
            // 
            // bttnHome
            // 
            this.bttnHome.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bttnHome.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnHome.Location = new System.Drawing.Point(954, 20);
            this.bttnHome.Margin = new System.Windows.Forms.Padding(2);
            this.bttnHome.Name = "bttnHome";
            this.bttnHome.Size = new System.Drawing.Size(70, 69);
            this.bttnHome.TabIndex = 5;
            this.bttnHome.Text = "Home";
            this.bttnHome.UseVisualStyleBackColor = true;
            this.bttnHome.Click += new System.EventHandler(this.bttnHome_Click);
            // 
            // bttnCart
            // 
            this.bttnCart.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bttnCart.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnCart.Location = new System.Drawing.Point(1028, 20);
            this.bttnCart.Margin = new System.Windows.Forms.Padding(2);
            this.bttnCart.Name = "bttnCart";
            this.bttnCart.Size = new System.Drawing.Size(70, 69);
            this.bttnCart.TabIndex = 6;
            this.bttnCart.Text = "Cart";
            this.bttnCart.UseVisualStyleBackColor = true;
            this.bttnCart.Click += new System.EventHandler(this.bttnCart_Click);
            // 
            // bttnHelp
            // 
            this.bttnHelp.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bttnHelp.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnHelp.Location = new System.Drawing.Point(1102, 20);
            this.bttnHelp.Margin = new System.Windows.Forms.Padding(2);
            this.bttnHelp.Name = "bttnHelp";
            this.bttnHelp.Size = new System.Drawing.Size(71, 69);
            this.bttnHelp.TabIndex = 7;
            this.bttnHelp.Text = "Help";
            this.bttnHelp.UseVisualStyleBackColor = true;
            this.bttnHelp.Click += new System.EventHandler(this.bttnHelp_Click);
            // 
            // bttnLogin
            // 
            this.bttnLogin.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bttnLogin.Enabled = false;
            this.bttnLogin.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnLogin.Location = new System.Drawing.Point(911, 105);
            this.bttnLogin.Margin = new System.Windows.Forms.Padding(2);
            this.bttnLogin.Name = "bttnLogin";
            this.bttnLogin.Size = new System.Drawing.Size(129, 61);
            this.bttnLogin.TabIndex = 8;
            this.bttnLogin.Text = "Login";
            this.bttnLogin.UseVisualStyleBackColor = true;
            // 
            // bttnSign
            // 
            this.bttnSign.Enabled = false;
            this.bttnSign.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnSign.Location = new System.Drawing.Point(1044, 105);
            this.bttnSign.Margin = new System.Windows.Forms.Padding(2);
            this.bttnSign.Name = "bttnSign";
            this.bttnSign.Size = new System.Drawing.Size(129, 61);
            this.bttnSign.TabIndex = 9;
            this.bttnSign.Text = "Sign Up";
            this.bttnSign.UseVisualStyleBackColor = true;
            // 
            // txtBoxFirstName
            // 
            this.txtBoxFirstName.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxFirstName.Location = new System.Drawing.Point(380, 380);
            this.txtBoxFirstName.Name = "txtBoxFirstName";
            this.txtBoxFirstName.Size = new System.Drawing.Size(210, 29);
            this.txtBoxFirstName.TabIndex = 10;
            this.txtBoxFirstName.Text = "First Name";
            // 
            // txtBoxLastName
            // 
            this.txtBoxLastName.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxLastName.Location = new System.Drawing.Point(596, 380);
            this.txtBoxLastName.Name = "txtBoxLastName";
            this.txtBoxLastName.Size = new System.Drawing.Size(210, 29);
            this.txtBoxLastName.TabIndex = 11;
            this.txtBoxLastName.Text = "Last Name";
            // 
            // txtBoxEmail
            // 
            this.txtBoxEmail.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxEmail.Location = new System.Drawing.Point(380, 416);
            this.txtBoxEmail.Name = "txtBoxEmail";
            this.txtBoxEmail.Size = new System.Drawing.Size(426, 29);
            this.txtBoxEmail.TabIndex = 12;
            this.txtBoxEmail.Text = "Email";
            // 
            // txtBoxPassword
            // 
            this.txtBoxPassword.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxPassword.Location = new System.Drawing.Point(380, 451);
            this.txtBoxPassword.Name = "txtBoxPassword";
            this.txtBoxPassword.Size = new System.Drawing.Size(426, 29);
            this.txtBoxPassword.TabIndex = 13;
            this.txtBoxPassword.Text = "Password";
            // 
            // bttnCreate
            // 
            this.bttnCreate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bttnCreate.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnCreate.Location = new System.Drawing.Point(380, 511);
            this.bttnCreate.Margin = new System.Windows.Forms.Padding(2);
            this.bttnCreate.Name = "bttnCreate";
            this.bttnCreate.Size = new System.Drawing.Size(426, 61);
            this.bttnCreate.TabIndex = 14;
            this.bttnCreate.Text = "Create Account";
            this.bttnCreate.UseVisualStyleBackColor = true;
            this.bttnCreate.Click += new System.EventHandler(this.bttnCreate_Click);
            // 
            // signUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(1184, 861);
            this.ControlBox = false;
            this.Controls.Add(this.bttnCreate);
            this.Controls.Add(this.txtBoxPassword);
            this.Controls.Add(this.txtBoxEmail);
            this.Controls.Add(this.txtBoxLastName);
            this.Controls.Add(this.txtBoxFirstName);
            this.Controls.Add(this.bttnSign);
            this.Controls.Add(this.bttnLogin);
            this.Controls.Add(this.bttnHelp);
            this.Controls.Add(this.bttnCart);
            this.Controls.Add(this.bttnHome);
            this.Controls.Add(this.signUpPicBox);
            this.Controls.Add(this.signUpBanner);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "signUpForm";
            this.Text = "signUpForm";
            ((System.ComponentModel.ISupportInitialize)(this.signUpPicBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Splitter signUpBanner;
        private System.Windows.Forms.PictureBox signUpPicBox;
        private System.Windows.Forms.Button bttnHome;
        private System.Windows.Forms.Button bttnCart;
        private System.Windows.Forms.Button bttnHelp;
        private System.Windows.Forms.Button bttnLogin;
        private System.Windows.Forms.Button bttnSign;
        private System.Windows.Forms.TextBox txtBoxFirstName;
        private System.Windows.Forms.TextBox txtBoxLastName;
        private System.Windows.Forms.TextBox txtBoxEmail;
        private System.Windows.Forms.TextBox txtBoxPassword;
        private System.Windows.Forms.Button bttnCreate;
    }
}