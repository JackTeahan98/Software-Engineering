namespace FoneFixSYS
{
    partial class frmIssuenvoice
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
            this.btnBackButton = new System.Windows.Forms.Button();
            this.lblRepairID = new System.Windows.Forms.Label();
            this.txtRepairID = new System.Windows.Forms.TextBox();
            this.txtCustomerID = new System.Windows.Forms.TextBox();
            this.lblIssueInvoice = new System.Windows.Forms.Label();
            this.lblCustomerID = new System.Windows.Forms.Label();
            this.lblTotalCost = new System.Windows.Forms.Label();
            this.txtTotalCost = new System.Windows.Forms.TextBox();
            this.btnSendInvoice = new System.Windows.Forms.Button();
            this.SuspendLayout();
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
            // lblRepairID
            // 
            this.lblRepairID.AutoSize = true;
            this.lblRepairID.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRepairID.Location = new System.Drawing.Point(60, 103);
            this.lblRepairID.Name = "lblRepairID";
            this.lblRepairID.Size = new System.Drawing.Size(95, 20);
            this.lblRepairID.TabIndex = 55;
            this.lblRepairID.Text = "Repair ID";
            // 
            // txtRepairID
            // 
            this.txtRepairID.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRepairID.Location = new System.Drawing.Point(158, 98);
            this.txtRepairID.Name = "txtRepairID";
            this.txtRepairID.Size = new System.Drawing.Size(71, 27);
            this.txtRepairID.TabIndex = 54;
            // 
            // txtCustomerID
            // 
            this.txtCustomerID.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerID.Location = new System.Drawing.Point(158, 144);
            this.txtCustomerID.Name = "txtCustomerID";
            this.txtCustomerID.Size = new System.Drawing.Size(71, 27);
            this.txtCustomerID.TabIndex = 56;
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
            // lblCustomerID
            // 
            this.lblCustomerID.AutoSize = true;
            this.lblCustomerID.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerID.Location = new System.Drawing.Point(32, 149);
            this.lblCustomerID.Name = "lblCustomerID";
            this.lblCustomerID.Size = new System.Drawing.Size(123, 20);
            this.lblCustomerID.TabIndex = 59;
            this.lblCustomerID.Text = "Customer ID";
            // 
            // lblTotalCost
            // 
            this.lblTotalCost.AutoSize = true;
            this.lblTotalCost.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCost.Location = new System.Drawing.Point(32, 251);
            this.lblTotalCost.Name = "lblTotalCost";
            this.lblTotalCost.Size = new System.Drawing.Size(119, 20);
            this.lblTotalCost.TabIndex = 61;
            this.lblTotalCost.Text = "Total Cost :";
            // 
            // txtTotalCost
            // 
            this.txtTotalCost.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalCost.Location = new System.Drawing.Point(158, 244);
            this.txtTotalCost.Name = "txtTotalCost";
            this.txtTotalCost.Size = new System.Drawing.Size(113, 27);
            this.txtTotalCost.TabIndex = 60;
            // 
            // btnSendInvoice
            // 
            this.btnSendInvoice.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSendInvoice.Location = new System.Drawing.Point(105, 294);
            this.btnSendInvoice.Name = "btnSendInvoice";
            this.btnSendInvoice.Size = new System.Drawing.Size(169, 55);
            this.btnSendInvoice.TabIndex = 62;
            this.btnSendInvoice.Text = "Send Invoice";
            this.btnSendInvoice.UseVisualStyleBackColor = true;
            this.btnSendInvoice.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmIssuenvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.btnSendInvoice);
            this.Controls.Add(this.lblTotalCost);
            this.Controls.Add(this.txtTotalCost);
            this.Controls.Add(this.lblCustomerID);
            this.Controls.Add(this.lblIssueInvoice);
            this.Controls.Add(this.txtCustomerID);
            this.Controls.Add(this.lblRepairID);
            this.Controls.Add(this.txtRepairID);
            this.Controls.Add(this.btnBackButton);
            this.Name = "frmIssuenvoice";
            this.Text = "Issuenvoice";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBackButton;
        private System.Windows.Forms.Label lblRepairID;
        private System.Windows.Forms.TextBox txtRepairID;
        private System.Windows.Forms.TextBox txtCustomerID;
        private System.Windows.Forms.Label lblIssueInvoice;
        private System.Windows.Forms.Label lblCustomerID;
        private System.Windows.Forms.Label lblTotalCost;
        private System.Windows.Forms.TextBox txtTotalCost;
        private System.Windows.Forms.Button btnSendInvoice;
    }
}