using Administracion_Bookingera.controller;
using Administracion_Hotelera.model;
using Administracion_Hotelera.utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Administracion_Hotelera.view
{
    public partial class FormViewBooking : Form
    {
        private BookingController bookingController;
        private Utilities gv = Utilities.getInstance;

        public FormViewBooking()
        {
            InitializeComponent();
            bookingController = new BookingController();
            lblName.Text = gv.username;
        }

        public FormViewBooking(Booking booking)
        {
            InitializeComponent();
            bookingController = new BookingController();
            lblName.Text = gv.username;
            label4.Text = booking.id + "";
            bookingData(booking);
        }

        public void bookingData(Booking booking)
        {
            booking = bookingController.getBookingById(booking.id);
            lblHotel.Text = booking.name_hotel;
            lblCity.Text = booking.city_hotel;
            lblRoom.Text = booking.location_room;
            lblTypeR.Text = booking.type_room;
            lblAmount.Text = booking.capacity_room + "";
            lblFecIni.Text = booking.date_start.ToString("yyyy-MM-dd");
            lblFecFin.Text = booking.date_end.ToString("yyyy-MM-dd");
            lblValue.Text = booking.value_room + "";
            lblTax.Text = booking.tax_room + "";
            lblTypeDoc.Text = booking.type_doc_pssg;
            lblDoc.Text = booking.id.ToString();
            lblFName.Text = booking.first_name_pssg;
            lblLName.Text = booking.last_name_pssg;
            lblTel.Text = booking.phone_pssg;
            lblEmail.Text = booking.email_pssg;
        }

        private void btnCancelHotel_Click(object sender, EventArgs e)
        {
            FormManagement mng = new FormManagement();
            mng.Show();

            this.Hide();
        }

        private void imgExit1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
