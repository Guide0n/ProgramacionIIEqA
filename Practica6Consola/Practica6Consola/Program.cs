using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica6Consola
{
    internal class Program
    {
        static List<string> lista;
        static void Main(string[] args)
        {
            lista = new List<string>();
            int opcion;

            do
            {
                opcion = ImprimeMenu();
                switch (opcion)
                {
                    case 1:
                        Agregar();
                        break;
                    case 2:
                        Consultar();
                        break;
                    case 3:
                        ImprimirListaCompleta();
                        break;
                    case 4:
                        Eliminar();
                        break;
                    case 5:
                        Console.WriteLine("Saliendo del programa...");
                        break;
                    default:
                        Console.WriteLine("Opción no válida. Intente de nuevo.");
                        Console.ReadLine();
                        break;
                }

            } while (opcion != 5);
        }

        static int ImprimeMenu()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("Menu: ");
            Console.WriteLine("1.- Agregar");
            Console.WriteLine("2.- Consultar");
            Console.WriteLine("3.- Imprimir lista completa");
            Console.WriteLine("4.- Eliminar");
            Console.WriteLine("5.- Salir");

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("SELECCIÓN: ");
            string opcion = Console.ReadLine();

            int opcion_int;
            if (!int.TryParse(opcion, out opcion_int))
            {
                return -1; // Opción no válida
            }

            return opcion_int;
        }

        static void Agregar()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Escriba lo que va a agregar: ");

            Console.ForegroundColor = ConsoleColor.Blue;
            string texto = Console.ReadLine();

            lista.Add(texto);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Elemento agregado correctamente.");
            Console.ReadLine();
        }

        static void Consultar()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;

            if (lista.Count == 0)
            {
                Console.WriteLine("La lista está vacía.");
                Console.ReadLine();
                return;
            }

            Console.WriteLine("Consulta de elementos:");
            Console.WriteLine("1. Consultar por posición");
            Console.WriteLine("2. Consultar si existe un elemento");
            Console.Write("Seleccione una opción: ");

            string opcion = Console.ReadLine();

            if (opcion == "1")
            {
                Console.Write("Ingrese la posición a consultar (0 a {0}): ", lista.Count - 1);
                if (int.TryParse(Console.ReadLine(), out int posicion) && posicion >= 0 && posicion < lista.Count)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Elemento en posición {0}: {1}", posicion, lista[posicion]);
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Posición no válida.");
                }
            }
            else if (opcion == "2")
            {
                Console.Write("Ingrese el elemento a buscar: ");
                string elemento = Console.ReadLine();

                if (lista.Contains(elemento))
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("El elemento '{0}' existe en la lista.", elemento);
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("El elemento '{0}' no existe en la lista.", elemento);
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Opción no válida.");
            }

            Console.ReadLine();
        }

        static void ImprimirListaCompleta()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("La lista contiene los siguientes elementos:");

            if (lista.Count == 0)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("La lista está vacía.");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                for (int i = 0; i < lista.Count; i++)
                {
                    Console.WriteLine("{0}. {1}", i, lista[i]);
                }
            }

            Console.WriteLine("Presione ENTER para continuar.");
            Console.ReadLine();
        }

        static void Eliminar()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;

            if (lista.Count == 0)
            {
                Console.WriteLine("La lista está vacía. No hay elementos para eliminar.");
                Console.ReadLine();
                return;
            }

            Console.WriteLine("Eliminar elementos:");
            Console.WriteLine("1. Eliminar por posición (RemoveAt)");
            Console.WriteLine("2. Eliminar por elemento (Remove)");
            Console.Write("Seleccione una opción: ");

            string opcion = Console.ReadLine();

            if (opcion == "1")
            {
                Console.Write("Ingrese la posición a eliminar (0 a {0}): ", lista.Count - 1);
                if (int.TryParse(Console.ReadLine(), out int posicion) && posicion >= 0 && posicion < lista.Count)
                {
                    string elementoEliminado = lista[posicion];
                    lista.RemoveAt(posicion);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Elemento '{0}' en posición {1} eliminado correctamente.", elementoEliminado, posicion);
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Posición no válida.");
                }
            }
            else if (opcion == "2")
            {
                Console.Write("Ingrese el elemento a eliminar: ");
                string elemento = Console.ReadLine();

                if (lista.Contains(elemento))
                {
                    bool eliminado = lista.Remove(elemento);
                    if (eliminado)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Elemento '{0}' eliminado correctamente.", elemento);
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("No se pudo eliminar el elemento.");
                    }
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("El elemento '{0}' no existe en la lista.", elemento);
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Opción no válida.");
            }

            Console.ReadLine();
        }
    }
}