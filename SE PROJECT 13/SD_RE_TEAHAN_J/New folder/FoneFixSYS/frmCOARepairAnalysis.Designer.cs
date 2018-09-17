namespace FoneFixSYS
{
    partial class frmCOARepairAnalysis
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
            this.grdRepairAnalysis = new System.Windows.Forms.DataGridView();
            this.btnBackButton = new System.Windows.Forms.Button();
            this.StockID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StockName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StockType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StockPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StockQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdRepairAnalysis)).BeginInit();
            this.SuspendLayout();
            // 
            // grdRepairAnalysis
            // 
            this.grdRepairAnalysis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdRepairAnalysis.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StockID,
            this.StockName,
            this.StockType,
            this.StockPrice,
            this.StockQuantity,
            this.Description});
            this.grdRepairAnalysis.Location = new System.Drawing.Point(15, 90);
            this.grdRepairAnalysis.Margin = new System.Windows.Forms.Padding(4);
            this.grdRepairAnalysis.Name = "grdRepairAnalysis";
            this.grdRepairAnalysis.Size = new System.Drawing.Size(731, 182);
            this.grdRepairAnalysis.TabIndex = 55;
            // 
            // btnBackButton
            // 
            this.btnBackButton.BackColor = System.Drawing.SystemColors.Control;
            this.btnBackButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnBackButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnBackButton.FlatAppearance.BorderSize = 20;
            this.btnBackButton.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnBackButton.Image = global::FoneFixSYS.Properties.Resources.Arrows_Back_icon;
            this.btnBackButton.Location = new System.Drawing.Point(1, 2);
            this.btnBackButton.Margin = new System.Windows.Forms.Padding(4);
            this.btnBackButton.Name = "btnBackButton";
            this.btnBackButton.Size = new System.Drawing.Size(107, 43);
            this.btnBackButton.TabIndex = 56;
            this.btnBackButton.UseVisualStyleBackColor = false;
            this.btnBackButton.Click += new System.EventHandler(this.btnBackButton_Click);
            // 
            // StockID
            // 
            this.StockID.HeaderText = "Repair ID";
            this.StockID.Name = "StockID";
            // 
            // StockName
            // 
            this.StockName.HeaderText = "Phone Serial Number";
            this.StockName.Name = "StockName";
            // 
            // StockType
            // 
            this.StockType.HeaderText = "Password";
            this.StockType.Name = "StockType";
            // 
            // StockPrice
            // 
            this.StockPrice.HeaderText = "Customer Name";
            this.StockPrice.Name = "StockPrice";
            // 
            // StockQuantity
            // 
            this.StockQuantity.HeaderText = "CustomerID";
            this.StockQuantity.Name = "StockQuantity";
            // 
            // Description
            // 
            this.Description.HeaderText = "Description";
            this.Description.Name = "Description";
            // 
            // frm14RepairAnalysisResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 306);
            this.Controls.Add(this.btnBackButton);
            this.Controls.Add(this.grdRepairAnalysis);
            this.Name = "frm14RepairAnalysisResult";
            this.Text = "frm14RepairAnalysisResult";
            this.Load += new System.EventHandler(this.frm14RepairAnalysisResult_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdRepairAnalysis)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grdRepairAnalysis;
        private System.Windows.Forms.Button btnBackButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn StockID;
        private System.Windows.Forms.DataGridViewTextBoxColumn StockName;
        private System.Windows.Forms.DataGridViewTextBoxColumn StockType;
        private System.Windows.Forms.DataGridViewTextBoxColumn StockPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn StockQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
    }
}