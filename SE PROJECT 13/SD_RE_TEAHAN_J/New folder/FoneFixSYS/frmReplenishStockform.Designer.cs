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
            this.SuspendLayout();
            // 
            // lblPartsUsed
            // 
            this.lblPartsUsed.AutoSize = true;
            this.lblPartsUsed.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPartsUsed.Location = new System.Drawing.Point(12, 77);
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
            "iPhone 7 Screen x 2",
            "iPhone 6s Battery x 4",
            "Samsung J3 mini Chargin Port x 5",
            "Nokia 3310 Screen x 2",
            "iPhone SE Chargin Port x 5"});
            this.cbbPartsUsed.Location = new System.Drawing.Point(115, 74);
            this.cbbPartsUsed.Name = "cbbPartsUsed";
            this.cbbPartsUsed.Size = new System.Drawing.Size(220, 21);
            this.cbbPartsUsed.TabIndex = 56;
            // 
            // ReplenishStockform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 141);
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
    }
}