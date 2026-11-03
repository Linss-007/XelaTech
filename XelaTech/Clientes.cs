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
    public partial class Clientes : Form
    {
        public Clientes()
        {
            InitializeComponent();
        }

        private void Clientes_FormClosed(object sender, FormClosedEventArgs e)
        {
            MenuPrincipal menu = new MenuPrincipal();
            menu.Show();
        }

        private void btnSalirCliente_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRegisCliente_Click(object sender, EventArgs e)
        {
            RegistroCliente registro = new RegistroCliente();
            registro.Show();
            this.Hide();
        }

        private void btnActuCliente_Click(object sender, EventArgs e)
        {
            if (Datos.clientes.Count > 0)
            {
                ActualizarCliente actualizar = new ActualizarCliente();
                actualizar.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("No existen clientes guardados", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnConsCliente_Click(object sender, EventArgs e)
        {
            if (Datos.clientes.Count > 0)
            {
                ConsultarCliente consultar = new ConsultarCliente();
                consultar.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("No existen clientes guardados", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
