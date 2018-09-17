namespace FoneFixSYS
{
    partial class frmCustomerUpdate
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
            this.lblCustomerForename = new System.Windows.Forms.Label();
            this.txtCustomerForeName = new System.Windows.Forms.TextBox();
            this.btnUpdateCustomer = new System.Windows.Forms.Button();
            this.lblCustomerEirCode = new System.Windows.Forms.Label();
            this.txtCustomerEircode = new System.Windows.Forms.TextBox();
            this.txtCustomerCounty = new System.Windows.Forms.TextBox();
            this.txtCustomerTown = new System.Windows.Forms.TextBox();
            this.txtCustomerStreet = new System.Windows.Forms.TextBox();
            this.txtCustomerEmail = new System.Windows.Forms.TextBox();
            this.txtCustomerPhone = new System.Windows.Forms.TextBox();
            this.lblCustomerCounty = new System.Windows.Forms.Label();
            this.lblCustomerTown = new System.Windows.Forms.Label();
            this.lblCustomerStreet = new System.Windows.Forms.Label();
            this.lblCustomerEmail = new System.Windows.Forms.Label();
            this.lblCustomerPhone = new System.Windows.Forms.Label();
            this.txtCustomerSurname = new System.Windows.Forms.TextBox();
            this.lblCustomerSurname = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.imgAddCustomer = new System.Windows.Forms.PictureBox();
            this.grdAllCustomers = new System.Windows.Forms.DataGridView();
            this.grpBoxDetails = new System.Windows.Forms.GroupBox();
            this.lblHeader = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imgAddCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdAllCustomers)).BeginInit();
            this.grpBoxDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCustomerForename
            // 
            this.lblCustomerForename.AutoSize = true;
            this.lblCustomerForename.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerForename.Location = new System.Drawing.Point(10, 48);
            this.lblCustomerForename.Name = "lblCustomerForename";
            this.lblCustomerForename.Size = new System.Drawing.Size(81, 16);
            this.lblCustomerForename.TabIndex = 49;
            this.lblCustomerForename.Text = "ForeName";
            // 
            // txtCustomerForeName
            // 
            this.txtCustomerForeName.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerForeName.Location = new System.Drawing.Point(97, 41);
            this.txtCustomerForeName.MaxLength = 30;
            this.txtCustomerForeName.Name = "txtCustomerForeName";
            this.txtCustomerForeName.Size = new System.Drawing.Size(194, 21);
            this.txtCustomerForeName.TabIndex = 48;
            // 
            // btnUpdateCustomer
            // 
            this.btnUpdateCustomer.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateCustomer.Location = new System.Drawing.Point(301, 133);
            this.btnUpdateCustomer.Name = "btnUpdateCustomer";
            this.btnUpdateCustomer.Size = new System.Drawing.Size(210, 46);
            this.btnUpdateCustomer.TabIndex = 45;
            this.btnUpdateCustomer.Text = "Update";
            this.btnUpdateCustomer.UseVisualStyleBackColor = true;
            this.btnUpdateCustomer.Click += new System.EventHandler(this.btnUpdateCustomer_Click);
            // 
            // lblCustomerEirCode
            // 
            this.lblCustomerEirCode.AutoSize = true;
            this.lblCustomerEirCode.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerEirCode.Location = new System.Drawing.Point(599, 42);
            this.lblCustomerEirCode.Name = "lblCustomerEirCode";
            this.lblCustomerEirCode.Size = new System.Drawing.Size(64, 16);
            this.lblCustomerEirCode.TabIndex = 42;
            this.lblCustomerEirCode.Text = "EirCode";
            // 
            // txtCustomerEircode
            // 
            this.txtCustomerEircode.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerEircode.Location = new System.Drawing.Point(667, 38);
            this.txtCustomerEircode.MaxLength = 7;
            this.txtCustomerEircode.Name = "txtCustomerEircode";
            this.txtCustomerEircode.Size = new System.Drawing.Size(172, 21);
            this.txtCustomerEircode.TabIndex = 41;
            // 
            // txtCustomerCounty
            // 
            this.txtCustomerCounty.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerCounty.Location = new System.Drawing.Point(667, 12);
            this.txtCustomerCounty.MaxLength = 20;
            this.txtCustomerCounty.Name = "txtCustomerCounty";
            this.txtCustomerCounty.Size = new System.Drawing.Size(172, 21);
            this.txtCustomerCounty.TabIndex = 40;
            // 
            // txtCustomerTown
            // 
            this.txtCustomerTown.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerTown.Location = new System.Drawing.Point(370, 67);
            this.txtCustomerTown.MaxLength = 20;
            this.txtCustomerTown.Name = "txtCustomerTown";
            this.txtCustomerTown.Size = new System.Drawing.Size(201, 21);
            this.txtCustomerTown.TabIndex = 39;
            this.txtCustomerTown.TextChanged += new System.EventHandler(this.txtCustomerTown_TextChanged);
            // 
            // txtCustomerStreet
            // 
            this.txtCustomerStreet.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerStreet.Location = new System.Drawing.Point(370, 39);
            this.txtCustomerStreet.MaxLength = 20;
            this.txtCustomerStreet.Name = "txtCustomerStreet";
            this.txtCustomerStreet.Size = new System.Drawing.Size(201, 21);
            this.txtCustomerStreet.TabIndex = 38;
            // 
            // txtCustomerEmail
            // 
            this.txtCustomerEmail.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerEmail.Location = new System.Drawing.Point(370, 11);
            this.txtCustomerEmail.MaxLength = 30;
            this.txtCustomerEmail.Name = "txtCustomerEmail";
            this.txtCustomerEmail.Size = new System.Drawing.Size(201, 21);
            this.txtCustomerEmail.TabIndex = 37;
            // 
            // txtCustomerPhone
            // 
            this.txtCustomerPhone.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerPhone.Location = new System.Drawing.Point(97, 70);
            this.txtCustomerPhone.MaxLength = 20;
            this.txtCustomerPhone.Name = "txtCustomerPhone";
            this.txtCustomerPhone.Size = new System.Drawing.Size(194, 21);
            this.txtCustomerPhone.TabIndex = 36;
            // 
            // lblCustomerCounty
            // 
            this.lblCustomerCounty.AutoSize = true;
            this.lblCustomerCounty.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerCounty.Location = new System.Drawing.Point(600, 14);
            this.lblCustomerCounty.Name = "lblCustomerCounty";
            this.lblCustomerCounty.Size = new System.Drawing.Size(61, 16);
            this.lblCustomerCounty.TabIndex = 35;
            this.lblCustomerCounty.Text = "County";
            // 
            // lblCustomerTown
            // 
            this.lblCustomerTown.AutoSize = true;
            this.lblCustomerTown.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerTown.Location = new System.Drawing.Point(307, 70);
            this.lblCustomerTown.Name = "lblCustomerTown";
            this.lblCustomerTown.Size = new System.Drawing.Size(48, 16);
            this.lblCustomerTown.TabIndex = 34;
            this.lblCustomerTown.Text = "Town";
            // 
            // lblCustomerStreet
            // 
            this.lblCustomerStreet.AutoSize = true;
            this.lblCustomerStreet.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerStreet.Location = new System.Drawing.Point(309, 44);
            this.lblCustomerStreet.Name = "lblCustomerStreet";
            this.lblCustomerStreet.Size = new System.Drawing.Size(56, 16);
            this.lblCustomerStreet.TabIndex = 33;
            this.lblCustomerStreet.Text = "Street";
            this.lblCustomerStreet.Click += new System.EventHandler(this.lblCustomerStreet_Click);
            // 
            // lblCustomerEmail
            // 
            this.lblCustomerEmail.AutoSize = true;
            this.lblCustomerEmail.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerEmail.Location = new System.Drawing.Point(309, 15);
            this.lblCustomerEmail.Name = "lblCustomerEmail";
            this.lblCustomerEmail.Size = new System.Drawing.Size(46, 16);
            this.lblCustomerEmail.TabIndex = 32;
            this.lblCustomerEmail.Text = "Email";
            // 
            // lblCustomerPhone
            // 
            this.lblCustomerPhone.AutoSize = true;
            this.lblCustomerPhone.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerPhone.Location = new System.Drawing.Point(10, 79);
            this.lblCustomerPhone.Name = "lblCustomerPhone";
            this.lblCustomerPhone.Size = new System.Drawing.Size(53, 16);
            this.lblCustomerPhone.TabIndex = 31;
            this.lblCustomerPhone.Text = "Phone";
            // 
            // txtCustomerSurname
            // 
            this.txtCustomerSurname.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerSurname.Location = new System.Drawing.Point(97, 12);
            this.txtCustomerSurname.MaxLength = 30;
            this.txtCustomerSurname.Name = "txtCustomerSurname";
            this.txtCustomerSurname.Size = new System.Drawing.Size(194, 21);
            this.txtCustomerSurname.TabIndex = 30;
            // 
            // lblCustomerSurname
            // 
            this.lblCustomerSurname.AutoSize = true;
            this.lblCustomerSurname.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerSurname.Location = new System.Drawing.Point(10, 15);
            this.lblCustomerSurname.Name = "lblCustomerSurname";
            this.lblCustomerSurname.Size = new System.Drawing.Size(72, 16);
            this.lblCustomerSurname.TabIndex = 29;
            this.lblCustomerSurname.Text = "Surname";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.Cursor = System.Windows.Forms.Cursors.Default;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 20;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.button1.Image = global::FoneFixSYS.Properties.Resources.Arrows_Back_icon;
            this.button1.Location = new System.Drawing.Point(0, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 35);
            this.button1.TabIndex = 50;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.Control;
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnBack.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnBack.FlatAppearance.BorderSize = 20;
            this.btnBack.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnBack.Image = global::FoneFixSYS.Properties.Resources.Arrows_Back_icon;
            this.btnBack.Location = new System.Drawing.Point(127, -34);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(80, 35);
            this.btnBack.TabIndex = 47;
            this.btnBack.UseVisualStyleBackColor = false;
            // 
            // imgAddCustomer
            // 
            this.imgAddCustomer.Image = global::FoneFixSYS.Properties.Resources.Actions_view_refresh_icon;
            this.imgAddCustomer.Location = new System.Drawing.Point(769, -8);
            this.imgAddCustomer.Name = "imgAddCustomer";
            this.imgAddCustomer.Size = new System.Drawing.Size(100, 100);
            this.imgAddCustomer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgAddCustomer.TabIndex = 46;
            this.imgAddCustomer.TabStop = false;
            // 
            // grdAllCustomers
            // 
            this.grdAllCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdAllCustomers.Location = new System.Drawing.Point(12, 93);
            this.grdAllCustomers.Name = "grdAllCustomers";
            this.grdAllCustomers.ReadOnly = true;
            this.grdAllCustomers.Size = new System.Drawing.Size(845, 195);
            this.grdAllCustomers.TabIndex = 57;
            this.grdAllCustomers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdAllCustomers_CellClick);
            // 
            // grpBoxDetails
            // 
            this.grpBoxDetails.Controls.Add(this.lblCustomerForename);
            this.grpBoxDetails.Controls.Add(this.txtCustomerForeName);
            this.grpBoxDetails.Controls.Add(this.lblCustomerEirCode);
            this.grpBoxDetails.Controls.Add(this.txtCustomerEircode);
            this.grpBoxDetails.Controls.Add(this.btnUpdateCustomer);
            this.grpBoxDetails.Controls.Add(this.txtCustomerCounty);
            this.grpBoxDetails.Controls.Add(this.txtCustomerTown);
            this.grpBoxDetails.Controls.Add(this.txtCustomerStreet);
            this.grpBoxDetails.Controls.Add(this.txtCustomerEmail);
            this.grpBoxDetails.Controls.Add(this.txtCustomerPhone);
            this.grpBoxDetails.Controls.Add(this.lblCustomerCounty);
            this.grpBoxDetails.Controls.Add(this.lblCustomerTown);
            this.grpBoxDetails.Controls.Add(this.lblCustomerStreet);
            this.grpBoxDetails.Controls.Add(this.lblCustomerEmail);
            this.grpBoxDetails.Controls.Add(this.lblCustomerPhone);
            this.grpBoxDetails.Controls.Add(this.txtCustomerSurname);
            this.grpBoxDetails.Controls.Add(this.lblCustomerSurname);
            this.grpBoxDetails.Location = new System.Drawing.Point(12, 314);
            this.grpBoxDetails.Name = "grpBoxDetails";
            this.grpBoxDetails.Size = new System.Drawing.Size(845, 206);
            this.grpBoxDetails.TabIndex = 58;
            this.grpBoxDetails.TabStop = false;
            this.grpBoxDetails.Text = "Details...";
            this.grpBoxDetails.Enter += new System.EventHandler(this.grpBoxDetails_Enter);
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(337, 40);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(186, 24);
            this.lblHeader.TabIndex = 59;
            this.lblHeader.Text = "Select From Grid...";
            this.lblHeader.Click += new System.EventHandler(this.lblHeader_Click);
            // 
            // frmCustomerUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 532);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.grpBoxDetails);
            this.Controls.Add(this.grdAllCustomers);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.imgAddCustomer);
            this.Name = "frmCustomerUpdate";
            this.Text = "Update Customer";
            this.Load += new System.EventHandler(this.UpdateCustomers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgAddCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdAllCustomers)).EndInit();
            this.grpBoxDetails.ResumeLayout(false);
            this.grpBoxDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCustomerForename;
        private System.Windows.Forms.TextBox txtCustomerForeName;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.PictureBox imgAddCustomer;
        private System.Windows.Forms.Button btnUpdateCustomer;
        private System.Windows.Forms.Label lblCustomerEirCode;
        private System.Windows.Forms.TextBox txtCustomerEircode;
        private System.Windows.Forms.TextBox txtCustomerCounty;
        private System.Windows.Forms.TextBox txtCustomerTown;
        private System.Windows.Forms.TextBox txtCustomerStreet;
        private System.Windows.Forms.TextBox txtCustomerEmail;
        private System.Windows.Forms.TextBox txtCustomerPhone;
        private System.Windows.Forms.Label lblCustomerCounty;
        private System.Windows.Forms.Label lblCustomerTown;
        private System.Windows.Forms.Label lblCustomerStreet;
        private System.Windows.Forms.Label lblCustomerEmail;
        private System.Windows.Forms.Label lblCustomerPhone;
        private System.Windows.Forms.TextBox txtCustomerSurname;
        private System.Windows.Forms.Label lblCustomerSurname;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView grdAllCustomers;
        private System.Windows.Forms.GroupBox grpBoxDetails;
        private System.Windows.Forms.Label lblHeader;
    }
}