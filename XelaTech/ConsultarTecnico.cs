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
    public partial class ConsultarTecnico : Form
    {
        public ConsultarTecnico()
        {
            InitializeComponent();
        }

        private void ConsultarTecnico_Load(object sender, EventArgs e)
        {
            dgvTecnicosGuardados.DataSource = Datos.tecnicos.Select(t => new
            {
                Codigo = t.Codigo,
                Nombre = t.NombreCompleto,
                Especialidad = Textos.De(t.Especialidad),
                Estado = Textos.De(t.Estado),
                Activos = t.CantTrabajosActivos + "/" + Tecnico.LimiteTrabajos,
                Finalizados = t.CantTrabajosFin,
                Promedio = Math.Round(t.CalifPromedio, 2)
            }).ToList();
        }

        private void btnVolverTecnico_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ConsultarTecnico_FormClosed(object sender, FormClosedEventArgs e)
        {
            Tecnicos tecnicos = new Tecnicos();
            tecnicos.Show();
        }
    }
}
