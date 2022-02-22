using System;

namespace Tarea_1._4._3_MemoriaLocal
{
    class Program
    {

        public int max(int primerdato, int segundodato) //recibe parametros
        {
            return Math.Max(primerdato, segundodato);

        }
        public int min(int primerdato, int segundodato)//recibe parametros
        {
            return Math.Min(primerdato, segundodato);
        }
        static void Main(string[] args)

        {
            Console.Title = "1.4.3";
            Console.WriteLine("COMPARAR NUMEROS ENTEROS\n");
            int numero1, numero2; // variables locales del main
            Console.WriteLine("ingrese 2 numeros para compararlos");
            Console.Write("1er numero: ");
            numero1 = int.Parse(Console.ReadLine());
            Console.Write("2do numero: ");
            numero2 = int.Parse(Console.ReadLine());
            Console.WriteLine("\nResultados del programa");
            Program llamar = new Program();//compara
            Console.WriteLine("el mayor numero es: " + llamar.max(numero1, numero2));
            Console.WriteLine("el menor numero es: " + llamar.min(numero1, numero2));
            Console.WriteLine("\nPrograma finalizado, pulsa cualquier tecla para salir. . .");
            Console.ReadKey();
        }
    }
}