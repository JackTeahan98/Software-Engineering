namespace FoneFixSYS
{
    partial class frm12RecievePayment
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnRecievePayment = new System.Windows.Forms.Button();
            this.lblIssueInvoice = new System.Windows.Forms.Label();
            this.btnBackButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Name   :   Repair ID 189   :  Samsing Screen",
            "Name   :   Repair ID 12     :  IphoneScreen",
            "Name   :   Repair ID 1009 :  nokia battery"});
            this.comboBox1.Location = new System.Drawing.Point(81, 108);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(212, 21);
            this.comboBox1.TabIndex = 69;
            // 
            // btnRecievePayment
            // 
            this.btnRecievePayment.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecievePayment.Location = new System.Drawing.Point(104, 152);
            this.btnRecievePayment.Name = "btnRecievePayment";
            this.btnRecievePayment.Size = new System.Drawing.Size(169, 55);
            this.btnRecievePayment.TabIndex = 68;
            this.btnRecievePayment.Text = "Recieve Payment";
            this.btnRecievePayment.UseVisualStyleBackColor = true;
            this.btnRecievePayment.Click += new System.EventHandler(this.btnRecievePayment_Click);
            // 
            // lblIssueInvoice
            // 
            this.lblIssueInvoice.AutoSize = true;
            this.lblIssueInvoice.Font = new System.Drawing.Font("MS Reference Sans Serif", 22F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIssueInvoice.Location = new System.Drawing.Point(53, 39);
            this.lblIssueInvoice.Name = "lblIssueInvoice";
            this.lblIssueInvoice.Size = new System.Drawing.Size(293, 38);
            this.lblIssueInvoice.TabIndex = 65;
            this.lblIssueInvoice.Text = "Recieve Payment";
            // 
            // btnBackButton
            // 
            this.btnBackButton.BackColor = System.Drawing.SystemColors.Control;
            this.btnBackButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnBackButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnBackButton.FlatAppearance.BorderSize = 20;
            this.btnBackButton.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnBackButton.Image = global::FoneFixSYS.Properties.Resources.Arrows_Back_icon;
            this.btnBackButton.Location = new System.Drawing.Point(-3, 1);
            this.btnBackButton.Name = "btnBackButton";
            this.btnBackButton.Size = new System.Drawing.Size(80, 35);
            this.btnBackButton.TabIndex = 64;
            this.btnBackButton.UseVisualStyleBackColor = false;
            this.btnBackButton.Click += new System.EventHandler(this.btnBackButton_Click);
            // 
            // frm12RecievePayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 219);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnRecievePayment);
            this.Controls.Add(this.lblIssueInvoice);
            this.Controls.Add(this.btnBackButton);
            this.Name = "frm12RecievePayment";
            this.Text = "frm12RecievePayment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnRecievePayment;
        private System.Windows.Forms.Label lblIssueInvoice;
        private System.Windows.Forms.Button btnBackButton;
    }
}