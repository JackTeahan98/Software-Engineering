namespace FoneFixSYS
{
    partial class frmCustomerAdd
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
            this.lblCustomerSurname = new System.Windows.Forms.Label();
            this.txtCustomerSurname = new System.Windows.Forms.TextBox();
            this.lblCustomerPhone = new System.Windows.Forms.Label();
            this.lblCustomerEmail = new System.Windows.Forms.Label();
            this.lblCustomerStreet = new System.Windows.Forms.Label();
            this.lblCustomerTown = new System.Windows.Forms.Label();
            this.lblCustomerCounty = new System.Windows.Forms.Label();
            this.txtCustomerPhone = new System.Windows.Forms.TextBox();
            this.txtCustomerEmail = new System.Windows.Forms.TextBox();
            this.txtCustomerStreet = new System.Windows.Forms.TextBox();
            this.txtCustomerTown = new System.Windows.Forms.TextBox();
            this.txtCustomerCounty = new System.Windows.Forms.TextBox();
            this.txtCustomerEircode = new System.Windows.Forms.TextBox();
            this.lblCustomerEirCode = new System.Windows.Forms.Label();
            this.txtCustId = new System.Windows.Forms.TextBox();
            this.lblCustomerID = new System.Windows.Forms.Label();
            this.btnAddCustomer = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.imgAddCustomer = new System.Windows.Forms.PictureBox();
            this.txtCustomerForeName = new System.Windows.Forms.TextBox();
            this.lblCustomerForename = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.imgAddCustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCustomerSurname
            // 
            this.lblCustomerSurname.AutoSize = true;
            this.lblCustomerSurname.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerSurname.Location = new System.Drawing.Point(37, 94);
            this.lblCustomerSurname.Name = "lblCustomerSurname";
            this.lblCustomerSurname.Size = new System.Drawing.Size(72, 16);
            this.lblCustomerSurname.TabIndex = 1;
            this.lblCustomerSurname.Text = "Surname";
            this.lblCustomerSurname.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtCustomerSurname
            // 
            this.txtCustomerSurname.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerSurname.Location = new System.Drawing.Point(152, 94);
            this.txtCustomerSurname.MaxLength = 30;
            this.txtCustomerSurname.Name = "txtCustomerSurname";
            this.txtCustomerSurname.Size = new System.Drawing.Size(140, 21);
            this.txtCustomerSurname.TabIndex = 2;
            // 
            // lblCustomerPhone
            // 
            this.lblCustomerPhone.AutoSize = true;
            this.lblCustomerPhone.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerPhone.Location = new System.Drawing.Point(34, 168);
            this.lblCustomerPhone.Name = "lblCustomerPhone";
            this.lblCustomerPhone.Size = new System.Drawing.Size(114, 16);
            this.lblCustomerPhone.TabIndex = 3;
            this.lblCustomerPhone.Text = "Phone Number";
            this.lblCustomerPhone.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblCustomerEmail
            // 
            this.lblCustomerEmail.AutoSize = true;
            this.lblCustomerEmail.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerEmail.Location = new System.Drawing.Point(34, 205);
            this.lblCustomerEmail.Name = "lblCustomerEmail";
            this.lblCustomerEmail.Size = new System.Drawing.Size(46, 16);
            this.lblCustomerEmail.TabIndex = 4;
            this.lblCustomerEmail.Text = "Email";
            // 
            // lblCustomerStreet
            // 
            this.lblCustomerStreet.AutoSize = true;
            this.lblCustomerStreet.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerStreet.Location = new System.Drawing.Point(34, 238);
            this.lblCustomerStreet.Name = "lblCustomerStreet";
            this.lblCustomerStreet.Size = new System.Drawing.Size(56, 16);
            this.lblCustomerStreet.TabIndex = 5;
            this.lblCustomerStreet.Text = "Street";
            // 
            // lblCustomerTown
            // 
            this.lblCustomerTown.AutoSize = true;
            this.lblCustomerTown.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerTown.Location = new System.Drawing.Point(34, 273);
            this.lblCustomerTown.Name = "lblCustomerTown";
            this.lblCustomerTown.Size = new System.Drawing.Size(48, 16);
            this.lblCustomerTown.TabIndex = 6;
            this.lblCustomerTown.Text = "Town";
            // 
            // lblCustomerCounty
            // 
            this.lblCustomerCounty.AutoSize = true;
            this.lblCustomerCounty.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerCounty.Location = new System.Drawing.Point(34, 305);
            this.lblCustomerCounty.Name = "lblCustomerCounty";
            this.lblCustomerCounty.Size = new System.Drawing.Size(61, 16);
            this.lblCustomerCounty.TabIndex = 7;
            this.lblCustomerCounty.Text = "County";
            // 
            // txtCustomerPhone
            // 
            this.txtCustomerPhone.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerPhone.Location = new System.Drawing.Point(152, 165);
            this.txtCustomerPhone.MaxLength = 20;
            this.txtCustomerPhone.Name = "txtCustomerPhone";
            this.txtCustomerPhone.Size = new System.Drawing.Size(140, 21);
            this.txtCustomerPhone.TabIndex = 8;
            // 
            // txtCustomerEmail
            // 
            this.txtCustomerEmail.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerEmail.Location = new System.Drawing.Point(152, 198);
            this.txtCustomerEmail.MaxLength = 30;
            this.txtCustomerEmail.Name = "txtCustomerEmail";
            this.txtCustomerEmail.Size = new System.Drawing.Size(140, 21);
            this.txtCustomerEmail.TabIndex = 9;
            this.txtCustomerEmail.TextChanged += new System.EventHandler(this.txtCustomerEmail_TextChanged);
            // 
            // txtCustomerStreet
            // 
            this.txtCustomerStreet.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerStreet.Location = new System.Drawing.Point(152, 231);
            this.txtCustomerStreet.MaxLength = 20;
            this.txtCustomerStreet.Name = "txtCustomerStreet";
            this.txtCustomerStreet.Size = new System.Drawing.Size(140, 21);
            this.txtCustomerStreet.TabIndex = 10;
            // 
            // txtCustomerTown
            // 
            this.txtCustomerTown.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerTown.Location = new System.Drawing.Point(152, 266);
            this.txtCustomerTown.MaxLength = 20;
            this.txtCustomerTown.Name = "txtCustomerTown";
            this.txtCustomerTown.Size = new System.Drawing.Size(140, 21);
            this.txtCustomerTown.TabIndex = 11;
            // 
            // txtCustomerCounty
            // 
            this.txtCustomerCounty.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerCounty.Location = new System.Drawing.Point(152, 298);
            this.txtCustomerCounty.MaxLength = 20;
            this.txtCustomerCounty.Name = "txtCustomerCounty";
            this.txtCustomerCounty.Size = new System.Drawing.Size(140, 21);
            this.txtCustomerCounty.TabIndex = 12;
            // 
            // txtCustomerEircode
            // 
            this.txtCustomerEircode.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerEircode.Location = new System.Drawing.Point(152, 333);
            this.txtCustomerEircode.MaxLength = 7;
            this.txtCustomerEircode.Name = "txtCustomerEircode";
            this.txtCustomerEircode.Size = new System.Drawing.Size(140, 21);
            this.txtCustomerEircode.TabIndex = 13;
            // 
            // lblCustomerEirCode
            // 
            this.lblCustomerEirCode.AutoSize = true;
            this.lblCustomerEirCode.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerEirCode.Location = new System.Drawing.Point(34, 339);
            this.lblCustomerEirCode.Name = "lblCustomerEirCode";
            this.lblCustomerEirCode.Size = new System.Drawing.Size(64, 16);
            this.lblCustomerEirCode.TabIndex = 14;
            this.lblCustomerEirCode.Text = "EirCode";
            // 
            // txtCustId
            // 
            this.txtCustId.Enabled = false;
            this.txtCustId.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustId.Location = new System.Drawing.Point(152, 47);
            this.txtCustId.Name = "txtCustId";
            this.txtCustId.Size = new System.Drawing.Size(49, 23);
            this.txtCustId.TabIndex = 15;
            // 
            // lblCustomerID
            // 
            this.lblCustomerID.AutoSize = true;
            this.lblCustomerID.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerID.Location = new System.Drawing.Point(37, 54);
            this.lblCustomerID.Name = "lblCustomerID";
            this.lblCustomerID.Size = new System.Drawing.Size(100, 16);
            this.lblCustomerID.TabIndex = 16;
            this.lblCustomerID.Text = "Customer ID";
            this.lblCustomerID.Click += new System.EventHandler(this.label8_Click);
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCustomer.Location = new System.Drawing.Point(60, 382);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(169, 55);
            this.btnAddCustomer.TabIndex = 24;
            this.btnAddCustomer.Text = "Submit";
            this.btnAddCustomer.UseVisualStyleBackColor = true;
            this.btnAddCustomer.Click += new System.EventHandler(this.btnAdd_Click);
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
            this.btnBack.TabIndex = 26;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.button4_Click);
            // 
            // imgAddCustomer
            // 
            this.imgAddCustomer.Image = global::FoneFixSYS.Properties.Resources.Alarm_Plus_icon1;
            this.imgAddCustomer.Location = new System.Drawing.Point(288, -6);
            this.imgAddCustomer.Name = "imgAddCustomer";
            this.imgAddCustomer.Size = new System.Drawing.Size(100, 100);
            this.imgAddCustomer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgAddCustomer.TabIndex = 25;
            this.imgAddCustomer.TabStop = false;
            // 
            // txtCustomerForeName
            // 
            this.txtCustomerForeName.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerForeName.Location = new System.Drawing.Point(152, 129);
            this.txtCustomerForeName.MaxLength = 30;
            this.txtCustomerForeName.Name = "txtCustomerForeName";
            this.txtCustomerForeName.Size = new System.Drawing.Size(140, 21);
            this.txtCustomerForeName.TabIndex = 27;
            // 
            // lblCustomerForename
            // 
            this.lblCustomerForename.AutoSize = true;
            this.lblCustomerForename.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerForename.Location = new System.Drawing.Point(37, 133);
            this.lblCustomerForename.Name = "lblCustomerForename";
            this.lblCustomerForename.Size = new System.Drawing.Size(81, 16);
            this.lblCustomerForename.TabIndex = 28;
            this.lblCustomerForename.Text = "ForeName";
            // 
            // frmCustomerAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 451);
            this.Controls.Add(this.lblCustomerForename);
            this.Controls.Add(this.txtCustomerForeName);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.imgAddCustomer);
            this.Controls.Add(this.btnAddCustomer);
            this.Controls.Add(this.lblCustomerID);
            this.Controls.Add(this.txtCustId);
            this.Controls.Add(this.lblCustomerEirCode);
            this.Controls.Add(this.txtCustomerEircode);
            this.Controls.Add(this.txtCustomerCounty);
            this.Controls.Add(this.txtCustomerTown);
            this.Controls.Add(this.txtCustomerStreet);
            this.Controls.Add(this.txtCustomerEmail);
            this.Controls.Add(this.txtCustomerPhone);
            this.Controls.Add(this.lblCustomerCounty);
            this.Controls.Add(this.lblCustomerTown);
            this.Controls.Add(this.lblCustomerStreet);
            this.Controls.Add(this.lblCustomerEmail);
            this.Controls.Add(this.lblCustomerPhone);
            this.Controls.Add(this.txtCustomerSurname);
            this.Controls.Add(this.lblCustomerSurname);
            this.Name = "frmCustomerAdd";
            this.Text = "Add Customer";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgAddCustomer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblCustomerSurname;
        private System.Windows.Forms.TextBox txtCustomerSurname;
        private System.Windows.Forms.Label lblCustomerPhone;
        private System.Windows.Forms.Label lblCustomerEmail;
        private System.Windows.Forms.Label lblCustomerStreet;
        private System.Windows.Forms.Label lblCustomerTown;
        private System.Windows.Forms.Label lblCustomerCounty;
        private System.Windows.Forms.TextBox txtCustomerPhone;
        private System.Windows.Forms.TextBox txtCustomerEmail;
        private System.Windows.Forms.TextBox txtCustomerStreet;
        private System.Windows.Forms.TextBox txtCustomerTown;
        private System.Windows.Forms.TextBox txtCustomerCounty;
        private System.Windows.Forms.TextBox txtCustomerEircode;
        private System.Windows.Forms.Label lblCustomerEirCode;
        private System.Windows.Forms.TextBox txtCustId;
        private System.Windows.Forms.Label lblCustomerID;
        private System.Windows.Forms.Button btnAddCustomer;
        private System.Windows.Forms.PictureBox imgAddCustomer;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TextBox txtCustomerForeName;
        private System.Windows.Forms.Label lblCustomerForename;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}