namespace FoneFixSYS
{
    partial class frmStockNew
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
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblStockID = new System.Windows.Forms.Label();
            this.txtStockID = new System.Windows.Forms.TextBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtType = new System.Windows.Forms.TextBox();
            this.lblStockQuantity = new System.Windows.Forms.Label();
            this.lblStockPrice = new System.Windows.Forms.Label();
            this.lblStockType = new System.Windows.Forms.Label();
            this.txtStockName = new System.Windows.Forms.TextBox();
            this.lblStockName = new System.Windows.Forms.Label();
            this.btnBackButton = new System.Windows.Forms.Button();
            this.imgPlus = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgPlus)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(126, 306);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(169, 55);
            this.btnSubmit.TabIndex = 50;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblStockID
            // 
            this.lblStockID.AutoSize = true;
            this.lblStockID.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStockID.Location = new System.Drawing.Point(53, 85);
            this.lblStockID.Name = "lblStockID";
            this.lblStockID.Size = new System.Drawing.Size(73, 16);
            this.lblStockID.TabIndex = 42;
            this.lblStockID.Text = "Stock ID";
            this.lblStockID.Click += new System.EventHandler(this.label8_Click);
            // 
            // txtStockID
            // 
            this.txtStockID.Enabled = false;
            this.txtStockID.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStockID.Location = new System.Drawing.Point(160, 78);
            this.txtStockID.Name = "txtStockID";
            this.txtStockID.ReadOnly = true;
            this.txtStockID.Size = new System.Drawing.Size(75, 21);
            this.txtStockID.TabIndex = 41;
            this.txtStockID.TextChanged += new System.EventHandler(this.txtStockID_TextChanged);
            // 
            // txtQuantity
            // 
            this.txtQuantity.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantity.Location = new System.Drawing.Point(159, 236);
            this.txtQuantity.MaxLength = 5;
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(134, 21);
            this.txtQuantity.TabIndex = 36;
            this.txtQuantity.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // txtPrice
            // 
            this.txtPrice.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.Location = new System.Drawing.Point(159, 203);
            this.txtPrice.MaxLength = 5;
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(134, 21);
            this.txtPrice.TabIndex = 35;
            // 
            // txtType
            // 
            this.txtType.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtType.Location = new System.Drawing.Point(159, 170);
            this.txtType.MaxLength = 20;
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(134, 21);
            this.txtType.TabIndex = 34;
            // 
            // lblStockQuantity
            // 
            this.lblStockQuantity.AutoSize = true;
            this.lblStockQuantity.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStockQuantity.Location = new System.Drawing.Point(30, 243);
            this.lblStockQuantity.Name = "lblStockQuantity";
            this.lblStockQuantity.Size = new System.Drawing.Size(122, 16);
            this.lblStockQuantity.TabIndex = 31;
            this.lblStockQuantity.Text = "Stock Quantity";
            // 
            // lblStockPrice
            // 
            this.lblStockPrice.AutoSize = true;
            this.lblStockPrice.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStockPrice.Location = new System.Drawing.Point(30, 210);
            this.lblStockPrice.Name = "lblStockPrice";
            this.lblStockPrice.Size = new System.Drawing.Size(94, 16);
            this.lblStockPrice.TabIndex = 30;
            this.lblStockPrice.Text = "Stock Price";
            // 
            // lblStockType
            // 
            this.lblStockType.AutoSize = true;
            this.lblStockType.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStockType.Location = new System.Drawing.Point(30, 173);
            this.lblStockType.Name = "lblStockType";
            this.lblStockType.Size = new System.Drawing.Size(94, 16);
            this.lblStockType.TabIndex = 29;
            this.lblStockType.Text = "Stock Type";
            // 
            // txtStockName
            // 
            this.txtStockName.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStockName.Location = new System.Drawing.Point(160, 132);
            this.txtStockName.MaxLength = 20;
            this.txtStockName.Name = "txtStockName";
            this.txtStockName.Size = new System.Drawing.Size(134, 21);
            this.txtStockName.TabIndex = 28;
            // 
            // lblStockName
            // 
            this.lblStockName.AutoSize = true;
            this.lblStockName.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStockName.Location = new System.Drawing.Point(30, 139);
            this.lblStockName.Name = "lblStockName";
            this.lblStockName.Size = new System.Drawing.Size(97, 16);
            this.lblStockName.TabIndex = 27;
            this.lblStockName.Text = "Stock Name";
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
            this.btnBackButton.TabIndex = 52;
            this.btnBackButton.UseVisualStyleBackColor = false;
            this.btnBackButton.Click += new System.EventHandler(this.button4_Click);
            // 
            // imgPlus
            // 
            this.imgPlus.Image = global::FoneFixSYS.Properties.Resources.Alarm_Plus_icon1;
            this.imgPlus.Location = new System.Drawing.Point(314, -4);
            this.imgPlus.Name = "imgPlus";
            this.imgPlus.Size = new System.Drawing.Size(101, 89);
            this.imgPlus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgPlus.TabIndex = 51;
            this.imgPlus.TabStop = false;
            // 
            // frmStockNew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 391);
            this.Controls.Add(this.btnBackButton);
            this.Controls.Add(this.imgPlus);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.lblStockID);
            this.Controls.Add(this.txtStockID);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtType);
            this.Controls.Add(this.lblStockQuantity);
            this.Controls.Add(this.lblStockPrice);
            this.Controls.Add(this.lblStockType);
            this.Controls.Add(this.txtStockName);
            this.Controls.Add(this.lblStockName);
            this.Name = "frmStockNew";
            this.Text = "New Stock";
            this.Load += new System.EventHandler(this.NewStock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgPlus)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBackButton;
        private System.Windows.Forms.PictureBox imgPlus;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblStockID;
        private System.Windows.Forms.TextBox txtStockID;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtType;
        private System.Windows.Forms.Label lblStockQuantity;
        private System.Windows.Forms.Label lblStockPrice;
        private System.Windows.Forms.Label lblStockType;
        private System.Windows.Forms.TextBox txtStockName;
        private System.Windows.Forms.Label lblStockName;
    }
}