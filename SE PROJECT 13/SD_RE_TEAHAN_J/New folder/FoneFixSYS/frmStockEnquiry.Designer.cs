namespace FoneFixSYS
{
    partial class frmStockEnquiry
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtStockQuantity = new System.Windows.Forms.TextBox();
            this.txtStockPrice = new System.Windows.Forms.TextBox();
            this.txtStockType = new System.Windows.Forms.TextBox();
            this.lblStockQuantity = new System.Windows.Forms.Label();
            this.lblStockPrice = new System.Windows.Forms.Label();
            this.lblStockType = new System.Windows.Forms.Label();
            this.txtStockName = new System.Windows.Forms.TextBox();
            this.lblStockName = new System.Windows.Forms.Label();
            this.txtStockID = new System.Windows.Forms.TextBox();
            this.lblStockID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.btnBackButton.TabIndex = 76;
            this.btnBackButton.UseVisualStyleBackColor = false;
            this.btnBackButton.Click += new System.EventHandler(this.button4_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(314, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(101, 89);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 75;
            this.pictureBox1.TabStop = false;
            // 
            // txtStockQuantity
            // 
            this.txtStockQuantity.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStockQuantity.Location = new System.Drawing.Point(198, 292);
            this.txtStockQuantity.Name = "txtStockQuantity";
            this.txtStockQuantity.Size = new System.Drawing.Size(86, 23);
            this.txtStockQuantity.TabIndex = 73;
            this.txtStockQuantity.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // txtStockPrice
            // 
            this.txtStockPrice.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStockPrice.Location = new System.Drawing.Point(198, 247);
            this.txtStockPrice.Name = "txtStockPrice";
            this.txtStockPrice.Size = new System.Drawing.Size(86, 23);
            this.txtStockPrice.TabIndex = 72;
            // 
            // txtStockType
            // 
            this.txtStockType.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStockType.Location = new System.Drawing.Point(198, 204);
            this.txtStockType.Name = "txtStockType";
            this.txtStockType.Size = new System.Drawing.Size(113, 23);
            this.txtStockType.TabIndex = 71;
            // 
            // lblStockQuantity
            // 
            this.lblStockQuantity.AutoSize = true;
            this.lblStockQuantity.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStockQuantity.Location = new System.Drawing.Point(69, 296);
            this.lblStockQuantity.Name = "lblStockQuantity";
            this.lblStockQuantity.Size = new System.Drawing.Size(122, 16);
            this.lblStockQuantity.TabIndex = 70;
            this.lblStockQuantity.Text = "Stock Quantity";
            this.lblStockQuantity.Click += new System.EventHandler(this.label4_Click);
            // 
            // lblStockPrice
            // 
            this.lblStockPrice.AutoSize = true;
            this.lblStockPrice.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStockPrice.Location = new System.Drawing.Point(69, 254);
            this.lblStockPrice.Name = "lblStockPrice";
            this.lblStockPrice.Size = new System.Drawing.Size(94, 16);
            this.lblStockPrice.TabIndex = 69;
            this.lblStockPrice.Text = "Stock Price";
            // 
            // lblStockType
            // 
            this.lblStockType.AutoSize = true;
            this.lblStockType.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStockType.Location = new System.Drawing.Point(69, 207);
            this.lblStockType.Name = "lblStockType";
            this.lblStockType.Size = new System.Drawing.Size(94, 16);
            this.lblStockType.TabIndex = 68;
            this.lblStockType.Text = "Stock Type";
            // 
            // txtStockName
            // 
            this.txtStockName.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStockName.Location = new System.Drawing.Point(199, 155);
            this.txtStockName.Name = "txtStockName";
            this.txtStockName.Size = new System.Drawing.Size(113, 23);
            this.txtStockName.TabIndex = 67;
            // 
            // lblStockName
            // 
            this.lblStockName.AutoSize = true;
            this.lblStockName.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStockName.Location = new System.Drawing.Point(69, 162);
            this.lblStockName.Name = "lblStockName";
            this.lblStockName.Size = new System.Drawing.Size(97, 16);
            this.lblStockName.TabIndex = 66;
            this.lblStockName.Text = "Stock Name";
            // 
            // txtStockID
            // 
            this.txtStockID.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStockID.Location = new System.Drawing.Point(199, 97);
            this.txtStockID.Name = "txtStockID";
            this.txtStockID.Size = new System.Drawing.Size(46, 23);
            this.txtStockID.TabIndex = 78;
            // 
            // lblStockID
            // 
            this.lblStockID.AutoSize = true;
            this.lblStockID.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStockID.Location = new System.Drawing.Point(69, 104);
            this.lblStockID.Name = "lblStockID";
            this.lblStockID.Size = new System.Drawing.Size(73, 16);
            this.lblStockID.TabIndex = 77;
            this.lblStockID.Text = "Stock ID";
            // 
            // frmStockEnquiry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 391);
            this.Controls.Add(this.txtStockID);
            this.Controls.Add(this.lblStockID);
            this.Controls.Add(this.btnBackButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtStockQuantity);
            this.Controls.Add(this.txtStockPrice);
            this.Controls.Add(this.txtStockType);
            this.Controls.Add(this.lblStockQuantity);
            this.Controls.Add(this.lblStockPrice);
            this.Controls.Add(this.lblStockType);
            this.Controls.Add(this.txtStockName);
            this.Controls.Add(this.lblStockName);
            this.Name = "frmStockEnquiry";
            this.Text = "StockEnquiry";
            this.Load += new System.EventHandler(this.StockEnquiry_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBackButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtStockQuantity;
        private System.Windows.Forms.TextBox txtStockPrice;
        private System.Windows.Forms.TextBox txtStockType;
        private System.Windows.Forms.Label lblStockQuantity;
        private System.Windows.Forms.Label lblStockPrice;
        private System.Windows.Forms.Label lblStockType;
        private System.Windows.Forms.TextBox txtStockName;
        private System.Windows.Forms.Label lblStockName;
        private System.Windows.Forms.TextBox txtStockID;
        private System.Windows.Forms.Label lblStockID;
    }
}