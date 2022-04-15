using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;


namespace programa12_multiplicacion2numeros
{
    class Program
    {


        static void Main(string[] args)

        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            long totalInicio = System.GC.GetTotalMemory(true);


            char opc;
            do
            {
                Console.Clear();
                Console.WriteLine("MECANICA DE RECURSIVIDAD");
                Console.WriteLine("MENÚ\n" + "a.- Calcular Multiplicacion\n" + "b.- Salir");
                Console.Write("Escriba que opcion quiere: ");
                opc = Console.ReadKey().KeyChar;

                switch (opc)
                {
                    case 'a':
                        PTS pot = new PTS();
                        Console.WriteLine("\n\nCAPTURA DE DATOS");
                        Console.Write("Inserte el valor de A: ");
                        int a = int.Parse(Console.ReadLine());
                        Console.Write("Inserte el valor de B: ");
                        int b = int.Parse(Console.ReadLine());
                        Console.WriteLine("El resultado de la operacion es: " + pot.Mult(a, b));
                        Console.ReadKey();
                        break;
                    case 'b':
                        stopwatch.Stop();
                        Console.WriteLine("\n\n\nRESULTADO DE LAS COMPLEJIDADES DE ESPACIO Y TIEMPO");
                        long ticks1 = stopwatch.ElapsedTicks;
                        Console.WriteLine("\n" + ticks1 + " ticks transcurridos");

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
            } while (opc != 'b');
        }

        class PTS
        {
            public int Mult(int a, int b)
            {
                if (b == 1)
                {
                    return a;
                }
                else
                {
                    return (a + Mult(a, b - 1));
                    //  return (b * Mult(b, e - 1));
                }
            }
            ~PTS()
            {
                Console.WriteLine("\nMemoria del objeto PTS liberada");
            }
        }



    } 
}
