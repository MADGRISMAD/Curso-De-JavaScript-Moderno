using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace _2_3_1_Multiplicacionrec
{
    class Program
    {

        class multrec
            {

            public int Mult(int m,int x, int n)
            {

                if (n==0)
                {
                return m;
                    
                }
                else
                    
                {
                    return  (m + Mult(m*x,x,n));
                    
                }
       
            }
        }

        static void Main(string[] args)
        {
            var stopwatch = Stopwatch.StartNew();
            stopwatch.Start();
            char opc;
            do
            {
                Console.Clear();
                Console.WriteLine("MULTIPLICACION DE DOS NUMEROS\n");
                Console.WriteLine("MENÚ");
                Console.WriteLine("a.- realizar operacion");
                Console.WriteLine("b.- Salir del programa");
                Console.Write("Escriba que opcion quiere: ");
                opc = Console.ReadKey().KeyChar;

                switch (opc)
                {


                    case 'a':

                        multrec obb = new multrec();
                        Console.WriteLine("\n\nCAPTURA DE DATOS");
                        Console.Write("monto: ");
                        int a = int.Parse(Console.ReadLine());
                        Console.Write("porcentaje: ");
                        int b = int.Parse(Console.ReadLine());
                        Console.Write("años ");
                        int c = int.Parse(Console.ReadLine());

                        Console.WriteLine("El resultado de la operacion es:" + obb.Mult());
                        /*****/
                        Console.WriteLine("Presione cualquier tecla para continuar");
                        Console.ReadKey();
                        break;

                    case 'b':
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
            } while (opc != 'b');
        }
    }
}
