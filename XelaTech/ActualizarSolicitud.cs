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
    public partial class ActualizarSolicitud : Form
    {
        Solicitud solicitudActual = null;
        public ActualizarSolicitud()
        {
            InitializeComponent();
        }

        private void ActualizarSolicitud_FormClosed(object sender, FormClosedEventArgs e)
        {
            Solicitudes solicitudes = new Solicitudes();
            solicitudes.Show();
        }

        private void btnVolverSoli_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MostrarInfo()
        {
            lblInfoSoli.Text = solicitudActual.Resumen();
        }

        private bool HaySolicitud()
        {
            if (solicitudActual == null)
            {
                MessageBox.Show("Primero debe buscar una solicitud", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        private void Resultado(string error, string exito)
        {
            if (error != null)
            {
                MessageBox.Show(error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show(exito, "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MostrarInfo();
            }
        }

        private void btnBuscarSoli_Click(object sender, EventArgs e)
        {
            solicitudActual = Datos.BuscarSolicitud(txbBuscarSoli.Text);
            if (solicitudActual != null)
            {
                MessageBox.Show("El codigo ha sido encontrado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MostrarInfo();
            }
            else
            {
                MessageBox.Show("El codigo no se ha podido encontrar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblInfoSoli.Text = "Busque una solicitud por su código.";
            }
        }

        private void btnAsignarSoli_Click(object sender, EventArgs e)
        {
            if (!HaySolicitud())
            {
                return;
            }
            Tecnico tecnico = Datos.BuscarTecnico(txbTecnicoSoli.Text);
            if (tecnico == null)
            {
                MessageBox.Show("El técnico ingresado no existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbTecnicoSoli.Clear();
                return;
            }
            Resultado(solicitudActual.AsignarTecnico(tecnico), "La solicitud se asignó al técnico " + tecnico.NombreCompleto);
            txbTecnicoSoli.Clear();
        }

        private void btnIniciarSoli_Click(object sender, EventArgs e)
        {
            if (!HaySolicitud())
            {
                return;
            }
            Resultado(solicitudActual.IniciarReparacion(), "La solicitud esta En Proceso");
        }

        private void btnDiagSoli_Click(object sender, EventArgs e)
        {
            if (!HaySolicitud())
            {
                return;
            }
            double manoObraIng;
            if (!Textos.TryNumero(txbManoSoli.Text, out manoObraIng))
            {
                MessageBox.Show("El costo de mano de obra debe ser un número", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbManoSoli.Clear();
                return;
            }
            string error = solicitudActual.RegistrarDiagnostico(txbDiagSoli.Text, manoObraIng);
            Resultado(error, "Diagnóstico registrado. Total actual: " + Textos.Q(solicitudActual.Total));
        }

        private void btnRepSoli_Click(object sender, EventArgs e)
        {
            if (!HaySolicitud())
            {
                return;
            }
            Repuesto repuesto = Datos.BuscarRepuesto(txbRepuestoSoli.Text);
            if (repuesto == null)
            {
                MessageBox.Show("El repuesto ingresado no existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbRepuestoSoli.Clear();
                return;
            }
            int cantidadIng;
            if (!int.TryParse(txbCantRepSoli.Text, out cantidadIng))
            {
                MessageBox.Show("La cantidad debe ser un número entero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbCantRepSoli.Clear();
                return;
            }
            string error = solicitudActual.AgregarRepuesto(repuesto, cantidadIng);
            string exito = "Se usaron " + cantidadIng + " x " + repuesto.Nombre + ". Existencia restante: " + repuesto.Existencia;
            if (repuesto.Agotado)
            {
                exito += " (AGOTADO)";
            }
            else if (repuesto.EnMinimo)
            {
                exito += " (en el mínimo)";
            }
            Resultado(error, exito);
            if (error == null)
            {
                txbRepuestoSoli.Clear();
                txbCantRepSoli.Clear();
            }
        }

        private void btnEntregarSoli_Click(object sender, EventArgs e)
        {
            if (!HaySolicitud())
            {
                return;
            }
            int califIng;
            if (!int.TryParse(txbCalifSoli.Text, out califIng))
            {
                MessageBox.Show("La calificación debe ser un número entero entre 1 y 5", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbCalifSoli.Clear();
                return;
            }
            Resultado(solicitudActual.Entregar(califIng), "La solicitud se entregó. Total a cobrar: " + Textos.Q(solicitudActual.Total));
            txbCalifSoli.Clear();
        }

        private void btnCancelarSoli_Click(object sender, EventArgs e)
        {
            if (!HaySolicitud())
            {
                return;
            }
            DialogResult respuesta = MessageBox.Show("¿Desea cancelar la solicitud " + solicitudActual.CodigoSolicitud + "? Los repuestos usados volverán al inventario.", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta != DialogResult.Yes)
            {
                return;
            }
            int devueltos;
            string error = solicitudActual.Cancelar(out devueltos);
            string exito;
            if (devueltos > 0)
            {
                exito = "La solicitud se ha cancelado. Se devolvieron " + devueltos + " repuesto(s) al inventario";
            }
            else
            {
                exito = "La solicitud se ha cancelado";
            }
            Resultado(error, exito);
        }

        private void btnDeshacerSoli_Click(object sender, EventArgs e)
        {
            if (!HaySolicitud())
            {
                return;
            }
            string mensaje;
            string error = solicitudActual.DeshacerUltimoCambio(out mensaje);
            Resultado(error, mensaje);
        }
    }
}
