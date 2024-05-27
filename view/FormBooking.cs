using Administracion_Hotelera.model;
using Administracion_Roomera.controller;
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
    public partial class FormBooking : Form
    {
        private Timer timer;
        private Room filter;
        private Booking booking;
        private RoomController roomController = new RoomController();

        public FormBooking()
        {
            InitializeComponent();
            timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
            timer.Start();

            filter = new Room();
            loadRooms();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("HH:mm");
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            filter.date_start = dtFecIni.Value;
            filter.date_end = dtFecFin.Value;
            int cap = 0;
            if(int.TryParse(txtCapacity.Text, out cap)) { filter.capacity = cap; }
            filter.city = txtCity.Text;
            loadRooms();
        }

        private void loadRooms()
        {
            DGBookings.DataSource = null;
            DGBookings.Rows.Clear();
            DGBookings.Refresh();
            DGBookings.DataSource = roomController.getBookingRooms(filter);
            DGBookings.Columns["id"].Visible = false;
            DGBookings.Columns["id_hotel"].Visible = false;
            DGBookings.Columns["status"].Visible = false;
            DGBookings.Columns["date_start"].Visible = false;
            DGBookings.Columns["date_start"].Visible = false;
            DGBookings.Columns["date_end"].Visible = false;
            DGBookings.Columns["capacity"].Visible = false;
            DGBookings.Columns["statusDescAdmin"].Visible = false;
            DGBookings.Columns["tax"].Visible = false;
            DGBookings.Columns["Reservar"].DisplayIndex = 0;
            DGBookings.Columns["Reservar"].Width = 71;
            DGBookings.Columns["hotel"].DisplayIndex = 1;
            DGBookings.Columns["hotel"].HeaderText = "Hotel";
            DGBookings.Columns["hotel"].Width = 120;
            DGBookings.Columns["city"].DisplayIndex = 2;
            DGBookings.Columns["city"].HeaderText = "Ciudad";
            DGBookings.Columns["city"].Width = 120;
            DGBookings.Columns["type"].DisplayIndex = 3;
            DGBookings.Columns["type"].HeaderText = "Tipo";
            DGBookings.Columns["type"].Width = 120;
            DGBookings.Columns["capacityView"].DisplayIndex = 4;
            DGBookings.Columns["capacityView"].HeaderText = "Capacidad";
            DGBookings.Columns["capacityView"].Width = 120;
            DGBookings.Columns["value"].DisplayIndex = 5;
            DGBookings.Columns["value"].HeaderText = "Costo ($)";
            DGBookings.Columns["value"].Width = 120;
            DGBookings.Columns["location"].DisplayIndex = 6;
            DGBookings.Columns["location"].HeaderText = "Ubicación";
            DGBookings.Columns["location"].Width = 118;
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.Value is bool)
            {
                e.Value = (bool)e.Value ? "Habilitado" : "Deshabilitado";
                e.FormattingApplied = true;
            }

            if (e.Value is Image && DGBookings.Columns[e.ColumnIndex].Name == "Reservar")
            {
                Image imagenOriginal = (Image)e.Value;
                int nuevoAncho = 20;
                int nuevoAlto = 20;

                Image imagenReescalada = new Bitmap(nuevoAncho, nuevoAlto);
                using (Graphics graficos = Graphics.FromImage(imagenReescalada))
                {
                    graficos.DrawImage(imagenOriginal, 0, 0, nuevoAncho, nuevoAlto);
                }

                e.Value = imagenReescalada;
            }
        }

        private void DGBookings_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex != -1)
            {
                if (DGBookings.Columns[e.ColumnIndex].Name == "Reservar")
                {
                    FormNewBooking newBooking = new FormNewBooking(addBooking());
                    newBooking.Show();

                    this.Hide();
                }
            }
        }

        private Booking addBooking()
        {
            booking = new Booking();
            int cap;
            if (int.TryParse(DGBookings.CurrentRow.Cells["id_hotel"].Value.ToString(), out cap))
            {
                booking.id_hotel = cap;
            }
            if (int.TryParse(DGBookings.CurrentRow.Cells["id"].Value.ToString(), out cap))
            {
                booking.id_room = cap;
            }
            booking.name_hotel = DGBookings.CurrentRow.Cells["hotel"].Value.ToString();
            booking.city_hotel = DGBookings.CurrentRow.Cells["city"].Value.ToString();
            booking.location_room = DGBookings.CurrentRow.Cells["location"].Value.ToString();
            booking.type_room = DGBookings.CurrentRow.Cells["type"].Value.ToString();
            if (int.TryParse(DGBookings.CurrentRow.Cells["capacity"].Value.ToString(), out cap))
            {
                booking.capacity_room = cap;
            }
            booking.date_start = dtFecIni.Value;
            booking.date_end = dtFecFin.Value;
            float value;
            if (float.TryParse(DGBookings.CurrentRow.Cells["value"].Value.ToString(), out value))
            {
                booking.value_room = value;
            }
            if (float.TryParse(DGBookings.CurrentRow.Cells["tax"].Value.ToString(), out value))
            {
                booking.tax_room = value;
            }
            return booking;
        }

        private void imgExit2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            FormHome home = new FormHome();
            home.Show();

            this.Hide();
        }
    }
}
