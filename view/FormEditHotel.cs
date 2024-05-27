using Administracion_Hotelera.controller;
using Administracion_Hotelera.model;
using Administracion_Hotelera.utilities;
using Administracion_Roomera.controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Administracion_Hotelera.view
{
    public partial class FormEditHotel : Form
    {
        private Timer timer;
        private Hotel newHotel = new Hotel();
        private Room newRoom = new Room();
        private HotelController hotelController = new HotelController();
        private RoomController roomController = new RoomController();
        private Utilities gv = Utilities.getInstance;

        public FormEditHotel()
        {
            InitializeComponent();
            timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
            timer.Start();

            lblName.Text = gv.username;

            this.MaximizeBox = false;
            this.Height = 370;
            pnlRooms.Visible = false;
            imgExit1.Visible = true;
            imgExit2.Visible = false;
            newRoom = new Room();
        }

        public FormEditHotel(Hotel hotel)
        {
            InitializeComponent();
            timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
            timer.Start();

            lblName.Text = gv.username;

            this.MaximizeBox = false;
            this.Height = 765;
            pnlHotel.Height = 284;
            panel2.Height = 44;
            pnlRooms.Visible = true;
            imgExit1.Visible = false;
            imgExit2.Visible = true;
            find(hotel);
            newRoom = new Room();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("HH:mm");
        }

        private void find(Hotel hotel)
        {
            try
            {
                if (hotel != null)
                {
                    newHotel = hotel;
                    txtName.Text = hotel.name;
                    txtCity.Text = hotel.city;
                    slEstatus.SelectedIndex = hotel.status ? 0 : 1;

                    loadRooms();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void loadRooms()
        {
            DGRooms.DataSource = null;
            DGRooms.Rows.Clear();
            DGRooms.Refresh();
            DGRooms.DataSource = roomController.getRoomsByHotel(newHotel.id);
            DGRooms.Columns["id"].Visible = false;
            DGRooms.Columns["id_hotel"].Visible = false;
            DGRooms.Columns["status"].Visible = false;
            DGRooms.Columns["date_start"].Visible = false;
            DGRooms.Columns["date_end"].Visible = false;
            DGRooms.Columns["city"].Visible = false;
            DGRooms.Columns["hotel"].Visible = false;
            DGRooms.Columns["capacity"].Visible = false;
            DGRooms.Columns["Editar"].DisplayIndex = 0;
            DGRooms.Columns["Editar"].Width = 71;
            DGRooms.Columns["statusDescAdmin"].DisplayIndex = 1;
            DGRooms.Columns["statusDescAdmin"].HeaderText = "Estado";
            DGRooms.Columns["statusDescAdmin"].Width = 135;
            DGRooms.Columns["value"].DisplayIndex = 2;
            DGRooms.Columns["value"].HeaderText = "Costo";
            DGRooms.Columns["value"].Width = 135;
            DGRooms.Columns["tax"].DisplayIndex = 3;
            DGRooms.Columns["tax"].HeaderText = "Impuestos";
            DGRooms.Columns["tax"].Width = 135;
            DGRooms.Columns["type"].DisplayIndex = 4;
            DGRooms.Columns["type"].HeaderText = "Tipo";
            DGRooms.Columns["type"].Width = 135;
            DGRooms.Columns["capacityView"].DisplayIndex = 5;
            DGRooms.Columns["capacityView"].HeaderText = "Capacidad";
            DGRooms.Columns["capacityView"].Width = 135;
            DGRooms.Columns["location"].DisplayIndex = 6;
            DGRooms.Columns["location"].HeaderText = "Ubicación";
            DGRooms.Columns["location"].Width = 135;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            FormManagement mg = new FormManagement();
            mg.Show();
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Debe ingresar el nombre del hotel.");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtCity.Text))
            {
                MessageBox.Show("Debe ingresar el nombre de la ciudad.");
                return;
            }
            if (slEstatus.SelectedItem == null)
            {
                MessageBox.Show("Debe seleccionar un estado.");
                return;
            }
            if (newHotel.id == 0)
            {
                newHotel.name = txtName.Text;
                newHotel.city = txtCity.Text;
                newHotel.status = slEstatus.AccessibilityObject.Value.Equals("Habilitado") ? true : false;

                if (hotelController.addHotel(newHotel))
                {
                    FormManagement mg = new FormManagement();
                    mg.Show();
                    MessageBox.Show("Registro añadido.");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error al crear registro.");
                }
            }
            else
            {
                newHotel.name = txtName.Text;
                newHotel.city = txtCity.Text;
                newHotel.status = slEstatus.AccessibilityObject.Value.Equals("Habilitado") ? true : false;

                if (hotelController.updateHotel(newHotel))
                {
                    FormManagement mg = new FormManagement();
                    mg.Show();
                    MessageBox.Show("Registro actualizado.");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error al actualizar registro.");
                }
            }
        }

        private void DGRooms_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.Value is bool)
            {
                e.Value = (bool)e.Value ? "Habilitado" : "Deshabilitado";
                e.FormattingApplied = true;
            }

            if (e.Value is Image && DGRooms.Columns[e.ColumnIndex].Name == "Editar")
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

        private void btnAddRoom_Click(object sender, EventArgs e)
        {
            btnCancelRoom_Click(sender, e);
            newRoom = new Room();
            newRoom.id_hotel = newHotel.id;
            pnlAdd.Show();
            txtTitle.Text = "Nueva Habitación";
            DGRooms.Width = 589;
        }

        private void btnCancelRoom_Click(object sender, EventArgs e)
        {
            slStatusRoom.SelectedIndex = 0;
            txtValueRoom.Text = string.Empty;
            txtTaxRoom.Text = string.Empty;
            txtTypeRoom.Text = string.Empty;
            txtCapacityRoom.Text = string.Empty;
            txtLocationRoom.Text = string.Empty;
            txtTitle.Text = string.Empty;

            DGRooms.Width = 937;
            pnlAdd.Hide();
        }

        private void btnSaveRoom_Click(object sender, EventArgs e)
        {
            if (slEstatus.SelectedItem == null)
            {
                MessageBox.Show("Debe seleccionar un estado.");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtValueRoom.Text))
            {
                MessageBox.Show("Debe ingresar el costo de la habitación.");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtTaxRoom.Text))
            {
                MessageBox.Show("Debe ingresar los impuestos de la habitación.");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtTypeRoom.Text))
            {
                MessageBox.Show("Debe ingresar el tipo de habitación.");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtCapacityRoom.Text))
            {
                MessageBox.Show("Debe ingresar la cantidad de personas máxima.");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtLocationRoom.Text))
            {
                MessageBox.Show("Debe ingresar la ubicaión de la habitación.");
                return;
            }

            float val = 0;
            newRoom.status = slStatusRoom.AccessibilityObject.Value.Equals("Habilitado") ? true : false;
            if (float.TryParse(txtValueRoom.Text, out val))
            {
                newRoom.value = val;
                val = 0;
                if (float.TryParse(txtTaxRoom.Text, out val))
                {
                    newRoom.tax = val;
                }
            }
            newRoom.type = txtTypeRoom.Text;
            int cap = 0;
            if (int.TryParse(txtCapacityRoom.Text, out cap))
            {
                newRoom.capacity = cap;
            }
            newRoom.location = txtLocationRoom.Text;

            if (newRoom.id == 0)
            {
                if (roomController.addRoom(newRoom))
                {
                    MessageBox.Show("Registro añadido.");
                }
            }
            else
            {
                if (roomController.updateRoom(newRoom))
                {
                    MessageBox.Show("Registro actualizado.");
                }
            }

            loadRooms();
            btnCancelRoom_Click(sender, e);
        }

        private void DGRooms_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex != -1)
            {
                if (DGRooms.Columns[e.ColumnIndex].Name == "Editar")
                {
                    int id;
                    if (int.TryParse(DGRooms.CurrentRow.Cells["id"].Value.ToString(), out id))
                    {
                        newRoom.id = id;
                        id = 0;
                        if (int.TryParse(DGRooms.CurrentRow.Cells["id_hotel"].Value.ToString(), out id))
                        {
                            newRoom.id_hotel = id;
                        }
                    }
                    Boolean status;
                    if (Boolean.TryParse(DGRooms.CurrentRow.Cells["status"].Value.ToString(), out status))
                    {
                        slStatusRoom.SelectedIndex = status ? 0 : 1;
                    }
                    txtValueRoom.Text = DGRooms.CurrentRow.Cells["value"].Value.ToString();
                    txtTaxRoom.Text = DGRooms.CurrentRow.Cells["tax"].Value.ToString();
                    txtTypeRoom.Text = DGRooms.CurrentRow.Cells["type"].Value.ToString();
                    txtCapacityRoom.Text = DGRooms.CurrentRow.Cells["capacity"].Value.ToString();
                    txtLocationRoom.Text = DGRooms.CurrentRow.Cells["location"].Value.ToString();

                    pnlAdd.Show();
                    txtTitle.Text = "Editar Habitación";
                    DGRooms.Width = 589;
                }
            }
        }

        private void txtValueRoom_KeyPress(object sender, KeyPressEventArgs e)
        {
            gv.numberValidate(sender, e, txtValueRoom);
        }

        private void txtTaxRoom_KeyPress(object sender, KeyPressEventArgs e)
        {
            gv.numberValidate(sender, e, txtTaxRoom);
        }

        private void txtCapacityRoom_KeyPress(object sender, KeyPressEventArgs e)
        {
            gv.numberValidate(sender, e, txtCapacityRoom);
        }

        private void imgExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
