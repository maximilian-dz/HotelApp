using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelAppV2.Repositorys
{
    public class InvoiceRepository
    {
        public List<Invoice> GetInvoices()
        {
            List<Invoice> invoices;
            using (var context = new HotelDBEntities())
            {
                invoices = context.Invoices.ToList();
            }

            return invoices;
        }

        public void MarkInvoiceAsPaid(int invoiceId)
        {
            Invoice invoice;

            using (var context = new HotelDBEntities())
            {
                invoice = context.Invoices.SingleOrDefault(i => i.InvoiceID == invoiceId);
            }

            invoice.IsPaid = true;

            using (var context = new HotelDBEntities())
            {

                context.Invoices.Attach(invoice);
                context.Entry(invoice).State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        public List<Invoice> GetInvoicesTest()
        {
            List<Invoice> invoices;
            using (var context = new HotelDBEntities())
            {
                invoices = context.Invoices.ToList();
            }

            return invoices;
        }
    }
}
