namespace FoneFixSYS
{
    partial class frmDeleteRepair
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
            this.SuspendLayout();
            // 
            // txtRepairID
            // 
            this.txtRepairID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRepairID.Location = new System.Drawing.Point(109, 67);
            this.txtRepairID.Name = "txtRepairID";
            this.txtRepairID.Size = new System.Drawing.Size(78, 30);
            this.txtRepairID.TabIndex = 10;
            this.txtRepairID.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnSubmitRepairID
            // 
            this.btnSubmitRepairID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmitRepairID.Location = new System.Drawing.Point(74, 116);
            this.btnSubmitRepairID.Name = "btnSubmitRepairID";
            this.btnSubmitRepairID.Size = new System.Drawing.Size(145, 45);
            this.btnSubmitRepairID.TabIndex = 9;
            this.btnSubmitRepairID.Text = "Submit...";
            this.btnSubmitRepairID.UseVisualStyleBackColor = true;
            this.btnSubmitRepairID.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblRepairID
            // 
            this.lblRepairID.AutoSize = true;
            this.lblRepairID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRepairID.Location = new System.Drawing.Point(46, 28);
            this.lblRepairID.Name = "lblRepairID";
            this.lblRepairID.Size = new System.Drawing.Size(209, 20);
            this.lblRepairID.TabIndex = 8;
            this.lblRepairID.Text = "Please Enter Repair ID...";
            this.lblRepairID.Click += new System.EventHandler(this.label2_Click);
            // 
            // deleteRepair
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 171);
            this.Controls.Add(this.txtRepairID);
            this.Controls.Add(this.btnSubmitRepairID);
            this.Controls.Add(this.lblRepairID);
            this.Name = "deleteRepair";
            this.Text = "deleteRepair";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtRepairID;
        private System.Windows.Forms.Button btnSubmitRepairID;
        private System.Windows.Forms.Label lblRepairID;
    }
}