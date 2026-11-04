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
    public partial class ConsultarRepuesto : Form
    {
        public ConsultarRepuesto()
        {
            InitializeComponent();
        }

        private void ConsultarRepuesto_Load(object sender, EventArgs e)
        {
            dgvRepuestosGuardados.DataSource = Datos.repuestos.Select(r => new
            {
                Codigo = r.Codigo,
                Nombre = r.Nombre,
                Categoria = Textos.De(r.Categoria),
                Existencia = r.Existencia,
                Minima = r.ExistenciaMin,
                Costo = Textos.Q(r.CostoUnitario),
                Precio = Textos.Q(r.PrecioVenta),
                Utilizada = r.CantUtilizada,
                Estado = r.EstadoStock
            }).ToList();
        }

        // Rojo: agotado. Naranja: existencia en el minimo
        private void dgvRepuestosGuardados_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex >= Datos.repuestos.Count)
            {
                return;
            }
            Repuesto repuesto = Datos.repuestos[e.RowIndex];
            if (repuesto.Agotado)
            {
                e.CellStyle.BackColor = Color.LightCoral;
            }
            else if (repuesto.EnMinimo)
            {
                e.CellStyle.BackColor = Color.Orange;
            }
        }

        private void btnVolverRepuesto_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ConsultarRepuesto_FormClosed(object sender, FormClosedEventArgs e)
        {
            Repuestos repuestos = new Repuestos();
            repuestos.Show();
        }
    }
}
