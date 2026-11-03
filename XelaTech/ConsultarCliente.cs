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
    public partial class ConsultarCliente : Form
    {
        public ConsultarCliente()
        {
            InitializeComponent();
        }

        private void ConsultarCliente_Load(object sender, EventArgs e)
        {
            dgvClientesGuardados.DataSource = Datos.clientes;
        }
        private void btnVolverCliente_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void ConsultarCliente_FormClosed(object sender, FormClosedEventArgs e)
        {
            Clientes clientes = new Clientes();
            clientes.Show();
        }
    }
}
