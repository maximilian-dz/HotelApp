using HotelAppV2.Repositorys;
using System;
using System.Windows.Forms;

namespace HotelAppV2
{
    public partial class frmInvoiceMgmt : Form
    {
        public frmInvoiceMgmt()
        {
            InitializeComponent();

            InvoiceRepository invRepo = new InvoiceRepository();

            UpdateInvoiceList(invRepo);
        }

        private void buttonPayInvoice_Click(object sender, EventArgs e)
        {
            var invoiceId = (int) listBoxInvoices.SelectedValue;

            InvoiceRepository invRepo = new InvoiceRepository();
            invRepo.MarkInvoiceAsPaid(invoiceId);

            UpdateInvoiceList(invRepo);
        }

        private void buttonDeleteOverdue_Click(object sender, EventArgs e)
        {
            BookingRepository bookRepo = new BookingRepository();
            bookRepo.DeleteBookingOverdue();

            InvoiceRepository invRepo = new InvoiceRepository();
            UpdateInvoiceList(invRepo);
        }

        private void UpdateInvoiceList(InvoiceRepository invRepo)
        {
            listBoxInvoices.DisplayMember = "FullDetails";
            listBoxInvoices.ValueMember = "InvoiceID";
            listBoxInvoices.DataSource = invRepo.GetInvoicesTest();
        }
    }
}
