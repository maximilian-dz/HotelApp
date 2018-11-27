using System;
using System.Windows.Forms;

namespace HotelAppV2
{
    public partial class frmStartMenu : Form
    {
        public frmStartMenu()
        {
            InitializeComponent();
            comboBoxPersons.Items.Add(1);
            comboBoxPersons.Items.Add(2);
            comboBoxPersons.Items.Add(3);
            comboBoxPersons.Items.Add(4);
            comboBoxExtrabeds.Items.Add(0);
            comboBoxExtrabeds.Items.Add(1);
            comboBoxExtrabeds.Items.Add(2);
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(comboBoxPersons.Text))
            {
                MessageBox.Show("Please enter amount of people so we can find a room suitable for you.");
            }
            else
            {
                RoomRepository rp = new RoomRepository();
                listBox1.DisplayMember = "FullDetails";
                listBox1.ValueMember = "RoomID";
                listBox1.DataSource = rp.GetAvailableRooms(dateTimePickerFrom.Value.Date, dateTimePickerTo.Value.Date,
                    int.Parse(comboBoxPersons.Text));
            }
        }

        private void buttonCreateCustomer_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxFirstName.Text) || string.IsNullOrEmpty(textBoxLastName.Text)
                || string.IsNullOrEmpty(textBoxAddress.Text) || string.IsNullOrEmpty(textBoxEmail.Text))
            {
                MessageBox.Show("You have not supplied requested information. Please try again");
            }

            else
            {
                CustomerRepository custRepo =  new CustomerRepository();
                custRepo.CreateCustomer(textBoxFirstName.Text, textBoxLastName.Text,
                textBoxAddress.Text, textBoxEmail.Text);
            }

        }

        private void buttonMakeBooking_Click(object sender, EventArgs e)
        {
            int roomId = (int) listBox1.SelectedValue;

            if (string.IsNullOrEmpty(comboBoxPersons.Text) || string.IsNullOrEmpty(comboBoxExtrabeds.Text)
                || string.IsNullOrEmpty(textBoxCustomerID.Text) || string.IsNullOrEmpty(roomId.ToString()))
            {
                MessageBox.Show("You have not supplied requested information. Please try again");
            }

            else if (int.Parse(comboBoxExtrabeds.Text) > 0 && RoomRepository.CheckExtraBedCompatible(roomId) == false)
            {
                MessageBox.Show("The room you have picked is not compatible with extra beds");
            }

            else if (!RoomRepository.CanPersonFitInRoom(roomId, int.Parse(comboBoxPersons.Text)))
            {
                MessageBox.Show("But hello there! Y'all just won't fit in that room!");
            }

            else if (dateTimePickerFrom.Value.Date.Equals(dateTimePickerTo.Value.Date))

            {
                MessageBox.Show("You can not check in and check out the same day");
            }
            
            else
            {
                BookingRepository bookRepo = new BookingRepository();
                bookRepo.MakeBooking(roomId, dateTimePickerFrom.Value.Date,
                    dateTimePickerTo.Value.Date, textBoxCustomerID.Text,
                    comboBoxPersons.Text, comboBoxExtrabeds.Text, out decimal totalPrice, out int bookingId);

                MessageBox.Show("Thank you for booking a room. Your Booking-ID is: " +bookingId +
                                "\r\nTotal price is " + totalPrice.ToString("0.##") + " SEK");
            }
        }

        private void buttonApplyUpdate_Click(object sender, EventArgs e)
        {
            var bookingId = int.Parse(textBoxUpdateBookingID.Text);
            int roomId = (int)listBox1.SelectedValue;

            BookingRepository bookRepo = new BookingRepository();
            bookRepo.UpdateBooking(roomId, bookingId, dateTimePickerFrom.Value.Date,
                dateTimePickerTo.Value.Date,
                comboBoxPersons.Text, comboBoxExtrabeds.Text, out decimal totalPrice);

            MessageBox.Show("Your booking has been changed and invoice updated." +
                            "Total price is " + totalPrice + " SEK");

        }

        private void buttonDeleteBooking_Click(object sender, EventArgs e)
        {
            var bookingId = int.Parse(textBoxDeleteBooking.Text);

            BookingRepository bookRepo = new BookingRepository();
            bookRepo.DeleteBooking(bookingId);

            MessageBox.Show("Your Booking has been cancelled.");
        }

        private void buttonInvoiceMgmt_Click(object sender, EventArgs e)
        {
            Form form = new frmInvoiceMgmt();
            form.Show();
        }

        private void buttonGetCustInfo_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxCustIdUD.Text))
            {
                MessageBox.Show("You must enter a customer-id");
            }

            else
            {
                int customerId = int.Parse(textBoxCustIdUD.Text);

                CustomerRepository custRepo = new CustomerRepository();

                var customer = custRepo.GetCustomerInfo(customerId);

                if (customer == null)
                {
                    MessageBox.Show("We could not find a customer with customer-id: " + customerId);
                }

                else
                {
                    textBoxFirstName.Text = customer.FirstName;
                    textBoxLastName.Text = customer.LastName;
                    textBoxAddress.Text = customer.StreetAddress;
                    textBoxEmail.Text = customer.Email;
                }
            }
        }

        private void buttonUpdateAcc_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxCustIdUD.Text))
            {
                MessageBox.Show("You must enter a customer-id and fetch customer before you can do an update");
            }

            else
            {
                int.TryParse(textBoxCustIdUD.Text, out int customerId);
                CustomerRepository custRepo = new CustomerRepository();

                custRepo.UpdateCustomerInfo(customerId, textBoxFirstName.Text, textBoxLastName.Text,
                    textBoxAddress.Text, textBoxEmail.Text);
                
                MessageBox.Show("You account has been successfully updated.");
            }
        }

        private void buttonDeleteAcc_Click(object sender, EventArgs e)
        {
           
            CustomerRepository customerRepo = new CustomerRepository();
            int.TryParse(textBoxCustIdUD.Text, out int customerId);

            if (customerRepo.CustomerHasBooking(customerId))
            {
                MessageBox.Show("Unable to remove account. You have existing booking(s)");
            }

            else
            {
                customerRepo.DeleteCustomerAccount(customerId);
                MessageBox.Show("Your account has been successfully deleted");
            }
        }
    }
}
