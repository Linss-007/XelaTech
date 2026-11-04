using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XelaTech
{
    public class Tecnico : Usuario
    {
        public const int LimiteTrabajos = 3;
        public const int MaximoTecnicos = 10;

        public Tecnico(string codigoIng, string nombreIng, especialidad especialidadIng, estadoTecnico estadoIng) : base(codigoIng, nombreIng)
        {
            Especialidad = especialidadIng;
            Estado = estadoIng;
        }

        private especialidad especialidad;
        public especialidad Especialidad
        {
            get { return especialidad; }
            set { especialidad = value; }
        }

        private estadoTecnico estado;
        public estadoTecnico Estado
        {
            get { return estado; }
            set { estado = value; }
        }

        private int cantTrabajosActivos;
        public int CantTrabajosActivos
        {
            get { return cantTrabajosActivos; }
            set { cantTrabajosActivos = value; }
        }

        private int cantTrabajosFin;
        public int CantTrabajosFin
        {
            get { return cantTrabajosFin; }
            set { cantTrabajosFin = value; }
        }

        // Arreglo de 5 posiciones: posicion 0 = nota 1 ... posicion 4 = nota 5 (veces recibida)
        private int[] calificaciones = new int[5];
        public int[] Calificaciones
        {
            get { return calificaciones; }
        }

        // Promedio ponderado; si aun no tiene calificaciones es 0 para evitar dividir entre cero
        public double CalifPromedio
        {
            get
            {
                int total = 0;
                int suma = 0;
                for (int i = 0; i < calificaciones.Length; i++)
                {
                    total += calificaciones[i];
                    suma += (i + 1) * calificaciones[i];
                }
                if (total == 0)
                {
                    return 0;
                }
                return (double)suma / total;
            }
        }

        // Fila que ocupa el tecnico en la matriz de carga semanal
        private int filaMatriz = -1;
        public int FilaMatriz
        {
            get { return filaMatriz; }
            set { filaMatriz = value; }
        }

        public bool CargaCompleta
        {
            get { return cantTrabajosActivos >= LimiteTrabajos; }
        }

        public void RegistrarTecnico(Tecnico tecnico)
        {
            tecnico.FilaMatriz = Datos.tecnicos.Count;
            Datos.tecnicos.Add(tecnico);
        }

        // Cada especialidad atiende ciertos tipos de equipo
        public bool AtiendeTipo(tipoEquipo tipo)
        {
            switch (tipo)
            {
                case tipoEquipo.Laptop:
                case tipoEquipo.Computadora:
                    return Especialidad == especialidad.Computadoras || Especialidad == especialidad.Software;
                case tipoEquipo.Celular:
                    return Especialidad == especialidad.Celulares || Especialidad == especialidad.Software;
                case tipoEquipo.Impresora:
                    return Especialidad == especialidad.Impresoras;
                default:
                    return false;
            }
        }

        // Devuelve null si puede recibir el trabajo; si no, el motivo del rechazo
        public string MotivoRechazo(tipoEquipo tipo)
        {
            if (Estado == estadoTecnico.FueraDeServicio)
            {
                return "El técnico " + Codigo + " está fuera de servicio.";
            }
            if (!AtiendeTipo(tipo))
            {
                return "El técnico " + Codigo + " no tiene la especialidad requerida para este equipo.";
            }
            if (CargaCompleta)
            {
                return "El técnico " + Codigo + " tiene la carga completa (" + LimiteTrabajos + " trabajos activos).";
            }
            return null;
        }

        public string TomarTrabajo(tipoEquipo tipo)
        {
            string motivo = MotivoRechazo(tipo);
            if (motivo != null)
            {
                return motivo;
            }
            cantTrabajosActivos++;
            ActualizarEstadoPorCarga();
            return null;
        }

        public string LiberarTrabajo(bool finalizado, int calificacion)
        {
            if (cantTrabajosActivos <= 0)
            {
                return "El técnico " + Codigo + " no tiene trabajos activos.";
            }
            if (finalizado)
            {
                if (calificacion < 1 || calificacion > 5)
                {
                    return "La calificación debe estar entre 1 y 5.";
                }
                cantTrabajosFin++;
                calificaciones[calificacion - 1]++;
            }
            cantTrabajosActivos--;
            ActualizarEstadoPorCarga();
            return null;
        }

        private void ActualizarEstadoPorCarga()
        {
            if (Estado == estadoTecnico.FueraDeServicio)
            {
                return;
            }
            if (cantTrabajosActivos > 0)
            {
                Estado = estadoTecnico.Asignado;
            }
            else
            {
                Estado = estadoTecnico.Disponible;
            }
        }

        // Devuelve null si se actualizó; si no, el motivo
        public string ActualizarInfo(string nombreIng, especialidad especialidadIng, bool ausente)
        {
            if (nombreIng == null || nombreIng == "")
            {
                return "Nombre no puede estar vacio";
            }
            if (especialidadIng != Especialidad && cantTrabajosActivos > 0)
            {
                return "No se puede cambiar la especialidad de un técnico con trabajos activos.";
            }
            if (ausente && Estado != estadoTecnico.FueraDeServicio)
            {
                if (cantTrabajosActivos > 0)
                {
                    return "No se puede marcar como ausente a un técnico con trabajos activos (" + cantTrabajosActivos + ").";
                }
                Estado = estadoTecnico.FueraDeServicio;
            }
            else if (!ausente && Estado == estadoTecnico.FueraDeServicio)
            {
                Estado = estadoTecnico.Disponible;
                ActualizarEstadoPorCarga();
            }
            NombreCompleto = nombreIng;
            Especialidad = especialidadIng;
            return null;
        }

        public override string ToString()
        {
            return Codigo + " - " + NombreCompleto;
        }
    }
}
