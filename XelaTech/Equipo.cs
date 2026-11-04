using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XelaTech
{
    public class Equipo
    {
        public Equipo(string codigoIng, string numSerieIng, string marcaIng, string modeloIng, tipoEquipo tipoIng, estadoFisico estadoIng, string accesoriosIng, Cliente propietarioIng)
        {
            CodigoInterno = codigoIng;
            NumSerie = numSerieIng;
            Marca = marcaIng;
            Modelo = modeloIng;
            TipoEquipo = tipoIng;
            EstadoFisico = estadoIng;
            Accesorios = accesoriosIng;
            Propietario = propietarioIng;
        }

        private string codigoInterno;
        public string CodigoInterno
        {
            get { return codigoInterno; }
            set
            {
                if (value == null || value == "")
                {
                    MessageBox.Show("El código interno no puede estar vacio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    codigoInterno = value;
                }
            }
        }

        private string numSerie;
        public string NumSerie
        {
            get { return numSerie; }
            set
            {
                if (value == null || value == "")
                {
                    MessageBox.Show("El número de serie no puede estar vacio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    numSerie = value;
                }
            }
        }

        private string marca;
        public string Marca
        {
            get { return marca; }
            set
            {
                if (value == null || value == "")
                {
                    MessageBox.Show("La marca no puede estar vacia", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    marca = value;
                }
            }
        }

        private string modelo;
        public string Modelo
        {
            get { return modelo; }
            set
            {
                if (value == null || value == "")
                {
                    MessageBox.Show("El modelo no puede estar vacio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    modelo = value;
                }
            }
        }

        private tipoEquipo tipoEquipo;
        public tipoEquipo TipoEquipo
        {
            get { return tipoEquipo; }
            set { tipoEquipo = value; }
        }

        private estadoFisico estadoFisico;
        public estadoFisico EstadoFisico
        {
            get { return estadoFisico; }
            set { estadoFisico = value; }
        }

        private string accesorios;
        public string Accesorios
        {
            get { return accesorios; }
            set
            {
                if (value == null || value == "")
                {
                    accesorios = "Ninguno";
                }
                else
                {
                    accesorios = value;
                }
            }
        }

        private Cliente propietario;
        public Cliente Propietario
        {
            get { return propietario; }
            set
            {
                if (value == null)
                {
                    MessageBox.Show("El equipo debe tener un propietario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    propietario = value;
                }
            }
        }
        private List<Solicitud> historial = new List<Solicitud>();
        public List<Solicitud> Historial
        {
            get { return historial; }
        }
        public double CostoRevision
        {
            get
            {
                switch (TipoEquipo)
                {
                    case tipoEquipo.Laptop: return 150;
                    case tipoEquipo.Computadora: return 100;
                    case tipoEquipo.Celular: return 80;
                    default: return 120;
                }
            }
        }
        public double HorasEstimadas
        {
            get
            {
                switch (TipoEquipo)
                {
                    case tipoEquipo.Laptop: return 3.0;
                    case tipoEquipo.Computadora: return 2.5;
                    default: return 2.0;
                }
            }
        }

        public string Descripcion
        {
            get { return Textos.De(TipoEquipo) + " " + Marca + " " + Modelo; }
        }

        public void RegistrarEquipo(Equipo equipo)
        {
            Datos.equipos.Add(equipo);
        }
        public string ActualizarInfo(string marcaIng, string modeloIng, estadoFisico estadoIng, string accesoriosIng)
        {
            if (marcaIng == null || marcaIng == "")
            {
                return "La marca no puede estar vacia";
            }
            if (modeloIng == null || modeloIng == "")
            {
                return "El modelo no puede estar vacio";
            }
            Marca = marcaIng;
            Modelo = modeloIng;
            EstadoFisico = estadoIng;
            Accesorios = accesoriosIng;
            return null;
        }
        public string Ficha()
        {
            StringBuilder ficha = new StringBuilder();
            ficha.AppendLine("EQUIPO " + CodigoInterno + " - " + Descripcion);
            ficha.AppendLine("Serie: " + NumSerie);
            ficha.AppendLine("Estado físico: " + Textos.De(EstadoFisico));
            ficha.AppendLine("Accesorios: " + Accesorios);
            ficha.AppendLine("Propietario: " + Propietario.Codigo + " - " + Propietario.NombreCompleto);
            ficha.AppendLine("Costo de revisión: " + Textos.Q(CostoRevision));
            ficha.AppendLine("Horas estimadas: " + Textos.Horas(HorasEstimadas));
            ficha.AppendLine();
            ficha.AppendLine("Historial de solicitudes:");
            if (Historial.Count == 0)
            {
                ficha.AppendLine("  (sin solicitudes)");
            }
            foreach (Solicitud solicitud in Historial)
            {
                ficha.AppendLine("  " + solicitud.CodigoSolicitud + " | " + Textos.Fecha(solicitud.FechaHora) + " | " + solicitud.EstadoTexto + " | " + Textos.Q(solicitud.Total));
            }
            return ficha.ToString();
        }
    }
}
