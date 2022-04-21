using System;
using Sistema;

namespace Practico_5___Programacion_2
{
    class Program
    {
        static Administradora sistema = new Sistema.Administradora();

        static void Main(string[] args)
        {

            foreach (Comunes item in sistema.VehiculosComunes())
            {
                Console.WriteLine(item);
            }

            foreach (Carga item in sistema.VehiculosCarga())
            {
                Console.WriteLine(item);
            }
        }
    }
}
