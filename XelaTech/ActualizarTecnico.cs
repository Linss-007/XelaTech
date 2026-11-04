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
    public partial class ActualizarTecnico : Form
    {
        Tecnico tecnicoActual = null;
        public ActualizarTecnico()
        {
            InitializeComponent();
        }

        private void ActualizarTecnico_FormClosed(object sender, FormClosedEventArgs e)
        {
            Tecnicos tecnicos = new Tecnicos();
            tecnicos.Show();
        }

        private void btnVolverTecnico_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MostrarCampos(bool visible)
        {
            txbNomTecnico.Visible = visible;
            cbxEspecialidadTec.Visible = visible;
            cbxEstadoTec.Visible = visible;
        }

        private void btnBuscarTecnico_Click(object sender, EventArgs e)
        {
            tecnicoActual = Datos.BuscarTecnico(txbBuscarTecnico.Text);
            if (tecnicoActual != null)
            {
                MessageBox.Show("El codigo ha sido encontrado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txbNomTecnico.Text = tecnicoActual.NombreCompleto;
                cbxEspecialidadTec.SelectedIndex = (int)tecnicoActual.Especialidad;
                if (tecnicoActual.Estado == estadoTecnico.FueraDeServicio)
                {
                    cbxEstadoTec.SelectedIndex = 1;
                }
                else
                {
                    cbxEstadoTec.SelectedIndex = 0;
                }
                MostrarCampos(true);
            }
            else
            {
                MessageBox.Show("El codigo no se ha podido encontrar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MostrarCampos(false);
            }
        }

        private void btnActuTecnico_Click(object sender, EventArgs e)
        {
            if (tecnicoActual == null)
            {
                MessageBox.Show("No se ha ingresado un codigo a buscar o no se ha encontrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (cbxEspecialidadTec.SelectedIndex < 0 || cbxEstadoTec.SelectedIndex < 0)
            {
                MessageBox.Show("Debe seleccionar una especialidad y un estado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            especialidad especialidadIng = (especialidad)(cbxEspecialidadTec.SelectedIndex);
            bool ausente = cbxEstadoTec.SelectedIndex == 1;
            string error = tecnicoActual.ActualizarInfo(txbNomTecnico.Text, especialidadIng, ausente);
            if (error != null)
            {
                MessageBox.Show(error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("El técnico se ha actualizado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tecnicoActual = null;
                txbBuscarTecnico.Clear();
                txbNomTecnico.Clear();
                MostrarCampos(false);
            }
        }
    }
}
