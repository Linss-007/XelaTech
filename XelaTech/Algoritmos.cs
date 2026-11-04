using System;
using System.Collections.Generic;

namespace XelaTech
{
    public static class Algoritmos
    {
        public static void BubbleSortSolicitudesPorTotal(List<Solicitud> lista, bool ascendente)
        {
            if (lista == null || lista.Count < 2)
            {
                return;
            }

            for (int i = 0; i < lista.Count - 1; i++)
            {
                bool huboCambio = false;
                for (int j = 0; j < lista.Count - 1 - i; j++)
                {
                    bool cambiar = ascendente
                        ? lista[j].Total > lista[j + 1].Total
                        : lista[j].Total < lista[j + 1].Total;

                    if (cambiar)
                    {
                        IntercambiarSolicitud(lista, j, j + 1);
                        huboCambio = true;
                    }
                }
                if (!huboCambio)
                {
                    break;
                }
            }
        }
        public static void SelectionSortTecnicosPorServicios(List<Tecnico> lista)
        {
            if (lista == null || lista.Count < 2)
            {
                return;
            }

            for (int i = 0; i < lista.Count - 1; i++)
            {
                int mayor = i;
                for (int j = i + 1; j < lista.Count; j++)
                {
                    if (lista[j].CantTrabajosFin > lista[mayor].CantTrabajosFin ||
                        (lista[j].CantTrabajosFin == lista[mayor].CantTrabajosFin &&
                         lista[j].CalifPromedio > lista[mayor].CalifPromedio))
                    {
                        mayor = j;
                    }
                }

                if (mayor != i)
                {
                    Tecnico auxiliar = lista[i];
                    lista[i] = lista[mayor];
                    lista[mayor] = auxiliar;
                }
            }
        }
        public static void ShellSortRepuestosPorExistencia(List<Repuesto> lista, bool ascendente)
        {
            if (lista == null || lista.Count < 2)
            {
                return;
            }

            int salto = lista.Count / 2;
            while (salto > 0)
            {
                for (int i = salto; i < lista.Count; i++)
                {
                    Repuesto actual = lista[i];
                    int j = i;

                    while (j >= salto && CompararRepuesto(lista[j - salto], actual, ascendente) > 0)
                    {
                        lista[j] = lista[j - salto];
                        j -= salto;
                    }

                    lista[j] = actual;
                }

                salto /= 2;
            }
        }
        public static void QuickSortSolicitudesPorFecha(List<Solicitud> lista, int inicio, int fin)
        {
            if (lista == null || inicio < 0 || fin >= lista.Count || inicio >= fin)
            {
                return;
            }

            int i = inicio;
            int j = fin;
            DateTime pivote = lista[(inicio + fin) / 2].FechaHora;

            while (i <= j)
            {
                while (lista[i].FechaHora < pivote)
                {
                    i++;
                }

                while (lista[j].FechaHora > pivote)
                {
                    j--;
                }

                if (i <= j)
                {
                    IntercambiarSolicitud(lista, i, j);
                    i++;
                    j--;
                }
            }

            if (inicio < j)
            {
                QuickSortSolicitudesPorFecha(lista, inicio, j);
            }

            if (i < fin)
            {
                QuickSortSolicitudesPorFecha(lista, i, fin);
            }
        }
        public static void QuickSortSolicitudesPorCodigo(List<Solicitud> lista, int inicio, int fin)
        {
            if (lista == null || inicio < 0 || fin >= lista.Count || inicio >= fin)
            {
                return;
            }

            int i = inicio;
            int j = fin;
            string pivote = lista[(inicio + fin) / 2].CodigoSolicitud;

            while (i <= j)
            {
                while (string.Compare(lista[i].CodigoSolicitud, pivote, StringComparison.OrdinalIgnoreCase) < 0)
                {
                    i++;
                }

                while (string.Compare(lista[j].CodigoSolicitud, pivote, StringComparison.OrdinalIgnoreCase) > 0)
                {
                    j--;
                }

                if (i <= j)
                {
                    IntercambiarSolicitud(lista, i, j);
                    i++;
                    j--;
                }
            }

            if (inicio < j)
            {
                QuickSortSolicitudesPorCodigo(lista, inicio, j);
            }

            if (i < fin)
            {
                QuickSortSolicitudesPorCodigo(lista, i, fin);
            }
        }
        public static List<Cliente> BusquedaSecuencialClientesPorNombre(string parcial)
        {
            List<Cliente> encontrados = new List<Cliente>();
            string criterio = parcial == null ? "" : parcial.Trim();

            if (criterio == "")
            {
                return encontrados;
            }

            foreach (Cliente cliente in Datos.clientes)
            {
                if (cliente.NombreCompleto != null &&
                    cliente.NombreCompleto.IndexOf(criterio, StringComparison.OrdinalIgnoreCase) >= 0)
                {
                    encontrados.Add(cliente);
                }
            }

            return encontrados;
        }
        public static List<Solicitud> BusquedaSecuencialSolicitudesPorEstado(estadoSolicitud estado)
        {
            List<Solicitud> encontradas = new List<Solicitud>();

            foreach (Solicitud solicitud in Datos.solicitudes)
            {
                if (solicitud.Estado == estado)
                {
                    encontradas.Add(solicitud);
                }
            }

            return encontradas;
        }
        public static List<Equipo> BusquedaSecuencialEquiposPorMarca(string parcial)
        {
            List<Equipo> encontrados = new List<Equipo>();
            string criterio = parcial == null ? "" : parcial.Trim();

            if (criterio == "")
            {
                return encontrados;
            }

            foreach (Equipo equipo in Datos.equipos)
            {
                if (equipo.Marca != null &&
                    equipo.Marca.IndexOf(criterio, StringComparison.OrdinalIgnoreCase) >= 0)
                {
                    encontrados.Add(equipo);
                }
            }

            return encontrados;
        }
        public static bool EstaOrdenadoPorCodigo(List<Solicitud> lista)
        {
            if (lista == null || lista.Count < 2)
            {
                return true;
            }

            for (int i = 1; i < lista.Count; i++)
            {
                if (string.Compare(lista[i - 1].CodigoSolicitud, lista[i].CodigoSolicitud,
                    StringComparison.OrdinalIgnoreCase) > 0)
                {
                    return false;
                }
            }

            return true;
        }
        public static int BusquedaBinariaSolicitudPorCodigo(List<Solicitud> lista, string codigo)
        {
            if (lista == null || lista.Count == 0 || codigo == null || codigo.Trim() == "")
            {
                return -1;
            }
            if (!EstaOrdenadoPorCodigo(lista))
            {
                return -1;
            }

            string buscado = codigo.Trim();
            int bajo = 0;
            int alto = lista.Count - 1;

            while (bajo <= alto)
            {
                int medio = (bajo + alto) / 2;
                int comparacion = string.Compare(lista[medio].CodigoSolicitud, buscado,
                    StringComparison.OrdinalIgnoreCase);

                if (comparacion == 0)
                {
                    return medio;
                }

                if (comparacion < 0)
                {
                    bajo = medio + 1;
                }
                else
                {
                    alto = medio - 1;
                }
            }

            return -1;
        }
        private static void IntercambiarSolicitud(List<Solicitud> lista, int a, int b)
        {
            Solicitud auxiliar = lista[a];
            lista[a] = lista[b];
            lista[b] = auxiliar;
        }

        private static int CompararRepuesto(Repuesto a, Repuesto b, bool ascendente)
        {
            int comparacion = a.Existencia.CompareTo(b.Existencia);

            if (comparacion == 0)
            {
                comparacion = string.Compare(a.Nombre, b.Nombre, StringComparison.OrdinalIgnoreCase);
            }

            return ascendente ? comparacion : -comparacion;
        }
    }
    public static class BitacoraBusquedas
    {
        public static string Clientes = "(sin busquedas)";
        public static string Solicitudes = "(sin busquedas)";
        public static string Equipos = "(sin busquedas)";
    }
}
