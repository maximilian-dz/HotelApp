namespace HotelAppV2
{
    partial class frmInvoiceMgmt
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
            this.listBoxInvoices = new System.Windows.Forms.ListBox();
            this.buttonDeleteOverdue = new System.Windows.Forms.Button();
            this.buttonPayInvoice = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBoxInvoices
            // 
            this.listBoxInvoices.FormattingEnabled = true;
            this.listBoxInvoices.ItemHeight = 25;
            this.listBoxInvoices.Location = new System.Drawing.Point(32, 51);
            this.listBoxInvoices.Name = "listBoxInvoices";
            this.listBoxInvoices.Size = new System.Drawing.Size(577, 329);
            this.listBoxInvoices.TabIndex = 0;
            // 
            // buttonDeleteOverdue
            // 
            this.buttonDeleteOverdue.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonDeleteOverdue.Location = new System.Drawing.Point(32, 410);
            this.buttonDeleteOverdue.Name = "buttonDeleteOverdue";
            this.buttonDeleteOverdue.Size = new System.Drawing.Size(496, 51);
            this.buttonDeleteOverdue.TabIndex = 106;
            this.buttonDeleteOverdue.Text = "Delete bookings";
            this.buttonDeleteOverdue.UseVisualStyleBackColor = false;
            this.buttonDeleteOverdue.Click += new System.EventHandler(this.buttonDeleteOverdue_Click);
            // 
            // buttonPayInvoice
            // 
            this.buttonPayInvoice.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.buttonPayInvoice.Location = new System.Drawing.Point(627, 51);
            this.buttonPayInvoice.Name = "buttonPayInvoice";
            this.buttonPayInvoice.Size = new System.Drawing.Size(295, 454);
            this.buttonPayInvoice.TabIndex = 105;
            this.buttonPayInvoice.Text = "Mark as paid";
            this.buttonPayInvoice.UseVisualStyleBackColor = false;
            this.buttonPayInvoice.Click += new System.EventHandler(this.buttonPayInvoice_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 473);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(571, 25);
            this.label1.TabIndex = 107;
            this.label1.Text = "WARNING! Removes all bookings where payment overdue";
            // 
            // frmInvoiceMgmt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 618);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonDeleteOverdue);
            this.Controls.Add(this.buttonPayInvoice);
            this.Controls.Add(this.listBoxInvoices);
            this.Name = "frmInvoiceMgmt";
            this.Text = "frmUpdate";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxInvoices;
        private System.Windows.Forms.Button buttonDeleteOverdue;
        private System.Windows.Forms.Button buttonPayInvoice;
        private System.Windows.Forms.Label label1;
    }
}