namespace FoneFixSYS
{
    partial class frmRepairCancel
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
            this.btnRepairCancel = new System.Windows.Forms.Button();
            this.txtRepairID = new System.Windows.Forms.TextBox();
            this.lblRepairID = new System.Windows.Forms.Label();
            this.lblRepairStatus = new System.Windows.Forms.Label();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.lblHeader = new System.Windows.Forms.Label();
            this.grdAllRepairs = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.grdAllRepairs)).BeginInit();
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
            this.btnBackButton.Location = new System.Drawing.Point(1, 1);
            this.btnBackButton.Name = "btnBackButton";
            this.btnBackButton.Size = new System.Drawing.Size(80, 35);
            this.btnBackButton.TabIndex = 29;
            this.btnBackButton.UseVisualStyleBackColor = false;
            this.btnBackButton.Click += new System.EventHandler(this.btnBackButton_Click);
            // 
            // btnRepairCancel
            // 
            this.btnRepairCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRepairCancel.Location = new System.Drawing.Point(330, 406);
            this.btnRepairCancel.Name = "btnRepairCancel";
            this.btnRepairCancel.Size = new System.Drawing.Size(166, 47);
            this.btnRepairCancel.TabIndex = 77;
            this.btnRepairCancel.Text = "Update Repair Status...";
            this.btnRepairCancel.UseVisualStyleBackColor = true;
            this.btnRepairCancel.Click += new System.EventHandler(this.btnRepairCancel_Click);
            // 
            // txtRepairID
            // 
            this.txtRepairID.Enabled = false;
            this.txtRepairID.Location = new System.Drawing.Point(406, 322);
            this.txtRepairID.Name = "txtRepairID";
            this.txtRepairID.Size = new System.Drawing.Size(200, 20);
            this.txtRepairID.TabIndex = 76;
            // 
            // lblRepairID
            // 
            this.lblRepairID.AutoSize = true;
            this.lblRepairID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRepairID.Location = new System.Drawing.Point(235, 323);
            this.lblRepairID.Name = "lblRepairID";
            this.lblRepairID.Size = new System.Drawing.Size(105, 17);
            this.lblRepairID.TabIndex = 75;
            this.lblRepairID.Text = "Enter RepairID:";
            // 
            // lblRepairStatus
            // 
            this.lblRepairStatus.AutoSize = true;
            this.lblRepairStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRepairStatus.Location = new System.Drawing.Point(235, 351);
            this.lblRepairStatus.Name = "lblRepairStatus";
            this.lblRepairStatus.Size = new System.Drawing.Size(141, 17);
            this.lblRepairStatus.TabIndex = 74;
            this.lblRepairStatus.Text = "Select Repair Status:";
            // 
            // cmbStatus
            // 
            this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "IN PROGRESS",
            "CANCELLED"});
            this.cmbStatus.Location = new System.Drawing.Point(406, 350);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(200, 21);
            this.cmbStatus.TabIndex = 73;
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(296, 44);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(280, 24);
            this.lblHeader.TabIndex = 72;
            this.lblHeader.Text = "Select From Grid to Cancel...";
            // 
            // grdAllRepairs
            // 
            this.grdAllRepairs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdAllRepairs.Location = new System.Drawing.Point(32, 101);
            this.grdAllRepairs.Name = "grdAllRepairs";
            this.grdAllRepairs.ReadOnly = true;
            this.grdAllRepairs.Size = new System.Drawing.Size(756, 195);
            this.grdAllRepairs.TabIndex = 71;
            this.grdAllRepairs.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdAllRepair_CellClick);
            this.grdAllRepairs.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdAllRepairs_CellContentClick);
            // 
            // frmRepairCancel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 472);
            this.Controls.Add(this.btnRepairCancel);
            this.Controls.Add(this.txtRepairID);
            this.Controls.Add(this.lblRepairID);
            this.Controls.Add(this.lblRepairStatus);
            this.Controls.Add(this.cmbStatus);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.grdAllRepairs);
            this.Controls.Add(this.btnBackButton);
            this.Name = "frmRepairCancel";
            this.Text = "deleteRepair";
            this.Load += new System.EventHandler(this.frmRepairCancel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdAllRepairs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBackButton;
        private System.Windows.Forms.Button btnRepairCancel;
        private System.Windows.Forms.TextBox txtRepairID;
        private System.Windows.Forms.Label lblRepairID;
        private System.Windows.Forms.Label lblRepairStatus;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.DataGridView grdAllRepairs;
    }
}