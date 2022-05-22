﻿using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programa36_Quicksort_Numeros_de_Control
{
    class CLASEBASE
    {
        class quicksort
        {
            int[] arreglo = new int[50];
            public int Pas = 0;
            public int Comp = 0;
            public int intercambio = 0;
            Random rnd = new Random();

            public void Genera()
            {
                for (int i = 0; i < 50; i++)
                {
                    arreglo[i] = rnd.Next(19210000, 19210100);
                }
            }
            public void desplega()
            {
                for (int i = 0; i < arreglo.Length; i++)
                {
                    Console.WriteLine((i + 1) + " " + arreglo[i]);
                }
            }
            public void ordena(int L, int R)
            {
                int I = L;
                int J = R;
                int X = arreglo[(L + R) / 2];
                Pas++;
                do
                {
                    while (arreglo[I] < X)
                    {
                        Comp++;
                        I += 1;
                    }
                    while (arreglo[J] > X)
                    {
                        Comp++;
                        J -= 1;
                    }
                    if (I <= J)
                    {
                        intercambio++;
                        int W = arreglo[I];
                        arreglo[I] = arreglo[J];
                        arreglo[J] = W;
                        I += 1;
                        J -= 1;
                    }
                } while (I < J);
                if (L < J)
                {
                    ordena(L, J);
                }
                if (I < R)
                {
                    ordena(I, R);
                }
            }
            ~quicksort()
            {
                Console.WriteLine("La clase quicksort se a liberado exitosamente");
            }
        }



        // -- MENU DEL PROGRAMA

        // -- Se crea el metodo que se utiliza para poder medir la memoria utilizada en el codigo

        public static void MakeSomeGarbage()
        {
            Version vt;

            for (int i = 0; i < maxGarbage; i++)
            {
                vt = new Version();
            }
        }


        // -- Usamos esta sentencia para darle un limite de memoria al programa

        private const int maxGarbage = 1000;


        // -- Se crea la clase para el main


        public static void Main()
        {


            // -- Objeto para utilizar nuestro contador de tiempo

            Stopwatch sw = new Stopwatch();

            //---- Inicia el contador de tiempo basandose en la duracion de utilizacion del programa:

            sw.Start();

            char OPS;

            // -------------

            // -- Objeto para el Menu

            quicksort br = new quicksort();

            // -- Realizamos el ciclo para el menu

            do
            {

                // -- Hacemos nuestro menu de operaciones

                Console.Clear();

                Console.Write("Bienvenido al menu, por favor seleccione una de las siguientes opciones.. ");

                Console.Write("\n\na) Inicializar el arreglo. ");
                Console.Write("\n\nb) Desplegar el arreglo. ");
                Console.Write("\n\nc) Ordenar el Arreglo. ");
                Console.Write("\n\nd) Salir Del Programa. ");

                Console.Write("\n\nIngrese la opcion a ejecutar: ");


                // -- Creamos el switch que actuara como nuestro menu con los casos

                OPS = Char.Parse(Console.ReadLine());

                switch (OPS)
                {

                    case 'a':

                        Console.Clear();

                        br.Genera();
                        Console.WriteLine("\nNumeros generados correctamente");

                        Console.Write("\n\nPresione ENTER para volver al menu. ");
                        Console.ReadKey();
                        Console.Clear();

                        break;

                    case 'b':

                        Console.Clear();

                        br.desplega();

                        Console.Write("\n\nPresione ENTER para volver al menu. ");
                        Console.ReadKey();
                        Console.Clear();

                        break;

                    case 'c':

                        Console.Clear();

                        br.ordena(0, 49);

                        Console.WriteLine("\nLos Numeros de Control Fueron Ordenados de Manera Correcta");

                        Console.Write("\n\nPresione ENTER para volver al menu. ");
                        Console.ReadKey();
                        Console.Clear();

                        break;

                    case 'd':

                        // -- Usamos este caso para dar cierre a nuestro programa 

                        Console.Write("\nGracias por usar el programa, pulse ENTER para continuar. ");
                        Console.ReadKey();

                        Console.Clear();

                        // -- Con esta sentencia detenemos el contador de tiempo

                        sw.Stop();

                        // -- Usamos esta sentencia para mostrar el tiempo transcurrido del programa

                        TimeSpan ts = sw.Elapsed;

                        string formatoTiempo = String.Format("{0:00}:{1:00}:{2:00}.{3:00}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10);

                        Console.Write("\nTiempo del uso del programa: {0} segundos. ", formatoTiempo);

                        // -- Muestra la cantidad de memoria antes de usar el programa

                        MakeSomeGarbage();
                        Console.Write("\n\nMemoria usada antes de la coleccion:       {0:N0} bytes", GC.GetTotalMemory(false));

                        // --- Muestra la cantidad de memoria utilizada por los objetos despues de usar el programa

                        GC.Collect();
                        Console.Write("\nMemoria usada despues de la coleccion:   {0:N0} bytes", GC.GetTotalMemory(true));

                        // --- Metodo de busqueda

                        Console.WriteLine("\nEl Numero de Pasadas en total es de: " + br.Pas);
                        Console.WriteLine("El Numero de Comparaciones en total es de: " + br.Comp);
                        Console.WriteLine("El Numero de Intercambios en total es de: " + br.intercambio);

                        Console.Write("\n\nPulse ENTER para salir del programa. ");

                        Console.ReadKey();

                        break;

                    default:

                        // -- El default funciona para poder marcar un error si en el menu se pone un caracter incorrecto a los que se indica en el menu este lo mencionara

                        Console.Clear();
                        Console.Write("\nLa opcion que eligio no es correcta, por favor intente de nuevo. ");
                        Console.Write("\nPresiona ENTER para volver al menu. ");

                        Console.ReadKey();
                        Console.Clear();

                        break;
                }

                // -- Cerramos aqui el ciclo del programa agregando el caso donde queremos que el ciclo cierre completamente

            } while (OPS != 'd');
        }
    }
}