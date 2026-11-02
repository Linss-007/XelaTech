using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XelaTech
{
    public class Cliente : Usuario
    {
        public Cliente(string codigoIng, string nombreIng) : base(codigoIng,nombreIng)
        {

        }

        private string numeroTel;
        public string NumeroTel
        {
            get { return numeroTel; }
            set { if (value.Length == 8)
                  {
                    numeroTel = value; 
                  }
                }
        }

        private string correo;
        public string Correo
        {
            get { return correo; }
            set { correo = value; }
        }

        private tipoCliente tipoCliente;
        public  tipoCliente TipoCliente
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

    }
}
