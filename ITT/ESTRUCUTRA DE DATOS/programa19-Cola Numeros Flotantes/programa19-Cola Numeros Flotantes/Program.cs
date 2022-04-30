using System;
using System.Diagnostics;

namespace programa19_Cola_Numeros_Flotantes
{
    public class COLA
    {

        // Campos de la clase 
        int Max, Frente, Final, Apuntador;
        float[] cola;

        // Constructor
        public COLA(int tamaño)
        {
            Max = tamaño;
            Frente = -1;
            Final = -1;
            cola = new float[tamaño];
            Console.WriteLine("\nLa cola ha sido creada con exito ");
            Console.WriteLine("\nPresiona Enter para continuar");
        }

        // Metodos de la clase

        // Metodo Push
        public void Push(float Elemento)
        {
            if (Frente == 0 & Final == Max - 1)
            {
                Console.Write("\nLa cola esta llena");
            }

            else
            {
                if (Frente == -1)
                {
                    Frente = 0;
                    Final = 0;
                }
                else
                {
                    Final = Final + 1;
                }
                cola[Final] = Elemento;
            }
        }

        // Metodo Pop
        public void Pop()
        {
            if (Frente != -1)
            {
                Console.Write("\nEliminando el Dato... " + cola[Frente]);
                cola[Frente] = 0;

                if (Frente == Final)
                {
                    Frente = -1;
                    Final = -1;
                }
                else
                {
                    Frente = Frente + 1;
                }
            }

            else
            {
                Console.Write("\n\nLa Cola Esta Vacia");
            }
        }

        // Metodo Recorrido
        public void Recorrido()
        {
            if (Frente != -1)
            {
                Apuntador = Frente;

                do
                {
                    Console.Write("\n\nElemento: " + cola[Apuntador] + " Posición: " + Apuntador);
                    Apuntador = Apuntador + 1;
                }
                while (Apuntador <= Final);
            }

            else
            {
                Console.Write("\nLa cola Esta Vacia ");
            }
        }

        // Metodo Busqueda
        public void Busqueda(float Elemento)
        {
            if (Frente != -1)
            {
                Apuntador = Frente;

                do
                {
                    if (Elemento == cola[Apuntador])
                    {
                        Console.Write("\nDato Encontrado en la posición: " + Apuntador);
                        return;
                    }

                    Apuntador = Apuntador + 1;

                }
                while (Apuntador <= Final);

                Console.Write("\nDato: " + Elemento + " No se Encontraron en la Cola");
            }

            else
            {
                Console.Write("\nLa Cola Esta Vacia ");
            }
        }

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

            int Tam;
            float elemen;

            // Objeto
            COLA col = null;

            // -- Objeto para utilizar nuestro contador de tiempo

            Stopwatch sw = new Stopwatch();

            //---- Inicia el contador de tiempo basandose en la duracion de utilizacion del programa:

            sw.Start();

            char OPS;

            // -- Realizamos el ciclo para el menu

            do
            {

                // -- Hacemos nuestro menu de operaciones

                Console.Clear();

                Console.Write("Bienvenido al menu, por favor seleccione una de las siguientes opciones.. ");

                Console.Write("\n\na) Crear cola. ");
                Console.Write("\n\nb) Insertar un elemento. ");
                Console.Write("\n\nc) Eliminar un dato. ");
                Console.Write("\n\nd) Recorrer la cola. ");
                Console.Write("\n\ne) Buscar un elemento. ");
                Console.Write("\n\nf) Salir Del Programa. ");

                Console.Write("\n\nIngrese la opcion a ejecutar: ");


                // -- Creamos el switch que actuara como nuestro menu con los casos

                OPS = Char.Parse(Console.ReadLine());

                switch (OPS)
                {
                    case 'a':
                        Console.Clear();
                        Console.Write("\n\nIngresa el tamaño de la cola: ");
                        Tam = int.Parse(Console.ReadLine());

                        col = new COLA(Tam);

                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case 'b':
                        Console.Clear();
                        Console.Write("\nIngresa el Elemento: ");
                        elemen = float.Parse(Console.ReadLine());

                        col.Push(elemen);

                        Console.Write("\n\nPresiona Enter para volver al menu");
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case 'c':
                        Console.Clear();

                        col.Pop();

                        Console.Write("\n\nPresiona volver al Menú");
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case 'd':
                        Console.Clear();

                        col.Recorrido();

                        Console.Write("\n\nPresiona volver al Menú");
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case 'e':
                        Console.Clear();

                        Console.Write("\nIngresa el Elemento a buscar: ");
                        float sear;
                        sear = float.Parse(Console.ReadLine());

                        col.Busqueda(sear);

                        Console.Write("\n\nPresiona volver al Menú");
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case 'f':

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

            } while (OPS != 'f');
        }

        ~COLA()
        {
            Console.WriteLine("La clase COLA ha sido liberada.. ");
        }

    }
}
