namespace FoneFixSYS
{
    partial class frmCustomerDeregister
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
            this.button4 = new System.Windows.Forms.Button();
            this.lblHeader = new System.Windows.Forms.Label();
            this.grdAllCustomers = new System.Windows.Forms.DataGridView();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.lblCustomerStatus = new System.Windows.Forms.Label();
            this.lblCustomerID = new System.Windows.Forms.Label();
            this.txtCustomerID = new System.Windows.Forms.TextBox();
            this.btnCustomerDeRegister = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grdAllCustomers)).BeginInit();
            this.SuspendLayout();
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.Control;
            this.button4.Cursor = System.Windows.Forms.Cursors.Default;
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button4.FlatAppearance.BorderSize = 20;
            this.button4.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.button4.Image = global::FoneFixSYS.Properties.Resources.Arrows_Back_icon;
            this.button4.Location = new System.Drawing.Point(1, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(80, 35);
            this.button4.TabIndex = 54;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(520, 26);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(186, 24);
            this.lblHeader.TabIndex = 61;
            this.lblHeader.Text = "Select From Grid...";
            // 
            // grdAllCustomers
            // 
            this.grdAllCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdAllCustomers.Location = new System.Drawing.Point(18, 67);
            this.grdAllCustomers.Name = "grdAllCustomers";
            this.grdAllCustomers.ReadOnly = true;
            this.grdAllCustomers.Size = new System.Drawing.Size(1222, 195);
            this.grdAllCustomers.TabIndex = 60;
            this.grdAllCustomers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdAllCustomers_CellClick);
            this.grdAllCustomers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdAllCustomers_CellContentClick);
            // 
            // cmbStatus
            // 
            this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "A",
            "D"});
            this.cmbStatus.Location = new System.Drawing.Point(559, 338);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(200, 21);
            this.cmbStatus.TabIndex = 63;
            this.cmbStatus.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // lblCustomerStatus
            // 
            this.lblCustomerStatus.AutoSize = true;
            this.lblCustomerStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerStatus.Location = new System.Drawing.Point(388, 339);
            this.lblCustomerStatus.Name = "lblCustomerStatus";
            this.lblCustomerStatus.Size = new System.Drawing.Size(159, 17);
            this.lblCustomerStatus.TabIndex = 64;
            this.lblCustomerStatus.Text = "Select Customer Status:";
            this.lblCustomerStatus.Click += new System.EventHandler(this.lblCustomerStatus_Click);
            // 
            // lblCustomerID
            // 
            this.lblCustomerID.AutoSize = true;
            this.lblCustomerID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerID.Location = new System.Drawing.Point(388, 311);
            this.lblCustomerID.Name = "lblCustomerID";
            this.lblCustomerID.Size = new System.Drawing.Size(123, 17);
            this.lblCustomerID.TabIndex = 65;
            this.lblCustomerID.Text = "Enter CustomerID:";
            // 
            // txtCustomerID
            // 
            this.txtCustomerID.Enabled = false;
            this.txtCustomerID.Location = new System.Drawing.Point(559, 310);
            this.txtCustomerID.Name = "txtCustomerID";
            this.txtCustomerID.Size = new System.Drawing.Size(200, 20);
            this.txtCustomerID.TabIndex = 66;
            // 
            // btnCustomerDeRegister
            // 
            this.btnCustomerDeRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomerDeRegister.Location = new System.Drawing.Point(524, 392);
            this.btnCustomerDeRegister.Name = "btnCustomerDeRegister";
            this.btnCustomerDeRegister.Size = new System.Drawing.Size(166, 47);
            this.btnCustomerDeRegister.TabIndex = 67;
            this.btnCustomerDeRegister.Text = "Update Customer Status...";
            this.btnCustomerDeRegister.UseVisualStyleBackColor = true;
            this.btnCustomerDeRegister.Click += new System.EventHandler(this.btnCustomerDeRegister_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(765, 355);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 17);
            this.label1.TabIndex = 68;
            this.label1.Text = "D : DEACTIVE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(765, 338);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 17);
            this.label2.TabIndex = 69;
            this.label2.Text = "A : ACTIVE";
            // 
            // frmCustomerDeregister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1252, 460);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCustomerDeRegister);
            this.Controls.Add(this.txtCustomerID);
            this.Controls.Add(this.lblCustomerID);
            this.Controls.Add(this.lblCustomerStatus);
            this.Controls.Add(this.cmbStatus);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.grdAllCustomers);
            this.Controls.Add(this.button4);
            this.Name = "frmCustomerDeregister";
            this.Text = "Delete Customer";
            this.Load += new System.EventHandler(this.frmCustomerDeregister_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdAllCustomers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.DataGridView grdAllCustomers;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Label lblCustomerStatus;
        private System.Windows.Forms.Label lblCustomerID;
        private System.Windows.Forms.TextBox txtCustomerID;
        private System.Windows.Forms.Button btnCustomerDeRegister;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}