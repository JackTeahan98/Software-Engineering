namespace FoneFixSYS
{
    partial class frmCOAIssueInvoice
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
            this.grdAllCustomer = new System.Windows.Forms.DataGridView();
            this.txtNameEntered = new System.Windows.Forms.TextBox();
            this.btnSubmitCustomerID = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.grpRepairsDone = new System.Windows.Forms.GroupBox();
            this.btnIssueInvoice = new System.Windows.Forms.Button();
            this.lblTotalCostFill = new System.Windows.Forms.Label();
            this.lblTotalCost = new System.Windows.Forms.Label();
            this.grpRepairInfo = new System.Windows.Forms.GroupBox();
            this.lblRepairID = new System.Windows.Forms.Label();
            this.lblCostFill = new System.Windows.Forms.Label();
            this.lblCost = new System.Windows.Forms.Label();
            this.lblRepairIDFill = new System.Windows.Forms.Label();
            this.lblDescriptionFill = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.grdRepairs = new System.Windows.Forms.DataGridView();
            this.lblCustomerBalance = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblCustomerID = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grdAllCustomer)).BeginInit();
            this.grpRepairsDone.SuspendLayout();
            this.grpRepairInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdRepairs)).BeginInit();
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
            // grdAllCustomer
            // 
            this.grdAllCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdAllCustomer.Location = new System.Drawing.Point(120, 196);
            this.grdAllCustomer.Name = "grdAllCustomer";
            this.grdAllCustomer.ReadOnly = true;
            this.grdAllCustomer.Size = new System.Drawing.Size(447, 131);
            this.grdAllCustomer.TabIndex = 87;
            this.grdAllCustomer.Visible = false;
            this.grdAllCustomer.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdAllCustomer_CellClick);
            this.grdAllCustomer.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdAllCustomer_CellContentClick);
            // 
            // txtNameEntered
            // 
            this.txtNameEntered.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNameEntered.Location = new System.Drawing.Point(182, 147);
            this.txtNameEntered.Name = "txtNameEntered";
            this.txtNameEntered.Size = new System.Drawing.Size(174, 30);
            this.txtNameEntered.TabIndex = 81;
            // 
            // btnSubmitCustomerID
            // 
            this.btnSubmitCustomerID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmitCustomerID.Location = new System.Drawing.Point(362, 139);
            this.btnSubmitCustomerID.Name = "btnSubmitCustomerID";
            this.btnSubmitCustomerID.Size = new System.Drawing.Size(145, 45);
            this.btnSubmitCustomerID.TabIndex = 80;
            this.btnSubmitCustomerID.Text = "Search...";
            this.btnSubmitCustomerID.UseVisualStyleBackColor = true;
            this.btnSubmitCustomerID.Click += new System.EventHandler(this.btnSubmitCustomerID_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(227, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(270, 18);
            this.label1.TabIndex = 79;
            this.label1.Text = "Please Enter Customer Surname...";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(268, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 30);
            this.label2.TabIndex = 88;
            this.label2.Text = "Issue Invoice";
            // 
            // grpRepairsDone
            // 
            this.grpRepairsDone.Controls.Add(this.btnIssueInvoice);
            this.grpRepairsDone.Controls.Add(this.lblTotalCostFill);
            this.grpRepairsDone.Controls.Add(this.lblTotalCost);
            this.grpRepairsDone.Controls.Add(this.grpRepairInfo);
            this.grpRepairsDone.Controls.Add(this.lblPhoneNumber);
            this.grpRepairsDone.Controls.Add(this.grdRepairs);
            this.grpRepairsDone.Controls.Add(this.lblCustomerBalance);
            this.grpRepairsDone.Controls.Add(this.label4);
            this.grpRepairsDone.Controls.Add(this.lblSurname);
            this.grpRepairsDone.Controls.Add(this.label5);
            this.grpRepairsDone.Controls.Add(this.lblCustomerID);
            this.grpRepairsDone.Controls.Add(this.label6);
            this.grpRepairsDone.Controls.Add(this.label7);
            this.grpRepairsDone.Location = new System.Drawing.Point(29, 354);
            this.grpRepairsDone.Name = "grpRepairsDone";
            this.grpRepairsDone.Size = new System.Drawing.Size(621, 436);
            this.grpRepairsDone.TabIndex = 89;
            this.grpRepairsDone.TabStop = false;
            this.grpRepairsDone.Text = "Invoice";
            this.grpRepairsDone.Visible = false;
            this.grpRepairsDone.Enter += new System.EventHandler(this.grpRepairsDone_Enter);
            // 
            // btnIssueInvoice
            // 
            this.btnIssueInvoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIssueInvoice.Location = new System.Drawing.Point(418, 240);
            this.btnIssueInvoice.Name = "btnIssueInvoice";
            this.btnIssueInvoice.Size = new System.Drawing.Size(115, 36);
            this.btnIssueInvoice.TabIndex = 108;
            this.btnIssueInvoice.Text = "Issue Invoice";
            this.btnIssueInvoice.UseVisualStyleBackColor = true;
            this.btnIssueInvoice.Visible = false;
            this.btnIssueInvoice.Click += new System.EventHandler(this.btnIssueInvoice_Click);
            // 
            // lblTotalCostFill
            // 
            this.lblTotalCostFill.AutoSize = true;
            this.lblTotalCostFill.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCostFill.Location = new System.Drawing.Point(438, 197);
            this.lblTotalCostFill.Name = "lblTotalCostFill";
            this.lblTotalCostFill.Size = new System.Drawing.Size(0, 30);
            this.lblTotalCostFill.TabIndex = 107;
            this.lblTotalCostFill.Visible = false;
            // 
            // lblTotalCost
            // 
            this.lblTotalCost.AutoSize = true;
            this.lblTotalCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCost.Location = new System.Drawing.Point(396, 158);
            this.lblTotalCost.Name = "lblTotalCost";
            this.lblTotalCost.Size = new System.Drawing.Size(137, 30);
            this.lblTotalCost.TabIndex = 106;
            this.lblTotalCost.Text = "Total Cost:";
            this.lblTotalCost.Visible = false;
            // 
            // grpRepairInfo
            // 
            this.grpRepairInfo.BackColor = System.Drawing.Color.Transparent;
            this.grpRepairInfo.Controls.Add(this.lblRepairID);
            this.grpRepairInfo.Controls.Add(this.lblCostFill);
            this.grpRepairInfo.Controls.Add(this.lblCost);
            this.grpRepairInfo.Controls.Add(this.lblRepairIDFill);
            this.grpRepairInfo.Controls.Add(this.lblDescriptionFill);
            this.grpRepairInfo.Controls.Add(this.lblDescription);
            this.grpRepairInfo.Location = new System.Drawing.Point(13, 295);
            this.grpRepairInfo.Name = "grpRepairInfo";
            this.grpRepairInfo.Size = new System.Drawing.Size(591, 123);
            this.grpRepairInfo.TabIndex = 105;
            this.grpRepairInfo.TabStop = false;
            this.grpRepairInfo.Text = "CURRENT REPAIR";
            this.grpRepairInfo.Visible = false;
            this.grpRepairInfo.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lblRepairID
            // 
            this.lblRepairID.AutoSize = true;
            this.lblRepairID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRepairID.Location = new System.Drawing.Point(6, 28);
            this.lblRepairID.Name = "lblRepairID";
            this.lblRepairID.Size = new System.Drawing.Size(81, 20);
            this.lblRepairID.TabIndex = 98;
            this.lblRepairID.Text = "Repair ID:";
            // 
            // lblCostFill
            // 
            this.lblCostFill.AutoSize = true;
            this.lblCostFill.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCostFill.Location = new System.Drawing.Point(130, 57);
            this.lblCostFill.Name = "lblCostFill";
            this.lblCostFill.Size = new System.Drawing.Size(0, 20);
            this.lblCostFill.TabIndex = 104;
            // 
            // lblCost
            // 
            this.lblCost.AutoSize = true;
            this.lblCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCost.Location = new System.Drawing.Point(6, 57);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(46, 20);
            this.lblCost.TabIndex = 100;
            this.lblCost.Text = "Cost:";
            // 
            // lblRepairIDFill
            // 
            this.lblRepairIDFill.AutoSize = true;
            this.lblRepairIDFill.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRepairIDFill.Location = new System.Drawing.Point(130, 28);
            this.lblRepairIDFill.Name = "lblRepairIDFill";
            this.lblRepairIDFill.Size = new System.Drawing.Size(0, 20);
            this.lblRepairIDFill.TabIndex = 102;
            // 
            // lblDescriptionFill
            // 
            this.lblDescriptionFill.AutoSize = true;
            this.lblDescriptionFill.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescriptionFill.Location = new System.Drawing.Point(130, 91);
            this.lblDescriptionFill.Name = "lblDescriptionFill";
            this.lblDescriptionFill.Size = new System.Drawing.Size(0, 15);
            this.lblDescriptionFill.TabIndex = 103;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(6, 90);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(93, 20);
            this.lblDescription.TabIndex = 99;
            this.lblDescription.Text = "Description:";
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhoneNumber.Location = new System.Drawing.Point(142, 256);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(0, 20);
            this.lblPhoneNumber.TabIndex = 97;
            // 
            // grdRepairs
            // 
            this.grdRepairs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdRepairs.Location = new System.Drawing.Point(0, 25);
            this.grdRepairs.Name = "grdRepairs";
            this.grdRepairs.ReadOnly = true;
            this.grdRepairs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdRepairs.Size = new System.Drawing.Size(621, 117);
            this.grdRepairs.TabIndex = 88;
            this.grdRepairs.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdRepairs_CellClick);
            this.grdRepairs.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdRepairs_CellContentClick);
            // 
            // lblCustomerBalance
            // 
            this.lblCustomerBalance.AutoSize = true;
            this.lblCustomerBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerBalance.Location = new System.Drawing.Point(142, 226);
            this.lblCustomerBalance.Name = "lblCustomerBalance";
            this.lblCustomerBalance.Size = new System.Drawing.Size(0, 20);
            this.lblCustomerBalance.TabIndex = 96;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(19, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 20);
            this.label4.TabIndex = 90;
            this.label4.Text = "Customer ID:";
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSurname.Location = new System.Drawing.Point(142, 197);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(0, 20);
            this.lblSurname.TabIndex = 95;
            this.lblSurname.Click += new System.EventHandler(this.lblSurname_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(19, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 20);
            this.label5.TabIndex = 91;
            this.label5.Text = "Surname:";
            // 
            // lblCustomerID
            // 
            this.lblCustomerID.AutoSize = true;
            this.lblCustomerID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerID.Location = new System.Drawing.Point(142, 168);
            this.lblCustomerID.Name = "lblCustomerID";
            this.lblCustomerID.Size = new System.Drawing.Size(0, 20);
            this.lblCustomerID.TabIndex = 94;
            this.lblCustomerID.Click += new System.EventHandler(this.lblCustomerID_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(19, 226);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 20);
            this.label6.TabIndex = 92;
            this.label6.Text = "Balance:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(19, 252);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 20);
            this.label7.TabIndex = 93;
            this.label7.Text = "Phone Number:";
            // 
            // frmCOAIssueInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 857);
            this.Controls.Add(this.grpRepairsDone);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNameEntered);
            this.Controls.Add(this.grdAllCustomer);
            this.Controls.Add(this.btnSubmitCustomerID);
            this.Controls.Add(this.btnBackButton);
            this.Name = "frmCOAIssueInvoice";
            this.Text = "Issue Invoice";
            this.Load += new System.EventHandler(this.frmCOAIssueInvoice_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdAllCustomer)).EndInit();
            this.grpRepairsDone.ResumeLayout(false);
            this.grpRepairsDone.PerformLayout();
            this.grpRepairInfo.ResumeLayout(false);
            this.grpRepairInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdRepairs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBackButton;
        private System.Windows.Forms.DataGridView grdAllCustomer;
        private System.Windows.Forms.TextBox txtNameEntered;
        private System.Windows.Forms.Button btnSubmitCustomerID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox grpRepairsDone;
        private System.Windows.Forms.DataGridView grdRepairs;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.Label lblCustomerBalance;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label lblCustomerID;
        private System.Windows.Forms.Label lblCostFill;
        private System.Windows.Forms.Label lblRepairID;
        private System.Windows.Forms.Label lblDescriptionFill;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblRepairIDFill;
        private System.Windows.Forms.Label lblCost;
        private System.Windows.Forms.GroupBox grpRepairInfo;
        private System.Windows.Forms.Label lblTotalCostFill;
        private System.Windows.Forms.Label lblTotalCost;
        private System.Windows.Forms.Button btnIssueInvoice;
    }
}