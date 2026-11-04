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
    public partial class ConsultarEquipo : Form
    {
        public ConsultarEquipo()
        {
            InitializeComponent();
        }

        private void ConsultarEquipo_Load(object sender, EventArgs e)
        {
            dgvEquiposGuardados.DataSource = Datos.equipos.Select(q => new
            {
                Codigo = q.CodigoInterno,
                Serie = q.NumSerie,
                Marca = q.Marca,
                Modelo = q.Modelo,
                Tipo = Textos.De(q.TipoEquipo),
                Estado = Textos.De(q.EstadoFisico),
                Accesorios = q.Accesorios,
                Propietario = q.Propietario.Codigo + " - " + q.Propietario.NombreCompleto,
                CostoRevision = Textos.Q(q.CostoRevision),
                Horas = Textos.Horas(q.HorasEstimadas),
                Solicitudes = q.Historial.Count
            }).ToList();
        }

        private void btnFichaEquipo_Click(object sender, EventArgs e)
        {
            if (dgvEquiposGuardados.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un equipo de la tabla", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Equipo equipo = Datos.equipos[dgvEquiposGuardados.CurrentRow.Index];
            MessageBox.Show(equipo.Ficha(), "Ficha del equipo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnVolverEquipo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ConsultarEquipo_FormClosed(object sender, FormClosedEventArgs e)
        {
            Equipos equipos = new Equipos();
            equipos.Show();
        }
    }
}
