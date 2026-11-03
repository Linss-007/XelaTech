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
    public partial class ActualizarCliente : Form
    {
        string codigoBuscar;
        int posCodigo = -1;
        bool codigoEncontrado = false;
        public ActualizarCliente()
        {
            InitializeComponent();
        }
        private void ActualizarCliente_FormClosed(object sender, FormClosedEventArgs e)
        {
            Clientes clientes = new Clientes();
            clientes.Show();
        }
        private void btnVolverCliente_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            codigoBuscar = txbBuscarCliente.Text;
            codigoEncontrado = false;
            foreach(Cliente cliente in Datos.clientes)
            {
                if(cliente.Codigo == codigoBuscar)
                {
                    codigoEncontrado = true;
                    posCodigo = Datos.clientes.IndexOf(cliente);
                    break;
                }
                else
                {
                    codigoEncontrado = false;
                }
            }
            if(codigoEncontrado)
            {
                MessageBox.Show("El codigo ha sido encontrado", "Exito",MessageBoxButtons.OK,MessageBoxIcon.Information);
                txbNomCliente.Visible = true;
                txbCorreoCliente.Visible = true;
                txbTelCliente.Visible = true;
                cbxTipoCliente.Visible = true;
            }
            else
            {
                MessageBox.Show("El codigo no se ha podido encontrar", "Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void btnActuCliente_Click(object sender, EventArgs e)
        {
            string nombreIng = txbNomCliente.Text;
            string correoIng = txbCorreoCliente.Text;
            string telefonoIng = txbTelCliente.Text;
            tipoCliente tipoIng = (tipoCliente)(cbxTipoCliente.SelectedIndex);
            if ((codigoBuscar != null || codigoBuscar != "") && codigoEncontrado == true)
            {
                Cliente cliente = new Cliente(codigoBuscar, nombreIng, telefonoIng, correoIng, tipoIng);
                if (cliente.NombreCompleto != nombreIng)
                {
                    txbNomCliente.Clear();
                }
                else if (cliente.Correo != correoIng)
                {
                    txbCorreoCliente.Clear();
                }
                else if (cliente.NumeroTel != telefonoIng)
                {
                    txbTelCliente.Clear();
                }
                else if (cbxTipoCliente.SelectedIndex < 0 || cbxTipoCliente.SelectedIndex > 4)
                {
                    MessageBox.Show("El tipo debe ser uno de los disponibles", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cbxTipoCliente.ResetText();
                }
                else
                {
                    Datos.clientes[posCodigo] = cliente;
                    MessageBox.Show("El cliente se ha actualizado","Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("No se ha ingresado un codigo a buscar o no se ha encontrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
