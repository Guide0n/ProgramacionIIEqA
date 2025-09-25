using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuentaBancaria
    {
        internal class Cuenta1
        {
            string num_cuenta;
            string nombre_cli;
            float saldo = 0;

            public Cuenta1(string num_cuenta, string nombre_cli, float saldo)
            {
                this.num_cuenta = num_cuenta;
                this.nombre_cli = nombre_cli;
                this.saldo = saldo;
            }

            public void getSaldo()
            {
                Console.WriteLine("Su saldo es: $" + saldo);
            }
            public void depositar(float cantidad)
            {

                if (saldo > 0)
                {
                    saldo += cantidad;
                    Console.WriteLine("Nuevo saldo : $" + saldo);
                }
                else
                {
                    Console.WriteLine("El monto debe de ser mayor a $0");
                }
            }

            public void retirar(float cantidad)
            {
                if (saldo > cantidad)
                {
                    saldo -= cantidad;
                    Console.WriteLine("Su nuevo saldo: $" + saldo);
                }
                else { Console.WriteLine("La cantidad a retirar es mayor que el saldo a favor."); }

            }
        }
    }
}

