namespace FoneFixSYS
{
    partial class frmCOAMainMenu
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
            this.lblCarryOutAdmin = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnPaymentAnalysis = new System.Windows.Forms.Button();
            this.lblCustomerAnalysis = new System.Windows.Forms.Label();
            this.lblPaymentAnalysis = new System.Windows.Forms.Label();
            this.lblRecievePayment = new System.Windows.Forms.Label();
            this.lblIssueInvoice = new System.Windows.Forms.Label();
            this.btnCustomerAnalysis = new System.Windows.Forms.Button();
            this.btnRecievePayment = new System.Windows.Forms.Button();
            this.btnIssueInvoice = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCarryOutAdmin
            // 
            this.lblCarryOutAdmin.AutoSize = true;
            this.lblCarryOutAdmin.Font = new System.Drawing.Font("Lucida Console", 25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarryOutAdmin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.lblCarryOutAdmin.Location = new System.Drawing.Point(109, 59);
            this.lblCarryOutAdmin.Name = "lblCarryOutAdmin";
            this.lblCarryOutAdmin.Size = new System.Drawing.Size(315, 34);
            this.lblCarryOutAdmin.TabIndex = 20;
            this.lblCarryOutAdmin.Text = "Carry-Out-Admin";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(0, 0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 30;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(0, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 31;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 32;
            // 
            // btnPaymentAnalysis
            // 
            this.btnPaymentAnalysis.BackColor = System.Drawing.SystemColors.Control;
            this.btnPaymentAnalysis.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.btnPaymentAnalysis.Location = new System.Drawing.Point(493, 160);
            this.btnPaymentAnalysis.Name = "btnPaymentAnalysis";
            this.btnPaymentAnalysis.Size = new System.Drawing.Size(75, 75);
            this.btnPaymentAnalysis.TabIndex = 41;
            this.btnPaymentAnalysis.UseVisualStyleBackColor = false;
            this.btnPaymentAnalysis.Click += new System.EventHandler(this.btnStockAnalysis_Click);
            // 
            // lblCustomerAnalysis
            // 
            this.lblCustomerAnalysis.AutoSize = true;
            this.lblCustomerAnalysis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerAnalysis.Location = new System.Drawing.Point(329, 289);
            this.lblCustomerAnalysis.Name = "lblCustomerAnalysis";
            this.lblCustomerAnalysis.Size = new System.Drawing.Size(157, 20);
            this.lblCustomerAnalysis.TabIndex = 39;
            this.lblCustomerAnalysis.Text = "Customer Analysis";
            // 
            // lblPaymentAnalysis
            // 
            this.lblPaymentAnalysis.AutoSize = true;
            this.lblPaymentAnalysis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaymentAnalysis.Location = new System.Drawing.Point(329, 186);
            this.lblPaymentAnalysis.Name = "lblPaymentAnalysis";
            this.lblPaymentAnalysis.Size = new System.Drawing.Size(149, 20);
            this.lblPaymentAnalysis.TabIndex = 38;
            this.lblPaymentAnalysis.Text = "Payment Analysis";
            // 
            // lblRecievePayment
            // 
            this.lblRecievePayment.AutoSize = true;
            this.lblRecievePayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecievePayment.Location = new System.Drawing.Point(14, 289);
            this.lblRecievePayment.Name = "lblRecievePayment";
            this.lblRecievePayment.Size = new System.Drawing.Size(147, 20);
            this.lblRecievePayment.TabIndex = 36;
            this.lblRecievePayment.Text = "Recieve Payment";
            // 
            // lblIssueInvoice
            // 
            this.lblIssueInvoice.AutoSize = true;
            this.lblIssueInvoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIssueInvoice.Location = new System.Drawing.Point(14, 187);
            this.lblIssueInvoice.Name = "lblIssueInvoice";
            this.lblIssueInvoice.Size = new System.Drawing.Size(115, 20);
            this.lblIssueInvoice.TabIndex = 34;
            this.lblIssueInvoice.Text = "Issue Invoice";
            // 
            // btnCustomerAnalysis
            // 
            this.btnCustomerAnalysis.BackColor = System.Drawing.SystemColors.Control;
            this.btnCustomerAnalysis.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.btnCustomerAnalysis.Image = global::FoneFixSYS.Properties.Resources.Actions_view_refresh_icon;
            this.btnCustomerAnalysis.Location = new System.Drawing.Point(493, 264);
            this.btnCustomerAnalysis.Name = "btnCustomerAnalysis";
            this.btnCustomerAnalysis.Size = new System.Drawing.Size(75, 75);
            this.btnCustomerAnalysis.TabIndex = 40;
            this.btnCustomerAnalysis.UseVisualStyleBackColor = false;
            this.btnCustomerAnalysis.Click += new System.EventHandler(this.btnRepairAnalysis_Click);
            // 
            // btnRecievePayment
            // 
            this.btnRecievePayment.BackColor = System.Drawing.SystemColors.Control;
            this.btnRecievePayment.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.btnRecievePayment.Image = global::FoneFixSYS.Properties.Resources.Actions_edit_delete_icon;
            this.btnRecievePayment.Location = new System.Drawing.Point(194, 263);
            this.btnRecievePayment.Name = "btnRecievePayment";
            this.btnRecievePayment.Size = new System.Drawing.Size(75, 75);
            this.btnRecievePayment.TabIndex = 37;
            this.btnRecievePayment.UseVisualStyleBackColor = false;
            this.btnRecievePayment.Click += new System.EventHandler(this.button7_Click);
            // 
            // btnIssueInvoice
            // 
            this.btnIssueInvoice.BackColor = System.Drawing.SystemColors.Control;
            this.btnIssueInvoice.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.btnIssueInvoice.Image = global::FoneFixSYS.Properties.Resources.Alarm_Plus_icon1;
            this.btnIssueInvoice.Location = new System.Drawing.Point(194, 161);
            this.btnIssueInvoice.Name = "btnIssueInvoice";
            this.btnIssueInvoice.Size = new System.Drawing.Size(75, 75);
            this.btnIssueInvoice.TabIndex = 35;
            this.btnIssueInvoice.UseVisualStyleBackColor = false;
            this.btnIssueInvoice.Click += new System.EventHandler(this.button8_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.Control;
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnBack.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnBack.FlatAppearance.BorderSize = 20;
            this.btnBack.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnBack.Image = global::FoneFixSYS.Properties.Resources.Arrows_Back_icon;
            this.btnBack.Location = new System.Drawing.Point(0, 2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(80, 35);
            this.btnBack.TabIndex = 28;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.button4_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FoneFixSYS.Properties.Resources.COA1;
            this.pictureBox1.Location = new System.Drawing.Point(435, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(87, 82);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // frmCOAMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 401);
            this.Controls.Add(this.btnPaymentAnalysis);
            this.Controls.Add(this.btnCustomerAnalysis);
            this.Controls.Add(this.lblCustomerAnalysis);
            this.Controls.Add(this.lblPaymentAnalysis);
            this.Controls.Add(this.btnRecievePayment);
            this.Controls.Add(this.lblRecievePayment);
            this.Controls.Add(this.btnIssueInvoice);
            this.Controls.Add(this.lblIssueInvoice);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblCarryOutAdmin);
            this.Name = "frmCOAMainMenu";
            this.Text = "Carry_Out_Administration";
            this.Load += new System.EventHandler(this.Carry_Out_Administration_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblCarryOutAdmin;
        private System.Windows.Forms.Button btnPaymentAnalysis;
        private System.Windows.Forms.Button btnCustomerAnalysis;
        private System.Windows.Forms.Label lblCustomerAnalysis;
        private System.Windows.Forms.Label lblPaymentAnalysis;
        private System.Windows.Forms.Button btnRecievePayment;
        private System.Windows.Forms.Label lblRecievePayment;
        private System.Windows.Forms.Button btnIssueInvoice;
        private System.Windows.Forms.Label lblIssueInvoice;
    }
}