namespace FoneFixSYS
{
    partial class ManageCustomersMenu
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
            this.lblManageCustomers = new System.Windows.Forms.Label();
            this.lblAddCustomer = new System.Windows.Forms.Label();
            this.lblUpdateCustomer = new System.Windows.Forms.Label();
            this.lblDeRegisterCustomer = new System.Windows.Forms.Label();
            this.btnBackButton = new System.Windows.Forms.Button();
            this.btnDeRegisterCustomer = new System.Windows.Forms.Button();
            this.btnUpdateCustomer = new System.Windows.Forms.Button();
            this.btnAddCustomer = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblManageCustomers
            // 
            this.lblManageCustomers.AutoSize = true;
            this.lblManageCustomers.Font = new System.Drawing.Font("Lucida Console", 25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManageCustomers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.lblManageCustomers.Location = new System.Drawing.Point(102, 59);
            this.lblManageCustomers.Name = "lblManageCustomers";
            this.lblManageCustomers.Size = new System.Drawing.Size(335, 34);
            this.lblManageCustomers.TabIndex = 1;
            this.lblManageCustomers.Text = "Manage Customers";
            this.lblManageCustomers.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblAddCustomer
            // 
            this.lblAddCustomer.AutoSize = true;
            this.lblAddCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddCustomer.Location = new System.Drawing.Point(14, 187);
            this.lblAddCustomer.Name = "lblAddCustomer";
            this.lblAddCustomer.Size = new System.Drawing.Size(123, 20);
            this.lblAddCustomer.TabIndex = 4;
            this.lblAddCustomer.Text = "Add Customer";
            // 
            // lblUpdateCustomer
            // 
            this.lblUpdateCustomer.AutoSize = true;
            this.lblUpdateCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdateCustomer.Location = new System.Drawing.Point(14, 289);
            this.lblUpdateCustomer.Name = "lblUpdateCustomer";
            this.lblUpdateCustomer.Size = new System.Drawing.Size(150, 20);
            this.lblUpdateCustomer.TabIndex = 6;
            this.lblUpdateCustomer.Text = "Update Customer";
            // 
            // lblDeRegisterCustomer
            // 
            this.lblDeRegisterCustomer.AutoSize = true;
            this.lblDeRegisterCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeRegisterCustomer.Location = new System.Drawing.Point(316, 235);
            this.lblDeRegisterCustomer.Name = "lblDeRegisterCustomer";
            this.lblDeRegisterCustomer.Size = new System.Drawing.Size(182, 20);
            this.lblDeRegisterCustomer.TabIndex = 8;
            this.lblDeRegisterCustomer.Text = "DeRegister Customer";
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
            this.btnBackButton.TabIndex = 10;
            this.btnBackButton.UseVisualStyleBackColor = false;
            this.btnBackButton.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnDeRegisterCustomer
            // 
            this.btnDeRegisterCustomer.BackColor = System.Drawing.SystemColors.Control;
            this.btnDeRegisterCustomer.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.btnDeRegisterCustomer.Image = global::FoneFixSYS.Properties.Resources.Actions_edit_delete_icon;
            this.btnDeRegisterCustomer.Location = new System.Drawing.Point(504, 209);
            this.btnDeRegisterCustomer.Name = "btnDeRegisterCustomer";
            this.btnDeRegisterCustomer.Size = new System.Drawing.Size(75, 75);
            this.btnDeRegisterCustomer.TabIndex = 9;
            this.btnDeRegisterCustomer.UseVisualStyleBackColor = false;
            this.btnDeRegisterCustomer.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnUpdateCustomer
            // 
            this.btnUpdateCustomer.BackColor = System.Drawing.SystemColors.Control;
            this.btnUpdateCustomer.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.btnUpdateCustomer.Image = global::FoneFixSYS.Properties.Resources.Actions_view_refresh_icon;
            this.btnUpdateCustomer.Location = new System.Drawing.Point(194, 263);
            this.btnUpdateCustomer.Name = "btnUpdateCustomer";
            this.btnUpdateCustomer.Size = new System.Drawing.Size(75, 75);
            this.btnUpdateCustomer.TabIndex = 7;
            this.btnUpdateCustomer.UseVisualStyleBackColor = false;
            this.btnUpdateCustomer.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.BackColor = System.Drawing.SystemColors.Control;
            this.btnAddCustomer.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.btnAddCustomer.Image = global::FoneFixSYS.Properties.Resources.Alarm_Plus_icon1;
            this.btnAddCustomer.Location = new System.Drawing.Point(194, 161);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(75, 75);
            this.btnAddCustomer.TabIndex = 5;
            this.btnAddCustomer.UseVisualStyleBackColor = false;
            this.btnAddCustomer.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FoneFixSYS.Properties.Resources.manageCustomers1;
            this.pictureBox1.Location = new System.Drawing.Point(443, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(87, 82);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // ManageCustomersMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 401);
            this.Controls.Add(this.btnBackButton);
            this.Controls.Add(this.btnDeRegisterCustomer);
            this.Controls.Add(this.lblDeRegisterCustomer);
            this.Controls.Add(this.btnUpdateCustomer);
            this.Controls.Add(this.lblUpdateCustomer);
            this.Controls.Add(this.btnAddCustomer);
            this.Controls.Add(this.lblAddCustomer);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblManageCustomers);
            this.Name = "ManageCustomersMenu";
            this.Text = "ManageCustomersMenu";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblManageCustomers;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnAddCustomer;
        private System.Windows.Forms.Label lblAddCustomer;
        private System.Windows.Forms.Button btnUpdateCustomer;
        private System.Windows.Forms.Label lblUpdateCustomer;
        private System.Windows.Forms.Button btnDeRegisterCustomer;
        private System.Windows.Forms.Label lblDeRegisterCustomer;
        private System.Windows.Forms.Button btnBackButton;
    }
}