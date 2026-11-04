using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XelaTech
{
    // Un registro del historial de estados (se guarda en una pila dentro de cada solicitud)
    public class CambioEstado
    {
        public CambioEstado(bool tieneAnterior, estadoSolicitud anteriorIng, estadoSolicitud nuevoIng, string notaIng)
        {
            TieneAnterior = tieneAnterior;
            Anterior = anteriorIng;
            Nuevo = nuevoIng;
            Fecha = DateTime.Now;
            Nota = notaIng;
        }

        public bool TieneAnterior;
        public estadoSolicitud Anterior;
        public estadoSolicitud Nuevo;
        public DateTime Fecha;
        public string Nota;

        public override string ToString()
        {
            string origen = TieneAnterior ? Textos.De(Anterior) : "Cola";
            return Textos.Fecha(Fecha) + " | " + origen + " -> " + Textos.De(Nuevo) + " | " + Nota;
        }
    }

    // Repuesto usado en una solicitud, con el precio de venta vigente al usarlo
    public class RepuestoUsado
    {
        public RepuestoUsado(Repuesto repuestoIng, int cantidadIng)
        {
            Repuesto = repuestoIng;
            Cantidad = cantidadIng;
            PrecioUnitario = repuestoIng.PrecioVenta;
        }

        public Repuesto Repuesto;
        public int Cantidad;
        public double PrecioUnitario;

        public double Subtotal
        {
            get { return Cantidad * PrecioUnitario; }
        }
    }

    public class Solicitud
    {
        public const double TarifaHora = 50.0;

        public Solicitud(string codigoIng, Cliente clienteIng, Equipo equipoIng, string descripcionIng, DateTime fechaIng, prioridad prioridadIng)
        {
            CodigoSolicitud = codigoIng;
            Cliente = clienteIng;
            Equipo = equipoIng;
            Descripcion = descripcionIng;
            FechaHora = fechaIng;
            Prioridad = prioridadIng;
            if (equipoIng != null)
            {
                horasEstimadas = equipoIng.HorasEstimadas;
                costoManoObra = equipoIng.CostoRevision;
            }
        }

        private string codigoSolicitud;
        public string CodigoSolicitud
        {
            get { return codigoSolicitud; }
            set
            {
                if (value == null || value == "")
                {
                    MessageBox.Show("El código de la solicitud no puede estar vacio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    codigoSolicitud = value;
                }
            }
        }

        private Cliente cliente;
        public Cliente Cliente
        {
            get { return cliente; }
            set
            {
                if (value == null)
                {
                    MessageBox.Show("La solicitud debe tener un cliente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    cliente = value;
                }
            }
        }

        private Equipo equipo;
        public Equipo Equipo
        {
            get { return equipo; }
            set
            {
                if (value == null)
                {
                    MessageBox.Show("La solicitud debe tener un equipo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    equipo = value;
                }
            }
        }

        private string descripcion;
        public string Descripcion
        {
            get { return descripcion; }
            set
            {
                if (value == null || value.Trim().Length < 10)
                {
                    MessageBox.Show("La descripción del problema debe tener al menos 10 caracteres", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    descripcion = value;
                }
            }
        }

        private DateTime fechaHora;
        public DateTime FechaHora
        {
            get { return fechaHora; }
            set { fechaHora = value; }
        }

        private prioridad prioridad;
        public prioridad Prioridad
        {
            get { return prioridad; }
            set { prioridad = value; }
        }

        private estadoSolicitud estado = estadoSolicitud.Asignada;
        public estadoSolicitud Estado
        {
            get { return estado; }
        }

        private Tecnico tecnico;
        public Tecnico Tecnico
        {
            get { return tecnico; }
        }

        private string diagnostico = "";
        public string Diagnostico
        {
            get { return diagnostico; }
        }

        // Acciones realizadas durante el diagnostico (una por linea)
        private List<string> acciones = new List<string>();
        public List<string> Acciones
        {
            get { return acciones; }
        }

        private List<RepuestoUsado> repuestos = new List<RepuestoUsado>();
        public List<RepuestoUsado> Repuestos
        {
            get { return repuestos; }
        }

        private double horasEstimadas;
        public double HorasEstimadas
        {
            get { return horasEstimadas; }
        }

        private double costoManoObra;
        public double CostoManoObra
        {
            get { return costoManoObra; }
        }

        public double CostoRepuestos
        {
            get
            {
                double suma = 0;
                foreach (RepuestoUsado usado in repuestos)
                {
                    suma += usado.Subtotal;
                }
                return suma;
            }
        }

        public double Total
        {
            get { return costoManoObra + CostoRepuestos; }
        }

        private int calificacion;
        public int Calificacion
        {
            get { return calificacion; }
        }

        // Dia de atencion en la matriz de carga (0 = lunes ... 5 = sabado)
        private int diaAtencion = -1;

        // Pila de cambios: el primer elemento es siempre la ultima accion realizada
        private Stack<CambioEstado> historial = new Stack<CambioEstado>();
        public Stack<CambioEstado> Historial
        {
            get { return historial; }
        }

        public bool EsActiva
        {
            get { return estado != estadoSolicitud.Finalizada && estado != estadoSolicitud.Cancelada; }
        }

        public bool EnEspera
        {
            get { return EsActiva && tecnico == null; }
        }

        public bool EsUrgente
        {
            get { return prioridad != prioridad.Normal; }
        }

        // Una solicitud sin tecnico sigue en la cola de espera
        public string EstadoTexto
        {
            get
            {
                if (EnEspera)
                {
                    return "En cola";
                }
                return Textos.De(estado);
            }
        }

        public static int DiaDe(DateTime fecha)
        {
            if (fecha.DayOfWeek == DayOfWeek.Sunday)
            {
                return 0;
            }
            return (int)fecha.DayOfWeek - 1;
        }

        // Crea la solicitud y la añade a la cola segun su prioridad
        public void RegistrarSolicitud(Solicitud solicitud)
        {
            Datos.solicitudes.Add(solicitud);
            solicitud.Equipo.Historial.Add(solicitud);
            solicitud.Cliente.CantSolis++;
            if (solicitud.EsUrgente)
            {
                Datos.colaUrgente.Enqueue(solicitud);
            }
            else
            {
                Datos.colaNormal.Enqueue(solicitud);
            }
        }

        // Una solicitud entregada o cancelada no admite cambios
        private string ValidarModificable()
        {
            if (estado == estadoSolicitud.Finalizada)
            {
                return "La solicitud " + codigoSolicitud + " ya fue entregada y no admite cambios.";
            }
            if (estado == estadoSolicitud.Cancelada)
            {
                return "La solicitud " + codigoSolicitud + " esta cancelada y no admite cambios.";
            }
            return null;
        }

        private string ComprobarEnProceso(string accion)
        {
            string error = ValidarModificable();
            if (error != null)
            {
                return error;
            }
            if (tecnico == null || estado != estadoSolicitud.EnProceso)
            {
                return "No se puede " + accion + ": la solicitud debe estar En Proceso (estado actual: " + EstadoTexto + ").";
            }
            return null;
        }

        // Tabla de transiciones permitidas entre estados
        private static bool TransicionPermitida(estadoSolicitud de, estadoSolicitud a)
        {
            if (de == estadoSolicitud.Asignada)
            {
                return a == estadoSolicitud.EnProceso || a == estadoSolicitud.Cancelada;
            }
            if (de == estadoSolicitud.EnProceso)
            {
                return a == estadoSolicitud.Finalizada || a == estadoSolicitud.Cancelada;
            }
            return false;
        }

        private string CambiarEstado(estadoSolicitud nuevo, string nota)
        {
            string error = ValidarModificable();
            if (error != null)
            {
                return error;
            }
            if (tecnico == null && nuevo != estadoSolicitud.Cancelada)
            {
                return "La solicitud sigue en cola y aún no tiene técnico asignado.";
            }
            if (!TransicionPermitida(estado, nuevo))
            {
                return "Cambio de estado no permitido: " + Textos.De(estado) + " -> " + Textos.De(nuevo);
            }
            historial.Push(new CambioEstado(true, estado, nuevo, nota));
            estado = nuevo;
            return null;
        }

        // Todos los metodos siguientes devuelven null si se pudo; si no, el motivo del error
        public string AsignarTecnico(Tecnico tecnicoIng)
        {
            string error = ValidarModificable();
            if (error != null)
            {
                return error;
            }
            if (tecnico != null)
            {
                return "La solicitud ya tiene asignado al técnico " + tecnico.Codigo;
            }
            error = tecnicoIng.TomarTrabajo(equipo.TipoEquipo);
            if (error != null)
            {
                return error;
            }
            tecnico = tecnicoIng;
            diaAtencion = DiaDe(DateTime.Now);
            estado = estadoSolicitud.Asignada;
            historial.Push(new CambioEstado(false, estadoSolicitud.Asignada, estadoSolicitud.Asignada, "Asignada a " + tecnicoIng.Codigo));
            Datos.QuitarDeColas(this);
            Datos.cargaSemanal[tecnicoIng.FilaMatriz, diaAtencion]++;
            return null;
        }

        public string IniciarReparacion()
        {
            return CambiarEstado(estadoSolicitud.EnProceso, "Reparación iniciada");
        }

        public string RegistrarDiagnostico(string diagnosticoIng, double manoObraIng)
        {
            string error = ComprobarEnProceso("registrar el diagnóstico");
            if (error != null)
            {
                return error;
            }
            if (diagnosticoIng == null || diagnosticoIng.Trim() == "")
            {
                return "El diagnóstico no puede estar vacio";
            }
            if (manoObraIng < 0)
            {
                return "El costo de mano de obra no puede ser negativo";
            }
            diagnostico = diagnosticoIng.Trim();
            acciones.Clear();
            foreach (string linea in diagnostico.Split(new char[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries))
            {
                if (linea.Trim() != "")
                {
                    acciones.Add(linea.Trim());
                }
            }
            costoManoObra = manoObraIng;
            return null;
        }

        public string AgregarRepuesto(Repuesto repuestoIng, int cantidad)
        {
            if (cantidad <= 0)
            {
                return "La cantidad debe ser mayor que cero";
            }
            string error = ComprobarEnProceso("usar repuestos");
            if (error != null)
            {
                return error;
            }
            error = repuestoIng.Consumir(cantidad);
            if (error != null)
            {
                return error;
            }
            foreach (RepuestoUsado usado in repuestos)
            {
                if (usado.Repuesto == repuestoIng)
                {
                    usado.Cantidad += cantidad;
                    return null;
                }
            }
            repuestos.Add(new RepuestoUsado(repuestoIng, cantidad));
            return null;
        }

        public string Entregar(int calificacionIng)
        {
            string error = ComprobarEnProceso("entregar la solicitud");
            if (error != null)
            {
                return error;
            }
            if (diagnostico == "")
            {
                return "No se puede entregar sin registrar el diagnóstico";
            }
            if (calificacionIng < 1 || calificacionIng > 5)
            {
                return "La calificación debe estar entre 1 y 5";
            }
            error = CambiarEstado(estadoSolicitud.Finalizada, "Entregada, calificación " + calificacionIng + "/5");
            if (error != null)
            {
                return error;
            }
            calificacion = calificacionIng;
            return tecnico.LiberarTrabajo(true, calificacionIng);
        }

        // Cancela, devuelve los repuestos al inventario y libera al tecnico
        public string Cancelar(out int devueltos)
        {
            devueltos = 0;
            string error = CambiarEstado(estadoSolicitud.Cancelada, "Solicitud cancelada");
            if (error != null)
            {
                return error;
            }
            foreach (RepuestoUsado usado in repuestos)
            {
                usado.Repuesto.Devolver(usado.Cantidad);
                devueltos += usado.Cantidad;
            }
            repuestos.Clear();
            if (tecnico != null)
            {
                tecnico.LiberarTrabajo(false, 0);
                if (Datos.cargaSemanal[tecnico.FilaMatriz, diaAtencion] > 0)
                {
                    Datos.cargaSemanal[tecnico.FilaMatriz, diaAtencion]--;
                }
            }
            else
            {
                Datos.QuitarDeColas(this);
            }
            return null;
        }

        // Revierte el ultimo cambio (pila). Solo se puede deshacer de En Proceso a Asignada
        public string DeshacerUltimoCambio(out string mensaje)
        {
            mensaje = "";
            string error = ValidarModificable();
            if (error != null)
            {
                return error;
            }
            if (historial.Count == 0)
            {
                return "No hay cambios por deshacer";
            }
            CambioEstado ultimo = historial.Peek();
            if (!ultimo.TieneAnterior)
            {
                return "La asignación inicial del técnico no se puede deshacer";
            }
            historial.Pop();
            estado = ultimo.Anterior;
            int devueltos = 0;
            if (ultimo.Nuevo == estadoSolicitud.EnProceso)
            {
                foreach (RepuestoUsado usado in repuestos)
                {
                    usado.Repuesto.Devolver(usado.Cantidad);
                    devueltos += usado.Cantidad;
                }
                repuestos.Clear();
                diagnostico = "";
                acciones.Clear();
                costoManoObra = equipo.CostoRevision;
            }
            mensaje = "Se deshizo el cambio a " + Textos.De(ultimo.Nuevo) + ". La solicitud volvió a " + Textos.De(estado) + ".";
            if (devueltos > 0)
            {
                mensaje += " Se devolvieron " + devueltos + " repuesto(s) al inventario.";
            }
            return null;
        }

        // Resumen corto para mostrar en pantalla
        public string Resumen()
        {
            StringBuilder texto = new StringBuilder();
            texto.AppendLine("Código: " + codigoSolicitud);
            texto.AppendLine("Cliente: " + cliente.Codigo + " - " + cliente.NombreCompleto);
            texto.AppendLine("Equipo: " + equipo.CodigoInterno + " - " + equipo.Descripcion);
            texto.AppendLine("Prioridad: " + Textos.De(prioridad) + " | Estado: " + EstadoTexto);
            texto.AppendLine("Técnico: " + (tecnico != null ? tecnico.Codigo + " - " + tecnico.NombreCompleto : "(sin asignar)"));
            texto.AppendLine("Horas estimadas: " + Textos.Horas(horasEstimadas));
            texto.AppendLine("Mano de obra: " + Textos.Q(costoManoObra) + " | Repuestos: " + Textos.Q(CostoRepuestos));
            texto.AppendLine("TOTAL: " + Textos.Q(Total));
            texto.AppendLine("Diagnóstico: " + (diagnostico == "" ? "(pendiente)" : diagnostico.Replace("\r\n", " / ").Replace("\n", " / ")));
            return texto.ToString();
        }

        // Ficha completa con el historial de estados
        public string Ficha()
        {
            StringBuilder texto = new StringBuilder();
            texto.AppendLine("SOLICITUD " + codigoSolicitud);
            texto.AppendLine("Cliente: " + cliente.Codigo + " - " + cliente.NombreCompleto + " (" + Textos.De(cliente.TipoCliente) + ")");
            texto.AppendLine("Equipo: " + equipo.CodigoInterno + " - " + equipo.Descripcion);
            texto.AppendLine("Fecha: " + Textos.Fecha(fechaHora) + " | Prioridad: " + Textos.De(prioridad) + " | Estado: " + EstadoTexto);
            texto.AppendLine("Técnico: " + (tecnico != null ? tecnico.Codigo + " - " + tecnico.NombreCompleto : "(sin asignar)"));
            texto.AppendLine("Descripción: " + descripcion);
            texto.AppendLine("Horas estimadas: " + Textos.Horas(horasEstimadas));
            texto.AppendLine();
            texto.AppendLine("Diagnóstico: " + (diagnostico == "" ? "(pendiente)" : ""));
            foreach (string accion in acciones)
            {
                texto.AppendLine("  - " + accion);
            }
            texto.AppendLine();
            texto.AppendLine("Repuestos usados:");
            if (repuestos.Count == 0)
            {
                texto.AppendLine("  (ninguno)");
            }
            foreach (RepuestoUsado usado in repuestos)
            {
                texto.AppendLine("  " + usado.Cantidad + " x " + usado.Repuesto.Nombre + " a " + Textos.Q(usado.PrecioUnitario) + " = " + Textos.Q(usado.Subtotal));
            }
            texto.AppendLine();
            texto.AppendLine("Mano de obra: " + Textos.Q(costoManoObra) + " | Repuestos: " + Textos.Q(CostoRepuestos) + " | TOTAL: " + Textos.Q(Total));
            if (estado == estadoSolicitud.Finalizada)
            {
                texto.AppendLine("Calificación del servicio: " + calificacion + "/5");
            }
            texto.AppendLine();
            texto.AppendLine("Historial de estados (más reciente primero):");
            if (historial.Count == 0)
            {
                texto.AppendLine("  (sin cambios)");
            }
            foreach (CambioEstado cambio in historial)
            {
                texto.AppendLine("  " + cambio.ToString());
            }
            return texto.ToString();
        }
    }
}
