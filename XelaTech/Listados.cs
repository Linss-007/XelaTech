using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XelaTech
{
    public enum tipoCliente
    {
        Normal,
        Prioritario,
        Ejecutivo,
        Frecuente
    }        

    public enum estadoFisico
    {
        Nuevo,
        MuyBueno,
        Bueno,
        Malo,
        MuyMalo
    }

    public enum tipoEquipo
    {
        Laptop,
        Computadora,
        Celular,
        Impresora
    }

    public enum especialidad
    {
        Software,
        Computadoras,
        Celulares,
        Impresoras
    }

    public enum estadoTecnico
    {
        Disponible,
        Asignado,
        FueraDeServicio
    }

    public enum categoria
    {
        HardwareDePC,
        HardwareDeLaptop,
        HardwareDeImpresora,
        Periferico
    }

    public enum prioridad
    {
        MuyAlta,
        Alta,
        Normal
    }

    public enum estadoSolicitud
    {
        Asignada,
        EnProceso,
        Cancelada,
        Finalizada
    }
    public static class Textos
    {
        public static string De(Enum valor)
        {
            switch (valor.ToString())
            {
                case "MuyBueno": return "Muy bueno";
                case "MuyMalo": return "Muy malo";
                case "FueraDeServicio": return "Fuera de Servicio";
                case "HardwareDePC": return "Hardware de PC";
                case "HardwareDeLaptop": return "Hardware de Laptop";
                case "HardwareDeImpresora": return "Hardware de Impresora";
                case "MuyAlta": return "Muy Alta";
                case "EnProceso": return "En Proceso";
                default: return valor.ToString();
            }
        }

        public static string Q(double valor)
        {
            return "Q" + valor.ToString("N2", CultureInfo.InvariantCulture);
        }

        public static string Horas(double valor)
        {
            return valor.ToString("0.0", CultureInfo.InvariantCulture);
        }

        public static string Fecha(DateTime fecha)
        {
            return fecha.ToString("dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
        }
        public static bool TryNumero(string texto, out double valor)
        {
            if (texto == null)
            {
                valor = 0;
                return false;
            }
            return double.TryParse(texto.Trim().Replace(',', '.'), NumberStyles.Float, CultureInfo.InvariantCulture, out valor);
        }
    }
}
