namespace PCHawk
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.bttnPreBuild = new System.Windows.Forms.Button();
            this.bttnFreeBuild = new System.Windows.Forms.Button();
            this.rtbInfo = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.exitToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.cartToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipHelp = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipAccount = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipLog = new System.Windows.Forms.ToolTip(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.bttnAccount = new System.Windows.Forms.Button();
            this.btnHelp = new System.Windows.Forms.Button();
            this.bttnCart = new System.Windows.Forms.Button();
            this.bttnExit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.homeScreenControl1 = new PCHawk.homeScreenControl();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.bttnAccount);
            this.panel1.Controls.Add(this.btnHelp);
            this.panel1.Controls.Add(this.bttnCart);
            this.panel1.Controls.Add(this.bttnExit);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1170, 192);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Teal;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1184, 18);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.homeScreenControl1);
            this.panel3.Location = new System.Drawing.Point(331, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(853, 861);
            this.panel3.TabIndex = 2;
            // 
            // bttnPreBuild
            // 
            this.bttnPreBuild.FlatAppearance.BorderSize = 0;
            this.bttnPreBuild.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnPreBuild.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnPreBuild.ForeColor = System.Drawing.Color.White;
            this.bttnPreBuild.Location = new System.Drawing.Point(11, 218);
            this.bttnPreBuild.Name = "bttnPreBuild";
            this.bttnPreBuild.Size = new System.Drawing.Size(315, 275);
            this.bttnPreBuild.TabIndex = 3;
            this.bttnPreBuild.Text = "Pre-Built";
            this.bttnPreBuild.UseVisualStyleBackColor = true;
            this.bttnPreBuild.Click += new System.EventHandler(this.bttnPreBuild_Click);
            // 
            // bttnFreeBuild
            // 
            this.bttnFreeBuild.FlatAppearance.BorderSize = 0;
            this.bttnFreeBuild.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnFreeBuild.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnFreeBuild.ForeColor = System.Drawing.Color.White;
            this.bttnFreeBuild.Location = new System.Drawing.Point(11, 597);
            this.bttnFreeBuild.Name = "bttnFreeBuild";
            this.bttnFreeBuild.Size = new System.Drawing.Size(315, 225);
            this.bttnFreeBuild.TabIndex = 4;
            this.bttnFreeBuild.Text = "Free Build";
            this.bttnFreeBuild.UseVisualStyleBackColor = true;
            this.bttnFreeBuild.Click += new System.EventHandler(this.bttnFreeBuild_Click);
            // 
            // rtbInfo
            // 
            this.rtbInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rtbInfo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbInfo.ForeColor = System.Drawing.Color.White;
            this.rtbInfo.Location = new System.Drawing.Point(12, 498);
            this.rtbInfo.Name = "rtbInfo";
            this.rtbInfo.Size = new System.Drawing.Size(313, 94);
            this.rtbInfo.TabIndex = 5;
            this.rtbInfo.Text = "Select Pre-Built to view our pre assembled machines.\nSelect Free Build to build y" +
    "our own computer piece by piece.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(75, 469);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "LET\'S GET STARTED!";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = global::PCHawk.Properties.Resources.exit;
            this.button1.Location = new System.Drawing.Point(1071, 96);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 66);
            this.button1.TabIndex = 2;
            this.toolTipLog.SetToolTip(this.button1, "LogOut");
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // bttnAccount
            // 
            this.bttnAccount.BackColor = System.Drawing.Color.Black;
            this.bttnAccount.FlatAppearance.BorderSize = 0;
            this.bttnAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnAccount.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnAccount.ForeColor = System.Drawing.Color.White;
            this.bttnAccount.Image = global::PCHawk.Properties.Resources.user;
            this.bttnAccount.Location = new System.Drawing.Point(845, 96);
            this.bttnAccount.Name = "bttnAccount";
            this.bttnAccount.Size = new System.Drawing.Size(144, 66);
            this.bttnAccount.TabIndex = 1;
            this.toolTipAccount.SetToolTip(this.bttnAccount, "View Account Information");
            this.bttnAccount.UseVisualStyleBackColor = false;
            this.bttnAccount.Click += new System.EventHandler(this.bttnAccount_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.BackColor = System.Drawing.Color.Black;
            this.btnHelp.FlatAppearance.BorderSize = 0;
            this.btnHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHelp.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHelp.ForeColor = System.Drawing.Color.White;
            this.btnHelp.Image = global::PCHawk.Properties.Resources.info;
            this.btnHelp.Location = new System.Drawing.Point(868, 12);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(93, 66);
            this.btnHelp.TabIndex = 1;
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
            this.bttnCart.Image = global::PCHawk.Properties.Resources.shopping_cart__2_;
            this.bttnCart.Location = new System.Drawing.Point(967, 12);
            this.bttnCart.Name = "bttnCart";
            this.bttnCart.Size = new System.Drawing.Size(93, 66);
            this.bttnCart.TabIndex = 1;
            this.cartToolTip.SetToolTip(this.bttnCart, "View Cart");
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
            this.bttnExit.Image = global::PCHawk.Properties.Resources.power_button__2_;
            this.bttnExit.Location = new System.Drawing.Point(1063, 12);
            this.bttnExit.Name = "bttnExit";
            this.bttnExit.Size = new System.Drawing.Size(93, 66);
            this.bttnExit.TabIndex = 0;
            this.exitToolTip.SetToolTip(this.bttnExit, "Exit App");
            this.bttnExit.UseVisualStyleBackColor = false;
            this.bttnExit.Click += new System.EventHandler(this.bttnExit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PCHawk.Properties.Resources.banner;
            this.pictureBox1.Location = new System.Drawing.Point(175, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(528, 175);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // homeScreenControl1
            // 
            this.homeScreenControl1.BackColor = System.Drawing.Color.White;
            this.homeScreenControl1.Location = new System.Drawing.Point(0, 205);
            this.homeScreenControl1.Name = "homeScreenControl1";
            this.homeScreenControl1.Size = new System.Drawing.Size(839, 617);
            this.homeScreenControl1.TabIndex = 0;
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1168, 822);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rtbInfo);
            this.Controls.Add(this.bttnFreeBuild);
            this.Controls.Add(this.bttnPreBuild);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmHome";
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button bttnPreBuild;
        private System.Windows.Forms.Button bttnFreeBuild;
        private System.Windows.Forms.RichTextBox rtbInfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button bttnAccount;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Button bttnCart;
        private System.Windows.Forms.Button bttnExit;
        private System.Windows.Forms.ToolTip exitToolTip;
        private System.Windows.Forms.ToolTip toolTipHelp;
        private System.Windows.Forms.ToolTip cartToolTip;
        private System.Windows.Forms.ToolTip toolTipLog;
        private System.Windows.Forms.ToolTip toolTipAccount;
        private homeScreenControl homeScreenControl1;
    }
}