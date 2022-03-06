using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace _2._2._1_funcion_factorial
{
    class Program
    {
        public class fact
        {
            public long calc (long num)
            {
                if (num == 0 || num == 1)
                    return 1;
                return num * calc(num - 1);
            }
        }

        static void Main(string[] args)
        {
            
            GC.Collect();
            var stopwatch = Stopwatch.StartNew(); //aqui se declara el reloj
            stopwatch.Start();
            int opc;
            do
            {
                Console.Clear();
                Console.WriteLine("RECURSIVIDAD EN UNA FUNCION FACTORIAL\n");
                Console.WriteLine("MENÚ");
                Console.WriteLine("1.- Calcular funcion");
                Console.WriteLine("2.- Salir del programa");
                Console.Write("Escriba que opcion quiere: ");
                opc = Convert.ToInt32(Console.ReadLine());
                stopwatch.Stop();
                switch (opc)
                {
                    
                    //Se captura un dato para sacarle su funcion factorial llamando a la clase donde se encuentra la recursividad
                    case 1:
                        fact obj = new fact();
                        Console.WriteLine("\nCAPTURA DE DATOS");
                        Console.Write("Inserte el valor al que se le hara la funcion factorial: ");
                        long n = long.Parse(Console.ReadLine());
                        Console.WriteLine("El factorial del numero ingresado es: " + obj.calc(n));
                        Console.WriteLine("Presione cualquier tecla para continuar");
                        Console.ReadKey();
                        break;
               
                    case 2:
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
                stopwatch.Start();
            } while (opc != 2);
        }
    }
}

