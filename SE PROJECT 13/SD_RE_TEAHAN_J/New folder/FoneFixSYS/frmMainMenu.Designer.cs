namespace FoneFixSYS
{
    partial class frmMainMenu
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblManageCustomers = new System.Windows.Forms.Label();
            this.lblManageStock = new System.Windows.Forms.Label();
            this.lblProcessRepairs = new System.Windows.Forms.Label();
            this.lblCarryOutAdministration = new System.Windows.Forms.Label();
            this.btnCarryOutAdministration = new System.Windows.Forms.Button();
            this.btnProcessRepairs = new System.Windows.Forms.Button();
            this.btnManageStock = new System.Windows.Forms.Button();
            this.btnManageCustomers = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Console", 60F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.label1.Location = new System.Drawing.Point(12, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(370, 80);
            this.label1.TabIndex = 0;
            this.label1.Text = "FoneFix";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblManageCustomers
            // 
            this.lblManageCustomers.AutoSize = true;
            this.lblManageCustomers.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManageCustomers.Location = new System.Drawing.Point(49, 302);
            this.lblManageCustomers.Name = "lblManageCustomers";
            this.lblManageCustomers.Size = new System.Drawing.Size(200, 25);
            this.lblManageCustomers.TabIndex = 2;
            this.lblManageCustomers.Text = "Manage Customers";
            this.lblManageCustomers.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblManageStock
            // 
            this.lblManageStock.AutoSize = true;
            this.lblManageStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManageStock.Location = new System.Drawing.Point(49, 420);
            this.lblManageStock.Name = "lblManageStock";
            this.lblManageStock.Size = new System.Drawing.Size(151, 25);
            this.lblManageStock.TabIndex = 4;
            this.lblManageStock.Text = "Manage Stock";
            // 
            // lblProcessRepairs
            // 
            this.lblProcessRepairs.AutoSize = true;
            this.lblProcessRepairs.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProcessRepairs.Location = new System.Drawing.Point(49, 535);
            this.lblProcessRepairs.Name = "lblProcessRepairs";
            this.lblProcessRepairs.Size = new System.Drawing.Size(169, 25);
            this.lblProcessRepairs.TabIndex = 6;
            this.lblProcessRepairs.Text = "Process Repairs";
            // 
            // lblCarryOutAdministration
            // 
            this.lblCarryOutAdministration.AutoSize = true;
            this.lblCarryOutAdministration.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarryOutAdministration.Location = new System.Drawing.Point(49, 650);
            this.lblCarryOutAdministration.Name = "lblCarryOutAdministration";
            this.lblCarryOutAdministration.Size = new System.Drawing.Size(253, 25);
            this.lblCarryOutAdministration.TabIndex = 8;
            this.lblCarryOutAdministration.Text = "Carry-Out-Administration";
            // 
            // btnCarryOutAdministration
            // 
            this.btnCarryOutAdministration.BackColor = System.Drawing.SystemColors.Control;
            this.btnCarryOutAdministration.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.btnCarryOutAdministration.Image = global::FoneFixSYS.Properties.Resources.COA1;
            this.btnCarryOutAdministration.Location = new System.Drawing.Point(303, 628);
            this.btnCarryOutAdministration.Name = "btnCarryOutAdministration";
            this.btnCarryOutAdministration.Size = new System.Drawing.Size(75, 75);
            this.btnCarryOutAdministration.TabIndex = 11;
            this.btnCarryOutAdministration.UseVisualStyleBackColor = false;
            this.btnCarryOutAdministration.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnProcessRepairs
            // 
            this.btnProcessRepairs.BackColor = System.Drawing.SystemColors.Control;
            this.btnProcessRepairs.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.btnProcessRepairs.Image = global::FoneFixSYS.Properties.Resources.processRepairs;
            this.btnProcessRepairs.Location = new System.Drawing.Point(303, 513);
            this.btnProcessRepairs.Name = "btnProcessRepairs";
            this.btnProcessRepairs.Size = new System.Drawing.Size(75, 75);
            this.btnProcessRepairs.TabIndex = 10;
            this.btnProcessRepairs.UseVisualStyleBackColor = false;
            this.btnProcessRepairs.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnManageStock
            // 
            this.btnManageStock.BackColor = System.Drawing.SystemColors.Control;
            this.btnManageStock.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.btnManageStock.Image = global::FoneFixSYS.Properties.Resources.manageStock;
            this.btnManageStock.Location = new System.Drawing.Point(303, 398);
            this.btnManageStock.Name = "btnManageStock";
            this.btnManageStock.Size = new System.Drawing.Size(75, 75);
            this.btnManageStock.TabIndex = 9;
            this.btnManageStock.UseVisualStyleBackColor = false;
            this.btnManageStock.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnManageCustomers
            // 
            this.btnManageCustomers.BackColor = System.Drawing.SystemColors.Control;
            this.btnManageCustomers.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.btnManageCustomers.Image = global::FoneFixSYS.Properties.Resources.manageCustomers;
            this.btnManageCustomers.Location = new System.Drawing.Point(303, 280);
            this.btnManageCustomers.Name = "btnManageCustomers";
            this.btnManageCustomers.Size = new System.Drawing.Size(75, 75);
            this.btnManageCustomers.TabIndex = 3;
            this.btnManageCustomers.UseVisualStyleBackColor = false;
            this.btnManageCustomers.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FoneFixSYS.Properties.Resources.final1;
            this.pictureBox1.Location = new System.Drawing.Point(388, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(98, 197);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // frmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 754);
            this.Controls.Add(this.btnCarryOutAdministration);
            this.Controls.Add(this.btnProcessRepairs);
            this.Controls.Add(this.btnManageStock);
            this.Controls.Add(this.lblCarryOutAdministration);
            this.Controls.Add(this.lblProcessRepairs);
            this.Controls.Add(this.lblManageStock);
            this.Controls.Add(this.btnManageCustomers);
            this.Controls.Add(this.lblManageCustomers);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Name = "frmMainMenu";
            this.Text = "Main Menu";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblManageCustomers;
        private System.Windows.Forms.Button btnManageCustomers;
        private System.Windows.Forms.Label lblManageStock;
        private System.Windows.Forms.Label lblProcessRepairs;
        private System.Windows.Forms.Label lblCarryOutAdministration;
        private System.Windows.Forms.Button btnManageStock;
        private System.Windows.Forms.Button btnProcessRepairs;
        private System.Windows.Forms.Button btnCarryOutAdministration;
    }
}