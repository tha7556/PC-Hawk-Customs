namespace PCHawk
{
    partial class accountForm
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
            this.bttnLogout = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bttnExit = new System.Windows.Forms.Button();
            this.bttnCart = new System.Windows.Forms.Button();
            this.btnHelp = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtBoxFirst = new System.Windows.Forms.TextBox();
            this.txtBoxLast = new System.Windows.Forms.TextBox();
            this.txtBoxEmail = new System.Windows.Forms.TextBox();
            this.txtBoxAddress = new System.Windows.Forms.TextBox();
            this.txtBoxCity = new System.Windows.Forms.TextBox();
            this.txtBoxState = new System.Windows.Forms.TextBox();
            this.bttnChangeInfo = new System.Windows.Forms.Button();
            this.bttnPassChange = new System.Windows.Forms.Button();
            this.historyBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.toolTipHelp = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipCart = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipExit = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipHome = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipLogout = new System.Windows.Forms.ToolTip(this.components);
            this.bttnSave = new System.Windows.Forms.Button();
            this.txtBoxZip = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.bttnHome);
            this.panel1.Controls.Add(this.bttnLogout);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.bttnExit);
            this.panel1.Controls.Add(this.bttnCart);
            this.panel1.Controls.Add(this.btnHelp);
            this.panel1.Location = new System.Drawing.Point(0, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(870, 165);
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
            this.bttnHome.Location = new System.Drawing.Point(584, 91);
            this.bttnHome.Name = "bttnHome";
            this.bttnHome.Size = new System.Drawing.Size(67, 66);
            this.bttnHome.TabIndex = 9;
            this.toolTipHome.SetToolTip(this.bttnHome, "home");
            this.bttnHome.UseVisualStyleBackColor = false;
            this.bttnHome.Click += new System.EventHandler(this.bttnHome_Click);
            // 
            // bttnLogout
            // 
            this.bttnLogout.BackColor = System.Drawing.Color.Black;
            this.bttnLogout.FlatAppearance.BorderSize = 0;
            this.bttnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnLogout.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnLogout.ForeColor = System.Drawing.Color.White;
            this.bttnLogout.Image = global::PCHawk.Properties.Resources.exit;
            this.bttnLogout.Location = new System.Drawing.Point(798, 91);
            this.bttnLogout.Name = "bttnLogout";
            this.bttnLogout.Size = new System.Drawing.Size(69, 66);
            this.bttnLogout.TabIndex = 11;
            this.toolTipLogout.SetToolTip(this.bttnLogout, "logout");
            this.bttnLogout.UseVisualStyleBackColor = false;
            this.bttnLogout.Click += new System.EventHandler(this.bttnLogout_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PCHawk.Properties.Resources.banner;
            this.pictureBox1.Location = new System.Drawing.Point(0, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(508, 157);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // bttnExit
            // 
            this.bttnExit.BackColor = System.Drawing.Color.Black;
            this.bttnExit.FlatAppearance.BorderSize = 0;
            this.bttnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnExit.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnExit.ForeColor = System.Drawing.Color.White;
            this.bttnExit.Image = global::PCHawk.Properties.Resources.power_button__2_;
            this.bttnExit.Location = new System.Drawing.Point(798, 3);
            this.bttnExit.Name = "bttnExit";
            this.bttnExit.Size = new System.Drawing.Size(69, 66);
            this.bttnExit.TabIndex = 6;
            this.toolTipExit.SetToolTip(this.bttnExit, "exit application");
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
            this.bttnCart.Location = new System.Drawing.Point(685, 3);
            this.bttnCart.Name = "bttnCart";
            this.bttnCart.Size = new System.Drawing.Size(70, 66);
            this.bttnCart.TabIndex = 5;
            this.toolTipCart.SetToolTip(this.bttnCart, "view cart");
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
            this.btnHelp.Location = new System.Drawing.Point(584, 3);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(67, 66);
            this.btnHelp.TabIndex = 4;
            this.toolTipHelp.SetToolTip(this.btnHelp, "help");
            this.btnHelp.UseVisualStyleBackColor = false;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Teal;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(870, 20);
            this.panel2.TabIndex = 1;
            // 
            // txtBoxFirst
            // 
            this.txtBoxFirst.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxFirst.Location = new System.Drawing.Point(45, 224);
            this.txtBoxFirst.Name = "txtBoxFirst";
            this.txtBoxFirst.ReadOnly = true;
            this.txtBoxFirst.Size = new System.Drawing.Size(145, 26);
            this.txtBoxFirst.TabIndex = 3;
            // 
            // txtBoxLast
            // 
            this.txtBoxLast.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxLast.Location = new System.Drawing.Point(196, 224);
            this.txtBoxLast.Name = "txtBoxLast";
            this.txtBoxLast.Size = new System.Drawing.Size(145, 26);
            this.txtBoxLast.TabIndex = 4;
            // 
            // txtBoxEmail
            // 
            this.txtBoxEmail.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxEmail.Location = new System.Drawing.Point(45, 275);
            this.txtBoxEmail.Name = "txtBoxEmail";
            this.txtBoxEmail.Size = new System.Drawing.Size(296, 26);
            this.txtBoxEmail.TabIndex = 5;
            // 
            // txtBoxAddress
            // 
            this.txtBoxAddress.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxAddress.Location = new System.Drawing.Point(45, 325);
            this.txtBoxAddress.Name = "txtBoxAddress";
            this.txtBoxAddress.Size = new System.Drawing.Size(296, 26);
            this.txtBoxAddress.TabIndex = 6;
            // 
            // txtBoxCity
            // 
            this.txtBoxCity.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxCity.Location = new System.Drawing.Point(45, 375);
            this.txtBoxCity.Name = "txtBoxCity";
            this.txtBoxCity.Size = new System.Drawing.Size(296, 26);
            this.txtBoxCity.TabIndex = 7;
            // 
            // txtBoxState
            // 
            this.txtBoxState.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxState.Location = new System.Drawing.Point(45, 425);
            this.txtBoxState.Name = "txtBoxState";
            this.txtBoxState.Size = new System.Drawing.Size(296, 26);
            this.txtBoxState.TabIndex = 8;
            // 
            // bttnChangeInfo
            // 
            this.bttnChangeInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnChangeInfo.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnChangeInfo.ForeColor = System.Drawing.Color.White;
            this.bttnChangeInfo.Location = new System.Drawing.Point(45, 510);
            this.bttnChangeInfo.Name = "bttnChangeInfo";
            this.bttnChangeInfo.Size = new System.Drawing.Size(296, 40);
            this.bttnChangeInfo.TabIndex = 9;
            this.bttnChangeInfo.Text = "Update Info";
            this.bttnChangeInfo.UseVisualStyleBackColor = true;
            this.bttnChangeInfo.Click += new System.EventHandler(this.bttnChangeInfo_Click);
            // 
            // bttnPassChange
            // 
            this.bttnPassChange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnPassChange.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnPassChange.ForeColor = System.Drawing.Color.White;
            this.bttnPassChange.Location = new System.Drawing.Point(45, 556);
            this.bttnPassChange.Name = "bttnPassChange";
            this.bttnPassChange.Size = new System.Drawing.Size(296, 40);
            this.bttnPassChange.TabIndex = 10;
            this.bttnPassChange.Text = "Change Password";
            this.bttnPassChange.UseVisualStyleBackColor = true;
            this.bttnPassChange.Click += new System.EventHandler(this.bttnPassChange_Click);
            // 
            // historyBox
            // 
            this.historyBox.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.historyBox.FormattingEnabled = true;
            this.historyBox.ItemHeight = 20;
            this.historyBox.Location = new System.Drawing.Point(465, 257);
            this.historyBox.Name = "historyBox";
            this.historyBox.Size = new System.Drawing.Size(325, 384);
            this.historyBox.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(557, 224);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 26);
            this.label1.TabIndex = 12;
            this.label1.Text = "Order History";
            // 
            // bttnSave
            // 
            this.bttnSave.Enabled = false;
            this.bttnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnSave.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnSave.ForeColor = System.Drawing.Color.White;
            this.bttnSave.Location = new System.Drawing.Point(45, 602);
            this.bttnSave.Name = "bttnSave";
            this.bttnSave.Size = new System.Drawing.Size(296, 40);
            this.bttnSave.TabIndex = 13;
            this.bttnSave.Text = "Save Changes";
            this.bttnSave.UseVisualStyleBackColor = true;
            this.bttnSave.Click += new System.EventHandler(this.bttnSave_Click);
            // 
            // txtBoxZip
            // 
            this.txtBoxZip.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxZip.Location = new System.Drawing.Point(45, 475);
            this.txtBoxZip.Name = "txtBoxZip";
            this.txtBoxZip.Size = new System.Drawing.Size(296, 26);
            this.txtBoxZip.TabIndex = 14;
            this.txtBoxZip.TextChanged += new System.EventHandler(this.txtBoxZip_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(42, 203);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 18);
            this.label6.TabIndex = 18;
            this.label6.Text = "First Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(193, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 18);
            this.label2.TabIndex = 19;
            this.label2.Text = "Last Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(42, 454);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 18);
            this.label3.TabIndex = 20;
            this.label3.Text = "Zip:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(42, 404);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 18);
            this.label4.TabIndex = 21;
            this.label4.Text = "State:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(42, 354);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 18);
            this.label5.TabIndex = 22;
            this.label5.Text = "City:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(42, 304);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 18);
            this.label7.TabIndex = 23;
            this.label7.Text = "Address:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(42, 254);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 18);
            this.label8.TabIndex = 24;
            this.label8.Text = "Email:";
            // 
            // accountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(869, 685);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtBoxZip);
            this.Controls.Add(this.bttnSave);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.historyBox);
            this.Controls.Add(this.bttnPassChange);
            this.Controls.Add(this.bttnChangeInfo);
            this.Controls.Add(this.txtBoxState);
            this.Controls.Add(this.txtBoxCity);
            this.Controls.Add(this.txtBoxAddress);
            this.Controls.Add(this.txtBoxEmail);
            this.Controls.Add(this.txtBoxLast);
            this.Controls.Add(this.txtBoxFirst);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "accountForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "accountForm";
            this.Load += new System.EventHandler(this.accountForm_Load);
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
        private System.Windows.Forms.Button bttnHome;
        private System.Windows.Forms.Button bttnLogout;
        private System.Windows.Forms.TextBox txtBoxFirst;
        private System.Windows.Forms.TextBox txtBoxLast;
        private System.Windows.Forms.TextBox txtBoxEmail;
        private System.Windows.Forms.TextBox txtBoxAddress;
        private System.Windows.Forms.TextBox txtBoxCity;
        private System.Windows.Forms.TextBox txtBoxState;
        private System.Windows.Forms.Button bttnChangeInfo;
        private System.Windows.Forms.Button bttnPassChange;
        private System.Windows.Forms.ListBox historyBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip toolTipHome;
        private System.Windows.Forms.ToolTip toolTipLogout;
        private System.Windows.Forms.ToolTip toolTipExit;
        private System.Windows.Forms.ToolTip toolTipCart;
        private System.Windows.Forms.ToolTip toolTipHelp;
        private System.Windows.Forms.Button bttnSave;
        private System.Windows.Forms.TextBox txtBoxZip;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}