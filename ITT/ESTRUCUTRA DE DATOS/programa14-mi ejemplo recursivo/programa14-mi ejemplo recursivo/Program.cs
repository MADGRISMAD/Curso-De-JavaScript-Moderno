using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace _14
{
    class Program
    {

        class ciudad
        {
            /*md*/
            public int rec(int poblacion, int ratio, int dias)
            {

                if (dias == 0)
                {
                    return poblacion;

                }
                else
                {
                    
                    return rec(poblacion, ratio, (dias - 1)) - rec(poblacion, ratio, (dias - 1)) * ratio / 100;

                }

            }
        }

        static void Main(string[] args)
        {
            var stopwatch = Stopwatch.StartNew();
            stopwatch.Start();
            int opc;
            do
            {
                Console.Clear();
                Console.WriteLine("determinar la poblacion sana por semana en base a tasa de contagios por dia\n");
                Console.WriteLine("MENÚ");
                Console.WriteLine("1.- calcular tasa de contagios");
                Console.WriteLine("2.- Salir del programa");
                Console.WriteLine("Escriba que opcion quiere: ");
                opc = Int32.Parse((Console.ReadLine()));

                switch (opc)
                {


                    case 1:

                        ciudad obb = new ciudad();
                        Console.WriteLine("\n\nCAPTURA DE DATOS");
                        Console.WriteLine("poblacion ");
                        int a = int.Parse(Console.ReadLine());
                        Console.WriteLine("porcentaje de contagio por dia ");
                        int b = int.Parse(Console.ReadLine());   
                        

                        Console.WriteLine("el numero de personas sanas al cabo de " + 7 + " dias sera de " + obb.rec(a, b, 7) + " personas ") ;
                        /*****/
                        Console.WriteLine("Presione cualquier tecla para continuar");
                        Console.ReadKey();
                        break;

                    case 2:
                        stopwatch.Stop();
                        Console.WriteLine("\n\n\nRESULTADO DE LAS COMPLEJIDADES DE ESPACIO Y TIEMPO");
                        long ticks1 = stopwatch.ElapsedTicks;
                        TimeSpan ts = TimeSpan.FromTicks(ticks1);
                        double minutes = ts.TotalMinutes;
                        Console.WriteLine(ts + " segundos transcurridos");

                        Console.WriteLine("\nMemoria total: {0} bytes", GC.GetTotalMemory(false));
                        /*****/
                        Console.WriteLine("\nPresione cualquier tecla para terminar...");

                        Console.ReadKey();
                        break;

                    default:
                        Console.WriteLine("Opcion invalida, intente otra vez.");
                        Console.ReadKey();
                        break;

                }
                
            } while (opc != 2);
        }
    }
}
