namespace HotelAppV2
{
    partial class frmStartMenu
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
            this.buttonApplyUpdate = new System.Windows.Forms.Button();
            this.labelEmail = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.labelAddress = new System.Windows.Forms.Label();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.labelLastName = new System.Windows.Forms.Label();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.textBoxDeleteBooking = new System.Windows.Forms.TextBox();
            this.labelDeleteBookingID = new System.Windows.Forms.Label();
            this.labelUpdateBookingID = new System.Windows.Forms.Label();
            this.textBoxUpdateBookingID = new System.Windows.Forms.TextBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.buttonDeleteBooking = new System.Windows.Forms.Button();
            this.buttonCreateCustomer = new System.Windows.Forms.Button();
            this.buttonMakeBooking = new System.Windows.Forms.Button();
            this.textBoxCustomerID = new System.Windows.Forms.TextBox();
            this.labelCustomerID = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxPersons = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxExtrabeds = new System.Windows.Forms.ComboBox();
            this.labelExtraBeds = new System.Windows.Forms.Label();
            this.labelTo = new System.Windows.Forms.Label();
            this.labelFrom = new System.Windows.Forms.Label();
            this.dateTimePickerTo = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerFrom = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.buttonInvoiceMgmt = new System.Windows.Forms.Button();
            this.labelReqFields = new System.Windows.Forms.Label();
            this.buttonGetCustInfo = new System.Windows.Forms.Button();
            this.buttonDeleteAcc = new System.Windows.Forms.Button();
            this.textBoxCustIdUD = new System.Windows.Forms.TextBox();
            this.labelCustomerIDD = new System.Windows.Forms.Label();
            this.buttonUpdateAcc = new System.Windows.Forms.Button();
            this.labelCreateAcc = new System.Windows.Forms.Label();
            this.labelEditAcc = new System.Windows.Forms.Label();
            this.labelManageBooking = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonApplyUpdate
            // 
            this.buttonApplyUpdate.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonApplyUpdate.Location = new System.Drawing.Point(393, 683);
            this.buttonApplyUpdate.Name = "buttonApplyUpdate";
            this.buttonApplyUpdate.Size = new System.Drawing.Size(295, 51);
            this.buttonApplyUpdate.TabIndex = 104;
            this.buttonApplyUpdate.Text = "Apply change";
            this.buttonApplyUpdate.UseVisualStyleBackColor = false;
            this.buttonApplyUpdate.Click += new System.EventHandler(this.buttonApplyUpdate_Click);
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.BackColor = System.Drawing.SystemColors.MenuBar;
            this.labelEmail.Location = new System.Drawing.Point(779, 354);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(65, 25);
            this.labelEmail.TabIndex = 103;
            this.labelEmail.Text = "Email";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.textBoxEmail.Location = new System.Drawing.Point(779, 385);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(290, 31);
            this.textBoxEmail.TabIndex = 102;
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.BackColor = System.Drawing.SystemColors.MenuBar;
            this.labelAddress.Location = new System.Drawing.Point(779, 274);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(91, 25);
            this.labelAddress.TabIndex = 101;
            this.labelAddress.Text = "Address";
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.textBoxAddress.Location = new System.Drawing.Point(779, 305);
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(290, 31);
            this.textBoxAddress.TabIndex = 100;
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.BackColor = System.Drawing.SystemColors.MenuBar;
            this.labelLastName.Location = new System.Drawing.Point(779, 198);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(106, 25);
            this.labelLastName.TabIndex = 99;
            this.labelLastName.Text = "Lastname";
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.textBoxLastName.Location = new System.Drawing.Point(779, 229);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(290, 31);
            this.textBoxLastName.TabIndex = 98;
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.BackColor = System.Drawing.SystemColors.MenuBar;
            this.labelFirstName.Location = new System.Drawing.Point(779, 122);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(107, 25);
            this.labelFirstName.TabIndex = 97;
            this.labelFirstName.Text = "Firstname";
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.textBoxFirstName.Location = new System.Drawing.Point(779, 153);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(290, 31);
            this.textBoxFirstName.TabIndex = 96;
            // 
            // textBoxDeleteBooking
            // 
            this.textBoxDeleteBooking.BackColor = System.Drawing.Color.Khaki;
            this.textBoxDeleteBooking.Location = new System.Drawing.Point(525, 864);
            this.textBoxDeleteBooking.Name = "textBoxDeleteBooking";
            this.textBoxDeleteBooking.Size = new System.Drawing.Size(140, 31);
            this.textBoxDeleteBooking.TabIndex = 95;
            // 
            // labelDeleteBookingID
            // 
            this.labelDeleteBookingID.AutoSize = true;
            this.labelDeleteBookingID.BackColor = System.Drawing.SystemColors.Menu;
            this.labelDeleteBookingID.Location = new System.Drawing.Point(397, 861);
            this.labelDeleteBookingID.Name = "labelDeleteBookingID";
            this.labelDeleteBookingID.Size = new System.Drawing.Size(116, 25);
            this.labelDeleteBookingID.TabIndex = 94;
            this.labelDeleteBookingID.Text = "BookingID:";
            // 
            // labelUpdateBookingID
            // 
            this.labelUpdateBookingID.AutoSize = true;
            this.labelUpdateBookingID.BackColor = System.Drawing.SystemColors.MenuBar;
            this.labelUpdateBookingID.Location = new System.Drawing.Point(393, 743);
            this.labelUpdateBookingID.Name = "labelUpdateBookingID";
            this.labelUpdateBookingID.Size = new System.Drawing.Size(116, 25);
            this.labelUpdateBookingID.TabIndex = 93;
            this.labelUpdateBookingID.Text = "BookingID:";
            // 
            // textBoxUpdateBookingID
            // 
            this.textBoxUpdateBookingID.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.textBoxUpdateBookingID.Location = new System.Drawing.Point(525, 740);
            this.textBoxUpdateBookingID.Name = "textBoxUpdateBookingID";
            this.textBoxUpdateBookingID.Size = new System.Drawing.Size(140, 31);
            this.textBoxUpdateBookingID.TabIndex = 92;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(259, 175);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(200, 45);
            this.buttonSearch.TabIndex = 91;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // buttonDeleteBooking
            // 
            this.buttonDeleteBooking.BackColor = System.Drawing.Color.Khaki;
            this.buttonDeleteBooking.Location = new System.Drawing.Point(393, 810);
            this.buttonDeleteBooking.Name = "buttonDeleteBooking";
            this.buttonDeleteBooking.Size = new System.Drawing.Size(295, 51);
            this.buttonDeleteBooking.TabIndex = 90;
            this.buttonDeleteBooking.Text = "Delete booking";
            this.buttonDeleteBooking.UseVisualStyleBackColor = false;
            this.buttonDeleteBooking.Click += new System.EventHandler(this.buttonDeleteBooking_Click);
            // 
            // buttonCreateCustomer
            // 
            this.buttonCreateCustomer.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.buttonCreateCustomer.Location = new System.Drawing.Point(777, 434);
            this.buttonCreateCustomer.Name = "buttonCreateCustomer";
            this.buttonCreateCustomer.Size = new System.Drawing.Size(295, 51);
            this.buttonCreateCustomer.TabIndex = 88;
            this.buttonCreateCustomer.Text = "Create Account";
            this.buttonCreateCustomer.UseVisualStyleBackColor = false;
            this.buttonCreateCustomer.Click += new System.EventHandler(this.buttonCreateCustomer_Click);
            // 
            // buttonMakeBooking
            // 
            this.buttonMakeBooking.Location = new System.Drawing.Point(17, 810);
            this.buttonMakeBooking.Name = "buttonMakeBooking";
            this.buttonMakeBooking.Size = new System.Drawing.Size(295, 51);
            this.buttonMakeBooking.TabIndex = 87;
            this.buttonMakeBooking.Text = "Book it!";
            this.buttonMakeBooking.UseVisualStyleBackColor = true;
            this.buttonMakeBooking.Click += new System.EventHandler(this.buttonMakeBooking_Click);
            // 
            // textBoxCustomerID
            // 
            this.textBoxCustomerID.Location = new System.Drawing.Point(162, 718);
            this.textBoxCustomerID.Name = "textBoxCustomerID";
            this.textBoxCustomerID.Size = new System.Drawing.Size(142, 31);
            this.textBoxCustomerID.TabIndex = 86;
            // 
            // labelCustomerID
            // 
            this.labelCustomerID.AutoSize = true;
            this.labelCustomerID.Location = new System.Drawing.Point(12, 722);
            this.labelCustomerID.Name = "labelCustomerID";
            this.labelCustomerID.Size = new System.Drawing.Size(132, 25);
            this.labelCustomerID.TabIndex = 85;
            this.labelCustomerID.Text = "CustomerID*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 25);
            this.label4.TabIndex = 84;
            this.label4.Text = "Persons*";
            // 
            // comboBoxPersons
            // 
            this.comboBoxPersons.FormattingEnabled = true;
            this.comboBoxPersons.Location = new System.Drawing.Point(117, 179);
            this.comboBoxPersons.Name = "comboBoxPersons";
            this.comboBoxPersons.Size = new System.Drawing.Size(121, 33);
            this.comboBoxPersons.TabIndex = 83;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 265);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(171, 25);
            this.label3.TabIndex = 82;
            this.label3.Text = "Available rooms:";
            // 
            // comboBoxExtrabeds
            // 
            this.comboBoxExtrabeds.FormattingEnabled = true;
            this.comboBoxExtrabeds.Location = new System.Drawing.Point(167, 634);
            this.comboBoxExtrabeds.Name = "comboBoxExtrabeds";
            this.comboBoxExtrabeds.Size = new System.Drawing.Size(121, 33);
            this.comboBoxExtrabeds.TabIndex = 79;
            // 
            // labelExtraBeds
            // 
            this.labelExtraBeds.AutoSize = true;
            this.labelExtraBeds.Location = new System.Drawing.Point(12, 634);
            this.labelExtraBeds.Name = "labelExtraBeds";
            this.labelExtraBeds.Size = new System.Drawing.Size(137, 25);
            this.labelExtraBeds.TabIndex = 78;
            this.labelExtraBeds.Text = "Extra bed(s)*";
            // 
            // labelTo
            // 
            this.labelTo.AutoSize = true;
            this.labelTo.Location = new System.Drawing.Point(331, 123);
            this.labelTo.Name = "labelTo";
            this.labelTo.Size = new System.Drawing.Size(43, 25);
            this.labelTo.TabIndex = 77;
            this.labelTo.Text = "To:";
            // 
            // labelFrom
            // 
            this.labelFrom.AutoSize = true;
            this.labelFrom.Location = new System.Drawing.Point(12, 122);
            this.labelFrom.Name = "labelFrom";
            this.labelFrom.Size = new System.Drawing.Size(67, 25);
            this.labelFrom.TabIndex = 76;
            this.labelFrom.Text = "From:";
            // 
            // dateTimePickerTo
            // 
            this.dateTimePickerTo.Location = new System.Drawing.Point(393, 122);
            this.dateTimePickerTo.Name = "dateTimePickerTo";
            this.dateTimePickerTo.Size = new System.Drawing.Size(200, 31);
            this.dateTimePickerTo.TabIndex = 75;
            // 
            // dateTimePickerFrom
            // 
            this.dateTimePickerFrom.Location = new System.Drawing.Point(109, 122);
            this.dateTimePickerFrom.Name = "dateTimePickerFrom";
            this.dateTimePickerFrom.Size = new System.Drawing.Size(200, 31);
            this.dateTimePickerFrom.TabIndex = 74;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 25);
            this.label1.TabIndex = 73;
            this.label1.Text = "BOOK A ROOM";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 25;
            this.listBox1.Location = new System.Drawing.Point(17, 302);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(576, 304);
            this.listBox1.TabIndex = 105;
            // 
            // buttonInvoiceMgmt
            // 
            this.buttonInvoiceMgmt.BackColor = System.Drawing.SystemColors.Info;
            this.buttonInvoiceMgmt.Location = new System.Drawing.Point(779, 811);
            this.buttonInvoiceMgmt.Name = "buttonInvoiceMgmt";
            this.buttonInvoiceMgmt.Size = new System.Drawing.Size(293, 51);
            this.buttonInvoiceMgmt.TabIndex = 106;
            this.buttonInvoiceMgmt.Text = "Invoice Management";
            this.buttonInvoiceMgmt.UseVisualStyleBackColor = false;
            this.buttonInvoiceMgmt.Click += new System.EventHandler(this.buttonInvoiceMgmt_Click);
            // 
            // labelReqFields
            // 
            this.labelReqFields.AutoSize = true;
            this.labelReqFields.Location = new System.Drawing.Point(13, 868);
            this.labelReqFields.Name = "labelReqFields";
            this.labelReqFields.Size = new System.Drawing.Size(159, 25);
            this.labelReqFields.TabIndex = 107;
            this.labelReqFields.Text = "* Required field";
            // 
            // buttonGetCustInfo
            // 
            this.buttonGetCustInfo.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.buttonGetCustInfo.Location = new System.Drawing.Point(779, 621);
            this.buttonGetCustInfo.Name = "buttonGetCustInfo";
            this.buttonGetCustInfo.Size = new System.Drawing.Size(293, 51);
            this.buttonGetCustInfo.TabIndex = 108;
            this.buttonGetCustInfo.Text = "Get Account Info";
            this.buttonGetCustInfo.UseVisualStyleBackColor = false;
            this.buttonGetCustInfo.Click += new System.EventHandler(this.buttonGetCustInfo_Click);
            // 
            // buttonDeleteAcc
            // 
            this.buttonDeleteAcc.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.buttonDeleteAcc.Location = new System.Drawing.Point(780, 735);
            this.buttonDeleteAcc.Name = "buttonDeleteAcc";
            this.buttonDeleteAcc.Size = new System.Drawing.Size(292, 51);
            this.buttonDeleteAcc.TabIndex = 109;
            this.buttonDeleteAcc.Text = "Delete Account";
            this.buttonDeleteAcc.UseVisualStyleBackColor = false;
            this.buttonDeleteAcc.Click += new System.EventHandler(this.buttonDeleteAcc_Click);
            // 
            // textBoxCustIdUD
            // 
            this.textBoxCustIdUD.Location = new System.Drawing.Point(917, 553);
            this.textBoxCustIdUD.Name = "textBoxCustIdUD";
            this.textBoxCustIdUD.Size = new System.Drawing.Size(142, 31);
            this.textBoxCustIdUD.TabIndex = 111;
            // 
            // labelCustomerIDD
            // 
            this.labelCustomerIDD.AutoSize = true;
            this.labelCustomerIDD.Location = new System.Drawing.Point(775, 556);
            this.labelCustomerIDD.Name = "labelCustomerIDD";
            this.labelCustomerIDD.Size = new System.Drawing.Size(124, 25);
            this.labelCustomerIDD.TabIndex = 110;
            this.labelCustomerIDD.Text = "CustomerID";
            // 
            // buttonUpdateAcc
            // 
            this.buttonUpdateAcc.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.buttonUpdateAcc.Location = new System.Drawing.Point(780, 678);
            this.buttonUpdateAcc.Name = "buttonUpdateAcc";
            this.buttonUpdateAcc.Size = new System.Drawing.Size(292, 51);
            this.buttonUpdateAcc.TabIndex = 112;
            this.buttonUpdateAcc.Text = "Update Account";
            this.buttonUpdateAcc.UseVisualStyleBackColor = false;
            this.buttonUpdateAcc.Click += new System.EventHandler(this.buttonUpdateAcc_Click);
            // 
            // labelCreateAcc
            // 
            this.labelCreateAcc.AutoSize = true;
            this.labelCreateAcc.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCreateAcc.Location = new System.Drawing.Point(779, 67);
            this.labelCreateAcc.Name = "labelCreateAcc";
            this.labelCreateAcc.Size = new System.Drawing.Size(160, 25);
            this.labelCreateAcc.TabIndex = 113;
            this.labelCreateAcc.Text = "Create Account";
            // 
            // labelEditAcc
            // 
            this.labelEditAcc.AutoSize = true;
            this.labelEditAcc.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEditAcc.Location = new System.Drawing.Point(775, 510);
            this.labelEditAcc.Name = "labelEditAcc";
            this.labelEditAcc.Size = new System.Drawing.Size(133, 25);
            this.labelEditAcc.TabIndex = 114;
            this.labelEditAcc.Text = "Edit Account";
            // 
            // labelManageBooking
            // 
            this.labelManageBooking.AutoSize = true;
            this.labelManageBooking.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelManageBooking.Location = new System.Drawing.Point(397, 634);
            this.labelManageBooking.Name = "labelManageBooking";
            this.labelManageBooking.Size = new System.Drawing.Size(174, 25);
            this.labelManageBooking.TabIndex = 115;
            this.labelManageBooking.Text = "Manage Booking";
            // 
            // frmStartMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1460, 1087);
            this.Controls.Add(this.labelManageBooking);
            this.Controls.Add(this.labelEditAcc);
            this.Controls.Add(this.labelCreateAcc);
            this.Controls.Add(this.buttonUpdateAcc);
            this.Controls.Add(this.textBoxCustIdUD);
            this.Controls.Add(this.labelCustomerIDD);
            this.Controls.Add(this.buttonDeleteAcc);
            this.Controls.Add(this.buttonGetCustInfo);
            this.Controls.Add(this.labelReqFields);
            this.Controls.Add(this.buttonInvoiceMgmt);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.buttonApplyUpdate);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.labelAddress);
            this.Controls.Add(this.textBoxAddress);
            this.Controls.Add(this.labelLastName);
            this.Controls.Add(this.textBoxLastName);
            this.Controls.Add(this.labelFirstName);
            this.Controls.Add(this.textBoxFirstName);
            this.Controls.Add(this.textBoxDeleteBooking);
            this.Controls.Add(this.labelDeleteBookingID);
            this.Controls.Add(this.labelUpdateBookingID);
            this.Controls.Add(this.textBoxUpdateBookingID);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.buttonDeleteBooking);
            this.Controls.Add(this.buttonCreateCustomer);
            this.Controls.Add(this.buttonMakeBooking);
            this.Controls.Add(this.textBoxCustomerID);
            this.Controls.Add(this.labelCustomerID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBoxPersons);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxExtrabeds);
            this.Controls.Add(this.labelExtraBeds);
            this.Controls.Add(this.labelTo);
            this.Controls.Add(this.labelFrom);
            this.Controls.Add(this.dateTimePickerTo);
            this.Controls.Add(this.dateTimePickerFrom);
            this.Controls.Add(this.label1);
            this.Name = "frmStartMenu";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonApplyUpdate;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.TextBox textBoxDeleteBooking;
        private System.Windows.Forms.Label labelDeleteBookingID;
        private System.Windows.Forms.Label labelUpdateBookingID;
        private System.Windows.Forms.TextBox textBoxUpdateBookingID;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Button buttonDeleteBooking;
        private System.Windows.Forms.Button buttonCreateCustomer;
        private System.Windows.Forms.Button buttonMakeBooking;
        private System.Windows.Forms.TextBox textBoxCustomerID;
        private System.Windows.Forms.Label labelCustomerID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxPersons;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxExtrabeds;
        private System.Windows.Forms.Label labelExtraBeds;
        private System.Windows.Forms.Label labelTo;
        private System.Windows.Forms.Label labelFrom;
        private System.Windows.Forms.DateTimePicker dateTimePickerTo;
        private System.Windows.Forms.DateTimePicker dateTimePickerFrom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button buttonInvoiceMgmt;
        private System.Windows.Forms.Label labelReqFields;
        private System.Windows.Forms.Button buttonGetCustInfo;
        private System.Windows.Forms.Button buttonDeleteAcc;
        private System.Windows.Forms.TextBox textBoxCustIdUD;
        private System.Windows.Forms.Label labelCustomerIDD;
        private System.Windows.Forms.Button buttonUpdateAcc;
        private System.Windows.Forms.Label labelCreateAcc;
        private System.Windows.Forms.Label labelEditAcc;
        private System.Windows.Forms.Label labelManageBooking;
    }
}

