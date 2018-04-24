namespace PCHawk
{
    partial class cartForm
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
            this.btnHelp = new System.Windows.Forms.Button();
            this.bttnExit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.totalBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bttnContinue = new System.Windows.Forms.Button();
            this.bttnClear = new System.Windows.Forms.Button();
            this.bttnCheckOut = new System.Windows.Forms.Button();
            this.toolTipHelp = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipHome = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipAccount = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipLogout = new System.Windows.Forms.ToolTip(this.components);
            this.CartContentsBox = new System.Windows.Forms.ListBox();
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
            this.panel1.Controls.Add(this.btnHelp);
            this.panel1.Controls.Add(this.bttnExit);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(855, 163);
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
            this.bttnHome.Location = new System.Drawing.Point(582, 88);
            this.bttnHome.Name = "bttnHome";
            this.bttnHome.Size = new System.Drawing.Size(67, 66);
            this.bttnHome.TabIndex = 10;
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
            this.bttnAccount.Location = new System.Drawing.Point(677, 88);
            this.bttnAccount.Name = "bttnAccount";
            this.bttnAccount.Size = new System.Drawing.Size(65, 66);
            this.bttnAccount.TabIndex = 11;
            this.toolTipHome.SetToolTip(this.bttnAccount, "View Account");
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
            this.bttnLogout.Location = new System.Drawing.Point(769, 88);
            this.bttnLogout.Name = "bttnLogout";
            this.bttnLogout.Size = new System.Drawing.Size(69, 66);
            this.bttnLogout.TabIndex = 12;
            this.toolTipLogout.SetToolTip(this.bttnLogout, "Logout");
            this.bttnLogout.UseVisualStyleBackColor = false;
            this.bttnLogout.Click += new System.EventHandler(this.bttnLogout_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.BackColor = System.Drawing.Color.Black;
            this.btnHelp.FlatAppearance.BorderSize = 0;
            this.btnHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHelp.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHelp.ForeColor = System.Drawing.Color.White;
            this.btnHelp.Image = global::PCHawk.Properties.Resources.info;
            this.btnHelp.Location = new System.Drawing.Point(666, 3);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(76, 66);
            this.btnHelp.TabIndex = 4;
            this.toolTipHelp.SetToolTip(this.btnHelp, "Help");
            this.btnHelp.UseVisualStyleBackColor = false;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // bttnExit
            // 
            this.bttnExit.BackColor = System.Drawing.Color.Black;
            this.bttnExit.FlatAppearance.BorderSize = 0;
            this.bttnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnExit.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnExit.ForeColor = System.Drawing.Color.White;
            this.bttnExit.Image = global::PCHawk.Properties.Resources.power_button__2_;
            this.bttnExit.Location = new System.Drawing.Point(769, 3);
            this.bttnExit.Name = "bttnExit";
            this.bttnExit.Size = new System.Drawing.Size(69, 66);
            this.bttnExit.TabIndex = 6;
            this.toolTip1.SetToolTip(this.bttnExit, "Exit Application");
            this.bttnExit.UseVisualStyleBackColor = false;
            this.bttnExit.Click += new System.EventHandler(this.bttnExit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PCHawk.Properties.Resources.banner;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(509, 153);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Teal;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(855, 22);
            this.panel2.TabIndex = 1;
            // 
            // totalBox
            // 
            this.totalBox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalBox.Location = new System.Drawing.Point(146, 546);
            this.totalBox.Name = "totalBox";
            this.totalBox.ReadOnly = true;
            this.totalBox.Size = new System.Drawing.Size(185, 23);
            this.totalBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(51, 549);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "TOTAL COST:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(22, 215);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Your Cart Contents:";
            // 
            // bttnContinue
            // 
            this.bttnContinue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnContinue.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnContinue.ForeColor = System.Drawing.Color.White;
            this.bttnContinue.Location = new System.Drawing.Point(337, 236);
            this.bttnContinue.Name = "bttnContinue";
            this.bttnContinue.Size = new System.Drawing.Size(253, 60);
            this.bttnContinue.TabIndex = 6;
            this.bttnContinue.Text = "Continue Shopping";
            this.bttnContinue.UseVisualStyleBackColor = true;
            this.bttnContinue.Click += new System.EventHandler(this.bttnContinue_Click);
            // 
            // bttnClear
            // 
            this.bttnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnClear.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnClear.ForeColor = System.Drawing.Color.White;
            this.bttnClear.Location = new System.Drawing.Point(337, 414);
            this.bttnClear.Name = "bttnClear";
            this.bttnClear.Size = new System.Drawing.Size(253, 60);
            this.bttnClear.TabIndex = 8;
            this.bttnClear.Text = "Clear Cart";
            this.bttnClear.UseVisualStyleBackColor = true;
            this.bttnClear.Click += new System.EventHandler(this.bttnClear_Click);
            // 
            // bttnCheckOut
            // 
            this.bttnCheckOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnCheckOut.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnCheckOut.ForeColor = System.Drawing.Color.Yellow;
            this.bttnCheckOut.Location = new System.Drawing.Point(337, 480);
            this.bttnCheckOut.Name = "bttnCheckOut";
            this.bttnCheckOut.Size = new System.Drawing.Size(253, 60);
            this.bttnCheckOut.TabIndex = 9;
            this.bttnCheckOut.Text = "Check Out";
            this.bttnCheckOut.UseVisualStyleBackColor = true;
            this.bttnCheckOut.Click += new System.EventHandler(this.bttnCheckOut_Click);
            // 
            // CartContentsBox
            // 
            this.CartContentsBox.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CartContentsBox.FormattingEnabled = true;
            this.CartContentsBox.ItemHeight = 20;
            this.CartContentsBox.Location = new System.Drawing.Point(25, 236);
            this.CartContentsBox.Name = "CartContentsBox";
            this.CartContentsBox.Size = new System.Drawing.Size(306, 304);
            this.CartContentsBox.TabIndex = 10;
            // 
            // cartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(850, 600);
            this.Controls.Add(this.CartContentsBox);
            this.Controls.Add(this.bttnCheckOut);
            this.Controls.Add(this.bttnClear);
            this.Controls.Add(this.bttnContinue);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.totalBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "cartForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "cartForm";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button bttnExit;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Button bttnHome;
        private System.Windows.Forms.Button bttnAccount;
        private System.Windows.Forms.Button bttnLogout;
        private System.Windows.Forms.TextBox totalBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bttnContinue;
        private System.Windows.Forms.Button bttnClear;
        private System.Windows.Forms.Button bttnCheckOut;
        private System.Windows.Forms.ToolTip toolTipHome;
        private System.Windows.Forms.ToolTip toolTipLogout;
        private System.Windows.Forms.ToolTip toolTipHelp;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTipAccount;
        private System.Windows.Forms.ListBox CartContentsBox;
    }
}