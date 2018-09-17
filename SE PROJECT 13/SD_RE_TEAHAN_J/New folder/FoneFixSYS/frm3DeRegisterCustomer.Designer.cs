namespace FoneFixSYS
{
    partial class frm3DeRegisterCustomer
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
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.btnDeleteCustomerID = new System.Windows.Forms.Button();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerName.Location = new System.Drawing.Point(40, 69);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(219, 30);
            this.txtCustomerName.TabIndex = 10;
            // 
            // btnDeleteCustomerID
            // 
            this.btnDeleteCustomerID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteCustomerID.Location = new System.Drawing.Point(74, 118);
            this.btnDeleteCustomerID.Name = "btnDeleteCustomerID";
            this.btnDeleteCustomerID.Size = new System.Drawing.Size(145, 45);
            this.btnDeleteCustomerID.TabIndex = 9;
            this.btnDeleteCustomerID.Text = "Delete...";
            this.btnDeleteCustomerID.UseVisualStyleBackColor = true;
            this.btnDeleteCustomerID.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerName.Location = new System.Drawing.Point(24, 47);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(260, 20);
            this.lblCustomerName.TabIndex = 8;
            this.lblCustomerName.Text = "Please Enter Customer Name...";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.Control;
            this.button4.Cursor = System.Windows.Forms.Cursors.Default;
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button4.FlatAppearance.BorderSize = 20;
            this.button4.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.button4.Image = global::FoneFixSYS.Properties.Resources.Arrows_Back_icon;
            this.button4.Location = new System.Drawing.Point(1, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(80, 35);
            this.button4.TabIndex = 54;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // frm3DeRegisterCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 171);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.txtCustomerName);
            this.Controls.Add(this.btnDeleteCustomerID);
            this.Controls.Add(this.lblCustomerName);
            this.Name = "frm3DeRegisterCustomer";
            this.Text = "Delete Customer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Button btnDeleteCustomerID;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.Button button4;
    }
}