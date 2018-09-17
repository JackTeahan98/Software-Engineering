namespace FoneFixSYS
{
    partial class ReplenishStockform
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
            this.lblPartsUsed = new System.Windows.Forms.Label();
            this.btnBackButton = new System.Windows.Forms.Button();
            this.cbbPartsUsed = new System.Windows.Forms.ComboBox();
            this.btnSubmitRepairID = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblPartsUsed
            // 
            this.lblPartsUsed.AutoSize = true;
            this.lblPartsUsed.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPartsUsed.Location = new System.Drawing.Point(157, 39);
            this.lblPartsUsed.Name = "lblPartsUsed";
            this.lblPartsUsed.Size = new System.Drawing.Size(96, 16);
            this.lblPartsUsed.TabIndex = 53;
            this.lblPartsUsed.Text = "Parts Used:";
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
            this.btnBackButton.TabIndex = 55;
            this.btnBackButton.UseVisualStyleBackColor = false;
            this.btnBackButton.Click += new System.EventHandler(this.button4_Click);
            // 
            // cbbPartsUsed
            // 
            this.cbbPartsUsed.FormattingEnabled = true;
            this.cbbPartsUsed.Items.AddRange(new object[] {
            "iPhone",
            "Samsung",
            "OnePlus",
            "Nokia",
            "Alcatel",
            "CAT"});
            this.cbbPartsUsed.Location = new System.Drawing.Point(25, 58);
            this.cbbPartsUsed.Name = "cbbPartsUsed";
            this.cbbPartsUsed.Size = new System.Drawing.Size(107, 21);
            this.cbbPartsUsed.TabIndex = 56;
            // 
            // btnSubmitRepairID
            // 
            this.btnSubmitRepairID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmitRepairID.Location = new System.Drawing.Point(98, 105);
            this.btnSubmitRepairID.Name = "btnSubmitRepairID";
            this.btnSubmitRepairID.Size = new System.Drawing.Size(205, 45);
            this.btnSubmitRepairID.TabIndex = 57;
            this.btnSubmitRepairID.Text = "Add to Used Parts File...";
            this.btnSubmitRepairID.UseVisualStyleBackColor = true;
            this.btnSubmitRepairID.Click += new System.EventHandler(this.btnSubmitRepairID_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Battery",
            "Screen",
            "Charging Port",
            "Camera",
            "Microfone",
            "Back Panel",
            ""});
            this.comboBox1.Location = new System.Drawing.Point(150, 58);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(107, 21);
            this.comboBox1.TabIndex = 58;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "x 1",
            "x 2",
            "x 3",
            "x 4",
            "x 5",
            "x 6",
            "x 7",
            "x 8",
            "x 9",
            "x 10",
            "x 10+"});
            this.comboBox2.Location = new System.Drawing.Point(273, 58);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(107, 21);
            this.comboBox2.TabIndex = 59;
            // 
            // ReplenishStockform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 162);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnSubmitRepairID);
            this.Controls.Add(this.cbbPartsUsed);
            this.Controls.Add(this.btnBackButton);
            this.Controls.Add(this.lblPartsUsed);
            this.Name = "ReplenishStockform";
            this.Text = "ReplenishStockform";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBackButton;
        private System.Windows.Forms.Label lblPartsUsed;
        private System.Windows.Forms.ComboBox cbbPartsUsed;
        private System.Windows.Forms.Button btnSubmitRepairID;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
    }
}