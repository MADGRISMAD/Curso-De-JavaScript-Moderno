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
            public int busquedabinadira(int[] a, int low, int high, int key)
            {
                int mid = (low + high) / 2;
                if (a[mid] == key)
                {
                    return mid;
                }
                else if (low >= high)
                {
                    return -1;
                }
                else if (key < a[mid])
                {
                    return busquedabinadira(a,key, low, mid-1);
                }
                else
                {
                    return busquedabinadira(a, key, low, mid + 1, high);
                }
            }

        }
        public class generador { 
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
                            int[] iArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };
                            
                            Console.WriteLine("\nCAPTURA DE DATOS");
                            Console.Write("inserte el numero a encontrar");
                            int number = Convert.ToInt32(Console.ReadLine());
                            fibonacchi obj = new fibonacchi();
                            Console.WriteLine("index no. is {0}", obj.busquedabinadira(iArray, 0, iArray.Length - 1, number));         
                            Console.WriteLine("Presione cualquier tecla para continuar");
                            Console.ReadKey();
                            break;

                        case 2:

                       


                            break;

                        case 3:
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


