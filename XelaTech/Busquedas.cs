using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace XelaTech
{
    public partial class Busquedas : Form
    {
        public Busquedas()
        {
            InitializeComponent();
            cbxTipo.SelectedIndex = 0;
            cbxEstado.SelectedIndex = 0;
        }

        private void CbxTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool esEstado = cbxTipo.SelectedIndex == 1;

            if (esEstado)
            {
                lblCriterio.Text = "Estado:";
            }
            else if (cbxTipo.SelectedIndex == 0)
            {
                lblCriterio.Text = "Nombre (parcial):";
            }
            else if (cbxTipo.SelectedIndex == 2)
            {
                lblCriterio.Text = "Marca (parcial):";
            }
            else
            {
                lblCriterio.Text = "Codigo exacto:";
            }

            txbCriterio.Visible = !esEstado;
            cbxEstado.Visible = esEstado;
            LimpiarResultados();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                switch (cbxTipo.SelectedIndex)
                {
                    case 0:
                        BuscarClientes();
                        break;
                    case 1:
                        BuscarSolicitudesPorEstado();
                        break;
                    case 2:
                        BuscarEquiposPorMarca();
                        break;
                    case 3:
                        BuscarSolicitudPorCodigo();
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inesperado al buscar: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BuscarClientes()
        {
            string criterio = txbCriterio.Text.Trim();
            if (criterio == "")
            {
                Aviso("Escriba al menos una parte del nombre del cliente.");
                return;
            }

            List<Cliente> encontrados = Algoritmos.BusquedaSecuencialClientesPorNombre(criterio);
            List<string> codigos = new List<string>();
            foreach (Cliente cliente in encontrados)
            {
                codigos.Add(cliente.Codigo);
            }

            BitacoraBusquedas.Clientes = "Clientes por nombre \"" + criterio + "\": " +
                encontrados.Count + " coincidencia(s)" + DetalleCodigos(codigos);

            lblEncabezado.Text = "Busqueda secuencial | clientes por nombre parcial | \"" +
                criterio + "\" | " + encontrados.Count + " coincidencia(s)";

            dgvResultados.DataSource = encontrados.Select(c => new
            {
                Codigo = c.Codigo,
                Nombre = c.NombreCompleto,
                Telefono = c.NumeroTel,
                Correo = c.Correo,
                Tipo = Textos.De(c.TipoCliente),
                Solicitudes = c.CantSolis
            }).ToList();
        }

        private void BuscarSolicitudesPorEstado()
        {
            if (cbxEstado.SelectedIndex < 0)
            {
                Aviso("Seleccione un estado.");
                return;
            }

            estadoSolicitud estado = (estadoSolicitud)cbxEstado.SelectedIndex;
            List<Solicitud> encontradas = Algoritmos.BusquedaSecuencialSolicitudesPorEstado(estado);
            List<string> codigos = new List<string>();
            foreach (Solicitud solicitud in encontradas)
            {
                codigos.Add(solicitud.CodigoSolicitud);
            }

            BitacoraBusquedas.Solicitudes = "Solicitudes en estado " + Textos.De(estado) + ": " +
                encontradas.Count + " coincidencia(s)" + DetalleCodigos(codigos);

            lblEncabezado.Text = "Busqueda secuencial | solicitudes por estado | " +
                Textos.De(estado) + " | " + encontradas.Count + " coincidencia(s)";

            MostrarSolicitudes(encontradas);
        }

        private void BuscarEquiposPorMarca()
        {
            string criterio = txbCriterio.Text.Trim();
            if (criterio == "")
            {
                Aviso("Escriba al menos una parte de la marca.");
                return;
            }

            List<Equipo> encontrados = Algoritmos.BusquedaSecuencialEquiposPorMarca(criterio);
            List<string> codigos = new List<string>();
            foreach (Equipo equipo in encontrados)
            {
                codigos.Add(equipo.CodigoInterno);
            }

            BitacoraBusquedas.Equipos = "Equipos por marca \"" + criterio + "\": " +
                encontrados.Count + " coincidencia(s)" + DetalleCodigos(codigos);

            lblEncabezado.Text = "Busqueda secuencial | equipos por marca parcial | \"" +
                criterio + "\" | " + encontrados.Count + " coincidencia(s)";

            dgvResultados.DataSource = encontrados.Select(e => new
            {
                Codigo = e.CodigoInterno,
                Serie = e.NumSerie,
                Marca = e.Marca,
                Modelo = e.Modelo,
                Tipo = Textos.De(e.TipoEquipo),
                Propietario = e.Propietario.Codigo + " - " + e.Propietario.NombreCompleto,
                EstadoFisico = Textos.De(e.EstadoFisico),
                Solicitudes = e.Historial.Count
            }).ToList();
        }

        private void BuscarSolicitudPorCodigo()
        {
            string codigo = txbCriterio.Text.Trim();
            if (codigo == "")
            {
                Aviso("Escriba el codigo exacto de la solicitud.");
                return;
            }

            if (Datos.solicitudes.Count == 0)
            {
                Aviso("No hay solicitudes registradas.");
                return;
            }
            List<Solicitud> copia = new List<Solicitud>(Datos.solicitudes);
            Algoritmos.QuickSortSolicitudesPorCodigo(copia, 0, copia.Count - 1);

            string encabezado = "Busqueda binaria | ordenado por codigo con Quick Sort (ascendente) | " +
                copia.Count + " registros";

            if (!Algoritmos.EstaOrdenadoPorCodigo(copia))
            {
                dgvResultados.DataSource = null;
                lblEncabezado.Text = "Los datos no estan ordenados por codigo: no se ejecuta la busqueda binaria.";
                return;
            }

            int posicion = Algoritmos.BusquedaBinariaSolicitudPorCodigo(copia, codigo);

            if (posicion < 0)
            {
                dgvResultados.DataSource = null;
                dgvResultados.Columns.Clear();
                lblEncabezado.Text = encabezado + " | sin coincidencias para \"" + codigo + "\"";
                return;
            }

            List<Solicitud> resultado = new List<Solicitud>();
            resultado.Add(copia[posicion]);
            MostrarSolicitudes(resultado);

            lblEncabezado.Text = encabezado + " | encontrada en la posicion " + (posicion + 1);
        }

        private void MostrarSolicitudes(List<Solicitud> lista)
        {
            dgvResultados.DataSource = lista.Select(s => new
            {
                Codigo = s.CodigoSolicitud,
                Cliente = s.Cliente.NombreCompleto,
                Equipo = s.Equipo.Descripcion,
                Prioridad = Textos.De(s.Prioridad),
                Estado = s.EstadoTexto,
                Tecnico = s.Tecnico != null ? s.Tecnico.Codigo : "-",
                Fecha = Textos.Fecha(s.FechaHora),
                Total = Textos.Q(s.Total)
            }).ToList();
        }

        private void LimpiarResultados()
        {
            dgvResultados.DataSource = null;
            dgvResultados.Columns.Clear();
            lblEncabezado.Text = "Seleccione el tipo de busqueda, escriba el criterio y presione Buscar.";
        }

        private static string DetalleCodigos(List<string> codigos)
        {
            if (codigos.Count == 0)
            {
                return "";
            }

            StringBuilder detalle = new StringBuilder(" | codigos: ");
            int limite = Math.Min(codigos.Count, 8);

            for (int i = 0; i < limite; i++)
            {
                if (i > 0)
                {
                    detalle.Append(", ");
                }
                detalle.Append(codigos[i]);
            }

            if (codigos.Count > limite)
            {
                detalle.Append("...");
            }

            return detalle.ToString();
        }

        private void Aviso(string mensaje)
        {
            MessageBox.Show(mensaje, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnVolver_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Busquedas_FormClosed(object sender, FormClosedEventArgs e)
        {
            MenuPrincipal menu = new MenuPrincipal();
            menu.Show();
        }
    }
}
