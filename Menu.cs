using System;
using System.Collections.Generic;
using System.Text;

namespace ArticulosCRUD
{
    internal class Menu
    {
        private readonly string Titulo;
        private readonly string[] Opciones;
        private List<Producto> ListaProductos;

        public Menu(string titulo, string[] opciones)
        {
            Titulo = titulo;
            Opciones = opciones;
            ListaProductos = new List<Producto>();
        }

        public void MostrarMenu()
        {
            bool continuar = true;
            while (continuar)
            {
                Console.Clear();
                Console.WriteLine(Titulo);
                Console.WriteLine(new string('=', Titulo.Length));
                for (int i = 0;  i < Opciones.Length;  i++)
                {
                    Console.WriteLine($"{i + 1}. {Opciones[i]}");
                }
                //Console.WriteLine("Gestor de artículos");
                //Console.WriteLine("===================");
                //Console.WriteLine("1. Agregar");
                //Console.WriteLine("2. Listar");
                //Console.WriteLine("3. Buscar");
                //Console.WriteLine("4. Modificar");
                //Console.WriteLine("5. Eliminar");
                Console.WriteLine("0. salir");
                string opcion = Console.ReadLine() ?? "";
                switch (opcion)
                {
                    case "1":
                        
                        MostrarAgregar();
                        break;
                    case "2":
                        
                        MostrarListar();
                        break;
                    case "3":
                        
                        MostrarBuscar();
                        break;
                    case "4":
                        
                        MostrarModificar();
                        break;
                    case "5":
                        
                        MostrarEliminar();
                        break;
                    case "0":
                        continuar = false;
                        break;
                    default:
                        Console.WriteLine("Opción Inválida.");
                        Console.ReadLine();
                        break;
                }
            }

        }

        public void MostrarAgregar()
        {
            Console.Clear();
            Console.WriteLine("Agregar Producto");
            Console.WriteLine("=================");
            Console.WriteLine();
            Console.Write("Nombre: ");
            string nombre = Console.ReadLine();
            Console.Write("Precio: ");
            decimal precio = decimal.TryParse(Console.ReadLine(), out decimal valor)?valor : 0;
            Console.Write("Cantidad: ");
            int cantidad = int.TryParse(Console.ReadLine(), out int valor2) ? valor2 : 0;
            Producto producto = new Producto(ListaProductos.Count()+1,nombre,cantidad,precio);
            ListaProductos.Add(producto);
            Console.WriteLine("Producto creado correctamente");
            Console.ReadLine();
        }

        public void MostrarListar()
        {
            Console.Clear();
            Console.WriteLine("Listar Productos");
            Console.WriteLine("=================");
            foreach (Producto item in ListaProductos)
            {
                Console.WriteLine("ID = "+item.Id);
                Console.WriteLine("Nombre = " + item.Nombre);
                Console.WriteLine("Cantidad = " + item.Cantidad);
                Console.WriteLine("Precio = " + item.Precio);
            }
            Console.ReadLine();
        }

        public void MostrarBuscar()
        {
            Console.Clear();
            Console.WriteLine("Opcion Buscar Seleccionada");
            Console.ReadLine();
        }

        public void MostrarModificar()
        {
            Console.Clear();
            Console.WriteLine("Opcion Modificar Seleccionada");
            Console.ReadLine();
        }

        public void MostrarEliminar()
        {
            Console.Clear();
            Console.WriteLine("Opcion Eliminar Seleccionada");
            Console.ReadLine();
        }

    }
}
