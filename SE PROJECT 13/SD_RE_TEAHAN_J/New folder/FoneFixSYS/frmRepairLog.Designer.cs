namespace FoneFixSYS
{
    partial class frmRepairLog
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
            this.btnBackButton = new System.Windows.Forms.Button();
            this.imgPlus = new System.Windows.Forms.PictureBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.txtCustomerID = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtPhoneSerialNumber = new System.Windows.Forms.TextBox();
            this.lblDescrpition = new System.Windows.Forms.Label();
            this.lblCustomerID = new System.Windows.Forms.Label();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblPhoneSerialNumber = new System.Windows.Forms.Label();
            this.txtRepairID = new System.Windows.Forms.TextBox();
            this.lblRepairID = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label9 = new System.Windows.Forms.Label();
            this.cbbDescription = new System.Windows.Forms.ComboBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.grdgetRepairDetails = new System.Windows.Forms.DataGridView();
            this.grpRepairDetails = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbophonetype = new System.Windows.Forms.ComboBox();
            this.txtphonetype = new System.Windows.Forms.Label();
            this.txtCost = new System.Windows.Forms.TextBox();
            this.lblCost = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imgPlus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdgetRepairDetails)).BeginInit();
            this.grpRepairDetails.SuspendLayout();
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
            this.btnBackButton.Size = new System.Drawing.Size(80, 32);
            this.btnBackButton.TabIndex = 76;
            this.btnBackButton.UseVisualStyleBackColor = false;
            this.btnBackButton.Click += new System.EventHandler(this.button4_Click);
            // 
            // imgPlus
            // 
            this.imgPlus.Image = global::FoneFixSYS.Properties.Resources.Alarm_Plus_icon1;
            this.imgPlus.Location = new System.Drawing.Point(861, 5);
            this.imgPlus.Name = "imgPlus";
            this.imgPlus.Size = new System.Drawing.Size(101, 82);
            this.imgPlus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgPlus.TabIndex = 75;
            this.imgPlus.TabStop = false;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(399, 436);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(169, 51);
            this.btnSubmit.TabIndex = 74;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Visible = false;
            this.btnSubmit.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtCustomerID
            // 
            this.txtCustomerID.Enabled = false;
            this.txtCustomerID.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerID.Location = new System.Drawing.Point(231, 344);
            this.txtCustomerID.Name = "txtCustomerID";
            this.txtCustomerID.Size = new System.Drawing.Size(60, 23);
            this.txtCustomerID.TabIndex = 62;
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(204, 71);
            this.txtPassword.MaxLength = 20;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(113, 21);
            this.txtPassword.TabIndex = 61;
            // 
            // txtPhoneSerialNumber
            // 
            this.txtPhoneSerialNumber.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhoneSerialNumber.Location = new System.Drawing.Point(204, 41);
            this.txtPhoneSerialNumber.MaxLength = 20;
            this.txtPhoneSerialNumber.Name = "txtPhoneSerialNumber";
            this.txtPhoneSerialNumber.Size = new System.Drawing.Size(113, 21);
            this.txtPhoneSerialNumber.TabIndex = 60;
            // 
            // lblDescrpition
            // 
            this.lblDescrpition.AutoSize = true;
            this.lblDescrpition.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescrpition.Location = new System.Drawing.Point(34, 164);
            this.lblDescrpition.Name = "lblDescrpition";
            this.lblDescrpition.Size = new System.Drawing.Size(92, 16);
            this.lblDescrpition.TabIndex = 59;
            this.lblDescrpition.Text = "Description";
            // 
            // lblCustomerID
            // 
            this.lblCustomerID.AutoSize = true;
            this.lblCustomerID.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerID.Location = new System.Drawing.Point(62, 348);
            this.lblCustomerID.Name = "lblCustomerID";
            this.lblCustomerID.Size = new System.Drawing.Size(100, 16);
            this.lblCustomerID.TabIndex = 58;
            this.lblCustomerID.Text = "Customer ID";
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Font = new System.Drawing.Font("MS Reference Sans Serif", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerName.Location = new System.Drawing.Point(35, 294);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(314, 23);
            this.lblCustomerName.TabIndex = 57;
            this.lblCustomerName.Text = "Click grid to select a customer";
            this.lblCustomerName.Click += new System.EventHandler(this.label4_Click);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(35, 78);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(78, 16);
            this.lblPassword.TabIndex = 56;
            this.lblPassword.Text = "Password";
            // 
            // lblPhoneSerialNumber
            // 
            this.lblPhoneSerialNumber.AutoSize = true;
            this.lblPhoneSerialNumber.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhoneSerialNumber.Location = new System.Drawing.Point(34, 44);
            this.lblPhoneSerialNumber.Name = "lblPhoneSerialNumber";
            this.lblPhoneSerialNumber.Size = new System.Drawing.Size(162, 16);
            this.lblPhoneSerialNumber.TabIndex = 55;
            this.lblPhoneSerialNumber.Text = "Phone Serial Number";
            // 
            // txtRepairID
            // 
            this.txtRepairID.Enabled = false;
            this.txtRepairID.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRepairID.Location = new System.Drawing.Point(203, 55);
            this.txtRepairID.Name = "txtRepairID";
            this.txtRepairID.Size = new System.Drawing.Size(59, 23);
            this.txtRepairID.TabIndex = 54;
            this.txtRepairID.TextChanged += new System.EventHandler(this.txtRepairID_TextChanged);
            // 
            // lblRepairID
            // 
            this.lblRepairID.AutoSize = true;
            this.lblRepairID.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRepairID.Location = new System.Drawing.Point(33, 62);
            this.lblRepairID.Name = "lblRepairID";
            this.lblRepairID.Size = new System.Drawing.Size(70, 16);
            this.lblRepairID.TabIndex = 53;
            this.lblRepairID.Text = "RepairID";
            this.lblRepairID.Click += new System.EventHandler(this.lblRepairID_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(5, 82);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(272, 16);
            this.label9.TabIndex = 79;
            this.label9.Text = "---------------------------------";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // cbbDescription
            // 
            this.cbbDescription.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbDescription.FormattingEnabled = true;
            this.cbbDescription.Items.AddRange(new object[] {
            "Screen ",
            "Battery Change",
            "Charging Port",
            "Unlock",
            "Water Damage",
            "Backup",
            "Back Camera",
            "Front Camera",
            "Microphone Damage",
            "Other..."});
            this.cbbDescription.Location = new System.Drawing.Point(204, 159);
            this.cbbDescription.Name = "cbbDescription";
            this.cbbDescription.Size = new System.Drawing.Size(159, 20);
            this.cbbDescription.TabIndex = 80;
            this.cbbDescription.SelectedIndexChanged += new System.EventHandler(this.cbbDescription_SelectedIndexChanged);
            // 
            // txtDescription
            // 
            this.txtDescription.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.Location = new System.Drawing.Point(204, 185);
            this.txtDescription.MaxLength = 75;
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(266, 75);
            this.txtDescription.TabIndex = 81;
            this.txtDescription.Text = "\r\n";
            this.txtDescription.Enter += new System.EventHandler(this.txtDescription_Enter);
            // 
            // grdgetRepairDetails
            // 
            this.grdgetRepairDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdgetRepairDetails.Location = new System.Drawing.Point(37, 141);
            this.grdgetRepairDetails.Name = "grdgetRepairDetails";
            this.grdgetRepairDetails.ReadOnly = true;
            this.grdgetRepairDetails.Size = new System.Drawing.Size(331, 150);
            this.grdgetRepairDetails.TabIndex = 82;
            this.grdgetRepairDetails.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.grdgetRepairDetails.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdgetRepairDetails_CellContentClick);
            // 
            // grpRepairDetails
            // 
            this.grpRepairDetails.Controls.Add(this.label1);
            this.grpRepairDetails.Controls.Add(this.cbophonetype);
            this.grpRepairDetails.Controls.Add(this.txtphonetype);
            this.grpRepairDetails.Controls.Add(this.txtCost);
            this.grpRepairDetails.Controls.Add(this.lblCost);
            this.grpRepairDetails.Controls.Add(this.cbbDescription);
            this.grpRepairDetails.Controls.Add(this.txtPassword);
            this.grpRepairDetails.Controls.Add(this.txtDescription);
            this.grpRepairDetails.Controls.Add(this.txtPhoneSerialNumber);
            this.grpRepairDetails.Controls.Add(this.lblDescrpition);
            this.grpRepairDetails.Controls.Add(this.lblPassword);
            this.grpRepairDetails.Controls.Add(this.lblPhoneSerialNumber);
            this.grpRepairDetails.Location = new System.Drawing.Point(462, 93);
            this.grpRepairDetails.Name = "grpRepairDetails";
            this.grpRepairDetails.Size = new System.Drawing.Size(492, 337);
            this.grpRepairDetails.TabIndex = 83;
            this.grpRepairDetails.TabStop = false;
            this.grpRepairDetails.Visible = false;
            this.grpRepairDetails.Enter += new System.EventHandler(this.grpRepairDetails_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 218);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 16);
            this.label1.TabIndex = 86;
            this.label1.Text = "More Details...";
            // 
            // cbophonetype
            // 
            this.cbophonetype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbophonetype.FormattingEnabled = true;
            this.cbophonetype.Items.AddRange(new object[] {
            "iPhone",
            "Samsung",
            "Nokia",
            "Huwawei",
            "Sony",
            "Vodafone"});
            this.cbophonetype.Location = new System.Drawing.Point(204, 131);
            this.cbophonetype.Name = "cbophonetype";
            this.cbophonetype.Size = new System.Drawing.Size(159, 20);
            this.cbophonetype.TabIndex = 85;
            // 
            // txtphonetype
            // 
            this.txtphonetype.AutoSize = true;
            this.txtphonetype.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtphonetype.Location = new System.Drawing.Point(34, 136);
            this.txtphonetype.Name = "txtphonetype";
            this.txtphonetype.Size = new System.Drawing.Size(97, 16);
            this.txtphonetype.TabIndex = 84;
            this.txtphonetype.Text = "Phone Make";
            // 
            // txtCost
            // 
            this.txtCost.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCost.Location = new System.Drawing.Point(204, 282);
            this.txtCost.MaxLength = 5;
            this.txtCost.Name = "txtCost";
            this.txtCost.Size = new System.Drawing.Size(77, 21);
            this.txtCost.TabIndex = 83;
            // 
            // lblCost
            // 
            this.lblCost.AutoSize = true;
            this.lblCost.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCost.Location = new System.Drawing.Point(35, 289);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(135, 16);
            this.lblCost.TabIndex = 82;
            this.lblCost.Text = "Cost of Repair..?";
            // 
            // frmRepairLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 511);
            this.Controls.Add(this.grpRepairDetails);
            this.Controls.Add(this.grdgetRepairDetails);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnBackButton);
            this.Controls.Add(this.imgPlus);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtCustomerID);
            this.Controls.Add(this.lblCustomerID);
            this.Controls.Add(this.lblCustomerName);
            this.Controls.Add(this.txtRepairID);
            this.Controls.Add(this.lblRepairID);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmRepairLog";
            this.Text = "LogRepair";
            this.Load += new System.EventHandler(this.frmRepairLog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgPlus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdgetRepairDetails)).EndInit();
            this.grpRepairDetails.ResumeLayout(false);
            this.grpRepairDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBackButton;
        private System.Windows.Forms.PictureBox imgPlus;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox txtCustomerID;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtPhoneSerialNumber;
        private System.Windows.Forms.Label lblDescrpition;
        private System.Windows.Forms.Label lblCustomerID;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblPhoneSerialNumber;
        private System.Windows.Forms.TextBox txtRepairID;
        private System.Windows.Forms.Label lblRepairID;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbbDescription;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.DataGridView grdgetRepairDetails;
        private System.Windows.Forms.GroupBox grpRepairDetails;
        private System.Windows.Forms.TextBox txtCost;
        private System.Windows.Forms.Label lblCost;
        private System.Windows.Forms.ComboBox cbophonetype;
        private System.Windows.Forms.Label txtphonetype;
        private System.Windows.Forms.Label label1;
    }
}