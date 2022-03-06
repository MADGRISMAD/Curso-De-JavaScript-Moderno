using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace _2._2._2_fibonachi
{
    class Program
    {
        public class fibonacchi
        {
            

            public int calc(int n)
            {
                

                if ((n == 0) || (n == 1))
                {
                    return n;
                }
                
                else
                {
                    return calc(n - 2) + calc(n - 1);
                }

            }
        }
        static void Main(string[] args)
        {

            
            var stopwatch = Stopwatch.StartNew(); //aqui se declara el reloj
            stopwatch.Start();
            int opc;
            do
            {
                Console.Clear();
                Console.WriteLine("RECURSIVIDAD EN UNA SECUENCIA FIBONACCHI\n");
                Console.WriteLine("MENÚ");
                Console.WriteLine("1.- Calcular posicion fibonacchi");
                Console.WriteLine("2.- Salir del programa");
                Console.Write("Escriba que opcion quiere: ");
                opc = Convert.ToInt32(Console.ReadLine());
                
                switch (opc)
                {

                    //Se captura un dato para sacarle su funcion fibonacchiorial llamando a la clase donde se encuentra la recursividad
                    case 1:
                        fibonacchi obj = new fibonacchi();
                        Console.WriteLine("\nCAPTURA DE DATOS");
                        Console.Write("inserte la posicion del numero fibonachi que desea encontrar: ");

                        int n = int.Parse(Console.ReadLine());
                        Console.WriteLine("el numero fibonacchi en esa posicion es el " + obj.calc(n));
                        Console.WriteLine("Presione cualquier tecla para continuar");
                        Console.ReadKey();
                        break;

                    case 2:
                        stopwatch.Stop();
                        Console.WriteLine("\n\n\nRESULTADO DE LAS COMPLEJIDADES DE ESPACIO Y TIEMPO");
                        long ticks1 = stopwatch.ElapsedTicks;
                        Console.WriteLine("\n" + ticks1 + " ticks transcurridos");
                        
                        TimeSpan ts = TimeSpan.FromTicks(ticks1);
                        double minutes = ts.TotalMinutes;
                        Console.WriteLine(ts + " segundos transcurridos");

                        Console.WriteLine("\nMemoria total: {0} bytes", GC.GetTotalMemory(false));

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
