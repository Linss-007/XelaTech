using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XelaTech
{
    public class Usuario
    {
        public Usuario(string codigoIng, string nombreIng)
        {
            Codigo = codigoIng;
            NombreCompleto = nombreIng;
        }
        private string codigo;
		private string nombreCompleto;

		public string NombreCompleto
		{
			get { return nombreCompleto; }
			set 
			{
				if(value == null || value == "")
				{
					MessageBox.Show("Nombre no puede estar vacio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
				else
				{
					nombreCompleto = value;
				}
			}
		}

		public string Codigo
		{
			get { return codigo; }
			set 
			{
                if (value == null || value == "")
                {
                    MessageBox.Show("El código no puede estar vacio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    codigo = value;
                }
            }
		}
	}
}
