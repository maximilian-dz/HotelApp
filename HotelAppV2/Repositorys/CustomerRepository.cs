using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelAppV2
{
    public class CustomerRepository
    {
        private HotelDBEntities context;

        public CustomerRepository()
        {
            context = new HotelDBEntities();
        }

        public void CreateCustomer(string firstName, string lastName, string address, string email)
        {
            using (context)
            {
                Customer customer = new Customer
                {
                    FirstName = firstName,
                    LastName = lastName,
                    StreetAddress = address,
                    Email = email
                };

                context.Customers.Add(customer);
                context.SaveChanges();
                MessageBox.Show("Your account has been created. Your Customer-ID is " + customer.CustomerID);
            }
        }

        public Customer GetCustomerInfo(int customerId)
        {
            Customer customer;

            using (var context = new HotelDBEntities())
            {
                customer = context.Customers.SingleOrDefault(c => c.CustomerID == customerId);
            }

            return customer;
        }

        public void UpdateCustomerInfo(int customerId, string firstName, string lastName, string address, string email)
        {
            Customer customer;

            using (var context = new HotelDBEntities())
            {
                customer = context.Customers.SingleOrDefault(c => c.CustomerID == customerId);
            }

            customer.FirstName = firstName;
            customer.LastName = lastName;
            customer.StreetAddress = address;
            customer.Email = email;
            
            using (var context = new HotelDBEntities())
            {
                context.Customers.Attach(customer);
                context.Entry(customer).State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        public void DeleteCustomerAccount(int customerId)
        {
            Customer customer;

            using (var context = new HotelDBEntities())
            {
                customer = context.Customers.SingleOrDefault(c => c.CustomerID == customerId);

                context.Entry(customer).State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public bool CustomerHasBooking(int customerId)
        {
            bool hasBooking;
            List<BookingDetail> bookings;

            using (var context = new HotelDBEntities())
            {
                bookings = context.BookingDetails.Where(b => b.CustomerID == customerId).ToList();

                if (bookings.Count == 0)
                {
                    hasBooking = false;
                }
                else
                {
                    hasBooking = true;
                }
            }
            return hasBooking;
        }
    }
}
