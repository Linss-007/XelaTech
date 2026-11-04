using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XelaTech
{
    public partial class ConsultarSolicitud : Form
    {
        public ConsultarSolicitud()
        {
            InitializeComponent();
        }

        private void ConsultarSolicitud_Load(object sender, EventArgs e)
        {
            dgvSolicitudesGuardadas.DataSource = Datos.solicitudes.Select(s => new
            {
                Codigo = s.CodigoSolicitud,
                Cliente = s.Cliente.NombreCompleto,
                Equipo = s.Equipo.Descripcion,
                Prioridad = Textos.De(s.Prioridad),
                Estado = s.EstadoTexto,
                Tecnico = s.Tecnico != null ? s.Tecnico.Codigo : "-",
                Horas = Textos.Horas(s.HorasEstimadas),
                Total = Textos.Q(s.Total),
                Fecha = Textos.Fecha(s.FechaHora)
            }).ToList();
            lblColasSoli.Text = "En cola urgente: " + Datos.colaUrgente.Count + "   |   En cola normal: " + Datos.colaNormal.Count;
        }

        private void btnFichaSoli_Click(object sender, EventArgs e)
        {
            if (dgvSolicitudesGuardadas.CurrentRow == null)
            {
                MessageBox.Show("Seleccione una solicitud de la tabla", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Solicitud solicitud = Datos.solicitudes[dgvSolicitudesGuardadas.CurrentRow.Index];
            MessageBox.Show(solicitud.Ficha(), "Ficha de la solicitud", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnVolverSoli_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ConsultarSolicitud_FormClosed(object sender, FormClosedEventArgs e)
        {
            Solicitudes solicitudes = new Solicitudes();
            solicitudes.Show();
        }
    }
}
