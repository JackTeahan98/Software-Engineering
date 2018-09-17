namespace FoneFixSYS
{
    partial class frmStockUpdate
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
            this.btnUpdateStock = new System.Windows.Forms.Button();
            this.txtStockQuantity = new System.Windows.Forms.TextBox();
            this.txtStockPrice = new System.Windows.Forms.TextBox();
            this.txtStockType = new System.Windows.Forms.TextBox();
            this.lblStockQuantity = new System.Windows.Forms.Label();
            this.lblStockPrice = new System.Windows.Forms.Label();
            this.lblStockType = new System.Windows.Forms.Label();
            this.txtStockName = new System.Windows.Forms.TextBox();
            this.lblStockName = new System.Windows.Forms.Label();
            this.btnBackButton = new System.Windows.Forms.Button();
            this.imgRefresh = new System.Windows.Forms.PictureBox();
            this.grdAllStock = new System.Windows.Forms.DataGridView();
            this.lblAllStock = new System.Windows.Forms.Label();
            this.grpBox1 = new System.Windows.Forms.GroupBox();
            this.grpBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgRefresh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdAllStock)).BeginInit();
            this.grpBox1.SuspendLayout();
            this.grpBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnUpdateStock
            // 
            this.btnUpdateStock.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateStock.Location = new System.Drawing.Point(252, 105);
            this.btnUpdateStock.Name = "btnUpdateStock";
            this.btnUpdateStock.Size = new System.Drawing.Size(169, 38);
            this.btnUpdateStock.TabIndex = 63;
            this.btnUpdateStock.Text = "Update";
            this.btnUpdateStock.UseVisualStyleBackColor = true;
            this.btnUpdateStock.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtStockQuantity
            // 
            this.txtStockQuantity.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStockQuantity.Location = new System.Drawing.Point(491, 62);
            this.txtStockQuantity.MaxLength = 5;
            this.txtStockQuantity.Name = "txtStockQuantity";
            this.txtStockQuantity.Size = new System.Drawing.Size(150, 21);
            this.txtStockQuantity.TabIndex = 60;
            this.txtStockQuantity.Text = "Selected Quantity";
            // 
            // txtStockPrice
            // 
            this.txtStockPrice.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStockPrice.Location = new System.Drawing.Point(165, 60);
            this.txtStockPrice.MaxLength = 5;
            this.txtStockPrice.Name = "txtStockPrice";
            this.txtStockPrice.Size = new System.Drawing.Size(150, 21);
            this.txtStockPrice.TabIndex = 59;
            this.txtStockPrice.Text = "Selected Price";
            // 
            // txtStockType
            // 
            this.txtStockType.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStockType.Location = new System.Drawing.Point(491, 25);
            this.txtStockType.MaxLength = 20;
            this.txtStockType.Name = "txtStockType";
            this.txtStockType.Size = new System.Drawing.Size(150, 21);
            this.txtStockType.TabIndex = 58;
            this.txtStockType.Text = "Selected Type";
            this.txtStockType.TextChanged += new System.EventHandler(this.txtStockType_TextChanged);
            // 
            // lblStockQuantity
            // 
            this.lblStockQuantity.AutoSize = true;
            this.lblStockQuantity.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStockQuantity.Location = new System.Drawing.Point(364, 65);
            this.lblStockQuantity.Name = "lblStockQuantity";
            this.lblStockQuantity.Size = new System.Drawing.Size(122, 16);
            this.lblStockQuantity.TabIndex = 57;
            this.lblStockQuantity.Text = "Stock Quantity";
            // 
            // lblStockPrice
            // 
            this.lblStockPrice.AutoSize = true;
            this.lblStockPrice.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStockPrice.Location = new System.Drawing.Point(36, 65);
            this.lblStockPrice.Name = "lblStockPrice";
            this.lblStockPrice.Size = new System.Drawing.Size(94, 16);
            this.lblStockPrice.TabIndex = 56;
            this.lblStockPrice.Text = "Stock Price";
            // 
            // lblStockType
            // 
            this.lblStockType.AutoSize = true;
            this.lblStockType.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStockType.Location = new System.Drawing.Point(364, 28);
            this.lblStockType.Name = "lblStockType";
            this.lblStockType.Size = new System.Drawing.Size(94, 16);
            this.lblStockType.TabIndex = 55;
            this.lblStockType.Text = "Stock Type";
            // 
            // txtStockName
            // 
            this.txtStockName.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStockName.Location = new System.Drawing.Point(166, 23);
            this.txtStockName.MaxLength = 20;
            this.txtStockName.Name = "txtStockName";
            this.txtStockName.Size = new System.Drawing.Size(149, 21);
            this.txtStockName.TabIndex = 54;
            this.txtStockName.Text = "Selected Name";
            this.txtStockName.TextChanged += new System.EventHandler(this.txtStockName_TextChanged);
            // 
            // lblStockName
            // 
            this.lblStockName.AutoSize = true;
            this.lblStockName.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStockName.Location = new System.Drawing.Point(36, 28);
            this.lblStockName.Name = "lblStockName";
            this.lblStockName.Size = new System.Drawing.Size(97, 16);
            this.lblStockName.TabIndex = 53;
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
            this.btnBackButton.TabIndex = 65;
            this.btnBackButton.UseVisualStyleBackColor = false;
            this.btnBackButton.Click += new System.EventHandler(this.button4_Click);
            // 
            // imgRefresh
            // 
            this.imgRefresh.Image = global::FoneFixSYS.Properties.Resources.Actions_view_refresh_icon;
            this.imgRefresh.Location = new System.Drawing.Point(646, -2);
            this.imgRefresh.Name = "imgRefresh";
            this.imgRefresh.Size = new System.Drawing.Size(101, 89);
            this.imgRefresh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgRefresh.TabIndex = 64;
            this.imgRefresh.TabStop = false;
            // 
            // grdAllStock
            // 
            this.grdAllStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdAllStock.Location = new System.Drawing.Point(17, 43);
            this.grdAllStock.Name = "grdAllStock";
            this.grdAllStock.ReadOnly = true;
            this.grdAllStock.Size = new System.Drawing.Size(543, 150);
            this.grdAllStock.TabIndex = 66;
            this.grdAllStock.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdAllStock_CellClick);
            this.grdAllStock.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdAllStock_CellContentClick);
            // 
            // lblAllStock
            // 
            this.lblAllStock.AutoSize = true;
            this.lblAllStock.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAllStock.Location = new System.Drawing.Point(14, 10);
            this.lblAllStock.Name = "lblAllStock";
            this.lblAllStock.Size = new System.Drawing.Size(242, 32);
            this.lblAllStock.TabIndex = 70;
            this.lblAllStock.Text = "List of All Stock in Database...\r\nClick to get details...";
            // 
            // grpBox1
            // 
            this.grpBox1.Controls.Add(this.lblAllStock);
            this.grpBox1.Controls.Add(this.grdAllStock);
            this.grpBox1.Location = new System.Drawing.Point(67, 37);
            this.grpBox1.Name = "grpBox1";
            this.grpBox1.Size = new System.Drawing.Size(576, 196);
            this.grpBox1.TabIndex = 71;
            this.grpBox1.TabStop = false;
            // 
            // grpBox2
            // 
            this.grpBox2.Controls.Add(this.btnUpdateStock);
            this.grpBox2.Controls.Add(this.txtStockQuantity);
            this.grpBox2.Controls.Add(this.txtStockPrice);
            this.grpBox2.Controls.Add(this.txtStockType);
            this.grpBox2.Controls.Add(this.lblStockQuantity);
            this.grpBox2.Controls.Add(this.lblStockPrice);
            this.grpBox2.Controls.Add(this.lblStockType);
            this.grpBox2.Controls.Add(this.txtStockName);
            this.grpBox2.Controls.Add(this.lblStockName);
            this.grpBox2.Location = new System.Drawing.Point(24, 239);
            this.grpBox2.Name = "grpBox2";
            this.grpBox2.Size = new System.Drawing.Size(708, 162);
            this.grpBox2.TabIndex = 72;
            this.grpBox2.TabStop = false;
            this.grpBox2.Visible = false;
            // 
            // frmStockUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 404);
            this.Controls.Add(this.grpBox2);
            this.Controls.Add(this.grpBox1);
            this.Controls.Add(this.btnBackButton);
            this.Controls.Add(this.imgRefresh);
            this.Name = "frmStockUpdate";
            this.Text = "Update Stock";
            this.Load += new System.EventHandler(this.UpdateStock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgRefresh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdAllStock)).EndInit();
            this.grpBox1.ResumeLayout(false);
            this.grpBox1.PerformLayout();
            this.grpBox2.ResumeLayout(false);
            this.grpBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBackButton;
        private System.Windows.Forms.PictureBox imgRefresh;
        private System.Windows.Forms.Button btnUpdateStock;
        private System.Windows.Forms.TextBox txtStockQuantity;
        private System.Windows.Forms.TextBox txtStockPrice;
        private System.Windows.Forms.TextBox txtStockType;
        private System.Windows.Forms.Label lblStockQuantity;
        private System.Windows.Forms.Label lblStockPrice;
        private System.Windows.Forms.Label lblStockType;
        private System.Windows.Forms.TextBox txtStockName;
        private System.Windows.Forms.Label lblStockName;
        private System.Windows.Forms.DataGridView grdAllStock;
        private System.Windows.Forms.Label lblAllStock;
        private System.Windows.Forms.GroupBox grpBox1;
        private System.Windows.Forms.GroupBox grpBox2;
    }
}