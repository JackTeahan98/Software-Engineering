namespace FoneFixSYS
{
    partial class frmStockUpdateID
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
            this.txtStockID = new System.Windows.Forms.TextBox();
            this.btnSubmitStockID = new System.Windows.Forms.Button();
            this.lblStockID = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtStockID
            // 
            this.txtStockID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStockID.Location = new System.Drawing.Point(109, 67);
            this.txtStockID.Name = "txtStockID";
            this.txtStockID.Size = new System.Drawing.Size(78, 30);
            this.txtStockID.TabIndex = 10;
            // 
            // btnSubmitStockID
            // 
            this.btnSubmitStockID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmitStockID.Location = new System.Drawing.Point(74, 116);
            this.btnSubmitStockID.Name = "btnSubmitStockID";
            this.btnSubmitStockID.Size = new System.Drawing.Size(145, 45);
            this.btnSubmitStockID.TabIndex = 9;
            this.btnSubmitStockID.Text = "Submit...";
            this.btnSubmitStockID.UseVisualStyleBackColor = true;
            this.btnSubmitStockID.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblStockID
            // 
            this.lblStockID.AutoSize = true;
            this.lblStockID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStockID.Location = new System.Drawing.Point(48, 28);
            this.lblStockID.Name = "lblStockID";
            this.lblStockID.Size = new System.Drawing.Size(202, 20);
            this.lblStockID.TabIndex = 8;
            this.lblStockID.Text = "Please Enter Stock ID...";
            // 
            // frmStockUpdateID
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(304, 171);
            this.Controls.Add(this.txtStockID);
            this.Controls.Add(this.btnSubmitStockID);
            this.Controls.Add(this.lblStockID);
            this.Name = "frmStockUpdateID";
            this.Text = "Enter ID";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtStockID;
        private System.Windows.Forms.Button btnSubmitStockID;
        private System.Windows.Forms.Label lblStockID;
    }
}