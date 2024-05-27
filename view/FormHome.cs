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
    public partial class FormHome : Form
    {
        public FormHome()
        {
            InitializeComponent();

            this.MaximizeBox = false;
        }

        private void btnAgente_Click(object sender, EventArgs e)
        {
            FormLogin login = new FormLogin();
            login.Show();

            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormBooking booking = new FormBooking();
            booking.Show();

            this.Hide();
        }

        private void imgExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
