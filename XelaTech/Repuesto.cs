using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XelaTech
{
    public class Repuesto
    {
        public Repuesto(string codigoIng, string nombreIng, categoria categoriaIng, int existenciaIng, int existenciaMinIng, double costoIng, double precioIng)
        {
            Codigo = codigoIng;
            Nombre = nombreIng;
            Categoria = categoriaIng;
            Existencia = existenciaIng;
            ExistenciaMin = existenciaMinIng;
            CostoUnitario = costoIng;
            PrecioVenta = precioIng;
        }

        private string codigo;
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

        private string nombre;
        public string Nombre
        {
            get { return nombre; }
            set
            {
                if (value == null || value == "")
                {
                    MessageBox.Show("El nombre no puede estar vacio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    nombre = value;
                }
            }
        }

        private categoria categoria;
        public categoria Categoria
        {
            get { return categoria; }
            set { categoria = value; }
        }

        private int existencia;
        public int Existencia
        {
            get { return existencia; }
            set
            {
                if (value < 0)
                {
                    MessageBox.Show("La existencia no puede ser negativa", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    existencia = value;
                }
            }
        }

        private int existenciaMin;
        public int ExistenciaMin
        {
            get { return existenciaMin; }
            set
            {
                if (value < 0)
                {
                    MessageBox.Show("La existencia mínima no puede ser negativa", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    existenciaMin = value;
                }
            }
        }

        private double costoUnitario;
        public double CostoUnitario
        {
            get { return costoUnitario; }
            set
            {
                if (value < 0)
                {
                    MessageBox.Show("El costo unitario no puede ser negativo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    costoUnitario = value;
                }
            }
        }

        private double precioVenta;
        public double PrecioVenta
        {
            get { return precioVenta; }
            set
            {
                if (value < 0)
                {
                    MessageBox.Show("El precio de venta no puede ser negativo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (value < costoUnitario)
                {
                    MessageBox.Show("El precio de venta no puede ser menor que el costo unitario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    precioVenta = value;
                }
            }
        }

        private int cantUtilizada;
        public int CantUtilizada
        {
            get { return cantUtilizada; }
        }

        public bool Agotado
        {
            get { return existencia == 0; }
        }

        public bool EnMinimo
        {
            get { return existencia > 0 && existencia <= existenciaMin; }
        }

        public string EstadoStock
        {
            get
            {
                if (Agotado)
                {
                    return "AGOTADO";
                }
                if (EnMinimo)
                {
                    return "MÍNIMO";
                }
                return "OK";
            }
        }

        public void RegistrarRepuesto(Repuesto repuesto)
        {
            Datos.repuestos.Add(repuesto);
        }
        public string Consumir(int cantidad)
        {
            if (cantidad <= 0)
            {
                return "La cantidad debe ser mayor que cero";
            }
            if (cantidad > existencia)
            {
                return "Existencia insuficiente de " + nombre + ": disponible " + existencia + ", solicitado " + cantidad;
            }
            existencia -= cantidad;
            cantUtilizada += cantidad;
            return null;
        }
        public void Devolver(int cantidad)
        {
            if (cantidad <= 0)
            {
                return;
            }
            existencia += cantidad;
            cantUtilizada -= cantidad;
            if (cantUtilizada < 0)
            {
                cantUtilizada = 0;
            }
        }
        public string Reponer(int cantidad)
        {
            if (cantidad <= 0)
            {
                return "La cantidad a reponer debe ser mayor que cero";
            }
            existencia += cantidad;
            return null;
        }
        public string ActualizarInfo(string nombreIng, categoria categoriaIng, int existenciaMinIng, double costoIng, double precioIng)
        {
            if (nombreIng == null || nombreIng == "")
            {
                return "El nombre no puede estar vacio";
            }
            if (existenciaMinIng < 0)
            {
                return "La existencia mínima no puede ser negativa";
            }
            if (costoIng < 0 || precioIng < 0)
            {
                return "El costo y el precio no pueden ser negativos";
            }
            if (precioIng < costoIng)
            {
                return "El precio de venta no puede ser menor que el costo unitario";
            }
            nombre = nombreIng;
            categoria = categoriaIng;
            existenciaMin = existenciaMinIng;
            costoUnitario = costoIng;
            precioVenta = precioIng;
            return null;
        }
    }
}
