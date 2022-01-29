using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace i_t4_programa_al_gusto_con_UML
{
    public class Semana
    {
        //--------------------------------------------------------------------------------------------------------------------------------------------------------
        //--------------------------------------------------------------------------------------------------------------------------------------------------------
        //--------------------------------------------------------------------------------------------------------------------------------------------------------
            Console.Title = "calculadora de ganancias en porcentajes";
            Console.ForegroundColor = ConsoleColor.Red;

            double[] arreglo = new Double[7]; //esta línea declara el arreglo


            Console.WriteLine("------------------------------------------------------------\n------------------------------------------------------------\n" +
                "ingresa tus ventas diarias"); //línea de texto


            for (int llenado = 0; llenado< 7; llenado++) //este ciclo llena los datos para ser utilizados más tarde
            {
                arreglo[llenado] = int.Parse(Console.ReadLine());
            }


            Console.WriteLine("------------------------------------------------------------\n------------------------------------------------------------\n" +
                "tus ventas en esta semana fuero de:" + arreglo.Sum()); //esta linea suma todos los números del arreglo para para dar un resultado de ventas totales

            Console.ForegroundColor = ConsoleColor.Red;

            for (int i = 0; i< 7; i++) //este ciclo muestra todos los datos llenados anteriormente
            {
                Console.WriteLine(arreglo[i]);
            }


            Console.ReadLine();// leer datos


            Console.WriteLine("------------------------------------------------------------\n------------------------------------------------------------\n" +
                "tus porcentajes de ganancia respecto al día anterior son de"); //línea de texto 


            Console.WriteLine("dia 1: 100%"); //estas 7 líneas hacen las operaciones para tener el % extra de ganancia con respecto al día 1
            Console.WriteLine("dia 2: " + ((((arreglo[1] - arreglo[0])) / arreglo[0]) * 100) + "% extra con respecto al día 1");
            Console.WriteLine("dia 3: " + ((((arreglo[2] - arreglo[0])) / arreglo[0]) * 100) + "% extra con respecto al día 1");
            Console.WriteLine("dia 4: " + ((((arreglo[3] - arreglo[0])) / arreglo[0]) * 100) + "% extra con respecto al día 1");
            Console.WriteLine("dia 5: " + ((((arreglo[4] - arreglo[0])) / arreglo[0]) * 100) + "% extra con respecto al día 1");
            Console.WriteLine("dia 6: " + ((((arreglo[5] - arreglo[0])) / arreglo[0]) * 100) + "% extra con respecto al día 1");
            Console.WriteLine("dia 7: " + ((((arreglo[6] - arreglo[0])) / arreglo[0]) * 100) + "% extra con respecto al día 1");




            Console.ReadLine(); // lee datos

    }
    class Program
    {

        static void Main(string[] args)

        {
        semana objeto = new semana();
        Console.ReadLine(objeto); // lee datos

    }
    }
}

