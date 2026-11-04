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
    public partial class Tecnicos : Form
    {
        public Tecnicos()
        {
            InitializeComponent();
        }

        private void Tecnicos_FormClosed(object sender, FormClosedEventArgs e)
        {
            MenuPrincipal menu = new MenuPrincipal();
            menu.Show();
        }

        private void btnSalirTecnico_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRegisTecnico_Click(object sender, EventArgs e)
        {
            RegistroTecnico registro = new RegistroTecnico();
            registro.Show();
            this.Hide();
        }

        private void btnActuTecnico_Click(object sender, EventArgs e)
        {
            if (Datos.tecnicos.Count > 0)
            {
                ActualizarTecnico actualizar = new ActualizarTecnico();
                actualizar.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("No existen técnicos guardados", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnConsTecnico_Click(object sender, EventArgs e)
        {
            if (Datos.tecnicos.Count > 0)
            {
                ConsultarTecnico consultar = new ConsultarTecnico();
                consultar.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("No existen técnicos guardados", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
