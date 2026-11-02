using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XelaTech
{
    public class Usuario
    {
		private string codigo;
		private string nombreCompleto;

		public string NombreCompleto
		{
			get { return nombreCompleto; }
			set { nombreCompleto = value; }
		}

		public string Codigo
		{
			get { return codigo; }
			set { codigo = value; }
		}
		public Usuario(string codigoIng, string nombreIng)
		{
			Codigo = codigoIng;
			NombreCompleto= nombreIng;
		}
		public virtual void ConsultarInfo()
		{

		}
		public virtual void RegistrarInfo()
		{

		}
		public virtual void ActualizarInfo()
		{

		}
	}
}
