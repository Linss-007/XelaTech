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
    public partial class Equipos : Form
    {
        public Equipos()
        {
            InitializeComponent();
        }

        private void Equipos_FormClosed(object sender, FormClosedEventArgs e)
        {
            MenuPrincipal menu = new MenuPrincipal();
            menu.Show();
        }

        private void btnSalirEquipo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRegisEquipo_Click(object sender, EventArgs e)
        {
            if (Datos.clientes.Count == 0)
            {
                MessageBox.Show("No existen clientes guardados, primero debe registrar un cliente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            RegistroEquipo registro = new RegistroEquipo();
            registro.Show();
            this.Hide();
        }

        private void btnActuEquipo_Click(object sender, EventArgs e)
        {
            if (Datos.equipos.Count > 0)
            {
                ActualizarEquipo actualizar = new ActualizarEquipo();
                actualizar.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("No existen equipos guardados", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnConsEquipo_Click(object sender, EventArgs e)
        {
            if (Datos.equipos.Count > 0)
            {
                ConsultarEquipo consultar = new ConsultarEquipo();
                consultar.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("No existen equipos guardados", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
