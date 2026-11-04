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
    public partial class RegistroTecnico : Form
    {
        public RegistroTecnico()
        {
            InitializeComponent();
        }

        private void RegistroTecnico_FormClosed(object sender, FormClosedEventArgs e)
        {
            Tecnicos tecnicos = new Tecnicos();
            tecnicos.Show();
        }

        private void btnVolverTecnico_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRegTecnico_Click(object sender, EventArgs e)
        {
            string codigoIng = txbCodTecnico.Text;
            string nombreIng = txbNomTecnico.Text;
            if (!codigoIng.StartsWith("tec", StringComparison.OrdinalIgnoreCase))
            {
                MessageBox.Show("El código debe empezar con tec", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (Datos.tecnicos.Count >= Tecnico.MaximoTecnicos)
            {
                MessageBox.Show("La matriz de carga semanal está llena, solo se pueden registrar " + Tecnico.MaximoTecnicos + " técnicos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (Datos.BuscarTecnico(codigoIng) != null)
            {
                MessageBox.Show("El código ingresado ya esta registrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (cbxEspecialidadTec.SelectedIndex < 0)
            {
                MessageBox.Show("Debe seleccionar una especialidad", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (cbxEstadoTec.SelectedIndex < 0)
            {
                MessageBox.Show("Debe seleccionar un estado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            especialidad especialidadIng = (especialidad)(cbxEspecialidadTec.SelectedIndex);
            estadoTecnico estadoIng = estadoTecnico.Disponible;
            if (cbxEstadoTec.SelectedIndex == 1)
            {
                estadoIng = estadoTecnico.FueraDeServicio;
            }
            Tecnico tecnico = new Tecnico(codigoIng, nombreIng, especialidadIng, estadoIng);
            if (tecnico.Codigo != codigoIng)
            {
                txbCodTecnico.Clear();
            }
            else if (tecnico.NombreCompleto != nombreIng)
            {
                txbNomTecnico.Clear();
            }
            else
            {
                tecnico.RegistrarTecnico(tecnico);
                MessageBox.Show("El técnico se ha registrado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnLimpiarTecnico_Click(sender, e);
            }
        }

        private void btnLimpiarTecnico_Click(object sender, EventArgs e)
        {
            txbCodTecnico.Clear();
            txbNomTecnico.Clear();
            cbxEspecialidadTec.SelectedIndex = -1;
            cbxEstadoTec.SelectedIndex = -1;
        }
    }
}
