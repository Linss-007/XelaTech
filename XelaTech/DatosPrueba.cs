using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace XelaTech
{
    public partial class DatosPrueba : Form
    {
        public DatosPrueba()
        {
            InitializeComponent();
        }

        private void BtnGenerar_Click(object sender, EventArgs e)
        {
            try
            {
                int cantidad = (int)nudCantidad.Value;
                Random rnd = new Random();

                int clientesCreados = GenerarClientes(cantidad, rnd);
                int tecnicosCreados = GenerarTecnicos(cantidad, rnd);
                int equiposCreados = GenerarEquipos(cantidad, rnd);
                int repuestosCreados = GenerarRepuestos(cantidad, rnd);
                int solicitudesCreadas = GenerarSolicitudes(cantidad, rnd);

                StringBuilder resumen = new StringBuilder();
                resumen.AppendLine("DATOS DE PRUEBA GENERADOS");
                resumen.AppendLine(new string('=', 60));
                resumen.AppendLine("Clientes creados:      " + clientesCreados);
                resumen.AppendLine("Tecnicos creados:      " + tecnicosCreados);
                resumen.AppendLine("Equipos creados:       " + equiposCreados);
                resumen.AppendLine("Repuestos creados:     " + repuestosCreados);
                resumen.AppendLine("Solicitudes creadas:   " + solicitudesCreadas);
                resumen.AppendLine();
                resumen.AppendLine("TOTALES EN EL SISTEMA");
                resumen.AppendLine(new string('=', 60));
                resumen.AppendLine("Clientes:    " + Datos.clientes.Count);
                resumen.AppendLine("Tecnicos:    " + Datos.tecnicos.Count + " / " + Tecnico.MaximoTecnicos);
                resumen.AppendLine("Equipos:     " + Datos.equipos.Count);
                resumen.AppendLine("Repuestos:   " + Datos.repuestos.Count);
                resumen.AppendLine("Solicitudes: " + Datos.solicitudes.Count);
                resumen.AppendLine();
                resumen.AppendLine("Cola urgente: " + Datos.colaUrgente.Count);
                resumen.AppendLine("Cola normal:  " + Datos.colaNormal.Count);

                if (tecnicosCreados < cantidad)
                {
                    resumen.AppendLine();
                    resumen.AppendLine("Nota: no se crearon mas tecnicos porque se alcanzo el limite de " +
                        Tecnico.MaximoTecnicos + ".");
                }

                if (solicitudesCreadas < cantidad)
                {
                    resumen.AppendLine();
                    resumen.AppendLine("Nota: no se crearon mas solicitudes porque todos los equipos");
                    resumen.AppendLine("ya tienen una solicitud activa.");
                }

                lblResumen.Text = resumen.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inesperado al generar los datos: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private static int GenerarClientes(int cantidad, Random rnd)
        {
            string[] nombres = { "Ana", "Luis", "Maria", "Carlos", "Jose", "Sofia", "Diego", "Elena",
                                 "Pablo", "Lucia", "Jorge", "Andrea" };
            string[] apellidos = { "Lopez", "Garcia", "Perez", "Ramirez", "Castillo", "Morales",
                                   "Hernandez", "Gomez", "Diaz", "Ruiz" };

            int creados = 0;

            for (int i = 0; i < cantidad; i++)
            {
                string codigo = CodigoCliente();
                string nombre = nombres[rnd.Next(nombres.Length)] + " " +
                    apellidos[rnd.Next(apellidos.Length)] + " " +
                    apellidos[rnd.Next(apellidos.Length)];
                string telefono = rnd.Next(10000000, 100000000).ToString();
                string correo = codigo + "@correo.com";
                tipoCliente tipo = (tipoCliente)rnd.Next(0, 4);

                Cliente cliente = new Cliente(codigo, nombre, telefono, correo, tipo);
                cliente.RegistrarCliente(cliente);
                creados++;
            }

            return creados;
        }

        private static int GenerarTecnicos(int cantidad, Random rnd)
        {
            string[] nombres = { "Mario", "Julia", "Ramon", "Patricia", "Hector", "Silvia",
                                 "Oscar", "Teresa", "Victor", "Claudia", "Manuel", "Rosa" };
            string[] apellidos = { "Aguilar", "Barrios", "Cifuentes", "Estrada", "Fuentes",
                                   "Giron", "Juarez", "Mejia", "Orozco", "Pineda" };

            int creados = 0;

            for (int i = 0; i < cantidad; i++)
            {
                if (Datos.tecnicos.Count >= Tecnico.MaximoTecnicos)
                {
                    break;
                }

                string codigo = CodigoTecnico();
                string nombre = nombres[rnd.Next(nombres.Length)] + " " +
                    apellidos[rnd.Next(apellidos.Length)];
                especialidad especialidadTecnico = (especialidad)(Datos.tecnicos.Count % 4);

                Tecnico tecnico = new Tecnico(codigo, nombre, especialidadTecnico, estadoTecnico.Disponible);
                tecnico.RegistrarTecnico(tecnico);
                creados++;
            }

            return creados;
        }

        private static int GenerarEquipos(int cantidad, Random rnd)
        {
            string[] marcas = { "HP", "Dell", "Lenovo", "Asus", "Acer", "Epson", "Canon", "Brother" };
            string[] modelos = { "ProBook", "Inspiron", "ThinkPad", "VivoBook", "Aspire",
                                 "L3250", "G3110", "HL-1212" };
            string[] accesorios = { "Cargador", "Cargador y mouse", "Cable de poder",
                                    "Estuche", "Ninguno" };

            int creados = 0;

            for (int i = 0; i < cantidad; i++)
            {
                string codigo = CodigoEquipo();
                string serie = SerieUnica(rnd);
                string marca = marcas[rnd.Next(marcas.Length)];
                string modelo = modelos[rnd.Next(modelos.Length)];
                // Se rotan los tipos para garantizar que existan las cuatro variedades
                tipoEquipo tipo = (tipoEquipo)(i % 4);
                estadoFisico estado = (estadoFisico)rnd.Next(0, 5);
                Cliente propietario = Datos.clientes[rnd.Next(0, Datos.clientes.Count)];

                Equipo equipo = new Equipo(codigo, serie, marca, modelo, tipo, estado,
                    accesorios[rnd.Next(accesorios.Length)], propietario);
                equipo.RegistrarEquipo(equipo);
                creados++;
            }

            return creados;
        }

        private static int GenerarRepuestos(int cantidad, Random rnd)
        {
            string[] nombres = { "Memoria RAM 8GB", "Disco SSD 480GB", "Teclado de reemplazo",
                                 "Pantalla 15.6", "Toner negro", "Cartucho de tinta",
                                 "Pasta termica", "Ventilador interno", "Bateria de laptop",
                                 "Cable de poder" };

            int creados = 0;

            for (int i = 0; i < cantidad; i++)
            {
                string codigo = CodigoRepuesto();
                string nombre = nombres[rnd.Next(nombres.Length)];
                categoria categoriaRepuesto = (categoria)rnd.Next(0, 4);
                int existencia = rnd.Next(5, 51);
                int existenciaMinima = rnd.Next(1, 5);
                double costo = Math.Round(20 + rnd.NextDouble() * 480, 2);
                double precio = Math.Round(costo * 1.3, 2);

                Repuesto repuesto = new Repuesto(codigo, nombre, categoriaRepuesto, existencia,
                    existenciaMinima, costo, precio);
                repuesto.RegistrarRepuesto(repuesto);
                creados++;
            }

            return creados;
        }

        private static int GenerarSolicitudes(int cantidad, Random rnd)
        {
            string[] descripciones = {
                "El equipo no enciende y presenta fallas intermitentes.",
                "La pantalla muestra lineas y parpadeos constantes.",
                "La impresora no imprime y marca error de papel.",
                "El equipo se sobrecalienta y se apaga de forma repentina.",
                "El teclado tiene teclas que no responden.",
                "El equipo funciona lento y se congela con frecuencia."
            };

            int creados = 0;

            for (int i = 0; i < cantidad; i++)
            {
                List<Equipo> disponibles = new List<Equipo>();
                foreach (Equipo equipo in Datos.equipos)
                {
                    if (Datos.SolicitudActiva(equipo) == null)
                    {
                        disponibles.Add(equipo);
                    }
                }

                if (disponibles.Count == 0)
                {
                    break;
                }

                Equipo elegido = disponibles[rnd.Next(disponibles.Count)];
                string codigo = CodigoSolicitud();
                string descripcion = descripciones[rnd.Next(descripciones.Length)];
                DateTime fecha = DateTime.Now.AddMinutes(-rnd.Next(5, 1440));
                prioridad prioridadSolicitud = (prioridad)rnd.Next(0, 3);

                Solicitud solicitud = new Solicitud(codigo, elegido.Propietario, elegido,
                    descripcion, fecha, prioridadSolicitud);
                solicitud.RegistrarSolicitud(solicitud);
                creados++;
            }

            return creados;
        }

        // ------------------------- CODIGOS UNICOS -------------------------

        private static string CodigoCliente()
        {
            int numero = Datos.clientes.Count + 1;
            string codigo;

            do
            {
                codigo = "cli" + numero.ToString("00");
                numero++;
            }
            while (Datos.BuscarCliente(codigo) != null);

            return codigo;
        }

        private static string CodigoTecnico()
        {
            int numero = Datos.tecnicos.Count + 1;
            string codigo;

            do
            {
                codigo = "tec" + numero.ToString("00");
                numero++;
            }
            while (Datos.BuscarTecnico(codigo) != null);

            return codigo;
        }

        private static string CodigoEquipo()
        {
            int numero = Datos.equipos.Count + 1;
            string codigo;

            do
            {
                codigo = "equ" + numero.ToString("00");
                numero++;
            }
            while (Datos.BuscarEquipo(codigo) != null);

            return codigo;
        }

        private static string CodigoRepuesto()
        {
            int numero = Datos.repuestos.Count + 1;
            string codigo;

            do
            {
                codigo = "rep" + numero.ToString("00");
                numero++;
            }
            while (Datos.BuscarRepuesto(codigo) != null);

            return codigo;
        }

        private static string CodigoSolicitud()
        {
            int numero = Datos.solicitudes.Count + 1;
            string codigo;

            do
            {
                codigo = "sol" + numero.ToString("00");
                numero++;
            }
            while (Datos.BuscarSolicitud(codigo) != null);

            return codigo;
        }

        private static string SerieUnica(Random rnd)
        {
            string serie;

            do
            {
                serie = "SN-" + rnd.Next(1000, 10000).ToString();
            }
            while (Datos.BuscarEquipoPorSerie(serie) != null);

            return serie;
        }

        private void BtnVolver_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void DatosPrueba_FormClosed(object sender, FormClosedEventArgs e)
        {
            MenuPrincipal menu = new MenuPrincipal();
            menu.Show();
        }
    }
}
