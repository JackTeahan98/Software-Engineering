namespace FoneFixSYS
{
    partial class ManageStock
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
            this.lblStockEnquiry = new System.Windows.Forms.Label();
            this.lblUpdateStock = new System.Windows.Forms.Label();
            this.lblNewStock = new System.Windows.Forms.Label();
            this.lblManageStock = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.btnStockEnquiry = new System.Windows.Forms.Button();
            this.btnBackButton = new System.Windows.Forms.Button();
            this.btnUpdateStock = new System.Windows.Forms.Button();
            this.btnNewStock = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblStockEnquiry
            // 
            this.lblStockEnquiry.AutoSize = true;
            this.lblStockEnquiry.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStockEnquiry.Location = new System.Drawing.Point(316, 234);
            this.lblStockEnquiry.Name = "lblStockEnquiry";
            this.lblStockEnquiry.Size = new System.Drawing.Size(120, 20);
            this.lblStockEnquiry.TabIndex = 17;
            this.lblStockEnquiry.Text = "Stock Enquiry";
            // 
            // lblUpdateStock
            // 
            this.lblUpdateStock.AutoSize = true;
            this.lblUpdateStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdateStock.Location = new System.Drawing.Point(14, 289);
            this.lblUpdateStock.Name = "lblUpdateStock";
            this.lblUpdateStock.Size = new System.Drawing.Size(119, 20);
            this.lblUpdateStock.TabIndex = 15;
            this.lblUpdateStock.Text = "Update Stock";
            // 
            // lblNewStock
            // 
            this.lblNewStock.AutoSize = true;
            this.lblNewStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewStock.Location = new System.Drawing.Point(14, 187);
            this.lblNewStock.Name = "lblNewStock";
            this.lblNewStock.Size = new System.Drawing.Size(94, 20);
            this.lblNewStock.TabIndex = 13;
            this.lblNewStock.Text = "New Stock";
            this.lblNewStock.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblManageStock
            // 
            this.lblManageStock.AutoSize = true;
            this.lblManageStock.Font = new System.Drawing.Font("Lucida Console", 25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManageStock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.lblManageStock.Location = new System.Drawing.Point(153, 59);
            this.lblManageStock.Name = "lblManageStock";
            this.lblManageStock.Size = new System.Drawing.Size(255, 34);
            this.lblManageStock.TabIndex = 11;
            this.lblManageStock.Text = "Manage Stock";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(0, 0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 20;
            // 
            // btnStockEnquiry
            // 
            this.btnStockEnquiry.BackColor = System.Drawing.SystemColors.Control;
            this.btnStockEnquiry.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.btnStockEnquiry.Location = new System.Drawing.Point(442, 208);
            this.btnStockEnquiry.Name = "btnStockEnquiry";
            this.btnStockEnquiry.Size = new System.Drawing.Size(75, 75);
            this.btnStockEnquiry.TabIndex = 22;
            this.btnStockEnquiry.UseVisualStyleBackColor = false;
            this.btnStockEnquiry.Click += new System.EventHandler(this.button5_Click);
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
            this.btnBackButton.TabIndex = 19;
            this.btnBackButton.UseVisualStyleBackColor = false;
            this.btnBackButton.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnUpdateStock
            // 
            this.btnUpdateStock.BackColor = System.Drawing.SystemColors.Control;
            this.btnUpdateStock.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.btnUpdateStock.Image = global::FoneFixSYS.Properties.Resources.Actions_view_refresh_icon;
            this.btnUpdateStock.Location = new System.Drawing.Point(194, 263);
            this.btnUpdateStock.Name = "btnUpdateStock";
            this.btnUpdateStock.Size = new System.Drawing.Size(75, 75);
            this.btnUpdateStock.TabIndex = 16;
            this.btnUpdateStock.UseVisualStyleBackColor = false;
            this.btnUpdateStock.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnNewStock
            // 
            this.btnNewStock.BackColor = System.Drawing.SystemColors.Control;
            this.btnNewStock.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.btnNewStock.Image = global::FoneFixSYS.Properties.Resources.Alarm_Plus_icon1;
            this.btnNewStock.Location = new System.Drawing.Point(194, 161);
            this.btnNewStock.Name = "btnNewStock";
            this.btnNewStock.Size = new System.Drawing.Size(75, 75);
            this.btnNewStock.TabIndex = 14;
            this.btnNewStock.UseVisualStyleBackColor = false;
            this.btnNewStock.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FoneFixSYS.Properties.Resources.manageStock;
            this.pictureBox1.Location = new System.Drawing.Point(414, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(103, 90);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // ManageStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 401);
            this.Controls.Add(this.btnStockEnquiry);
            this.Controls.Add(this.btnBackButton);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.lblStockEnquiry);
            this.Controls.Add(this.btnUpdateStock);
            this.Controls.Add(this.lblUpdateStock);
            this.Controls.Add(this.btnNewStock);
            this.Controls.Add(this.lblNewStock);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblManageStock);
            this.Name = "ManageStock";
            this.Text = "ManageStock";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBackButton;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label lblStockEnquiry;
        private System.Windows.Forms.Button btnUpdateStock;
        private System.Windows.Forms.Label lblUpdateStock;
        private System.Windows.Forms.Button btnNewStock;
        private System.Windows.Forms.Label lblNewStock;
        private System.Windows.Forms.Label lblManageStock;
        private System.Windows.Forms.Button btnStockEnquiry;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}