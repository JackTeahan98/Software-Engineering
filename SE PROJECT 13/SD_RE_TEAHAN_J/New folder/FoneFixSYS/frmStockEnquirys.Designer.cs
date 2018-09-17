namespace FoneFixSYS
{
    partial class frmStockEnquirys
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
            this.btnBackButton = new System.Windows.Forms.Button();
            this.txtNameEntered = new System.Windows.Forms.TextBox();
            this.btnSubmitCustomerID = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.grpBoxSearch = new System.Windows.Forms.GroupBox();
            this.grdAllStock = new System.Windows.Forms.DataGridView();
            this.grpBoxDetails = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.grpBoxSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdAllStock)).BeginInit();
            this.grpBoxDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtStockQuantity
            // 
            this.txtStockQuantity.Enabled = false;
            this.txtStockQuantity.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStockQuantity.Location = new System.Drawing.Point(147, 170);
            this.txtStockQuantity.Name = "txtStockQuantity";
            this.txtStockQuantity.Size = new System.Drawing.Size(148, 23);
            this.txtStockQuantity.TabIndex = 73;
            this.txtStockQuantity.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // txtStockPrice
            // 
            this.txtStockPrice.Enabled = false;
            this.txtStockPrice.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStockPrice.Location = new System.Drawing.Point(147, 135);
            this.txtStockPrice.Name = "txtStockPrice";
            this.txtStockPrice.Size = new System.Drawing.Size(148, 23);
            this.txtStockPrice.TabIndex = 72;
            // 
            // txtStockType
            // 
            this.txtStockType.Enabled = false;
            this.txtStockType.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStockType.Location = new System.Drawing.Point(147, 101);
            this.txtStockType.Name = "txtStockType";
            this.txtStockType.Size = new System.Drawing.Size(148, 23);
            this.txtStockType.TabIndex = 71;
            // 
            // lblStockQuantity
            // 
            this.lblStockQuantity.AutoSize = true;
            this.lblStockQuantity.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStockQuantity.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblStockQuantity.Location = new System.Drawing.Point(18, 174);
            this.lblStockQuantity.Name = "lblStockQuantity";
            this.lblStockQuantity.Size = new System.Drawing.Size(122, 16);
            this.lblStockQuantity.TabIndex = 70;
            this.lblStockQuantity.Text = "Stock Quantity";
            this.lblStockQuantity.Click += new System.EventHandler(this.label4_Click);
            // 
            // lblStockPrice
            // 
            this.lblStockPrice.AutoSize = true;
            this.lblStockPrice.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStockPrice.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblStockPrice.Location = new System.Drawing.Point(18, 142);
            this.lblStockPrice.Name = "lblStockPrice";
            this.lblStockPrice.Size = new System.Drawing.Size(94, 16);
            this.lblStockPrice.TabIndex = 69;
            this.lblStockPrice.Text = "Stock Price";
            // 
            // lblStockType
            // 
            this.lblStockType.AutoSize = true;
            this.lblStockType.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStockType.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblStockType.Location = new System.Drawing.Point(18, 104);
            this.lblStockType.Name = "lblStockType";
            this.lblStockType.Size = new System.Drawing.Size(94, 16);
            this.lblStockType.TabIndex = 68;
            this.lblStockType.Text = "Stock Type";
            // 
            // txtStockName
            // 
            this.txtStockName.Enabled = false;
            this.txtStockName.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStockName.Location = new System.Drawing.Point(148, 61);
            this.txtStockName.Name = "txtStockName";
            this.txtStockName.Size = new System.Drawing.Size(147, 23);
            this.txtStockName.TabIndex = 67;
            // 
            // lblStockName
            // 
            this.lblStockName.AutoSize = true;
            this.lblStockName.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStockName.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblStockName.Location = new System.Drawing.Point(18, 68);
            this.lblStockName.Name = "lblStockName";
            this.lblStockName.Size = new System.Drawing.Size(97, 16);
            this.lblStockName.TabIndex = 66;
            this.lblStockName.Text = "Stock Name";
            // 
            // txtStockID
            // 
            this.txtStockID.Enabled = false;
            this.txtStockID.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStockID.Location = new System.Drawing.Point(148, 7);
            this.txtStockID.Name = "txtStockID";
            this.txtStockID.Size = new System.Drawing.Size(46, 23);
            this.txtStockID.TabIndex = 78;
            // 
            // lblStockID
            // 
            this.lblStockID.AutoSize = true;
            this.lblStockID.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStockID.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblStockID.Location = new System.Drawing.Point(18, 14);
            this.lblStockID.Name = "lblStockID";
            this.lblStockID.Size = new System.Drawing.Size(73, 16);
            this.lblStockID.TabIndex = 77;
            this.lblStockID.Text = "Stock ID";
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
            // txtNameEntered
            // 
            this.txtNameEntered.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNameEntered.Location = new System.Drawing.Point(221, 21);
            this.txtNameEntered.MaxLength = 20;
            this.txtNameEntered.Name = "txtNameEntered";
            this.txtNameEntered.Size = new System.Drawing.Size(174, 23);
            this.txtNameEntered.TabIndex = 81;
            this.txtNameEntered.TextChanged += new System.EventHandler(this.txtNameEntered_TextChanged);
            // 
            // btnSubmitCustomerID
            // 
            this.btnSubmitCustomerID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmitCustomerID.Location = new System.Drawing.Point(140, 52);
            this.btnSubmitCustomerID.Name = "btnSubmitCustomerID";
            this.btnSubmitCustomerID.Size = new System.Drawing.Size(145, 32);
            this.btnSubmitCustomerID.TabIndex = 80;
            this.btnSubmitCustomerID.Text = "Search...";
            this.btnSubmitCustomerID.UseVisualStyleBackColor = true;
            this.btnSubmitCustomerID.Click += new System.EventHandler(this.btnSubmitCustomerID_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 18);
            this.label1.TabIndex = 79;
            this.label1.Text = "Please Enter Stock Name...";
            // 
            // grpBoxSearch
            // 
            this.grpBoxSearch.Controls.Add(this.label2);
            this.grpBoxSearch.Controls.Add(this.grdAllStock);
            this.grpBoxSearch.Controls.Add(this.txtNameEntered);
            this.grpBoxSearch.Controls.Add(this.btnSubmitCustomerID);
            this.grpBoxSearch.Controls.Add(this.label1);
            this.grpBoxSearch.Location = new System.Drawing.Point(0, 44);
            this.grpBoxSearch.Name = "grpBoxSearch";
            this.grpBoxSearch.Size = new System.Drawing.Size(574, 263);
            this.grpBoxSearch.TabIndex = 82;
            this.grpBoxSearch.TabStop = false;
            this.grpBoxSearch.Text = "Search...";
            // 
            // grdAllStock
            // 
            this.grdAllStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdAllStock.Location = new System.Drawing.Point(21, 111);
            this.grdAllStock.Name = "grdAllStock";
            this.grdAllStock.ReadOnly = true;
            this.grdAllStock.Size = new System.Drawing.Size(561, 150);
            this.grdAllStock.TabIndex = 83;
            this.grdAllStock.Visible = false;
            this.grdAllStock.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdAllStock_CellClick);
            this.grdAllStock.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdAllStock_CellContentClick);
            // 
            // grpBoxDetails
            // 
            this.grpBoxDetails.Controls.Add(this.txtStockID);
            this.grpBoxDetails.Controls.Add(this.lblStockID);
            this.grpBoxDetails.Controls.Add(this.txtStockQuantity);
            this.grpBoxDetails.Controls.Add(this.txtStockPrice);
            this.grpBoxDetails.Controls.Add(this.txtStockType);
            this.grpBoxDetails.Controls.Add(this.lblStockQuantity);
            this.grpBoxDetails.Controls.Add(this.lblStockPrice);
            this.grpBoxDetails.Controls.Add(this.lblStockType);
            this.grpBoxDetails.Controls.Add(this.txtStockName);
            this.grpBoxDetails.Controls.Add(this.lblStockName);
            this.grpBoxDetails.Location = new System.Drawing.Point(0, 327);
            this.grpBoxDetails.Name = "grpBoxDetails";
            this.grpBoxDetails.Size = new System.Drawing.Size(573, 215);
            this.grpBoxDetails.TabIndex = 84;
            this.grpBoxDetails.TabStop = false;
            this.grpBoxDetails.Text = "Details...";
            this.grpBoxDetails.Visible = false;
            this.grpBoxDetails.Enter += new System.EventHandler(this.grpBoxDetails_Enter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 15);
            this.label2.TabIndex = 82;
            this.label2.Text = "Click to retrieve details...";
            // 
            // frmStockEnquirys
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 523);
            this.Controls.Add(this.grpBoxDetails);
            this.Controls.Add(this.grpBoxSearch);
            this.Controls.Add(this.btnBackButton);
            this.Name = "frmStockEnquirys";
            this.Text = "StockEnquiry";
            this.Load += new System.EventHandler(this.StockEnquiry_Load);
            this.grpBoxSearch.ResumeLayout(false);
            this.grpBoxSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdAllStock)).EndInit();
            this.grpBoxDetails.ResumeLayout(false);
            this.grpBoxDetails.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBackButton;
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
        private System.Windows.Forms.TextBox txtNameEntered;
        private System.Windows.Forms.Button btnSubmitCustomerID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpBoxSearch;
        private System.Windows.Forms.DataGridView grdAllStock;
        private System.Windows.Forms.GroupBox grpBoxDetails;
        private System.Windows.Forms.Label label2;
    }
}