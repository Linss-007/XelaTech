using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace XelaTech
{
    public partial class Ordenamientos : Form
    {
        public Ordenamientos()
        {
            InitializeComponent();
        }

        private void BtnOrdenar_Click(object sender, EventArgs e)
        {
            try
            {
                LimpiarTabla();

                switch (cbxOpcion.SelectedIndex)
                {
                    case 0:
                        OrdenarSolicitudesPorTotal();
                        break;
                    case 1:
                        OrdenarTecnicosPorServicios();
                        break;
                    case 2:
                        OrdenarRepuestosPorExistencia();
                        break;
                    case 3:
                        OrdenarSolicitudesPorFecha();
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inesperado al ordenar: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void OrdenarSolicitudesPorTotal()
        {
            if (Datos.solicitudes.Count < 2)
            {
                SinDatos("solicitudes");
                return;
            }

            List<Solicitud> lista = new List<Solicitud>(Datos.solicitudes);
            Algoritmos.BubbleSortSolicitudesPorTotal(lista, false);

            MostrarSolicitudes(lista, "Bubble Sort | criterio: costo total | orden: descendente");
        }

        private void OrdenarTecnicosPorServicios()
        {
            if (Datos.tecnicos.Count < 2)
            {
                SinDatos("tecnicos");
                return;
            }

            List<Tecnico> lista = new List<Tecnico>(Datos.tecnicos);
            Algoritmos.SelectionSortTecnicosPorServicios(lista);

            lblEncabezado.Text = "Selection Sort | criterio: servicios finalizados | orden: descendente | registros: " + lista.Count;

            dgvResultados.DataSource = lista.Select(t => new
            {
                Codigo = t.Codigo,
                Nombre = t.NombreCompleto,
                Especialidad = Textos.De(t.Especialidad),
                Activos = t.CantTrabajosActivos,
                Finalizados = t.CantTrabajosFin,
                Calificacion = t.CalifPromedio.ToString("0.00"),
                Estado = Textos.De(t.Estado)
            }).ToList();
        }

        private void OrdenarRepuestosPorExistencia()
        {
            if (Datos.repuestos.Count < 2)
            {
                SinDatos("repuestos");
                return;
            }

            List<Repuesto> lista = new List<Repuesto>(Datos.repuestos);
            Algoritmos.ShellSortRepuestosPorExistencia(lista, true);

            lblEncabezado.Text = "Shell Sort | criterio: existencia disponible | orden: ascendente | registros: " + lista.Count;

            dgvResultados.DataSource = lista.Select(r => new
            {
                Codigo = r.Codigo,
                Nombre = r.Nombre,
                Categoria = Textos.De(r.Categoria),
                Existencia = r.Existencia,
                Minima = r.ExistenciaMin,
                Estado = r.EstadoStock,
                Precio = Textos.Q(r.PrecioVenta)
            }).ToList();
        }

        private void OrdenarSolicitudesPorFecha()
        {
            if (Datos.solicitudes.Count < 2)
            {
                SinDatos("solicitudes");
                return;
            }

            List<Solicitud> lista = new List<Solicitud>(Datos.solicitudes);
            Algoritmos.QuickSortSolicitudesPorFecha(lista, 0, lista.Count - 1);

            MostrarSolicitudes(lista, "Quick Sort | criterio: fecha de recepcion | orden: ascendente");
        }

        private void MostrarSolicitudes(List<Solicitud> lista, string encabezado)
        {
            lblEncabezado.Text = encabezado + " | registros: " + lista.Count;

            dgvResultados.DataSource = lista.Select(s => new
            {
                Codigo = s.CodigoSolicitud,
                Cliente = s.Cliente.NombreCompleto,
                Equipo = s.Equipo.Descripcion,
                Prioridad = Textos.De(s.Prioridad),
                Estado = s.EstadoTexto,
                Fecha = Textos.Fecha(s.FechaHora),
                Horas = Textos.Horas(s.HorasEstimadas),
                Total = Textos.Q(s.Total)
            }).ToList();
        }

        private void SinDatos(string tipo)
        {
            lblEncabezado.Text = "No hay datos suficientes para ordenar: se necesitan al menos 2 " + tipo + ".";
            dgvResultados.DataSource = null;
        }

        private void LimpiarTabla()
        {
            dgvResultados.DataSource = null;
            dgvResultados.Columns.Clear();
        }

        private void BtnVolver_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Ordenamientos_FormClosed(object sender, FormClosedEventArgs e)
        {
            MenuPrincipal menu = new MenuPrincipal();
            menu.Show();
        }
    }
}
