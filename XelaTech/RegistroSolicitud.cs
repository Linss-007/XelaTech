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
    public partial class RegistroSolicitud : Form
    {
        public RegistroSolicitud()
        {
            InitializeComponent();
            dtpFechaSoli.Value = DateTime.Now;
        }

        private void RegistroSolicitud_FormClosed(object sender, FormClosedEventArgs e)
        {
            Solicitudes solicitudes = new Solicitudes();
            solicitudes.Show();
        }

        private void btnVolverSoli_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRegSoli_Click(object sender, EventArgs e)
        {
            string codigoIng = txbCodSolicitud.Text;
            string descripcionIng = txbDescSoli.Text;
            if (!codigoIng.StartsWith("sol", StringComparison.OrdinalIgnoreCase))
            {
                MessageBox.Show("El código debe empezar con sol", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (Datos.BuscarSolicitud(codigoIng) != null)
            {
                MessageBox.Show("El código ingresado ya esta registrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Cliente cliente = Datos.BuscarCliente(txbClienteSoli.Text);
            if (cliente == null)
            {
                MessageBox.Show("El cliente ingresado no existe, no se creó la solicitud", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbClienteSoli.Clear();
                return;
            }
            Equipo equipo = Datos.BuscarEquipo(txbEquipoSoli.Text);
            if (equipo == null)
            {
                MessageBox.Show("El equipo ingresado no existe, no se creó la solicitud", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbEquipoSoli.Clear();
                return;
            }
            if (equipo.Propietario != cliente)
            {
                MessageBox.Show("El equipo " + equipo.CodigoInterno + " no pertenece al cliente " + cliente.Codigo, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbEquipoSoli.Clear();
                return;
            }
            Solicitud activa = Datos.SolicitudActiva(equipo);
            if (activa != null)
            {
                MessageBox.Show("El equipo ya tiene la solicitud " + activa.CodigoSolicitud + " activa (" + activa.EstadoTexto + ")", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (cbxPrioridadSoli.SelectedIndex < 0)
            {
                MessageBox.Show("Debe seleccionar una prioridad", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            prioridad prioridadIng = (prioridad)(cbxPrioridadSoli.SelectedIndex);
            Solicitud solicitud = new Solicitud(codigoIng, cliente, equipo, descripcionIng, dtpFechaSoli.Value, prioridadIng);
            if (solicitud.CodigoSolicitud != codigoIng)
            {
                txbCodSolicitud.Clear();
            }
            else if (solicitud.Descripcion != descripcionIng)
            {
                txbDescSoli.Clear();
            }
            else
            {
                solicitud.RegistrarSolicitud(solicitud);
                string cola = solicitud.EsUrgente ? "urgente" : "normal";
                MessageBox.Show("La solicitud se ha registrado y se añadió a la cola " + cola, "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnLimpiarSoli_Click(sender, e);
            }
        }

        private void btnLimpiarSoli_Click(object sender, EventArgs e)
        {
            txbCodSolicitud.Clear();
            txbClienteSoli.Clear();
            txbEquipoSoli.Clear();
            txbDescSoli.Clear();
            cbxPrioridadSoli.SelectedIndex = -1;
            dtpFechaSoli.Value = DateTime.Now;
        }
    }
}
