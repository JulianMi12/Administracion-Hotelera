using Administracion_Hotelera.controller;
using Administracion_Hotelera.utilities;
using Administracion_Hotelera.view;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Administracion_Hotelera.view
{
    public partial class FormLogin : Form
    {
        private UserController controller;
        private Utilities gv = Utilities.getInstance;
        private ConnectionMySQL cn = ConnectionMySQL.GetInstance();

        public FormLogin()
        {
            InitializeComponent();
            controller = new UserController();

            this.MaximizeBox = false;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                form.Close();
            }
            Application.Exit();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                MessageBox.Show("Debe ingresar el nombre de usuario.");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Debe ingresar la contraseña.");
                return;
            }

            string username, password;
            username = txtUsername.Text;
            password = txtPassword.Text;

            try
            {
                if (username != "" && password != "")
                {
                    if (controller.login(username, password))
                    {
                        gv.username = username;
                        FormManagement form = new FormManagement();
                        form.Show();

                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Credenciales invalidas.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                cn.closeConnection();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormHome home = new FormHome();
            home.Show();
            this.Close();
        }

        private void imgExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
