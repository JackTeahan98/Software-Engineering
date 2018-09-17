namespace FoneFixSYS
{
    partial class frmCOACustomerAnalysis
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.lblHeader = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            this.grpCustomers = new System.Windows.Forms.GroupBox();
            this.lblYearFill = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.chtCustomers = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.cboYear = new System.Windows.Forms.ComboBox();
            this.btnBackButton = new System.Windows.Forms.Button();
            this.grpCustomers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chtCustomers)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(189, 25);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(263, 36);
            this.lblHeader.TabIndex = 75;
            this.lblHeader.Text = "Customer Analysis";
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Location = new System.Drawing.Point(29, 77);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(71, 13);
            this.lblYear.TabIndex = 74;
            this.lblYear.Text = "Pick a Year...";
            // 
            // grpCustomers
            // 
            this.grpCustomers.Controls.Add(this.lblYearFill);
            this.grpCustomers.Controls.Add(this.lblDescription);
            this.grpCustomers.Controls.Add(this.chtCustomers);
            this.grpCustomers.Location = new System.Drawing.Point(12, 120);
            this.grpCustomers.Name = "grpCustomers";
            this.grpCustomers.Size = new System.Drawing.Size(619, 418);
            this.grpCustomers.TabIndex = 73;
            this.grpCustomers.TabStop = false;
            this.grpCustomers.Visible = false;
            this.grpCustomers.Enter += new System.EventHandler(this.grpCustomers_Enter);
            // 
            // lblYearFill
            // 
            this.lblYearFill.AutoSize = true;
            this.lblYearFill.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYearFill.Location = new System.Drawing.Point(250, 92);
            this.lblYearFill.Name = "lblYearFill";
            this.lblYearFill.Size = new System.Drawing.Size(49, 20);
            this.lblYearFill.TabIndex = 70;
            this.lblYearFill.Text = "2018";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(6, 26);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(529, 17);
            this.lblDescription.TabIndex = 67;
            this.lblDescription.Text = "A chart showing the number of customers added to the system in the year selected";
            // 
            // chtCustomers
            // 
            chartArea1.Name = "ChartArea1";
            this.chtCustomers.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chtCustomers.Legends.Add(legend1);
            this.chtCustomers.Location = new System.Drawing.Point(-6, 117);
            this.chtCustomers.Name = "chtCustomers";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chtCustomers.Series.Add(series1);
            this.chtCustomers.Size = new System.Drawing.Size(548, 299);
            this.chtCustomers.TabIndex = 66;
            this.chtCustomers.Text = "chart1";
            // 
            // cboYear
            // 
            this.cboYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboYear.FormattingEnabled = true;
            this.cboYear.Items.AddRange(new object[] {
            "18",
            "17"});
            this.cboYear.Location = new System.Drawing.Point(29, 93);
            this.cboYear.Name = "cboYear";
            this.cboYear.Size = new System.Drawing.Size(121, 21);
            this.cboYear.TabIndex = 72;
            this.cboYear.SelectedIndexChanged += new System.EventHandler(this.cboYear_SelectedIndexChanged_1);
            // 
            // btnBackButton
            // 
            this.btnBackButton.BackColor = System.Drawing.SystemColors.Control;
            this.btnBackButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnBackButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnBackButton.FlatAppearance.BorderSize = 20;
            this.btnBackButton.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnBackButton.Image = global::FoneFixSYS.Properties.Resources.Arrows_Back_icon;
            this.btnBackButton.Location = new System.Drawing.Point(-1, -1);
            this.btnBackButton.Name = "btnBackButton";
            this.btnBackButton.Size = new System.Drawing.Size(80, 35);
            this.btnBackButton.TabIndex = 71;
            this.btnBackButton.UseVisualStyleBackColor = false;
            this.btnBackButton.Click += new System.EventHandler(this.btnBackButton_Click_1);
            // 
            // frmCOACustomerAnalysis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 581);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.grpCustomers);
            this.Controls.Add(this.cboYear);
            this.Controls.Add(this.btnBackButton);
            this.Name = "frmCOACustomerAnalysis";
            this.Text = "frmCOACustomerAnalysis";
            this.Load += new System.EventHandler(this.frmCOACustomerAnalysis_Load);
            this.grpCustomers.ResumeLayout(false);
            this.grpCustomers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chtCustomers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.GroupBox grpCustomers;
        private System.Windows.Forms.DataVisualization.Charting.Chart chtCustomers;
        private System.Windows.Forms.ComboBox cboYear;
        private System.Windows.Forms.Button btnBackButton;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblYearFill;
    }
}