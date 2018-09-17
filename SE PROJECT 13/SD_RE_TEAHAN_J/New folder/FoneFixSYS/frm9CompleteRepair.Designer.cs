namespace FoneFixSYS
{
    partial class frm9CompleteRepair
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
            this.txtRepairID = new System.Windows.Forms.TextBox();
            this.btnSubmitRepairID = new System.Windows.Forms.Button();
            this.lblRepairID = new System.Windows.Forms.Label();
            this.btnBackButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtRepairID
            // 
            this.txtRepairID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRepairID.Location = new System.Drawing.Point(50, 81);
            this.txtRepairID.Name = "txtRepairID";
            this.txtRepairID.Size = new System.Drawing.Size(190, 30);
            this.txtRepairID.TabIndex = 13;
            this.txtRepairID.TextChanged += new System.EventHandler(this.txtRepairID_TextChanged);
            // 
            // btnSubmitRepairID
            // 
            this.btnSubmitRepairID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmitRepairID.Location = new System.Drawing.Point(74, 116);
            this.btnSubmitRepairID.Name = "btnSubmitRepairID";
            this.btnSubmitRepairID.Size = new System.Drawing.Size(145, 45);
            this.btnSubmitRepairID.TabIndex = 12;
            this.btnSubmitRepairID.Text = "Complete...";
            this.btnSubmitRepairID.UseVisualStyleBackColor = true;
            this.btnSubmitRepairID.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblRepairID
            // 
            this.lblRepairID.AutoSize = true;
            this.lblRepairID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRepairID.Location = new System.Drawing.Point(21, 56);
            this.lblRepairID.Name = "lblRepairID";
            this.lblRepairID.Size = new System.Drawing.Size(260, 20);
            this.lblRepairID.TabIndex = 11;
            this.lblRepairID.Text = "Please Enter Customer Name...";
            // 
            // btnBackButton
            // 
            this.btnBackButton.BackColor = System.Drawing.SystemColors.Control;
            this.btnBackButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnBackButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnBackButton.FlatAppearance.BorderSize = 20;
            this.btnBackButton.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnBackButton.Image = global::FoneFixSYS.Properties.Resources.Arrows_Back_icon;
            this.btnBackButton.Location = new System.Drawing.Point(0, 0);
            this.btnBackButton.Name = "btnBackButton";
            this.btnBackButton.Size = new System.Drawing.Size(80, 35);
            this.btnBackButton.TabIndex = 30;
            this.btnBackButton.UseVisualStyleBackColor = false;
            this.btnBackButton.Click += new System.EventHandler(this.btnBackButton_Click);
            // 
            // frm9CompleteRepair
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 171);
            this.Controls.Add(this.btnBackButton);
            this.Controls.Add(this.txtRepairID);
            this.Controls.Add(this.btnSubmitRepairID);
            this.Controls.Add(this.lblRepairID);
            this.Name = "frm9CompleteRepair";
            this.Text = "CompleteRepair";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtRepairID;
        private System.Windows.Forms.Button btnSubmitRepairID;
        private System.Windows.Forms.Label lblRepairID;
        private System.Windows.Forms.Button btnBackButton;
    }
}