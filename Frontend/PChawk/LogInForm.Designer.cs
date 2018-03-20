namespace PChawk
{
    partial class LogInForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogInForm));
            this.signUpBanner = new System.Windows.Forms.Splitter();
            this.bttnHelpli = new System.Windows.Forms.Button();
            this.bttnHomeli = new System.Windows.Forms.Button();
            this.bttnLogin = new System.Windows.Forms.Button();
            this.bttnCA = new System.Windows.Forms.Button();
            this.txtBoxEmail = new System.Windows.Forms.TextBox();
            this.txtBoxPassword = new System.Windows.Forms.TextBox();
            this.signUpPicBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.signUpPicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // signUpBanner
            // 
            this.signUpBanner.BackColor = System.Drawing.SystemColors.InfoText;
            this.signUpBanner.Dock = System.Windows.Forms.DockStyle.Top;
            this.signUpBanner.Location = new System.Drawing.Point(0, 0);
            this.signUpBanner.Name = "signUpBanner";
            this.signUpBanner.Size = new System.Drawing.Size(919, 195);
            this.signUpBanner.TabIndex = 1;
            this.signUpBanner.TabStop = false;
            // 
            // bttnHelpli
            // 
            this.bttnHelpli.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bttnHelpli.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnHelpli.Location = new System.Drawing.Point(837, 11);
            this.bttnHelpli.Margin = new System.Windows.Forms.Padding(2);
            this.bttnHelpli.Name = "bttnHelpli";
            this.bttnHelpli.Size = new System.Drawing.Size(71, 69);
            this.bttnHelpli.TabIndex = 10;
            this.bttnHelpli.Text = "Help";
            this.bttnHelpli.UseVisualStyleBackColor = true;
            this.bttnHelpli.Click += new System.EventHandler(this.bttnHelpli_Click);
            // 
            // bttnHomeli
            // 
            this.bttnHomeli.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bttnHomeli.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnHomeli.Location = new System.Drawing.Point(763, 11);
            this.bttnHomeli.Margin = new System.Windows.Forms.Padding(2);
            this.bttnHomeli.Name = "bttnHomeli";
            this.bttnHomeli.Size = new System.Drawing.Size(70, 69);
            this.bttnHomeli.TabIndex = 8;
            this.bttnHomeli.Text = "Home";
            this.bttnHomeli.UseVisualStyleBackColor = true;
            this.bttnHomeli.Click += new System.EventHandler(this.bttnHomeli_Click);
            // 
            // bttnLogin
            // 
            this.bttnLogin.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bttnLogin.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnLogin.Location = new System.Drawing.Point(305, 350);
            this.bttnLogin.Margin = new System.Windows.Forms.Padding(2);
            this.bttnLogin.Name = "bttnLogin";
            this.bttnLogin.Size = new System.Drawing.Size(140, 80);
            this.bttnLogin.TabIndex = 11;
            this.bttnLogin.Text = "Login";
            this.bttnLogin.UseVisualStyleBackColor = true;
            // 
            // bttnCA
            // 
            this.bttnCA.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bttnCA.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnCA.Location = new System.Drawing.Point(449, 350);
            this.bttnCA.Margin = new System.Windows.Forms.Padding(2);
            this.bttnCA.Name = "bttnCA";
            this.bttnCA.Size = new System.Drawing.Size(140, 80);
            this.bttnCA.TabIndex = 12;
            this.bttnCA.Text = "Create Account";
            this.bttnCA.UseVisualStyleBackColor = true;
            this.bttnCA.Click += new System.EventHandler(this.bttnCA_Click);
            // 
            // txtBoxEmail
            // 
            this.txtBoxEmail.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxEmail.Location = new System.Drawing.Point(351, 281);
            this.txtBoxEmail.Name = "txtBoxEmail";
            this.txtBoxEmail.Size = new System.Drawing.Size(210, 29);
            this.txtBoxEmail.TabIndex = 13;
            this.txtBoxEmail.Text = "Email";
            // 
            // txtBoxPassword
            // 
            this.txtBoxPassword.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxPassword.Location = new System.Drawing.Point(351, 316);
            this.txtBoxPassword.Name = "txtBoxPassword";
            this.txtBoxPassword.Size = new System.Drawing.Size(210, 29);
            this.txtBoxPassword.TabIndex = 14;
            this.txtBoxPassword.Text = "Password";
            // 
            // signUpPicBox
            // 
            this.signUpPicBox.BackColor = System.Drawing.SystemColors.InfoText;
            this.signUpPicBox.Image = global::PChawk.Properties.Resources.pchlogo1;
            this.signUpPicBox.Location = new System.Drawing.Point(130, 0);
            this.signUpPicBox.Name = "signUpPicBox";
            this.signUpPicBox.Size = new System.Drawing.Size(617, 190);
            this.signUpPicBox.TabIndex = 2;
            this.signUpPicBox.TabStop = false;
            // 
            // LogInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(919, 561);
            this.ControlBox = false;
            this.Controls.Add(this.txtBoxPassword);
            this.Controls.Add(this.txtBoxEmail);
            this.Controls.Add(this.bttnCA);
            this.Controls.Add(this.bttnLogin);
            this.Controls.Add(this.bttnHelpli);
            this.Controls.Add(this.bttnHomeli);
            this.Controls.Add(this.signUpPicBox);
            this.Controls.Add(this.signUpBanner);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LogInForm";
            this.Text = "LogInForm";
            ((System.ComponentModel.ISupportInitialize)(this.signUpPicBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Splitter signUpBanner;
        private System.Windows.Forms.PictureBox signUpPicBox;
        private System.Windows.Forms.Button bttnHelpli;
        private System.Windows.Forms.Button bttnHomeli;
        private System.Windows.Forms.Button bttnLogin;
        private System.Windows.Forms.Button bttnCA;
        private System.Windows.Forms.TextBox txtBoxEmail;
        private System.Windows.Forms.TextBox txtBoxPassword;
    }
}