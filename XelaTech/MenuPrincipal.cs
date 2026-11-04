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
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnGesCliente_Click(object sender, EventArgs e)
        {
            Clientes clientes = new Clientes();
            clientes.Show();
            this.Close();
        }

        private void btnGesTecnico_Click(object sender, EventArgs e)
        {
            Tecnicos tecnicos = new Tecnicos();
            tecnicos.Show();
            this.Close();
        }

        private void btnGesEquipo_Click(object sender, EventArgs e)
        {
            Equipos equipos = new Equipos();
            equipos.Show();
            this.Close();
        }

        private void btnGesSolis_Click(object sender, EventArgs e)
        {
            Solicitudes solicitudes = new Solicitudes();
            solicitudes.Show();
            this.Close();
        }

        private void btnGesRepuestos_Click(object sender, EventArgs e)
        {
            Repuestos repuestos = new Repuestos();
            repuestos.Show();
            this.Close();
        }

        private void btnGesColas_Click(object sender, EventArgs e)
        {
            Colas colas = new Colas();
            colas.Show();
            this.Close();
        }

        private void btnOrdenamientos_Click(object sender, EventArgs e)
        {
            Ordenamientos ordenamientos = new Ordenamientos();
            ordenamientos.Show();
            this.Close();
        }

        private void btnBusquedas_Click(object sender, EventArgs e)
        {
            Busquedas busquedas = new Busquedas();
            busquedas.Show();
            this.Close();
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            Reportes reportes = new Reportes();
            reportes.Show();
            this.Close();
        }

        private void btnGenerarDatos_Click(object sender, EventArgs e)
        {
            DatosPrueba datosPrueba = new DatosPrueba();
            datosPrueba.Show();
            this.Close();
        }
    }
}
