using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XelaTech
{
    public partial class Solicitudes : Form
    {
        public Solicitudes()
        {
            InitializeComponent();
        }

        private void Solicitudes_FormClosed(object sender, FormClosedEventArgs e)
        {
            MenuPrincipal menu = new MenuPrincipal();
            menu.Show();
        }

        private void btnSalirSolicitud_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRegisSolicitud_Click(object sender, EventArgs e)
        {
            if (Datos.clientes.Count == 0)
            {
                MessageBox.Show("No existen clientes guardados, primero debe registrar un cliente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (Datos.equipos.Count == 0)
            {
                MessageBox.Show("No existen equipos guardados, primero debe registrar un equipo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            RegistroSolicitud registro = new RegistroSolicitud();
            registro.Show();
            this.Hide();
        }

        private void btnActuSolicitud_Click(object sender, EventArgs e)
        {
            if (Datos.solicitudes.Count > 0)
            {
                ActualizarSolicitud actualizar = new ActualizarSolicitud();
                actualizar.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("No existen solicitudes guardadas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnConsSolicitud_Click(object sender, EventArgs e)
        {
            if (Datos.solicitudes.Count > 0)
            {
                ConsultarSolicitud consultar = new ConsultarSolicitud();
                consultar.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("No existen solicitudes guardadas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
