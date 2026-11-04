using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XelaTech
{
    public static class Datos
    {
        public static List<Cliente> clientes = new List<Cliente>();
        public static List<Tecnico> tecnicos = new List<Tecnico>();
        public static List<Equipo> equipos = new List<Equipo>();
        public static List<Repuesto> repuestos = new List<Repuesto>();
        public static List<Solicitud> solicitudes = new List<Solicitud>();
        public static Queue<Solicitud> colaUrgente = new Queue<Solicitud>();
        public static Queue<Solicitud> colaNormal = new Queue<Solicitud>();
        public static int[,] cargaSemanal = new int[10, 6];

        public static Cliente BuscarCliente(string codigo)
        {
            if (codigo == null || codigo == "") return null;
            foreach (Cliente cliente in clientes)
            {
                if (string.Equals(cliente.Codigo, codigo.Trim(), StringComparison.OrdinalIgnoreCase)) return cliente;
            }
            return null;
        }

        public static Tecnico BuscarTecnico(string codigo)
        {
            if (codigo == null || codigo == "") return null;
            foreach (Tecnico tecnico in tecnicos)
            {
                if (string.Equals(tecnico.Codigo, codigo.Trim(), StringComparison.OrdinalIgnoreCase)) return tecnico;
            }
            return null;
        }

        public static Equipo BuscarEquipo(string codigo)
        {
            if (codigo == null || codigo == "") return null;
            foreach (Equipo equipo in equipos)
            {
                if (string.Equals(equipo.CodigoInterno, codigo.Trim(), StringComparison.OrdinalIgnoreCase)) return equipo;
            }
            return null;
        }

        public static Equipo BuscarEquipoPorSerie(string serie)
        {
            if (serie == null || serie == "") return null;
            foreach (Equipo equipo in equipos)
            {
                if (string.Equals(equipo.NumSerie, serie.Trim(), StringComparison.OrdinalIgnoreCase)) return equipo;
            }
            return null;
        }

        public static Repuesto BuscarRepuesto(string codigo)
        {
            if (codigo == null || codigo == "") return null;
            foreach (Repuesto repuesto in repuestos)
            {
                if (string.Equals(repuesto.Codigo, codigo.Trim(), StringComparison.OrdinalIgnoreCase)) return repuesto;
            }
            return null;
        }

        public static Solicitud BuscarSolicitud(string codigo)
        {
            if (codigo == null || codigo == "")
            { 
                return null; 
            }
            foreach (Solicitud solicitud in solicitudes)
            {
                if (string.Equals(solicitud.CodigoSolicitud, codigo.Trim(), StringComparison.OrdinalIgnoreCase))
                {
                    return solicitud;
                }
            }
            return null;
        }
        public static Solicitud SolicitudActiva(Equipo equipo)
        {
            foreach (Solicitud solicitud in equipo.Historial)
            {
                if (solicitud.EsActiva) return solicitud;
            }
            return null;
        }
        public static void QuitarDeColas(Solicitud solicitud)
        {
            colaUrgente = new Queue<Solicitud>(colaUrgente.Where(s => s != solicitud));
            colaNormal = new Queue<Solicitud>(colaNormal.Where(s => s != solicitud));
        }
    }
}
