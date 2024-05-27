using Administracion_Bookingera.controller;
using Administracion_Hotelera.controller;
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
    public partial class FormManagement : Form
    {
        private Timer timer;
        private HotelController hotelController;
        private BookingController bookingController;
        private Utilities gv = Utilities.getInstance;

        public FormManagement()
        {
            InitializeComponent();

            this.MaximizeBox = false;

            timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
            timer.Start();

            lblName.Text = gv.username;
            hotelController = new HotelController();
            bookingController = new BookingController();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("HH:mm");
        }

        private void btnHotels_Click(object sender, EventArgs e)
        {
            loadHotels();
            pnlWelcome.Visible = false;
            pnlHotels.Visible = true;
            pnlBookings.Visible = false;
        }
        private void btnBookings_Click(object sender, EventArgs e)
        {
            loadBookings();
            pnlWelcome.Visible = false;
            pnlHotels.Visible = false;
            pnlBookings.Visible = true;
        }

        public void loadHotels()
        {
            DGHotels.DataSource = null;
            DGHotels.Rows.Clear();
            DGHotels.Refresh();
            DGHotels.DataSource = hotelController.getAllHotels();
            DGHotels.Columns["id"].Visible = false;
            DGHotels.Columns["name"].DisplayIndex = 0;
            DGHotels.Columns["name"].HeaderText = "Nombre";
            DGHotels.Columns["name"].Width = 165;
            DGHotels.Columns["city"].DisplayIndex = 1;
            DGHotels.Columns["city"].HeaderText = "Ciudad";
            DGHotels.Columns["city"].Width = 165;
            DGHotels.Columns["status"].Visible = false;
            DGHotels.Columns["statusDesc"].DisplayIndex = 2;
            DGHotels.Columns["statusDesc"].HeaderText = "Estado";
            DGHotels.Columns["statusDesc"].Width = 165;
            DGHotels.Columns["Editar"].DisplayIndex = 3;
            DGHotels.Columns["Editar"].Width = 71;
        }
        public void loadBookings()
        {
            DGBookings.DataSource = null;
            DGBookings.Rows.Clear();
            DGBookings.Refresh();
            DGBookings.DataSource = bookingController.getAllBookings();
            DGBookings.Columns["id_hotel"].Visible = false;
            DGBookings.Columns["id_room"].Visible = false;
            DGBookings.Columns["id_passenger"].Visible = false;
            DGBookings.Columns["date_end"].Visible = false;
            DGBookings.Columns["location_room"].Visible = false;
            DGBookings.Columns["capacity_room"].Visible = false;
            DGBookings.Columns["value_room"].Visible = false;
            DGBookings.Columns["tax_room"].Visible = false;
            DGBookings.Columns["type_doc_pssg"].Visible = false;
            DGBookings.Columns["doc_pssg"].Visible = false;
            DGBookings.Columns["first_name_pssg"].Visible = false;
            DGBookings.Columns["last_name_pssg"].Visible = false;
            DGBookings.Columns["phone_pssg"].Visible = false;
            DGBookings.Columns["email_pssg"].Visible = false;
            DGBookings.Columns["city_hotel"].Visible = false;
            DGBookings.Columns["id"].DisplayIndex = 0;
            DGBookings.Columns["id"].HeaderText = "Nro.";
            DGBookings.Columns["id"].Width = 71;
            DGBookings.Columns["name_hotel"].DisplayIndex = 1;
            DGBookings.Columns["name_hotel"].HeaderText = "Hotel";
            DGBookings.Columns["name_hotel"].Width = 150;
            DGBookings.Columns["type_room"].DisplayIndex = 2;
            DGBookings.Columns["type_room"].HeaderText = "Habitación";
            DGBookings.Columns["type_room"].Width = 150;
            DGBookings.Columns["date_start"].DisplayIndex = 3;
            DGBookings.Columns["date_start"].HeaderText = "Fecha Ingreso";
            DGBookings.Columns["date_start"].Width = 130;
            DGBookings.Columns["Ver"].DisplayIndex = 4;
            DGBookings.Columns["Ver"].Width = 71;
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.Value is bool)
            {
                e.Value = (bool)e.Value ? "Habilitado" : "Deshabilitado";
                e.FormattingApplied = true;
            }

            if (e.Value is DateTime)
            {
                e.Value = ((DateTime)e.Value).ToString("yyyy-MM-dd");
                e.FormattingApplied = true;
            }

            if (e.Value is Image && DGHotels.Columns[e.ColumnIndex].Name == "Editar"
                || e.Value is Image && DGHotels.Columns[e.ColumnIndex].Name == "Ver")
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

        private void DGHotels_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex != -1)
            {
                if (DGHotels.Columns[e.ColumnIndex].Name == "Editar")
                {
                    FormEditHotel edit = new FormEditHotel(viewHotel());
                    edit.Show();

                    this.Hide();
                }
            }
        }
        private void DGBookings_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex != -1)
            {
                if (DGHotels.Columns[e.ColumnIndex].Name == "Editar")
                {
                    FormViewBooking edit = new FormViewBooking(viewBooking());
                    edit.Show();

                    this.Hide();
                }
            }
        }

        private Hotel viewHotel()
        {
            Hotel hotel = new Hotel();
            int id;
            if (int.TryParse(DGHotels.CurrentRow.Cells["id"].Value.ToString(), out id))
            {
                hotel.id = id;
            }
            hotel.name = DGHotels.CurrentRow.Cells["name"].Value.ToString();
            hotel.city = DGHotels.CurrentRow.Cells["city"].Value.ToString();
            Boolean status;
            if (Boolean.TryParse(DGHotels.CurrentRow.Cells["status"].Value.ToString(), out status))
            {
                hotel.status = status;
            }

            return hotel;
        }

        private Booking viewBooking()
        {
            Booking booking = new Booking();
            int id;
            if (int.TryParse(DGBookings.CurrentRow.Cells["id"].Value.ToString(), out id))
            {
                booking.id = id;
            }

            return booking;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FormEditHotel edit = new FormEditHotel();
            edit.Show();

            this.Hide();
        }
        private void btnReturn_Click(object sender, EventArgs e)
        {
            FormHome home = new FormHome();
            home.Show();

            this.Hide();
        }

        private void imgExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void DGBookings_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
