namespace PCHawkVer3
{
    partial class SignInForm
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
            this.bttnHelp = new System.Windows.Forms.Button();
            this.bttnExit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtBoxEmail = new System.Windows.Forms.TextBox();
            this.txtBoxPass = new System.Windows.Forms.TextBox();
            this.bttnLogin = new System.Windows.Forms.Button();
            this.bttnSignUp = new System.Windows.Forms.Button();
            this.chkBoxPass = new System.Windows.Forms.CheckBox();
            this.toolTipHelp = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipQuit = new System.Windows.Forms.ToolTip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.bttnHelp);
            this.panel1.Controls.Add(this.bttnExit);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(900, 163);
            this.panel1.TabIndex = 0;
            // 
            // bttnHelp
            // 
            this.bttnHelp.BackColor = System.Drawing.Color.Black;
            this.bttnHelp.FlatAppearance.BorderSize = 0;
            this.bttnHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnHelp.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnHelp.ForeColor = System.Drawing.Color.White;
            this.bttnHelp.Image = global::PCHawkVer3.Properties.Resources.info;
            this.bttnHelp.Location = new System.Drawing.Point(57, 45);
            this.bttnHelp.Name = "bttnHelp";
            this.bttnHelp.Size = new System.Drawing.Size(91, 81);
            this.bttnHelp.TabIndex = 5;
            this.toolTipHelp.SetToolTip(this.bttnHelp, "Help");
            this.bttnHelp.UseVisualStyleBackColor = false;
            this.bttnHelp.Click += new System.EventHandler(this.bttnHelp_Click);
            // 
            // bttnExit
            // 
            this.bttnExit.BackColor = System.Drawing.Color.Black;
            this.bttnExit.FlatAppearance.BorderSize = 0;
            this.bttnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnExit.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnExit.ForeColor = System.Drawing.Color.White;
            this.bttnExit.Image = global::PCHawkVer3.Properties.Resources.power_button__2_;
            this.bttnExit.Location = new System.Drawing.Point(756, 45);
            this.bttnExit.Name = "bttnExit";
            this.bttnExit.Size = new System.Drawing.Size(91, 81);
            this.bttnExit.TabIndex = 4;
            this.toolTipQuit.SetToolTip(this.bttnExit, "Exit Application");
            this.bttnExit.UseVisualStyleBackColor = false;
            this.bttnExit.Click += new System.EventHandler(this.bttnExit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PCHawkVer3.Properties.Resources.banner;
            this.pictureBox1.Location = new System.Drawing.Point(202, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(501, 160);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // txtBoxEmail
            // 
            this.txtBoxEmail.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxEmail.Location = new System.Drawing.Point(307, 265);
            this.txtBoxEmail.Name = "txtBoxEmail";
            this.txtBoxEmail.Size = new System.Drawing.Size(300, 26);
            this.txtBoxEmail.TabIndex = 1;
            // 
            // txtBoxPass
            // 
            this.txtBoxPass.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxPass.Location = new System.Drawing.Point(307, 318);
            this.txtBoxPass.Name = "txtBoxPass";
            this.txtBoxPass.Size = new System.Drawing.Size(300, 26);
            this.txtBoxPass.TabIndex = 2;
            this.txtBoxPass.TextChanged += new System.EventHandler(this.txtBoxPass_TextChanged);
            // 
            // bttnLogin
            // 
            this.bttnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnLogin.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnLogin.ForeColor = System.Drawing.Color.White;
            this.bttnLogin.Location = new System.Drawing.Point(307, 350);
            this.bttnLogin.Name = "bttnLogin";
            this.bttnLogin.Size = new System.Drawing.Size(140, 57);
            this.bttnLogin.TabIndex = 3;
            this.bttnLogin.Text = "Login";
            this.bttnLogin.UseVisualStyleBackColor = true;
            this.bttnLogin.Click += new System.EventHandler(this.bttnLogin_Click);
            // 
            // bttnSignUp
            // 
            this.bttnSignUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnSignUp.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnSignUp.ForeColor = System.Drawing.Color.White;
            this.bttnSignUp.Location = new System.Drawing.Point(467, 350);
            this.bttnSignUp.Name = "bttnSignUp";
            this.bttnSignUp.Size = new System.Drawing.Size(140, 57);
            this.bttnSignUp.TabIndex = 4;
            this.bttnSignUp.Text = "SignUp";
            this.bttnSignUp.UseVisualStyleBackColor = true;
            this.bttnSignUp.Click += new System.EventHandler(this.bttnSignUp_Click);
            // 
            // chkBoxPass
            // 
            this.chkBoxPass.AutoSize = true;
            this.chkBoxPass.Checked = true;
            this.chkBoxPass.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkBoxPass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkBoxPass.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBoxPass.ForeColor = System.Drawing.Color.White;
            this.chkBoxPass.Location = new System.Drawing.Point(613, 318);
            this.chkBoxPass.Name = "chkBoxPass";
            this.chkBoxPass.Size = new System.Drawing.Size(132, 24);
            this.chkBoxPass.TabIndex = 5;
            this.chkBoxPass.Text = "Hide Password";
            this.chkBoxPass.UseVisualStyleBackColor = true;
            this.chkBoxPass.CheckedChanged += new System.EventHandler(this.chkBoxPass_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(304, 244);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "Email:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(304, 294);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 18);
            this.label2.TabIndex = 7;
            this.label2.Text = "Password:";
            // 
            // SignInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(900, 445);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chkBoxPass);
            this.Controls.Add(this.bttnSignUp);
            this.Controls.Add(this.bttnLogin);
            this.Controls.Add(this.txtBoxPass);
            this.Controls.Add(this.txtBoxEmail);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SignInForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SignIn";
            this.Load += new System.EventHandler(this.SignInForm_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button bttnHelp;
        private System.Windows.Forms.Button bttnExit;
        private System.Windows.Forms.TextBox txtBoxEmail;
        private System.Windows.Forms.TextBox txtBoxPass;
        private System.Windows.Forms.Button bttnLogin;
        private System.Windows.Forms.Button bttnSignUp;
        private System.Windows.Forms.CheckBox chkBoxPass;
        private System.Windows.Forms.ToolTip toolTipHelp;
        private System.Windows.Forms.ToolTip toolTipQuit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

