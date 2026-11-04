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
    public partial class Repuestos : Form
    {
        public Repuestos()
        {
            InitializeComponent();
        }

        private void Repuestos_FormClosed(object sender, FormClosedEventArgs e)
        {
            MenuPrincipal menu = new MenuPrincipal();
            menu.Show();
        }

        private void btnSalirRepuesto_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRegisRepuesto_Click(object sender, EventArgs e)
        {
            RegistroRepuesto registro = new RegistroRepuesto();
            registro.Show();
            this.Hide();
        }

        private void btnActuRepuesto_Click(object sender, EventArgs e)
        {
            if (Datos.repuestos.Count > 0)
            {
                ActualizarRepuesto actualizar = new ActualizarRepuesto();
                actualizar.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("No existen repuestos guardados", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnConsRepuesto_Click(object sender, EventArgs e)
        {
            if (Datos.repuestos.Count > 0)
            {
                ConsultarRepuesto consultar = new ConsultarRepuesto();
                consultar.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("No existen repuestos guardados", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
