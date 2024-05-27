using Administracion_Bookingera.controller;
using Administracion_Hotelera.controller;
using Administracion_Hotelera.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Administracion_Hotelera.view
{
    public partial class FormNewBooking : Form
    {
        private Timer timer;
        private Booking newBooking;
        private Passenger newPassenger;
        private BookingController bookingController;
        private PassengerController passengerController;

        public FormNewBooking(Booking booking)
        {
            InitializeComponent();
            timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
            timer.Start();

            newBooking = booking;
            newPassenger = new Passenger();
            bookingController = new BookingController();
            passengerController = new PassengerController();

            bookingData(booking);
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("HH:mm");
        }

        public void bookingData(Booking booking)
        {
            lblHotel.Text = booking.name_hotel;
            lblCity.Text = booking.city_hotel;
            lblRoom.Text = booking.location_room;
            lblTypeR.Text = booking.type_room;
            lblAmount.Text = booking.capacity_room.ToString();
            lblFecIni.Text = booking.date_start.ToString("yyyy-MM-dd");
            lblFecFin.Text = booking.date_end.ToString("yyyy-MM-dd");
            lblValue.Text = booking.value_room.ToString();
            lblTax.Text = booking.tax_room.ToString();

            TimeSpan diff = booking.date_end.Subtract(booking.date_start);
            float total = (diff.Days == 0 ? 1 : diff.Days) * 
                (booking.value_room + (booking.value_room * booking.tax_room));
            lblTot.Text = total.ToString("0.00");
        }

        private void btnSaveHotel_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTypeDoc.Text))
            {
                MessageBox.Show("Debe ingresar su tipo de identificación.");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtDoc.Text))
            {
                MessageBox.Show("Debe ingresar su identificación.");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtFName.Text))
            {
                MessageBox.Show("Debe ingresar sus nombres.");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtLName.Text))
            {
                MessageBox.Show("Debe ingresar sus apellidos.");
                return;
            }
            if (dtDateBorn.Value != null && dtDateBorn.Value != DateTime.MinValue)
            {
                MessageBox.Show("Debe ingresar su fecha de nacimiento.");
                return;
            }
            if (cbGender.SelectedItem == null)
            {
                MessageBox.Show("Debe seleccionar un genero.");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtPhone.Text))
            {
                MessageBox.Show("Debe ingresar su teléfono.");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("Debe ingresar su teléfono.");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtCntName.Text))
            {
                MessageBox.Show("Debe ingresar un nombre y apellido.");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtCntTel.Text))
            {
                MessageBox.Show("Debe ingresar un teléfono.");
                return;
            }

            newPassenger.first_name = txtFName.Text;
            newPassenger.last_name = txtLName.Text;
            newPassenger.date_birth = dtDateBorn.Value;
            newPassenger.gender = cbGender.SelectedIndex.ToString();
            newPassenger.type_doc = txtTypeDoc.Text;
            int id = 0;
            if (int.TryParse(txtDoc.Text, out id)) { newPassenger.id = id; }
            newPassenger.email = txtEmail.Text;
            newPassenger.phone = txtPhone.Text;
            var emergency = new Dictionary<string, string>
            {
                { "FullName", txtCntName.Text },
                { "Phone", txtCntTel.Text }
            };
            newPassenger.emergency_contact = JsonSerializer.Serialize(emergency);

            //validar datos no nulos
            if (passengerController.addPassenger(newPassenger))
            {
                newBooking.id_passenger = newPassenger.id;
                if (bookingController.addBooking(newBooking))
                {
                    MessageBox.Show("Registro añadido.");
                    btnSalir_Click(sender, e);
                }
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            FormBooking home = new FormBooking();
            home.Show();

            this.Hide();
        }

        private void imgExit2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
