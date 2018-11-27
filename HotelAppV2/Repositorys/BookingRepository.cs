using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace HotelAppV2
{
    public class BookingRepository
    {
        public void MakeBooking(int roomId, DateTime fromDate, DateTime toDate, string customerId,
            string persons, string extraBed, out decimal totalPrice, out int bookingId)
        {
            using (var context = new HotelDBEntities())
            {
                var room = context.Rooms.SingleOrDefault(r => r.RoomID == roomId);
                totalPrice = room.Price + (300 * int.Parse(extraBed));

                Invoice invoice = new Invoice
                {
                    SentDate = DateTime.Now,
                    DueDate = DateTime.Now.AddDays(10),
                    Price = totalPrice,
                    IsPaid = false
                };
                context.Invoices.Add(invoice);

                BookingDetail booking = new BookingDetail
                {
                    RoomID = roomId,
                    BookingDate = DateTime.Now,
                    StartDate = fromDate,
                    EndDate = toDate,
                    CustomerID = int.Parse(customerId),
                    Persons = int.Parse(persons),
                    ExtraBed = int.Parse(extraBed)
                };

                context.BookingDetails.Add(booking);
                context.SaveChanges();

                bookingId = booking.BookingID;
            }
        }

        public void UpdateBooking(int roomId, int bookingId, DateTime fromDate, DateTime toDate,
            string persons, string extraBed, out decimal totalPrice)
        {
            BookingDetail booking;
            Invoice invoice;
            Room room;

            using (var context = new HotelDBEntities())
            {
                booking = context.BookingDetails.SingleOrDefault(b => b.BookingID == bookingId);
                invoice = context.Invoices.SingleOrDefault(i => i.InvoiceID == booking.InvoiceID);
                room = context.Rooms.SingleOrDefault(r => r.RoomID == roomId);
                totalPrice = room.Price + (300 * int.Parse(extraBed));
            }

            booking.RoomID = roomId;
            booking.BookingDate = DateTime.Now;
            booking.StartDate = fromDate;
            booking.EndDate = toDate;
            booking.Persons = int.Parse(persons);
            booking.ExtraBed = int.Parse(extraBed);

            invoice.Price = totalPrice;
            invoice.IsPaid = false;

            using (var context = new HotelDBEntities())
            {
                context.BookingDetails.Attach(booking);
                context.Entry(booking).State = EntityState.Modified;
                context.Invoices.Attach(invoice);
                context.Entry(invoice).State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        public void DeleteBooking(int bookingId)
        {
            BookingDetail booking;
            Invoice invoice;

            using (var context = new HotelDBEntities())
            {
                booking = context.BookingDetails.SingleOrDefault(b => b.BookingID == bookingId);
                invoice = context.Invoices.SingleOrDefault(i => i.InvoiceID == booking.InvoiceID);
            }

            using (var context = new HotelDBEntities())
            {
                context.Entry(booking).State = EntityState.Deleted;
                context.Entry(invoice).State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public void DeleteBookingOverdue()
        {
            List<BookingDetail> bookings;
            List<Invoice> invoices;

            using (var context = new HotelDBEntities())
            {
                invoices = (from invoice in context.Invoices
                    where invoice.DueDate <= DateTime.Now && invoice.IsPaid == false
                    select invoice).ToList();

                bookings = (from invoice in invoices
                    join booking in context.BookingDetails on invoice.InvoiceID equals booking.InvoiceID
                    select booking).ToList();
            }

            using (var context = new HotelDBEntities())
            {
                foreach (var booking in bookings)
                {
                    context.Entry(booking).State = EntityState.Deleted;
                }

                foreach (var invoice in invoices)
                {
                    context.Entry(invoice).State = EntityState.Deleted;
                }

                context.SaveChanges();
            }
        }
    }
}
