namespace FoneFixSYS
{
    partial class frm11Issuenvoice
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
            this.lblIssueInvoice = new System.Windows.Forms.Label();
            this.lblTotalCost = new System.Windows.Forms.Label();
            this.txtTotalCost = new System.Windows.Forms.TextBox();
            this.btnSendInvoice = new System.Windows.Forms.Button();
            this.btnBackButton = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblIssueInvoice
            // 
            this.lblIssueInvoice.AutoSize = true;
            this.lblIssueInvoice.Font = new System.Drawing.Font("MS Reference Sans Serif", 22F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIssueInvoice.Location = new System.Drawing.Point(87, 39);
            this.lblIssueInvoice.Name = "lblIssueInvoice";
            this.lblIssueInvoice.Size = new System.Drawing.Size(234, 38);
            this.lblIssueInvoice.TabIndex = 57;
            this.lblIssueInvoice.Text = "Issue Invoice";
            // 
            // lblTotalCost
            // 
            this.lblTotalCost.AutoSize = true;
            this.lblTotalCost.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCost.Location = new System.Drawing.Point(32, 173);
            this.lblTotalCost.Name = "lblTotalCost";
            this.lblTotalCost.Size = new System.Drawing.Size(119, 20);
            this.lblTotalCost.TabIndex = 61;
            this.lblTotalCost.Text = "Total Cost :";
            // 
            // txtTotalCost
            // 
            this.txtTotalCost.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalCost.Location = new System.Drawing.Point(158, 166);
            this.txtTotalCost.Name = "txtTotalCost";
            this.txtTotalCost.Size = new System.Drawing.Size(113, 27);
            this.txtTotalCost.TabIndex = 60;
            // 
            // btnSendInvoice
            // 
            this.btnSendInvoice.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSendInvoice.Location = new System.Drawing.Point(105, 216);
            this.btnSendInvoice.Name = "btnSendInvoice";
            this.btnSendInvoice.Size = new System.Drawing.Size(169, 55);
            this.btnSendInvoice.TabIndex = 62;
            this.btnSendInvoice.Text = "Send Invoice";
            this.btnSendInvoice.UseVisualStyleBackColor = true;
            this.btnSendInvoice.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnBackButton
            // 
            this.btnBackButton.BackColor = System.Drawing.SystemColors.Control;
            this.btnBackButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnBackButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnBackButton.FlatAppearance.BorderSize = 20;
            this.btnBackButton.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnBackButton.Image = global::FoneFixSYS.Properties.Resources.Arrows_Back_icon;
            this.btnBackButton.Location = new System.Drawing.Point(0, 2);
            this.btnBackButton.Name = "btnBackButton";
            this.btnBackButton.Size = new System.Drawing.Size(80, 35);
            this.btnBackButton.TabIndex = 53;
            this.btnBackButton.UseVisualStyleBackColor = false;
            this.btnBackButton.Click += new System.EventHandler(this.button4_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Name   :   Repair ID 189   :  Samsing Screen",
            "Name   :   Repair ID 12     :  IphoneScreen",
            "Name   :   Repair ID 1009 :  nokia battery"});
            this.comboBox1.Location = new System.Drawing.Point(94, 109);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(212, 21);
            this.comboBox1.TabIndex = 63;
            // 
            // frm11Issuenvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 279);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnSendInvoice);
            this.Controls.Add(this.lblTotalCost);
            this.Controls.Add(this.txtTotalCost);
            this.Controls.Add(this.lblIssueInvoice);
            this.Controls.Add(this.btnBackButton);
            this.Name = "frm11Issuenvoice";
            this.Text = "Issuenvoice";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBackButton;
        private System.Windows.Forms.Label lblIssueInvoice;
        private System.Windows.Forms.Label lblTotalCost;
        private System.Windows.Forms.TextBox txtTotalCost;
        private System.Windows.Forms.Button btnSendInvoice;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}