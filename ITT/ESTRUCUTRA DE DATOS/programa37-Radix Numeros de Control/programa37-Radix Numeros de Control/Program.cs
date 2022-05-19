using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programa37_Radix_Numeros_de_Control
{
    class CLASEBASE
    {

        public class Nodo
        {
            // --- campos de la clase

            public int info;
            public int next;

            // --- constructor de la clase

            public Nodo(int i, int n)
            {
                info = i;
                next = n;
            }

            // --- destructor de la clase

            ~Nodo()
            {
                Console.WriteLine("Recursos del Nodo Liberados");
            }
        }

        public class Radix
        {
            // --- campos de la clase

            public int pasadas = 0;
            public int comparativas = 0;
            public int intercambio = 0;

            public int[] arreglo = new int[50];
            int[] colf = new int[10];
            int[] coli = new int[11];

            Nodo[] nd = new Nodo[50];
            int[] x = new int[50];
            int M = 8;
            int r = 50;
            int first, p, y, exp, q, i;
            int j = 1;

            // --- constructor de la clase y creación de la lista enlazada de nodos

            public void Generar()
            {
                Random rnd = new Random();
                for (int i = 0; i < 50; i++)
                {
                    arreglo[i] = rnd.Next(19210000, 19210100);
                }
            }

            public void Desplegar()
            {
                for (int i = 0; i < arreglo.Length; i++)
                {
                    Console.WriteLine("[" + i + "]" + arreglo[i]);
                }
            }

            public void Ordenar()
            {
                for (int i = 0; i < nd.Length - 1; i = i + 1)
                {
                    intercambio++;
                    nd[i] = new Nodo(arreglo[i], i + 1);
                }

                intercambio++;
                nd[nd.Length - 1] = new Nodo(arreglo[nd.Length - 1], -1);
                first = 0;

                for (int k = 1; k <= M; k = k + 1)
                {
                    pasadas++;
                    for (int i = 0; i <= 9; i = i + 1)
                    {
                        colf[i] = -1;
                    }

                    for (int i = 0; i <= 10; i = i + 1)
                    {
                        coli[i] = -1;
                    }

                    while (first != -1)
                    {
                        p = first;
                        first = nd[first].next;
                        y = nd[p].info;
                        exp = 1;

                        for (int i = 1; i != k; i = i + 1)
                        {
                            exp = exp * 10;
                        }
                        j = (y / exp) % 10;
                        q = colf[j];

                        if (q == -1)
                        {
                            coli[j] = p;
                        }
                        else
                        {
                            nd[q].next = p;
                        }
                        colf[j] = p;
                    }
                    j = 0;

                    while (j <= 9 && (coli[j] == -1))
                    {
                        j = j + 1;
                    }
                    first = coli[j];
                    p = j;
                    while (j <= 9)
                    {
                        i = j + 1;
                        while (i <= 9 && coli[i] == -1)
                        {
                            i = i + 1;
                        }

                        if (i <= 9)
                        {
                            p = i;
                            nd[colf[j]].next = coli[i];
                        }
                        j = i;
                    }
                    nd[colf[p]].next = -1;
                }
                for (int i = 0; i <= nd.Length - 1; i++)
                {
                    intercambio++;
                    arreglo[i] = nd[first].info;
                    first = nd[first].next;
                }
            }

            // --- destructor de la clase

            ~Radix()
            {
                Console.WriteLine("Recursos del Radix Liberados");
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

            Radix r1 = new Radix();

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

                        Console.WriteLine("Generando el arreglo");
                        r1.Generar();

                        Console.Write("\n\nLos Numeros de Control Fueron Generados con Exito ");

                        Console.Write("\n\nPresione ENTER para volver al menu. ");
                        Console.ReadKey();
                        Console.Clear();

                        break;

                    case 'b':

                        Console.Clear();

                        Console.WriteLine("Desplegando arreglo");
                        r1.Desplegar();

                        Console.Write("\n\nPresione ENTER para volver al menu. ");
                        Console.ReadKey();
                        Console.Clear();

                        break;

                    case 'c':

                        Console.Clear();

                        Console.WriteLine("Ordenando el arreglo");
                        r1.Ordenar();

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

                        Console.WriteLine("\n\nNumero de pasadas: " + r1.pasadas);
                        Console.WriteLine("Numero de comparaciones: " + r1.comparativas);
                        Console.WriteLine("Numero de intercambios: " + r1.intercambio);

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
