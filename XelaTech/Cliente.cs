using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XelaTech
{
    public class Cliente : Usuario
    {
        public Cliente(string codigoIng, string nombreIng, string numeroTelIng, string correoIng, tipoCliente tipoClienteIng) : base(codigoIng, nombreIng)
        {
            NumeroTel = numeroTelIng;
            Correo = correoIng;
            TipoCliente = tipoClienteIng;
        }

        private string numeroTel;
        public string NumeroTel
        {
            get { return numeroTel; }
            set
            {
                if (value.Length != 8)
                {
                    MessageBox.Show("La longitud del número debe ser de 8 digitos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (!int.TryParse(value, out int numero))
                {
                    MessageBox.Show("El número no puede contener letras", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    numeroTel = value;
                }
            }
        }

        private string correo;
        public string Correo
        {
            get { return correo; }
            set
            {
                if(value == null || value == "")
                {
                    MessageBox.Show("El correo no puede estar vacio.","Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if(!value.Contains("@") || !value.Contains("."))
                {
                    MessageBox.Show("El correo debe contener @ y un dominio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    correo = value;
                }
            }
        }

        private tipoCliente tipoCliente;
        public tipoCliente TipoCliente
        {
            get { return tipoCliente; }
            set { tipoCliente = value; }
        }

        private int cantSolis;

        public int CantSolis
        {
            get { return cantSolis; }
            set { cantSolis = value; }
        }
        public void RegistrarCliente(Cliente cliente)
        {
            Datos.clientes.Add(cliente);
        }
    }
}
