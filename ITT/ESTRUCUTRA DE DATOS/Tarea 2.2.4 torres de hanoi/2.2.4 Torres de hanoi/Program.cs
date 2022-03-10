using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace _2_2_4_torrehanoi
{
    class Program
    {   
        public static int movimientos = 0;

        public class Torres
        {
            

            public void hanoi(int n, string Origen, string auxiliar, string destino)
            {
                Console.Clear();
                if (n == 1)
                {
                    Console.WriteLine(" mover un disco de " + Origen + " a " + destino);
                    movimientos++; 
                }
                else
                { 
                    movimientos++;
                    hanoi(n - 1, Origen, destino, auxiliar);
                    Console.WriteLine(" mover un disco de " + Origen + " a " + destino);                                  
                    hanoi(n - 1, auxiliar, Origen, destino);
                    
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
                
                Console.WriteLine("recursividad en torres de hanoi\n");
                Console.WriteLine("MENÚ");
                Console.WriteLine("1.- Calcular movimientos de la torre de hanoi");
                Console.WriteLine("2.- Salir del programa");
                Console.Write("Escriba que opcion quiere: ");
                opc = Convert.ToInt32(Console.ReadLine());

                switch (opc)
                {

                    
                    case 1:
                        
                        Torres obj = new Torres();        
                        Console.Write("numero de discos a mover?\n");
                        int n = int.Parse(Console.ReadLine());
                        /**/ 
                        obj.hanoi(n,"origen","auxiliar","destino");
                        Console.WriteLine("el numero de movimientos fue " + movimientos );                    
                        /*****/
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
