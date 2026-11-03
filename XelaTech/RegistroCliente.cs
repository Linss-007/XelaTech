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
    public partial class RegistroCliente : Form
    {
        public RegistroCliente()
        {
            InitializeComponent();
        }

        private void RegistroCliente_FormClosed(object sender, FormClosedEventArgs e)
        {
            Clientes cliente = new Clientes();
            cliente.Show();
        }
        private void btnVolverCliente_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnRegCliente_Click(object sender, EventArgs e)
        {
            string codigoIng = "";
            bool puedeRegistrarse = false;
            if (txbCodCliente.Text.StartsWith("cli"))
            {
                codigoIng = txbCodCliente.Text;
            }
            else
            {
                MessageBox.Show("El código debe empezar con cli", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            string nombreIng = txbNomCliente.Text;
            string correoIng = txbCorreoCliente.Text;
            string telefonoIng = txbTelCliente.Text;
            tipoCliente tipoIng = (tipoCliente)(cbxTipoCliente.SelectedIndex);
            Cliente cliente = new Cliente(codigoIng, nombreIng, telefonoIng, correoIng, tipoIng);
            if(cliente.Codigo != codigoIng)
            {
                txbCodCliente.Clear();
            }
            else if(cliente.NombreCompleto != nombreIng)
            {
                txbNomCliente.Clear();
            }
            else if(cliente.Correo != correoIng)
            {
                txbCorreoCliente.Clear();
            }
            else if(cliente.NumeroTel != telefonoIng)
            {
                txbTelCliente.Clear();
            }
            else if(cbxTipoCliente.SelectedIndex < 0 || cbxTipoCliente.SelectedIndex > 4)
            {
                MessageBox.Show("El tipo debe ser uno de los disponibles", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cbxTipoCliente.ResetText();
            }
            else if(Datos.clientes.Count > 0)
            {
                foreach(Cliente cli in Datos.clientes)
                {
                    if(cli.Codigo == codigoIng)
                    {
                        puedeRegistrarse = false;
                        break;
                    }
                    else
                    {
                        puedeRegistrarse = true;
                    }
                }
                if(!puedeRegistrarse)
                {
                    MessageBox.Show("El código ingresado ya esta registrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    cliente.RegistrarCliente(cliente);
                    MessageBox.Show("El cliente se ha registrado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                cliente.RegistrarCliente(cliente);
                MessageBox.Show("El cliente se ha registrado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MessageBox.Show(Convert.ToString(cbxTipoCliente.SelectedIndex));
            }
        }

        
    }
}
