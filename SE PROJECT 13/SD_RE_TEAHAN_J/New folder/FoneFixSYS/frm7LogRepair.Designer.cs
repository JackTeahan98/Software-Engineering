namespace FoneFixSYS
{
    partial class frm7LogRepair
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
            this.txtCustomerName = new System.Windows.Forms.TextBox();
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
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cbbDescription = new System.Windows.Forms.ComboBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgPlus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
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
            this.imgPlus.Location = new System.Drawing.Point(421, 11);
            this.imgPlus.Name = "imgPlus";
            this.imgPlus.Size = new System.Drawing.Size(101, 82);
            this.imgPlus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgPlus.TabIndex = 75;
            this.imgPlus.TabStop = false;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(183, 487);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(169, 51);
            this.btnSubmit.TabIndex = 74;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerName.Location = new System.Drawing.Point(203, 270);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(113, 23);
            this.txtCustomerName.TabIndex = 63;
            // 
            // txtCustomerID
            // 
            this.txtCustomerID.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerID.Location = new System.Drawing.Point(203, 238);
            this.txtCustomerID.Name = "txtCustomerID";
            this.txtCustomerID.Size = new System.Drawing.Size(60, 23);
            this.txtCustomerID.TabIndex = 62;
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(203, 176);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(113, 23);
            this.txtPassword.TabIndex = 61;
            // 
            // txtPhoneSerialNumber
            // 
            this.txtPhoneSerialNumber.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhoneSerialNumber.Location = new System.Drawing.Point(203, 146);
            this.txtPhoneSerialNumber.Name = "txtPhoneSerialNumber";
            this.txtPhoneSerialNumber.Size = new System.Drawing.Size(113, 23);
            this.txtPhoneSerialNumber.TabIndex = 60;
            // 
            // lblDescrpition
            // 
            this.lblDescrpition.AutoSize = true;
            this.lblDescrpition.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescrpition.Location = new System.Drawing.Point(34, 359);
            this.lblDescrpition.Name = "lblDescrpition";
            this.lblDescrpition.Size = new System.Drawing.Size(92, 16);
            this.lblDescrpition.TabIndex = 59;
            this.lblDescrpition.Text = "Description";
            // 
            // lblCustomerID
            // 
            this.lblCustomerID.AutoSize = true;
            this.lblCustomerID.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerID.Location = new System.Drawing.Point(34, 245);
            this.lblCustomerID.Name = "lblCustomerID";
            this.lblCustomerID.Size = new System.Drawing.Size(100, 16);
            this.lblCustomerID.TabIndex = 58;
            this.lblCustomerID.Text = "Customer ID";
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerName.Location = new System.Drawing.Point(33, 277);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(124, 16);
            this.lblCustomerName.TabIndex = 57;
            this.lblCustomerName.Text = "Customer Name";
            this.lblCustomerName.Click += new System.EventHandler(this.label4_Click);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(34, 183);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(78, 16);
            this.lblPassword.TabIndex = 56;
            this.lblPassword.Text = "Password";
            // 
            // lblPhoneSerialNumber
            // 
            this.lblPhoneSerialNumber.AutoSize = true;
            this.lblPhoneSerialNumber.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhoneSerialNumber.Location = new System.Drawing.Point(33, 149);
            this.lblPhoneSerialNumber.Name = "lblPhoneSerialNumber";
            this.lblPhoneSerialNumber.Size = new System.Drawing.Size(162, 16);
            this.lblPhoneSerialNumber.TabIndex = 55;
            this.lblPhoneSerialNumber.Text = "Phone Serial Number";
            // 
            // txtRepairID
            // 
            this.txtRepairID.Enabled = false;
            this.txtRepairID.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRepairID.Location = new System.Drawing.Point(204, 69);
            this.txtRepairID.Name = "txtRepairID";
            this.txtRepairID.Size = new System.Drawing.Size(59, 23);
            this.txtRepairID.TabIndex = 54;
            this.txtRepairID.Text = "1078";
            // 
            // lblRepairID
            // 
            this.lblRepairID.AutoSize = true;
            this.lblRepairID.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRepairID.Location = new System.Drawing.Point(34, 76);
            this.lblRepairID.Name = "lblRepairID";
            this.lblRepairID.Size = new System.Drawing.Size(70, 16);
            this.lblRepairID.TabIndex = 53;
            this.lblRepairID.Text = "RepairID";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(2, 205);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(530, 16);
            this.label7.TabIndex = 77;
            this.label7.Text = "__________________________________________________________";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(2, 313);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(530, 16);
            this.label8.TabIndex = 78;
            this.label8.Text = "__________________________________________________________";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(2, 106);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(530, 16);
            this.label9.TabIndex = 79;
            this.label9.Text = "__________________________________________________________";
            // 
            // cbbDescription
            // 
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
            "Other...",
            ""});
            this.cbbDescription.Location = new System.Drawing.Point(204, 354);
            this.cbbDescription.Name = "cbbDescription";
            this.cbbDescription.Size = new System.Drawing.Size(159, 20);
            this.cbbDescription.TabIndex = 80;
            // 
            // txtDescription
            // 
            this.txtDescription.Font = new System.Drawing.Font("MS Reference Sans Serif", 7F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.Location = new System.Drawing.Point(203, 388);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(266, 75);
            this.txtDescription.TabIndex = 81;
            this.txtDescription.Text = "Other... (Optional)";
            this.txtDescription.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // frm7LogRepair
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 564);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.cbbDescription);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnBackButton);
            this.Controls.Add(this.imgPlus);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtCustomerName);
            this.Controls.Add(this.txtCustomerID);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtPhoneSerialNumber);
            this.Controls.Add(this.lblDescrpition);
            this.Controls.Add(this.lblCustomerID);
            this.Controls.Add(this.lblCustomerName);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblPhoneSerialNumber);
            this.Controls.Add(this.txtRepairID);
            this.Controls.Add(this.lblRepairID);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frm7LogRepair";
            this.Text = "LogRepair";
            ((System.ComponentModel.ISupportInitialize)(this.imgPlus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBackButton;
        private System.Windows.Forms.PictureBox imgPlus;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox txtCustomerName;
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
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbbDescription;
        private System.Windows.Forms.TextBox txtDescription;
    }
}