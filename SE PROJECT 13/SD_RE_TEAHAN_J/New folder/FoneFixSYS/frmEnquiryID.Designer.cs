﻿namespace FoneFixSYS
{
    partial class EnquiryID
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
            this.txtCustomerID = new System.Windows.Forms.TextBox();
            this.btnSubmitCustomerID = new System.Windows.Forms.Button();
            this.lblCustomerID = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtCustomerID
            // 
            this.txtCustomerID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerID.Location = new System.Drawing.Point(109, 67);
            this.txtCustomerID.Name = "txtCustomerID";
            this.txtCustomerID.Size = new System.Drawing.Size(78, 30);
            this.txtCustomerID.TabIndex = 13;
            // 
            // btnSubmitCustomerID
            // 
            this.btnSubmitCustomerID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmitCustomerID.Location = new System.Drawing.Point(74, 116);
            this.btnSubmitCustomerID.Name = "btnSubmitCustomerID";
            this.btnSubmitCustomerID.Size = new System.Drawing.Size(145, 45);
            this.btnSubmitCustomerID.TabIndex = 12;
            this.btnSubmitCustomerID.Text = "Submit...";
            this.btnSubmitCustomerID.UseVisualStyleBackColor = true;
            this.btnSubmitCustomerID.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblCustomerID
            // 
            this.lblCustomerID.AutoSize = true;
            this.lblCustomerID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerID.Location = new System.Drawing.Point(41, 28);
            this.lblCustomerID.Name = "lblCustomerID";
            this.lblCustomerID.Size = new System.Drawing.Size(233, 20);
            this.lblCustomerID.TabIndex = 11;
            this.lblCustomerID.Text = "Please Enter Customer ID...";
            // 
            // EnquiryID
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 171);
            this.Controls.Add(this.txtCustomerID);
            this.Controls.Add(this.btnSubmitCustomerID);
            this.Controls.Add(this.lblCustomerID);
            this.Name = "EnquiryID";
            this.Text = "EnquiryID";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCustomerID;
        private System.Windows.Forms.Button btnSubmitCustomerID;
        private System.Windows.Forms.Label lblCustomerID;
    }
}