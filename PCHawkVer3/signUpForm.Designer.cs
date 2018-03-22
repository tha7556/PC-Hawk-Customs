namespace PCHawkVer3
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bttnCreateAcc = new System.Windows.Forms.Button();
            this.txtBoxPass = new System.Windows.Forms.TextBox();
            this.txtBoxEmail = new System.Windows.Forms.TextBox();
            this.txtBoxLast = new System.Windows.Forms.TextBox();
            this.txtBoxFirst = new System.Windows.Forms.TextBox();
            this.welcomeLab = new System.Windows.Forms.Label();
            this.toolTipExit = new System.Windows.Forms.ToolTip(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtBoxCity = new System.Windows.Forms.TextBox();
            this.txtBoxState = new System.Windows.Forms.TextBox();
            this.txtBoxZip = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(887, 160);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = global::PCHawkVer3.Properties.Resources.power_button__2_;
            this.button1.Location = new System.Drawing.Point(746, 40);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 81);
            this.button1.TabIndex = 1;
            this.toolTipExit.SetToolTip(this.button1, "Exit Application");
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PCHawkVer3.Properties.Resources.banner;
            this.pictureBox1.Location = new System.Drawing.Point(181, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(518, 168);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // bttnCreateAcc
            // 
            this.bttnCreateAcc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnCreateAcc.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnCreateAcc.ForeColor = System.Drawing.Color.White;
            this.bttnCreateAcc.Location = new System.Drawing.Point(235, 372);
            this.bttnCreateAcc.Name = "bttnCreateAcc";
            this.bttnCreateAcc.Size = new System.Drawing.Size(426, 61);
            this.bttnCreateAcc.TabIndex = 1;
            this.bttnCreateAcc.Text = "Create Account";
            this.bttnCreateAcc.UseVisualStyleBackColor = true;
            this.bttnCreateAcc.Click += new System.EventHandler(this.bttnCreateAcc_Click);
            // 
            // txtBoxPass
            // 
            this.txtBoxPass.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxPass.Location = new System.Drawing.Point(235, 279);
            this.txtBoxPass.Name = "txtBoxPass";
            this.txtBoxPass.Size = new System.Drawing.Size(426, 26);
            this.txtBoxPass.TabIndex = 2;
            this.txtBoxPass.Text = "Password";
            // 
            // txtBoxEmail
            // 
            this.txtBoxEmail.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxEmail.Location = new System.Drawing.Point(235, 247);
            this.txtBoxEmail.Name = "txtBoxEmail";
            this.txtBoxEmail.Size = new System.Drawing.Size(426, 26);
            this.txtBoxEmail.TabIndex = 3;
            this.txtBoxEmail.Text = "Email";
            // 
            // txtBoxLast
            // 
            this.txtBoxLast.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxLast.Location = new System.Drawing.Point(442, 215);
            this.txtBoxLast.Name = "txtBoxLast";
            this.txtBoxLast.Size = new System.Drawing.Size(219, 26);
            this.txtBoxLast.TabIndex = 4;
            this.txtBoxLast.Text = "Last Name";
            // 
            // txtBoxFirst
            // 
            this.txtBoxFirst.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxFirst.Location = new System.Drawing.Point(235, 215);
            this.txtBoxFirst.Name = "txtBoxFirst";
            this.txtBoxFirst.Size = new System.Drawing.Size(201, 26);
            this.txtBoxFirst.TabIndex = 5;
            this.txtBoxFirst.Text = "First Name";
            // 
            // welcomeLab
            // 
            this.welcomeLab.AutoSize = true;
            this.welcomeLab.Font = new System.Drawing.Font("Century Gothic", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeLab.ForeColor = System.Drawing.Color.White;
            this.welcomeLab.Location = new System.Drawing.Point(358, 163);
            this.welcomeLab.Name = "welcomeLab";
            this.welcomeLab.Size = new System.Drawing.Size(173, 38);
            this.welcomeLab.TabIndex = 6;
            this.welcomeLab.Text = "Welcome!";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(235, 311);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(426, 26);
            this.textBox1.TabIndex = 7;
            this.textBox1.Text = "Address";
            // 
            // txtBoxCity
            // 
            this.txtBoxCity.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxCity.Location = new System.Drawing.Point(235, 340);
            this.txtBoxCity.Name = "txtBoxCity";
            this.txtBoxCity.Size = new System.Drawing.Size(166, 26);
            this.txtBoxCity.TabIndex = 8;
            this.txtBoxCity.Text = "City";
            // 
            // txtBoxState
            // 
            this.txtBoxState.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxState.Location = new System.Drawing.Point(407, 340);
            this.txtBoxState.Name = "txtBoxState";
            this.txtBoxState.Size = new System.Drawing.Size(124, 26);
            this.txtBoxState.TabIndex = 9;
            this.txtBoxState.Text = "State";
            // 
            // txtBoxZip
            // 
            this.txtBoxZip.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxZip.Location = new System.Drawing.Point(537, 340);
            this.txtBoxZip.Name = "txtBoxZip";
            this.txtBoxZip.Size = new System.Drawing.Size(124, 26);
            this.txtBoxZip.TabIndex = 10;
            this.txtBoxZip.Text = "Zip";
            // 
            // signUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(887, 483);
            this.Controls.Add(this.txtBoxZip);
            this.Controls.Add(this.txtBoxState);
            this.Controls.Add(this.txtBoxCity);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.welcomeLab);
            this.Controls.Add(this.txtBoxFirst);
            this.Controls.Add(this.txtBoxLast);
            this.Controls.Add(this.txtBoxEmail);
            this.Controls.Add(this.txtBoxPass);
            this.Controls.Add(this.bttnCreateAcc);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "signUpForm";
            this.Text = "signUpForm";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button bttnCreateAcc;
        private System.Windows.Forms.TextBox txtBoxPass;
        private System.Windows.Forms.TextBox txtBoxEmail;
        private System.Windows.Forms.TextBox txtBoxLast;
        private System.Windows.Forms.TextBox txtBoxFirst;
        private System.Windows.Forms.Label welcomeLab;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolTip toolTipExit;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtBoxCity;
        private System.Windows.Forms.TextBox txtBoxState;
        private System.Windows.Forms.TextBox txtBoxZip;
    }
}