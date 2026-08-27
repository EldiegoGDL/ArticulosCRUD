using System;
using System.Collections.Generic;
using System.Text;

namespace ArticulosCRUD
{
    internal class Menu
    {
        public Menu()
        {

        }

        public void MostrarMenu()
        {
            bool continuar = true;
            while (continuar)
            {
                Console.Clear();
                Console.WriteLine("Gestor de artículos");
                Console.WriteLine("===================");
                Console.WriteLine("1. Agregar");
                Console.WriteLine("2. Listar");
                Console.WriteLine("3. Buscar");
                Console.WriteLine("4. Modificar");
                Console.WriteLine("5. Eliminar");
                Console.WriteLine("0. Salir");
                string opcion = Console.ReadLine() ?? "";
                switch (opcion)
                {
                    case "1":
                        // Lógica para agregar artículo
                        break;
                    case "2":
                        // Lógica para listar artículos
                        break;
                    case "3":
                        // Lógica para buscar artículo
                        break;
                    case "4":
                        // Lógica para modificar artículo
                        break;
                    case "5":
                        // Lógica para eliminar artículo
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
    }
}
