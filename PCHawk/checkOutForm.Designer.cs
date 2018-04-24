namespace PCHawk
{
    /// <summary>
    /// DO NOT TOUCH
    /// </summary>
    partial class checkOutForm
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bttnAccount = new System.Windows.Forms.Button();
            this.bttnLogout = new System.Windows.Forms.Button();
            this.btnHelp = new System.Windows.Forms.Button();
            this.bttnExit = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cartContentsBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.totalBoxPrice = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxFirst = new System.Windows.Forms.TextBox();
            this.txtBoxLast = new System.Windows.Forms.TextBox();
            this.txtBoxAddress = new System.Windows.Forms.TextBox();
            this.txtBoxCity = new System.Windows.Forms.TextBox();
            this.txtBoxState = new System.Windows.Forms.TextBox();
            this.txtBoxZip = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBoxFirstBilling = new System.Windows.Forms.TextBox();
            this.txtBoxLastBilling = new System.Windows.Forms.TextBox();
            this.txtBoxAddressBilling = new System.Windows.Forms.TextBox();
            this.txtBoxCityBilling = new System.Windows.Forms.TextBox();
            this.txtBoxStateBilling = new System.Windows.Forms.TextBox();
            this.txtBoxZipBilling = new System.Windows.Forms.TextBox();
            this.bttnSame = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBoxFirstPay = new System.Windows.Forms.TextBox();
            this.txtBoxLastPay = new System.Windows.Forms.TextBox();
            this.txtBoxCardNum = new System.Windows.Forms.TextBox();
            this.txtBoxExpiration = new System.Windows.Forms.TextBox();
            this.txtBoxSvv = new System.Windows.Forms.TextBox();
            this.bttnOrdered = new System.Windows.Forms.Button();
            this.toolTipHelp = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipPower = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipHome = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipAccount = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipLogOut = new System.Windows.Forms.ToolTip(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.bttnHome);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.bttnAccount);
            this.panel1.Controls.Add(this.bttnLogout);
            this.panel1.Controls.Add(this.btnHelp);
            this.panel1.Controls.Add(this.bttnExit);
            this.panel1.Location = new System.Drawing.Point(-1, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1058, 163);
            this.panel1.TabIndex = 1;
            // 
            // bttnHome
            // 
            this.bttnHome.BackColor = System.Drawing.Color.Black;
            this.bttnHome.FlatAppearance.BorderSize = 0;
            this.bttnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnHome.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnHome.ForeColor = System.Drawing.Color.White;
            this.bttnHome.Image = global::PCHawk.Properties.Resources.home__1_;
            this.bttnHome.Location = new System.Drawing.Point(764, 90);
            this.bttnHome.Name = "bttnHome";
            this.bttnHome.Size = new System.Drawing.Size(67, 66);
            this.bttnHome.TabIndex = 10;
            this.toolTipHome.SetToolTip(this.bttnHome, "Home");
            this.bttnHome.UseVisualStyleBackColor = false;
            this.bttnHome.Click += new System.EventHandler(this.bttnHome_Click);
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
            // bttnAccount
            // 
            this.bttnAccount.BackColor = System.Drawing.Color.Black;
            this.bttnAccount.FlatAppearance.BorderSize = 0;
            this.bttnAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnAccount.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnAccount.ForeColor = System.Drawing.Color.White;
            this.bttnAccount.Image = global::PCHawk.Properties.Resources.user;
            this.bttnAccount.Location = new System.Drawing.Point(869, 90);
            this.bttnAccount.Name = "bttnAccount";
            this.bttnAccount.Size = new System.Drawing.Size(65, 66);
            this.bttnAccount.TabIndex = 11;
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
            this.bttnLogout.Location = new System.Drawing.Point(971, 90);
            this.bttnLogout.Name = "bttnLogout";
            this.bttnLogout.Size = new System.Drawing.Size(69, 66);
            this.bttnLogout.TabIndex = 12;
            this.toolTipLogOut.SetToolTip(this.bttnLogout, "Logout");
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
            this.btnHelp.Location = new System.Drawing.Point(869, 3);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(65, 66);
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
            this.bttnExit.Location = new System.Drawing.Point(971, 3);
            this.bttnExit.Name = "bttnExit";
            this.bttnExit.Size = new System.Drawing.Size(69, 66);
            this.bttnExit.TabIndex = 6;
            this.toolTipPower.SetToolTip(this.bttnExit, "Exit Application");
            this.bttnExit.UseVisualStyleBackColor = false;
            this.bttnExit.Click += new System.EventHandler(this.bttnExit_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Teal;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1054, 22);
            this.panel2.TabIndex = 2;
            // 
            // cartContentsBox
            // 
            this.cartContentsBox.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cartContentsBox.FormattingEnabled = true;
            this.cartContentsBox.ItemHeight = 20;
            this.cartContentsBox.Location = new System.Drawing.Point(12, 214);
            this.cartContentsBox.Name = "cartContentsBox";
            this.cartContentsBox.Size = new System.Drawing.Size(306, 304);
            this.cartContentsBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(38, 521);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "TOTAL COST:";
            // 
            // totalBoxPrice
            // 
            this.totalBoxPrice.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalBoxPrice.Location = new System.Drawing.Point(133, 521);
            this.totalBoxPrice.Name = "totalBoxPrice";
            this.totalBoxPrice.ReadOnly = true;
            this.totalBoxPrice.Size = new System.Drawing.Size(185, 23);
            this.totalBoxPrice.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 18);
            this.label2.TabIndex = 7;
            this.label2.Text = "Your Cart Contents:";
            // 
            // txtBoxFirst
            // 
            this.txtBoxFirst.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxFirst.Location = new System.Drawing.Point(405, 214);
            this.txtBoxFirst.Name = "txtBoxFirst";
            this.txtBoxFirst.Size = new System.Drawing.Size(145, 26);
            this.txtBoxFirst.TabIndex = 8;
            this.txtBoxFirst.Text = "First Name";
            // 
            // txtBoxLast
            // 
            this.txtBoxLast.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxLast.Location = new System.Drawing.Point(556, 214);
            this.txtBoxLast.Name = "txtBoxLast";
            this.txtBoxLast.Size = new System.Drawing.Size(145, 26);
            this.txtBoxLast.TabIndex = 9;
            this.txtBoxLast.Text = "Last Name";
            // 
            // txtBoxAddress
            // 
            this.txtBoxAddress.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxAddress.Location = new System.Drawing.Point(405, 246);
            this.txtBoxAddress.Name = "txtBoxAddress";
            this.txtBoxAddress.Size = new System.Drawing.Size(296, 26);
            this.txtBoxAddress.TabIndex = 11;
            this.txtBoxAddress.Text = "Address";
            // 
            // txtBoxCity
            // 
            this.txtBoxCity.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxCity.Location = new System.Drawing.Point(405, 278);
            this.txtBoxCity.Name = "txtBoxCity";
            this.txtBoxCity.Size = new System.Drawing.Size(296, 26);
            this.txtBoxCity.TabIndex = 12;
            this.txtBoxCity.Text = "City";
            // 
            // txtBoxState
            // 
            this.txtBoxState.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxState.Location = new System.Drawing.Point(405, 310);
            this.txtBoxState.Name = "txtBoxState";
            this.txtBoxState.Size = new System.Drawing.Size(145, 26);
            this.txtBoxState.TabIndex = 13;
            this.txtBoxState.Text = "State";
            // 
            // txtBoxZip
            // 
            this.txtBoxZip.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxZip.Location = new System.Drawing.Point(556, 310);
            this.txtBoxZip.Name = "txtBoxZip";
            this.txtBoxZip.Size = new System.Drawing.Size(144, 26);
            this.txtBoxZip.TabIndex = 15;
            this.txtBoxZip.Text = "Zip Code";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Yellow;
            this.label3.Location = new System.Drawing.Point(402, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 18);
            this.label3.TabIndex = 16;
            this.label3.Text = "Shipping Address:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Yellow;
            this.label4.Location = new System.Drawing.Point(402, 342);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 18);
            this.label4.TabIndex = 17;
            this.label4.Text = "Billing Address:";
            // 
            // txtBoxFirstBilling
            // 
            this.txtBoxFirstBilling.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxFirstBilling.Location = new System.Drawing.Point(405, 378);
            this.txtBoxFirstBilling.Name = "txtBoxFirstBilling";
            this.txtBoxFirstBilling.Size = new System.Drawing.Size(145, 26);
            this.txtBoxFirstBilling.TabIndex = 18;
            this.txtBoxFirstBilling.Text = "First Name";
            // 
            // txtBoxLastBilling
            // 
            this.txtBoxLastBilling.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxLastBilling.Location = new System.Drawing.Point(556, 378);
            this.txtBoxLastBilling.Name = "txtBoxLastBilling";
            this.txtBoxLastBilling.Size = new System.Drawing.Size(145, 26);
            this.txtBoxLastBilling.TabIndex = 19;
            this.txtBoxLastBilling.Text = "Last Name";
            // 
            // txtBoxAddressBilling
            // 
            this.txtBoxAddressBilling.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxAddressBilling.Location = new System.Drawing.Point(405, 410);
            this.txtBoxAddressBilling.Name = "txtBoxAddressBilling";
            this.txtBoxAddressBilling.Size = new System.Drawing.Size(296, 26);
            this.txtBoxAddressBilling.TabIndex = 20;
            this.txtBoxAddressBilling.Text = "Address";
            // 
            // txtBoxCityBilling
            // 
            this.txtBoxCityBilling.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxCityBilling.Location = new System.Drawing.Point(405, 442);
            this.txtBoxCityBilling.Name = "txtBoxCityBilling";
            this.txtBoxCityBilling.Size = new System.Drawing.Size(296, 26);
            this.txtBoxCityBilling.TabIndex = 21;
            this.txtBoxCityBilling.Text = "City";
            // 
            // txtBoxStateBilling
            // 
            this.txtBoxStateBilling.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxStateBilling.Location = new System.Drawing.Point(405, 474);
            this.txtBoxStateBilling.Name = "txtBoxStateBilling";
            this.txtBoxStateBilling.Size = new System.Drawing.Size(145, 26);
            this.txtBoxStateBilling.TabIndex = 22;
            this.txtBoxStateBilling.Text = "State";
            // 
            // txtBoxZipBilling
            // 
            this.txtBoxZipBilling.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxZipBilling.Location = new System.Drawing.Point(556, 474);
            this.txtBoxZipBilling.Name = "txtBoxZipBilling";
            this.txtBoxZipBilling.Size = new System.Drawing.Size(144, 26);
            this.txtBoxZipBilling.TabIndex = 23;
            this.txtBoxZipBilling.Text = "Zip Code";
            // 
            // bttnSame
            // 
            this.bttnSame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnSame.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnSame.ForeColor = System.Drawing.Color.White;
            this.bttnSame.Location = new System.Drawing.Point(520, 342);
            this.bttnSame.Name = "bttnSame";
            this.bttnSame.Size = new System.Drawing.Size(180, 30);
            this.bttnSame.TabIndex = 24;
            this.bttnSame.Text = "Same as Shipping";
            this.bttnSame.UseVisualStyleBackColor = true;
            this.bttnSame.Click += new System.EventHandler(this.bttnSame_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Yellow;
            this.label5.Location = new System.Drawing.Point(740, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(163, 18);
            this.label5.TabIndex = 25;
            this.label5.Text = "Payment Information:";
            // 
            // txtBoxFirstPay
            // 
            this.txtBoxFirstPay.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxFirstPay.Location = new System.Drawing.Point(743, 235);
            this.txtBoxFirstPay.Name = "txtBoxFirstPay";
            this.txtBoxFirstPay.Size = new System.Drawing.Size(145, 26);
            this.txtBoxFirstPay.TabIndex = 26;
            // 
            // txtBoxLastPay
            // 
            this.txtBoxLastPay.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxLastPay.Location = new System.Drawing.Point(894, 235);
            this.txtBoxLastPay.Name = "txtBoxLastPay";
            this.txtBoxLastPay.Size = new System.Drawing.Size(145, 26);
            this.txtBoxLastPay.TabIndex = 27;
            // 
            // txtBoxCardNum
            // 
            this.txtBoxCardNum.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxCardNum.Location = new System.Drawing.Point(743, 299);
            this.txtBoxCardNum.Name = "txtBoxCardNum";
            this.txtBoxCardNum.Size = new System.Drawing.Size(296, 26);
            this.txtBoxCardNum.TabIndex = 28;
            this.txtBoxCardNum.TextChanged += new System.EventHandler(this.txtBoxCardNum_TextChanged);
            // 
            // txtBoxExpiration
            // 
            this.txtBoxExpiration.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxExpiration.Location = new System.Drawing.Point(743, 358);
            this.txtBoxExpiration.Name = "txtBoxExpiration";
            this.txtBoxExpiration.Size = new System.Drawing.Size(170, 26);
            this.txtBoxExpiration.TabIndex = 29;
            this.txtBoxExpiration.TextChanged += new System.EventHandler(this.txtBoxExpiration_TextChanged);
            // 
            // txtBoxSvv
            // 
            this.txtBoxSvv.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxSvv.Location = new System.Drawing.Point(922, 358);
            this.txtBoxSvv.Name = "txtBoxSvv";
            this.txtBoxSvv.Size = new System.Drawing.Size(118, 26);
            this.txtBoxSvv.TabIndex = 30;
            this.txtBoxSvv.TextChanged += new System.EventHandler(this.txtBoxSvv_TextChanged);
            // 
            // bttnOrdered
            // 
            this.bttnOrdered.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnOrdered.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnOrdered.ForeColor = System.Drawing.Color.Yellow;
            this.bttnOrdered.Location = new System.Drawing.Point(743, 390);
            this.bttnOrdered.Name = "bttnOrdered";
            this.bttnOrdered.Size = new System.Drawing.Size(296, 62);
            this.bttnOrdered.TabIndex = 31;
            this.bttnOrdered.Text = "Submit Order";
            this.bttnOrdered.UseVisualStyleBackColor = true;
            this.bttnOrdered.Click += new System.EventHandler(this.bttnOrdered_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Yellow;
            this.label6.Location = new System.Drawing.Point(740, 337);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(173, 18);
            this.label6.TabIndex = 32;
            this.label6.Text = "Expiration Date mmyy:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Yellow;
            this.label7.Location = new System.Drawing.Point(919, 337);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 18);
            this.label7.TabIndex = 33;
            this.label7.Text = "CVV:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Yellow;
            this.label8.Location = new System.Drawing.Point(740, 278);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(161, 18);
            this.label8.TabIndex = 34;
            this.label8.Text = "Credit Card Number:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Yellow;
            this.label9.Location = new System.Drawing.Point(743, 214);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 18);
            this.label9.TabIndex = 35;
            this.label9.Text = "First Name:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Yellow;
            this.label10.Location = new System.Drawing.Point(891, 211);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(88, 18);
            this.label10.TabIndex = 36;
            this.label10.Text = "Last Name:";
            // 
            // checkOutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1054, 600);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.bttnOrdered);
            this.Controls.Add(this.txtBoxSvv);
            this.Controls.Add(this.txtBoxExpiration);
            this.Controls.Add(this.txtBoxCardNum);
            this.Controls.Add(this.txtBoxLastPay);
            this.Controls.Add(this.txtBoxFirstPay);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.bttnSame);
            this.Controls.Add(this.txtBoxZipBilling);
            this.Controls.Add(this.txtBoxStateBilling);
            this.Controls.Add(this.txtBoxCityBilling);
            this.Controls.Add(this.txtBoxAddressBilling);
            this.Controls.Add(this.txtBoxLastBilling);
            this.Controls.Add(this.txtBoxFirstBilling);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBoxZip);
            this.Controls.Add(this.txtBoxState);
            this.Controls.Add(this.txtBoxCity);
            this.Controls.Add(this.txtBoxAddress);
            this.Controls.Add(this.txtBoxLast);
            this.Controls.Add(this.txtBoxFirst);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.totalBoxPrice);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cartContentsBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "checkOutForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "checkOutForm";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bttnHome;
        private System.Windows.Forms.Button bttnAccount;
        private System.Windows.Forms.Button bttnLogout;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Button bttnExit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListBox cartContentsBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox totalBoxPrice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBoxFirst;
        private System.Windows.Forms.TextBox txtBoxLast;
        private System.Windows.Forms.TextBox txtBoxAddress;
        private System.Windows.Forms.TextBox txtBoxCity;
        private System.Windows.Forms.TextBox txtBoxState;
        private System.Windows.Forms.TextBox txtBoxZip;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBoxFirstBilling;
        private System.Windows.Forms.TextBox txtBoxLastBilling;
        private System.Windows.Forms.TextBox txtBoxAddressBilling;
        private System.Windows.Forms.TextBox txtBoxCityBilling;
        private System.Windows.Forms.TextBox txtBoxStateBilling;
        private System.Windows.Forms.TextBox txtBoxZipBilling;
        private System.Windows.Forms.Button bttnSame;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBoxFirstPay;
        private System.Windows.Forms.TextBox txtBoxLastPay;
        private System.Windows.Forms.TextBox txtBoxCardNum;
        private System.Windows.Forms.TextBox txtBoxExpiration;
        private System.Windows.Forms.TextBox txtBoxSvv;
        private System.Windows.Forms.Button bttnOrdered;
        private System.Windows.Forms.ToolTip toolTipHelp;
        private System.Windows.Forms.ToolTip toolTipPower;
        private System.Windows.Forms.ToolTip toolTipHome;
        private System.Windows.Forms.ToolTip toolTipAccount;
        private System.Windows.Forms.ToolTip toolTipLogOut;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}