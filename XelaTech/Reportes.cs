using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace XelaTech
{
    public partial class Reportes : Form
    {
        public Reportes()
        {
            InitializeComponent();
            GenerarReporte();
        }

        private void BtnGenerar_Click(object sender, EventArgs e)
        {
            GenerarReporte();
        }

        private void GenerarReporte()
        {
            try
            {
                if (cbxReporte.SelectedIndex < 0)
                {
                    return;
                }

                StringBuilder sb = new StringBuilder();

                switch (cbxReporte.SelectedIndex)
                {
                    case 0:
                        ReporteEnEspera(sb);
                        break;
                    case 1:
                        ReporteEstados(sb);
                        break;
                    case 2:
                        ReporteTecnicos(sb);
                        break;
                    case 3:
                        ReporteTecnicoDestacado(sb);
                        break;
                    case 4:
                        ReporteEquiposPorTipo(sb);
                        break;
                    case 5:
                        ReporteSolicitudesPorTotal(sb);
                        break;
                    case 6:
                        ReporteSolicitudesPorFecha(sb);
                        break;
                    case 7:
                        ReporteRepuestosPorExistencia(sb);
                        break;
                    case 8:
                        ReporteRepuestosCriticos(sb);
                        break;
                    case 9:
                        ReporteIngresos(sb);
                        break;
                    case 10:
                        ReporteBusquedas(sb);
                        break;
                    case 11:
                        ReporteMatriz(sb);
                        break;
                }

                rtbReporte.Text = sb.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inesperado al generar el reporte: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ReporteEnEspera(StringBuilder sb)
        {
            Encabezado(sb, "SOLICITUDES EN ESPERA POR PRIORIDAD");

            sb.AppendLine("URGENTES (" + Datos.colaUrgente.Count + ")");
            if (Datos.colaUrgente.Count == 0)
            {
                sb.AppendLine("  (ninguna)");
            }
            foreach (Solicitud solicitud in Datos.colaUrgente)
            {
                sb.AppendLine("  " + solicitud.CodigoSolicitud + " | " + solicitud.Cliente.NombreCompleto +
                    " | " + solicitud.Equipo.Descripcion + " | " + Textos.Fecha(solicitud.FechaHora));
            }

            sb.AppendLine();
            sb.AppendLine("NORMALES (" + Datos.colaNormal.Count + ")");
            if (Datos.colaNormal.Count == 0)
            {
                sb.AppendLine("  (ninguna)");
            }
            foreach (Solicitud solicitud in Datos.colaNormal)
            {
                sb.AppendLine("  " + solicitud.CodigoSolicitud + " | " + solicitud.Cliente.NombreCompleto +
                    " | " + solicitud.Equipo.Descripcion + " | " + Textos.Fecha(solicitud.FechaHora));
            }
        }

        private void ReporteEstados(StringBuilder sb)
        {
            Encabezado(sb, "SOLICITUDES ACTIVAS, FINALIZADAS Y CANCELADAS");

            int activas = 0;
            int finalizadas = 0;
            int canceladas = 0;

            foreach (Solicitud solicitud in Datos.solicitudes)
            {
                if (solicitud.Estado == estadoSolicitud.Finalizada)
                {
                    finalizadas++;
                }
                else if (solicitud.Estado == estadoSolicitud.Cancelada)
                {
                    canceladas++;
                }
                else
                {
                    activas++;
                }
            }

            sb.AppendLine("Resumen: activas " + activas + " | finalizadas " + finalizadas +
                " | canceladas " + canceladas + " | total " + Datos.solicitudes.Count);
            sb.AppendLine();

            EscribirGrupo(sb, "ACTIVAS", activas);
            foreach (Solicitud solicitud in Datos.solicitudes)
            {
                if (solicitud.EsActiva)
                {
                    sb.AppendLine("  " + solicitud.CodigoSolicitud + " | " + solicitud.Cliente.NombreCompleto +
                        " | " + solicitud.EstadoTexto + " | " + Textos.Q(solicitud.Total));
                }
            }

            sb.AppendLine();
            EscribirGrupo(sb, "FINALIZADAS", finalizadas);
            foreach (Solicitud solicitud in Datos.solicitudes)
            {
                if (solicitud.Estado == estadoSolicitud.Finalizada)
                {
                    sb.AppendLine("  " + solicitud.CodigoSolicitud + " | " + solicitud.Cliente.NombreCompleto +
                        " | " + Textos.Q(solicitud.Total));
                }
            }

            sb.AppendLine();
            EscribirGrupo(sb, "CANCELADAS", canceladas);
            foreach (Solicitud solicitud in Datos.solicitudes)
            {
                if (solicitud.Estado == estadoSolicitud.Cancelada)
                {
                    sb.AppendLine("  " + solicitud.CodigoSolicitud + " | " + solicitud.Cliente.NombreCompleto);
                }
            }
        }

        private void ReporteTecnicos(StringBuilder sb)
        {
            Encabezado(sb, "TECNICOS DISPONIBLES Y CON CARGA COMPLETA");

            int disponibles = 0;
            int cargados = 0;

            foreach (Tecnico tecnico in Datos.tecnicos)
            {
                if (tecnico.CargaCompleta)
                {
                    cargados++;
                }
                else if (tecnico.Estado == estadoTecnico.Disponible)
                {
                    disponibles++;
                }
            }

            sb.AppendLine("Disponibles: " + disponibles + " | Carga completa: " + cargados +
                " | Total: " + Datos.tecnicos.Count);
            sb.AppendLine();

            sb.AppendLine("DISPONIBLES");
            if (disponibles == 0)
            {
                sb.AppendLine("  (ninguno)");
            }
            foreach (Tecnico tecnico in Datos.tecnicos)
            {
                if (!tecnico.CargaCompleta && tecnico.Estado == estadoTecnico.Disponible)
                {
                    sb.AppendLine("  " + tecnico.Codigo + " | " + tecnico.NombreCompleto +
                        " | " + Textos.De(tecnico.Especialidad) +
                        " | activos " + tecnico.CantTrabajosActivos + "/" + Tecnico.LimiteTrabajos +
                        " | calificacion " + tecnico.CalifPromedio.ToString("0.00"));
                }
            }

            sb.AppendLine();
            sb.AppendLine("CARGA COMPLETA");
            if (cargados == 0)
            {
                sb.AppendLine("  (ninguno)");
            }
            foreach (Tecnico tecnico in Datos.tecnicos)
            {
                if (tecnico.CargaCompleta)
                {
                    sb.AppendLine("  " + tecnico.Codigo + " | " + tecnico.NombreCompleto +
                        " | " + Textos.De(tecnico.Especialidad) +
                        " | activos " + tecnico.CantTrabajosActivos + "/" + Tecnico.LimiteTrabajos);
                }
            }
        }

        private void ReporteTecnicoDestacado(StringBuilder sb)
        {
            Encabezado(sb, "TECNICO CON MAS SERVICIOS FINALIZADOS");

            Tecnico mejor = null;

            foreach (Tecnico tecnico in Datos.tecnicos)
            {
                if (mejor == null ||
                    tecnico.CantTrabajosFin > mejor.CantTrabajosFin ||
                    (tecnico.CantTrabajosFin == mejor.CantTrabajosFin &&
                     tecnico.CalifPromedio > mejor.CalifPromedio))
                {
                    mejor = tecnico;
                }
            }

            if (mejor == null)
            {
                sb.AppendLine("No hay tecnicos registrados.");
                return;
            }

            sb.AppendLine("Tecnico: " + mejor.Codigo + " - " + mejor.NombreCompleto);
            sb.AppendLine("Especialidad: " + Textos.De(mejor.Especialidad));
            sb.AppendLine("Servicios finalizados: " + mejor.CantTrabajosFin);
            sb.AppendLine("Calificacion promedio: " + mejor.CalifPromedio.ToString("0.00"));
            sb.AppendLine("Trabajos activos: " + mejor.CantTrabajosActivos);
        }

        private void ReporteEquiposPorTipo(StringBuilder sb)
        {
            Encabezado(sb, "EQUIPOS ATENDIDOS POR TIPO");

            int[] conteo = new int[4];
            int total = 0;

            foreach (Equipo equipo in Datos.equipos)
            {
                if (equipo.Historial.Count > 0)
                {
                    conteo[(int)equipo.TipoEquipo]++;
                    total++;
                }
            }

            foreach (tipoEquipo tipo in Enum.GetValues(typeof(tipoEquipo)))
            {
                sb.AppendLine("  " + Textos.De(tipo) + ": " + conteo[(int)tipo]);
            }

            sb.AppendLine();
            sb.AppendLine("Total de equipos con al menos una solicitud: " + total);
        }

        private void ReporteSolicitudesPorTotal(StringBuilder sb)
        {
            Encabezado(sb, "SOLICITUDES ORDENADAS POR COSTO TOTAL");

            if (Datos.solicitudes.Count < 2)
            {
                sb.AppendLine("No hay datos suficientes para ordenar (minimo 2 solicitudes).");
                return;
            }

            List<Solicitud> lista = new List<Solicitud>(Datos.solicitudes);
            Algoritmos.BubbleSortSolicitudesPorTotal(lista, false);

            sb.AppendLine("Algoritmo: Bubble Sort | criterio: costo total | orden: descendente");
            sb.AppendLine();

            foreach (Solicitud solicitud in lista)
            {
                sb.AppendLine("  " + solicitud.CodigoSolicitud + " | " + solicitud.Cliente.NombreCompleto +
                    " | " + solicitud.EstadoTexto + " | " + Textos.Q(solicitud.Total));
            }
        }

        private void ReporteSolicitudesPorFecha(StringBuilder sb)
        {
            Encabezado(sb, "SOLICITUDES ORDENADAS POR FECHA DE RECEPCION");

            if (Datos.solicitudes.Count < 2)
            {
                sb.AppendLine("No hay datos suficientes para ordenar (minimo 2 solicitudes).");
                return;
            }

            List<Solicitud> lista = new List<Solicitud>(Datos.solicitudes);
            Algoritmos.QuickSortSolicitudesPorFecha(lista, 0, lista.Count - 1);

            sb.AppendLine("Algoritmo: Quick Sort | criterio: fecha de recepcion | orden: ascendente");
            sb.AppendLine();

            foreach (Solicitud solicitud in lista)
            {
                sb.AppendLine("  " + Textos.Fecha(solicitud.FechaHora) + " | " + solicitud.CodigoSolicitud +
                    " | " + solicitud.Cliente.NombreCompleto + " | horas: " + Textos.Horas(solicitud.HorasEstimadas));
            }
        }

        private void ReporteRepuestosPorExistencia(StringBuilder sb)
        {
            Encabezado(sb, "REPUESTOS ORDENADOS POR EXISTENCIA");

            if (Datos.repuestos.Count < 2)
            {
                sb.AppendLine("No hay datos suficientes para ordenar (minimo 2 repuestos).");
                return;
            }

            List<Repuesto> lista = new List<Repuesto>(Datos.repuestos);
            Algoritmos.ShellSortRepuestosPorExistencia(lista, true);

            sb.AppendLine("Algoritmo: Shell Sort | criterio: existencia disponible | orden: ascendente");
            sb.AppendLine();

            foreach (Repuesto repuesto in lista)
            {
                sb.AppendLine("  " + repuesto.Existencia.ToString().PadLeft(4) + " | " +
                    repuesto.Codigo + " | " + repuesto.Nombre +
                    " | minimo " + repuesto.ExistenciaMin + " | " + repuesto.EstadoStock);
            }
        }

        private void ReporteRepuestosCriticos(StringBuilder sb)
        {
            Encabezado(sb, "REPUESTOS CON EXISTENCIA MINIMA O AGOTADOS");

            int criticos = 0;
            foreach (Repuesto repuesto in Datos.repuestos)
            {
                if (repuesto.Agotado || repuesto.EnMinimo)
                {
                    criticos++;
                    sb.AppendLine("  " + repuesto.Codigo + " | " + repuesto.Nombre +
                        " | existencia " + repuesto.Existencia +
                        " | minima " + repuesto.ExistenciaMin +
                        " | " + repuesto.EstadoStock);
                }
            }

            if (criticos == 0)
            {
                sb.AppendLine("No hay repuestos agotados ni por debajo de la existencia minima.");
            }
            else
            {
                sb.AppendLine();
                sb.AppendLine("Total de repuestos criticos: " + criticos);
            }
        }

        private void ReporteIngresos(StringBuilder sb)
        {
            Encabezado(sb, "INGRESOS TOTALES POR SERVICIOS FINALIZADOS");

            double total = 0;
            int cantidad = 0;

            foreach (Solicitud solicitud in Datos.solicitudes)
            {
                if (solicitud.Estado == estadoSolicitud.Finalizada)
                {
                    total += solicitud.Total;
                    cantidad++;
                }
            }

            sb.AppendLine("Servicios finalizados: " + cantidad);
            sb.AppendLine("Ingresos totales: " + Textos.Q(total));

            if (cantidad == 0)
            {
                sb.AppendLine();
                sb.AppendLine("Todavia no hay servicios finalizados.");
            }
        }

        private void ReporteBusquedas(StringBuilder sb)
        {
            Encabezado(sb, "RESULTADOS DE LAS TRES BUSQUEDAS SECUENCIALES");

            sb.AppendLine("Clientes: " + BitacoraBusquedas.Clientes);
            sb.AppendLine();
            sb.AppendLine("Solicitudes: " + BitacoraBusquedas.Solicitudes);
            sb.AppendLine();
            sb.AppendLine("Equipos: " + BitacoraBusquedas.Equipos);
            sb.AppendLine();
            sb.AppendLine("Nota: se muestra el resultado de la ultima busqueda de cada tipo");
            sb.AppendLine("ejecutada en el modulo Busquedas.");
        }

        private void ReporteMatriz(StringBuilder sb)
        {
            Encabezado(sb, "MATRIZ SEMANAL DE CARGA DE TRABAJO");

            if (Datos.tecnicos.Count == 0)
            {
                sb.AppendLine("No hay tecnicos registrados.");
                return;
            }

            string[] dias = { "Lun", "Mar", "Mie", "Jue", "Vie", "Sab" };

            sb.AppendLine("Tecnico".PadRight(30) + "Lun  Mar  Mie  Jue  Vie  Sab   Total");
            sb.AppendLine(new string('-', 74));

            int filaMayor = -1;
            int columnaMayor = -1;
            int cargaMayor = 0;

            for (int fila = 0; fila < Datos.cargaSemanal.GetLength(0); fila++)
            {
                Tecnico tecnico = TecnicoPorFila(fila);
                if (tecnico == null)
                {
                    continue;
                }

                string nombre = (tecnico.Codigo + " " + tecnico.NombreCompleto);
                sb.Append(nombre.PadRight(30));

                int totalFila = 0;
                for (int columna = 0; columna < Datos.cargaSemanal.GetLength(1); columna++)
                {
                    int valor = Datos.cargaSemanal[fila, columna];
                    totalFila += valor;
                    sb.Append(valor.ToString().PadLeft(3) + "  ");

                    if (valor > cargaMayor)
                    {
                        cargaMayor = valor;
                        filaMayor = fila;
                        columnaMayor = columna;
                    }
                }

                sb.AppendLine(totalFila.ToString().PadLeft(5));
            }

            sb.AppendLine();
            if (cargaMayor == 0)
            {
                sb.AppendLine("Sin carga registrada: aun no se han asignado solicitudes.");
            }
            else
            {
                Tecnico tecnico = TecnicoPorFila(filaMayor);
                sb.AppendLine("Mayor carga: " + tecnico.Codigo + " - " + tecnico.NombreCompleto +
                    " el " + dias[columnaMayor] + " con " + cargaMayor + " solicitud(es).");
            }
        }
        private static void Encabezado(StringBuilder sb, string titulo)
        {
            sb.AppendLine(new string('=', 74));
            sb.AppendLine(titulo);
            sb.AppendLine(new string('=', 74));
            sb.AppendLine();
        }

        private static void EscribirGrupo(StringBuilder sb, string titulo, int cantidad)
        {
            sb.AppendLine(titulo + " (" + cantidad + ")");
            if (cantidad == 0)
            {
                sb.AppendLine("  (ninguna)");
            }
        }

        private static Tecnico TecnicoPorFila(int fila)
        {
            foreach (Tecnico tecnico in Datos.tecnicos)
            {
                if (tecnico.FilaMatriz == fila)
                {
                    return tecnico;
                }
            }

            return null;
        }

        private void BtnVolver_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Reportes_FormClosed(object sender, FormClosedEventArgs e)
        {
            MenuPrincipal menu = new MenuPrincipal();
            menu.Show();
        }
    }
}
