
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuentaBancaria
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("==MENU DE OPERACIONES==");
            Console.WriteLine("1. CONSULTAR SALDO");
            Console.WriteLine("2. DEPOSITAR");
            Console.WriteLine("3. RETIRAR");
            Console.WriteLine("INGRSE UNA OPCION: ");
            int opc;
            opc = int.Parse(Console.ReadLine());

            Cuenta1 miCuenta = new Cuenta1("24150030", "Alvaro Gallegos", 5000);

            switch (opc)
            {
                case 1: miCuenta.getSaldo(); break;
                case 2:
                    Console.WriteLine("INGRESE EL MONTO: ");
                    int cant = int.Parse(Console.ReadLine());
                    miCuenta.depositar(cant);
                    break;
                case 3:
                    Console.WriteLine("INGRESE EL MONTO: ");
                    int canti = int.Parse(Console.ReadLine());
                    miCuenta.retirar(canti);
                    break;

            }


        }
    }
}


