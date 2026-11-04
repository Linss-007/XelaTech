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
    public partial class RegistroEquipo : Form
    {
        public RegistroEquipo()
        {
            InitializeComponent();
        }

        private void RegistroEquipo_FormClosed(object sender, FormClosedEventArgs e)
        {
            Equipos equipos = new Equipos();
            equipos.Show();
        }

        private void btnVolverEquipo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRegEquipo_Click(object sender, EventArgs e)
        {
            string codigoIng = txbCodEquipo.Text;
            string serieIng = txbSerieEquipo.Text;
            string marcaIng = txbMarcaEquipo.Text;
            string modeloIng = txbModeloEquipo.Text;
            string accesoriosIng = txbAccesEquipo.Text;
            if (!codigoIng.StartsWith("eq", StringComparison.OrdinalIgnoreCase))
            {
                MessageBox.Show("El código debe empezar con eq", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (Datos.BuscarEquipo(codigoIng) != null)
            {
                MessageBox.Show("El código ingresado ya esta registrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (serieIng != "" && Datos.BuscarEquipoPorSerie(serieIng) != null)
            {
                MessageBox.Show("El número de serie ya esta registrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbSerieEquipo.Clear();
                return;
            }
            if (cbxTipoEquipo.SelectedIndex < 0 || cbxEstadoEquipo.SelectedIndex < 0)
            {
                MessageBox.Show("Debe seleccionar el tipo y el estado físico del equipo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Cliente propietario = Datos.BuscarCliente(txbPropEquipo.Text);
            if (propietario == null)
            {
                MessageBox.Show("El propietario ingresado no existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbPropEquipo.Clear();
                return;
            }
            tipoEquipo tipoIng = (tipoEquipo)(cbxTipoEquipo.SelectedIndex);
            estadoFisico estadoIng = (estadoFisico)(cbxEstadoEquipo.SelectedIndex);
            Equipo equipo = new Equipo(codigoIng, serieIng, marcaIng, modeloIng, tipoIng, estadoIng, accesoriosIng, propietario);
            if (equipo.CodigoInterno != codigoIng)
            {
                txbCodEquipo.Clear();
            }
            else if (equipo.NumSerie != serieIng)
            {
                txbSerieEquipo.Clear();
            }
            else if (equipo.Marca != marcaIng)
            {
                txbMarcaEquipo.Clear();
            }
            else if (equipo.Modelo != modeloIng)
            {
                txbModeloEquipo.Clear();
            }
            else
            {
                equipo.RegistrarEquipo(equipo);
                MessageBox.Show("El equipo se ha registrado" + Environment.NewLine +
                                "Costo de revisión: " + Textos.Q(equipo.CostoRevision) + Environment.NewLine +
                                "Horas estimadas: " + Textos.Horas(equipo.HorasEstimadas),
                                "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnLimpiarEquipo_Click(sender, e);
            }
        }

        private void btnLimpiarEquipo_Click(object sender, EventArgs e)
        {
            txbCodEquipo.Clear();
            txbSerieEquipo.Clear();
            txbMarcaEquipo.Clear();
            txbModeloEquipo.Clear();
            txbAccesEquipo.Clear();
            txbPropEquipo.Clear();
            cbxTipoEquipo.SelectedIndex = -1;
            cbxEstadoEquipo.SelectedIndex = -1;
        }
    }
}
