using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace XelaTech
{
    public partial class Colas : Form
    {
        private Solicitud enAtencion;

        public Colas()
        {
            InitializeComponent();
            Refrescar();
        }

        private void Colas_FormClosed(object sender, FormClosedEventArgs e)
        {
            MenuPrincipal menu = new MenuPrincipal();
            menu.Show();
        }
        private void Refrescar()
        {
            lstUrgente.BeginUpdate();
            lstNormal.BeginUpdate();
            lstUrgente.Items.Clear();
            lstNormal.Items.Clear();

            foreach (Solicitud solicitud in Datos.colaUrgente)
            {
                lstUrgente.Items.Add(new ItemCola(solicitud));
            }

            foreach (Solicitud solicitud in Datos.colaNormal)
            {
                lstNormal.Items.Add(new ItemCola(solicitud));
            }

            lstUrgente.EndUpdate();
            lstNormal.EndUpdate();

            cbxEnProceso.BeginUpdate();
            cbxEnProceso.Items.Clear();
            foreach (Solicitud solicitud in Datos.solicitudes)
            {
                if (solicitud.EsActiva && solicitud.Tecnico != null)
                {
                    cbxEnProceso.Items.Add(new ItemCola(solicitud));
                }
            }
            cbxEnProceso.EndUpdate();

            lblUrgente.Text = "Cola urgente (FIFO) - " + Datos.colaUrgente.Count + " solicitud(es)";
            lblNormal.Text = "Cola normal (FIFO) - " + Datos.colaNormal.Count + " solicitud(es)";

            if (enAtencion != null && !enAtencion.EsActiva)
            {
                enAtencion = null;
            }

            if (enAtencion == null)
            {
                lblAtencion.Text = "En atencion: (ninguna)";
            }
            else
            {
                string tecnico = enAtencion.Tecnico == null
                    ? "sin asignar"
                    : enAtencion.Tecnico.Codigo + " - " + enAtencion.Tecnico.NombreCompleto;

                lblAtencion.Text = "En atencion: " + enAtencion.CodigoSolicitud +
                    " | " + enAtencion.Cliente.NombreCompleto +
                    " | " + enAtencion.EstadoTexto +
                    " | Tecnico: " + tecnico +
                    " | Total: " + Textos.Q(enAtencion.Total);
            }
        }

        private Solicitud Seleccionada()
        {
            if (lstUrgente.SelectedItem != null)
            {
                return ((ItemCola)lstUrgente.SelectedItem).Solicitud;
            }

            if (lstNormal.SelectedItem != null)
            {
                return ((ItemCola)lstNormal.SelectedItem).Solicitud;
            }

            if (cbxEnProceso.SelectedItem != null)
            {
                return ((ItemCola)cbxEnProceso.SelectedItem).Solicitud;
            }

            return enAtencion;
        }

        private Solicitud ObtenerSeleccion()
        {
            Solicitud solicitud = Seleccionada();

            if (solicitud == null)
            {
                Aviso("Seleccione una solicitud de las colas o atienda una primero.");
            }

            return solicitud;
        }

        private void LstUrgente_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstUrgente.SelectedIndex >= 0)
            {
                lstNormal.ClearSelected();
                cbxEnProceso.SelectedIndex = -1;
            }
        }

        private void LstNormal_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstNormal.SelectedIndex >= 0)
            {
                lstUrgente.ClearSelected();
                cbxEnProceso.SelectedIndex = -1;
            }
        }

        private void CbxEnProceso_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxEnProceso.SelectedIndex >= 0)
            {
                lstUrgente.ClearSelected();
                lstNormal.ClearSelected();
            }
        }
        private void BtnAtender_Click(object sender, EventArgs e)
        {
            try
            {
                Queue<Solicitud> cola;

                if (Datos.colaUrgente.Count > 0)
                {
                    cola = Datos.colaUrgente;
                }
                else if (Datos.colaNormal.Count > 0)
                {
                    cola = Datos.colaNormal;
                }
                else
                {
                    Aviso("No hay solicitudes en espera.");
                    return;
                }

                Solicitud solicitud = cola.Peek();
                Tecnico tecnico = MejorTecnico(solicitud.Equipo.TipoEquipo);

                if (tecnico == null)
                {
                    Aviso("No hay un tecnico disponible con la especialidad requerida para " +
                        solicitud.Equipo.Descripcion + ".");
                    return;
                }

                cola.Dequeue();
                string error = solicitud.AsignarTecnico(tecnico);

                if (error != null)
                {
                    cola.Enqueue(solicitud);
                    Error(error);
                    return;
                }

                enAtencion = solicitud;
                Exito("Solicitud " + solicitud.CodigoSolicitud + " atendida y asignada a " +
                    tecnico.Codigo + " - " + tecnico.NombreCompleto + ".");
                Refrescar();
            }
            catch (Exception ex)
            {
                Error("Error inesperado al atender la cola: " + ex.Message);
            }
        }
        private Tecnico MejorTecnico(tipoEquipo tipo)
        {
            Tecnico mejor = null;

            foreach (Tecnico tecnico in Datos.tecnicos)
            {
                if (tecnico.MotivoRechazo(tipo) != null)
                {
                    continue;
                }

                if (mejor == null ||
                    tecnico.CantTrabajosActivos < mejor.CantTrabajosActivos ||
                    (tecnico.CantTrabajosActivos == mejor.CantTrabajosActivos &&
                     tecnico.CalifPromedio > mejor.CalifPromedio))
                {
                    mejor = tecnico;
                }
            }

            return mejor;
        }
        private void BtnIniciar_Click(object sender, EventArgs e)
        {
            Solicitud solicitud = ObtenerSeleccion();
            if (solicitud == null) return;

            try
            {
                string error = solicitud.IniciarReparacion();
                if (error == null)
                {
                    enAtencion = solicitud;
                }
                Resultado(error, "La solicitud " + solicitud.CodigoSolicitud + " esta En Proceso.");
            }
            catch (Exception ex)
            {
                Error("Error inesperado: " + ex.Message);
            }
        }
        private void BtnDiagnostico_Click(object sender, EventArgs e)
        {
            Solicitud solicitud = ObtenerSeleccion();
            if (solicitud == null) return;

            try
            {
                double manoObra;
                if (!Textos.TryNumero(txbManoObra.Text, out manoObra))
                {
                    Error("La mano de obra debe ser un numero mayor o igual a cero.");
                    return;
                }

                string error = solicitud.RegistrarDiagnostico(txbDiagnostico.Text, manoObra);
                if (error == null)
                {
                    enAtencion = solicitud;
                }
                Resultado(error, "Diagnostico registrado. Total actual: " + Textos.Q(solicitud.Total));
            }
            catch (Exception ex)
            {
                Error("Error inesperado: " + ex.Message);
            }
        }

        private void BtnRepuesto_Click(object sender, EventArgs e)
        {
            Solicitud solicitud = ObtenerSeleccion();
            if (solicitud == null) return;

            try
            {
                Repuesto repuesto = Datos.BuscarRepuesto(txbRepuesto.Text);
                if (repuesto == null)
                {
                    Error("El repuesto ingresado no existe.");
                    return;
                }

                int cantidad;
                if (!int.TryParse(txbCantidad.Text, out cantidad))
                {
                    Error("La cantidad debe ser un numero entero.");
                    return;
                }

                string error = solicitud.AgregarRepuesto(repuesto, cantidad);
                string exito = "Se usaron " + cantidad + " x " + repuesto.Nombre +
                    ". Existencia restante: " + repuesto.Existencia;

                if (repuesto.Agotado)
                {
                    exito += " (AGOTADO)";
                }
                else if (repuesto.EnMinimo)
                {
                    exito += " (en el minimo)";
                }

                if (error == null)
                {
                    enAtencion = solicitud;
                }
                Resultado(error, exito);
            }
            catch (Exception ex)
            {
                Error("Error inesperado: " + ex.Message);
            }
        }
        private void BtnEntregar_Click(object sender, EventArgs e)
        {
            Solicitud solicitud = ObtenerSeleccion();
            if (solicitud == null) return;

            try
            {
                int calificacion;
                if (!int.TryParse(txbCalificacion.Text, out calificacion))
                {
                    Error("La calificacion debe ser un numero entero entre 1 y 5.");
                    return;
                }

                string error = solicitud.Entregar(calificacion);
                if (error == null)
                {
                    enAtencion = null;
                }
                Resultado(error, "Solicitud entregada. Total a cobrar: " + Textos.Q(solicitud.Total));
            }
            catch (Exception ex)
            {
                Error("Error inesperado: " + ex.Message);
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Solicitud solicitud = ObtenerSeleccion();
            if (solicitud == null) return;

            try
            {
                DialogResult respuesta = MessageBox.Show(
                    "¿Desea cancelar la solicitud " + solicitud.CodigoSolicitud +
                    "? Los repuestos usados volveran al inventario.",
                    "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (respuesta != DialogResult.Yes)
                {
                    return;
                }

                int devueltos;
                string error = solicitud.Cancelar(out devueltos);
                string exito = devueltos > 0
                    ? "Solicitud cancelada. Se devolvieron " + devueltos + " repuesto(s) al inventario."
                    : "Solicitud cancelada.";

                if (error == null && enAtencion == solicitud)
                {
                    enAtencion = null;
                }
                Resultado(error, exito);
            }
            catch (Exception ex)
            {
                Error("Error inesperado: " + ex.Message);
            }
        }

        private void BtnDeshacer_Click(object sender, EventArgs e)
        {
            Solicitud solicitud = ObtenerSeleccion();
            if (solicitud == null) return;

            try
            {
                string mensaje;
                string error = solicitud.DeshacerUltimoCambio(out mensaje);
                if (error == null)
                {
                    enAtencion = solicitud;
                }
                Resultado(error, mensaje);
            }
            catch (Exception ex)
            {
                Error("Error inesperado: " + ex.Message);
            }
        }

        private void BtnFicha_Click(object sender, EventArgs e)
        {
            Solicitud solicitud = ObtenerSeleccion();
            if (solicitud == null) return;

            MessageBox.Show(solicitud.Resumen(), "Resumen de la solicitud " + solicitud.CodigoSolicitud,
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnHistorial_Click(object sender, EventArgs e)
        {
            Solicitud solicitud = ObtenerSeleccion();
            if (solicitud == null) return;

            MessageBox.Show(solicitud.Ficha(), "Historial de la solicitud " + solicitud.CodigoSolicitud,
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnVolver_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void Resultado(string error, string exito)
        {
            if (error != null)
            {
                Error(error);
            }
            else
            {
                Exito(exito);
                Refrescar();
            }
        }

        private void Aviso(string mensaje)
        {
            MessageBox.Show(mensaje, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Error(string mensaje)
        {
            MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void Exito(string mensaje)
        {
            MessageBox.Show(mensaje, "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private class ItemCola
        {
            public readonly Solicitud Solicitud;

            public ItemCola(Solicitud solicitud)
            {
                Solicitud = solicitud;
            }

            public override string ToString()
            {
                int minutos = (int)(DateTime.Now - Solicitud.FechaHora).TotalMinutes;
                if (minutos < 0)
                {
                    minutos = 0;
                }

                return Solicitud.CodigoSolicitud + " | " +
                    Solicitud.Cliente.NombreCompleto + " | " +
                    Solicitud.Equipo.Descripcion + " | " +
                    Textos.De(Solicitud.Prioridad) + " | " +
                    minutos + " min";
            }
        }
    }
}
