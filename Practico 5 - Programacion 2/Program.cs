using System;
using Sistema;

namespace Practico_5___Programacion_2
{
    class Program
    {
        static Administradora sistema = new Sistema.Administradora();

        static void Main(string[] args)
        {
            int opcion = 0;
            do
            {
                Console.WriteLine();
                Console.WriteLine("Practico 5 - C# .NET - PROGRAMACION 2");
                Console.WriteLine("--------------------------------------");
                Console.WriteLine("1-Lista vehiculos comunes\n2-Lista vehiculos carga\n3-Lista ordenados por anio\n4-Lista Ordenados por Marca\n5-Con servicio pendiente");
                opcion = int.Parse(Console.ReadLine());
                Console.WriteLine();

                switch (opcion)
                {
                    case 1:
                        ListarComunes();
                        break;
                    case 2:
                        ListarCarga();
                        break;
                    case 3:
                        ListarTodosPorAnio();
                        break;
                    case 4:
                        ListarTodosPorMarca();
                        break;
                    case 5:
                        ListarServiciosPendientes();
                        break;
                    default:
                        break;
                }
            } while (opcion != 0);
        }

        public static void ListarComunes()
        {
            Console.WriteLine("COMUNES----------------------");
            Console.WriteLine();
            foreach (Comun item in sistema.VehiculosComunes())
            {
                Console.WriteLine(item);
            }
        }

        public static void ListarCarga()
        {
            Console.WriteLine("CARGA----------------------");
            Console.WriteLine();
            foreach (Carga item in sistema.VehiculosCarga())
            {
                Console.WriteLine(item);
            }
        }

        public static void ListarTodosPorAnio()
        {
            Console.WriteLine("VEHICULOS------------------");
            foreach (var item in sistema.TodosLosVehiculosOrdenadosPorAnio())
            {
                Console.WriteLine(item);
            }
        }

        public static void ListarTodosPorMarca()
        {
            Console.WriteLine("VEHICULOS------------------");
            foreach (var item in sistema.TodosLosVehiculosOrdenadosPorAnio())
            {
                Console.WriteLine(item);
            }
        }

        public static void ListarServiciosPendientes()
        {
            Console.WriteLine("SERVICIOS PENDIENTES------");
            foreach (var item in sistema.ServicioPendienteEsteAnio())
            {
                Console.WriteLine(item);
            }
        }
    }
}
