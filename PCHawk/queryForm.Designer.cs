namespace PCHawk
{
    partial class queryForm
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
            this.bttnTwoTable = new System.Windows.Forms.Button();
            this.bttnThreeTable = new System.Windows.Forms.Button();
            this.bttnAvg = new System.Windows.Forms.Button();
            this.bttnExit = new System.Windows.Forms.Button();
            this.displayBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // bttnTwoTable
            // 
            this.bttnTwoTable.Location = new System.Drawing.Point(12, 212);
            this.bttnTwoTable.Name = "bttnTwoTable";
            this.bttnTwoTable.Size = new System.Drawing.Size(127, 75);
            this.bttnTwoTable.TabIndex = 0;
            this.bttnTwoTable.Text = "Two Table Join";
            this.bttnTwoTable.UseVisualStyleBackColor = true;
            // 
            // bttnThreeTable
            // 
            this.bttnThreeTable.Location = new System.Drawing.Point(12, 293);
            this.bttnThreeTable.Name = "bttnThreeTable";
            this.bttnThreeTable.Size = new System.Drawing.Size(127, 75);
            this.bttnThreeTable.TabIndex = 1;
            this.bttnThreeTable.Text = "Three Table Join";
            this.bttnThreeTable.UseVisualStyleBackColor = true;
            // 
            // bttnAvg
            // 
            this.bttnAvg.Location = new System.Drawing.Point(12, 374);
            this.bttnAvg.Name = "bttnAvg";
            this.bttnAvg.Size = new System.Drawing.Size(127, 75);
            this.bttnAvg.TabIndex = 2;
            this.bttnAvg.Text = "Average Price";
            this.bttnAvg.UseVisualStyleBackColor = true;
            // 
            // bttnExit
            // 
            this.bttnExit.Location = new System.Drawing.Point(12, 42);
            this.bttnExit.Name = "bttnExit";
            this.bttnExit.Size = new System.Drawing.Size(127, 64);
            this.bttnExit.TabIndex = 3;
            this.bttnExit.Text = "Close Page";
            this.bttnExit.UseVisualStyleBackColor = true;
            this.bttnExit.Click += new System.EventHandler(this.bttnExit_Click);
            // 
            // displayBox
            // 
            this.displayBox.Location = new System.Drawing.Point(145, 42);
            this.displayBox.Name = "displayBox";
            this.displayBox.Size = new System.Drawing.Size(553, 407);
            this.displayBox.TabIndex = 4;
            this.displayBox.Text = "";
            // 
            // queryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(734, 461);
            this.Controls.Add(this.displayBox);
            this.Controls.Add(this.bttnExit);
            this.Controls.Add(this.bttnAvg);
            this.Controls.Add(this.bttnThreeTable);
            this.Controls.Add(this.bttnTwoTable);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "queryForm";
            this.Text = "queryForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bttnTwoTable;
        private System.Windows.Forms.Button bttnThreeTable;
        private System.Windows.Forms.Button bttnAvg;
        private System.Windows.Forms.Button bttnExit;
        private System.Windows.Forms.RichTextBox displayBox;
    }
}