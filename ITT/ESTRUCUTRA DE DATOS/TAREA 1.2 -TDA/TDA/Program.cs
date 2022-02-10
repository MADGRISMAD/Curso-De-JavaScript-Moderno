using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDA
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> Lista = new List<string>();
            Lista.Add("Madeline");
            Lista.Add("Sofia");
            Lista.Add("Mariana");
            Lista.Add("Ana");
            Lista.Add("Citlali");
            Lista.Add("Karla");

            Console.WriteLine("el elemento de la posicion 2 es:" + Lista[1]);
            Console.WriteLine("La cantidad de elementos es:" + Lista.Count);
            Console.WriteLine("en el caso de mariana, ella se encuentra en el indice "+ Lista.IndexOf("Mariana"));

            Console.WriteLine("\n que nombre desea buscar?");
            string name = Console.ReadLine();
            bool res = Lista.Contains(name);
            if (res == true)
                Console.WriteLine("tienes suerte, este elemento si esta dentro de la lista");
            else
                Console.WriteLine("lo sentimos, ese elemento no se encuentra dentro de la lista");
            Console.ReadKey();




        }
    }
}
