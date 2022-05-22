using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programa40_Intercalación_Cuadrática_EDM
{
    class CLASEBASE
    {
        class Cuadratica
        {

            public int Pas = 0;
            public int Comp = 0;
            public int Intercambio;
            public int intercambio = 0;

            string[] estados = { "Zacatecas","Jalisco","Ciudad de México","Puebla","Sonora", "Estado de México","Hidalgo", "Campeche","Tamaulipas","Aguascalientes","Baja California","Michoacán"
                    ,"Chihuahua","Nuevo León","Colima","Veracruz","San Luis Potosí","Guanajuato","Chiapas","Tlaxcala","Yucatán","Guerrero","Baja California Sur"
                    ,"Nayarit","Morelos","Oaxaca","Querétaro","Coahuila","Quintana Roo","Sinaloa","Durango","Tabasco"};
            string[] AUX = new string[32];
            Random random = new Random();

            public void Genera()
            {
                for (int i = 0; i < estados.Length; i++)
                {
                    int Gen = random.Next(estados.Length);
                }
            }

            public void desplega()
            {
                Console.WriteLine("Estados de México");

                for (int i = 0; i < estados.Length; i++)
                {
                    Console.WriteLine((i + 1) + " {0}", estados[i]);
                }
            }

            public void intercala()
            {
                int N = estados.Length;
                int I = 0, J = 0, K = 0;
                int M1, M2;
                int L1, L2;
                int p = 1;

                while (p < N)
                {
                    Pas++;
                    L1 = 0;
                    K = 0;

                    while (L1 + p <= N)
                    {
                        L2 = L1 + p;
                        M1 = L2 - 1;

                        if ((L2 + p) - 1 <= N)
                        {
                            M2 = (L2 + p) - 1;
                        }
                        else
                        {
                            M2 = N - 1;
                        }
                        I = L1;
                        J = L2;

                        while (I <= M1 && J <= M2)
                        {
                            Pas++;
                            if (string.Compare(estados[I], estados[J]) < 0)
                            {
                                Intercambio++;
                                AUX[K] = estados[I];
                                I++;
                                K++;
                            }
                            else
                            {
                                Intercambio++;
                                AUX[K] = estados[J];
                                J++;
                                K++;
                            }
                        }
                        if (I > M1)
                        {
                            for (int y = J; y <= M2; y++)
                            {
                                Intercambio++;
                                AUX[K] = estados[y];
                                K++;
                            }
                            L1 = M2 + 1;
                        }
                        else
                        {
                            for (int y = I; y <= M1; y++)
                            {
                                Intercambio++;
                                AUX[K] = estados[y];
                                K++;
                            }
                            L1 = M2 + 1;
                        }
                    }
                    for (I = L1; K < N; I++)
                    {
                        Comp++;
                        AUX[K] = estados[I];
                        K++;
                    }
                    for (I = 0; I < N; I++)
                    {
                        Comp++;
                        estados[I] = AUX[I];
                    }
                    p = p * 2;
                }
            }

            ~Cuadratica()
            {
                Console.WriteLine("La clase Cuadratica se a liberado");
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

            Cuadratica br = new Cuadratica();

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

                        br.intercala();
                        Console.WriteLine("Arreglo ordenado correctamente");

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
