using System;
using System.Diagnostics;

namespace programa22_lista_nombres_colores
{

    class Nodo
    {

        // -- Campos de la clase Nodo

        public string elemento;
        public int siguiente;

        // -- Constructor de la clase

        public Nodo(string e, int s)
        {
            elemento = e;
            siguiente = s;
        }

        // -- Destructor

        ~Nodo()
        {
            Console.WriteLine("\nRecurso del Nodo Liberados ");
        }

        // --- Crear clase listas enlazadas 

        class Program
        {
            // -- Clase Nodo

            class Nodo
            {
                // -- Campos

                public string elemento;
                public int siguiente;

                // -- Constructor

                public Nodo(string e, int s)
                {
                    elemento = e;
                    siguiente = s;
                }

                // -- Destructor

                ~Nodo()
                {
                    Console.WriteLine("\nRecurso del Nodo Liberados ");
                }
            }

            // -- Clase Lista 

            class ListaEnlazada
            {
                // -- Campos de la clase Lista        

                int inicio, disponible, Max;
                Nodo[] listanombres;

                // -- Variables auxiliares 

                int tamaño, auxiliar, posicion, temporal;
                char otra;

                // -- Contructor de la clase

                public ListaEnlazada(int capacidad)
                {
                    Max = capacidad;
                    inicio = 0;
                    disponible = 0;
                    tamaño = 0;

                    listanombres = new Nodo[Max];
                    for (int c = 0; c < Max - 1; c++)
                    {
                        listanombres[c] = new Nodo("", c + 1);
                    }
                    listanombres[Max - 1] = new Nodo("", -1);

                    Console.Write("\nLista Enlazada creada ");
                    Console.Write("\nPresione Enter para continuar ");
                }

                // -- Metodos de la clase 

                public void Insertar() 
                {
                    string dato;
                    do
                    {
                        if (tamaño == Max)
                        {
                            Console.Write("\nLa Lista esta Llena ");
                            Console.ReadKey();
                            return;
                        }
                        else
                        {
                            // -- Capturardora

                            Console.Write("\nIngresa un elemento a la lista: ");
                            dato = Console.ReadLine();

                            temporal = listanombres[disponible].siguiente;
                            listanombres[disponible].elemento = dato;

                            // -- Llamar al metodo

                            lugar_insertar(dato);

                            if (posicion == inicio)
                            {
                                listanombres[disponible].siguiente = inicio;
                                inicio = disponible;
                            }
                            else
                            {
                                listanombres[disponible].siguiente = listanombres[auxiliar].siguiente;
                                listanombres[auxiliar].siguiente = disponible;
                            }
                            disponible = temporal;

                            // -- Incremento por la inserción

                            tamaño = tamaño + 1;
                        }

                        Console.Write("\nDesea otra inserción (S/N) ?: ");
                        otra = char.Parse(Console.ReadLine());

                    } while (otra == 'S' || otra == 's');
                }

                // -- Prodecimiento pt 1

                public void lugar_insertar(string dato)
                {
                    int encontrado = 0;
                    posicion = inicio;
                    auxiliar = 0;

                    while (posicion != -1 && encontrado != 1)
                    {
                        if (String.Compare(listanombres[posicion].elemento,dato)>0)
                        {
                            encontrado = 1;
                        }
                        else
                        {
                            auxiliar = posicion;
                            posicion = listanombres[posicion].siguiente;
                        }
                    }
                }

                // -- Procedimiento pt 2
                public void Eliminar()
                {
                    int encontrado;
                    string dato;
                    do
                    {
                        if (tamaño == 0)
                        {
                            Console.Write("\nLa Lista está Vacia");
                            Console.ReadKey();
                            return;
                        }
                        else
                        {

                            Console.Write("\nIngresa un dato a eliminar: ");
                            dato = Console.ReadLine();


                            encontrado = busca_eliminar(dato);

                            if (encontrado == 1)
                            {
                                if (auxiliar != -1)
                                {
                                    listanombres[auxiliar].siguiente = listanombres[posicion].siguiente;
                                }
                                else
                                {
                                    inicio = listanombres[posicion].siguiente;
                                }
                                listanombres[posicion].elemento = "";
                                listanombres[posicion].siguiente = -1;


                                temporal = disponible;
                                while (temporal != -1)
                                {
                                    if (listanombres[temporal].siguiente != 0)
                                    {
                                        temporal = listanombres[temporal].siguiente;
                                    }
                                    else
                                    {
                                        listanombres[temporal].siguiente = posicion;
                                    }
                                }


                                tamaño = tamaño - 1;
                            }
                        }

                        Console.Write("\n\nDesea otra eliminación (S/N) ?: ");
                        otra = char.Parse(Console.ReadLine());

                    } while (otra == 'S' || otra == 's');
                }

                // -- Funcion 

                public int busca_eliminar(string dato)
                {
                    int encontrado = 0;
                    posicion = inicio;
                    auxiliar = -1;
                    while (posicion != -1 && encontrado != 1)
                    {
                        if (listanombres[posicion].elemento == dato)
                        {
                            encontrado = 1;
                        }
                        else
                        {
                            auxiliar = posicion;
                            posicion = listanombres[posicion].siguiente;
                        }
                    }

                    if (encontrado == 0)
                    {
                        Console.Write("\nEl Elemento " + dato + " No esta en la Lista ");
                    }
                    else
                    {
                        Console.Write("\nEl Elemento " + dato + " Sera Eliminado de la Lista ");
                    }

                    return encontrado;
                }


                // -- Procedimiento pt 3

                public void Desplegar()
                {
                    posicion = inicio;
                    if (tamaño == 0)
                    {
                        Console.Write("\nLa lista Esta Vacia ");
                        Console.ReadKey();
                        return;
                    }
                    else
                    {
                        while (posicion != -1 && listanombres[posicion].elemento != "")
                        {
                            Console.Write("\n\nElemento: " + listanombres[posicion].elemento + " Posición: " + posicion);
                            posicion = listanombres[posicion].siguiente;
                        }
                    }
                }

                // -- Procedimiento pt 4

                public void Contar() // -- Metodo Contar
                {
                    int contador = 0;
                    posicion = inicio;
                    if (tamaño == 0)
                    {
                        Console.Write("\nLa Lista esta Vacia ");
                        Console.ReadKey();
                        return;
                    }
                    else
                    {
                        while (posicion != -1 && listanombres[posicion].elemento != "")
                        {
                            contador = contador + 1;
                            posicion = listanombres[posicion].siguiente;
                        }
                        Console.Write("\n\nEl Total de Elementos en la Lista es: " + contador);
                    }
                }

                // -- Localizacion

                public void Buscar() // -- Metodo Buscar
                {
                    string dato;
                    int encontrado = 0;
                    if (tamaño == 0)
                    {
                        Console.Write("\nLa lista esta vacia. ");
                        Console.ReadKey();
                        return;
                    }
                    else
                    {
                        do
                        {
                            posicion = inicio;

                            // -- Capturadora

                            Console.Write("\nIngresa el dato a buscar: ");
                            dato = Console.ReadLine();

                            while (posicion != -1 && encontrado != 1)
                            {
                                if (listanombres[posicion].elemento == dato)
                                {
                                    encontrado = 1;
                                }
                                else
                                {
                                    posicion = listanombres[posicion].siguiente;
                                }
                            }

                            if (encontrado == 0)
                            {
                                Console.WriteLine("\nElemento " + dato + " No esta en la lista");
                            }
                            else
                            {
                                Console.WriteLine("\nEl Elemento " + dato + " Esta en la posición " + posicion);
                            }

                            Console.Write("\nDesea otra inserción (S/N) ?: ");
                            otra = char.Parse(Console.ReadLine());
                        } while (otra == 'S' || otra == 's');
                    }
                }

                // --Destructor 

                ~ListaEnlazada()
                {
                    Console.WriteLine("\nLa memoria de la Clase Lista Enlazada fue Liberada ");
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


                // -- Objeto para utilizar nuestro contador de tiempo

                Stopwatch sw = new Stopwatch();

                //---- Inicia el contador de tiempo basandose en la duracion de utilizacion del programa:

                sw.Start();

                char OPS;

                int t;

                // Objeto
                ListaEnlazada lista = null;


                // -- Realizamos el ciclo para el menu

                do
                {

                    // -- Hacemos nuestro menu de operaciones

                    Console.Clear();

                    Console.Write("Bienvenido al menu, por favor seleccione una de las siguientes opciones.. ");

                    Console.Write("\n\na) Crear lista. ");
                    Console.Write("\n\nb) Insertar un elemento. ");
                    Console.Write("\n\nc) Eliminar un dato. ");
                    Console.Write("\n\nd) Recorrer la cola. ");
                    Console.Write("\n\ne) Determinar el numero de elementos. ");
                    Console.Write("\n\nf) Localizar un elemento en particular. ");
                    Console.Write("\n\ng) Salir Del Programa. ");

                    Console.Write("\n\nIngrese la opcion a ejecutar: ");


                    // -- Creamos el switch que actuara como nuestro menu con los casos

                    OPS = Char.Parse(Console.ReadLine());

                    switch (OPS)
                    {

                        case 'a':

                            Console.Clear();
                            Console.Write("\nIngresa el Tamaño de la Lista: ");
                            t = int.Parse(Console.ReadLine());
                            lista = new ListaEnlazada(t);
                            Console.ReadKey();
                            Console.Clear();

                            break;

                        case 'b':

                            Console.Clear();
                            lista.Insertar();

                            Console.Write("\n\nPresiona Enter para volver al menu");
                            Console.ReadKey();
                            Console.Clear();

                            break;

                        case 'c':

                            Console.Clear();
                            lista.Eliminar();

                            Console.Write("\n\nPresiona Enter para volver al menu");
                            Console.ReadKey();
                            Console.Clear();

                            break;

                        case 'd':

                            Console.Clear();
                            lista.Desplegar();

                            Console.Write("\n\nPresiona Enter para volver al menu");
                            Console.ReadKey();
                            Console.Clear();

                            break;

                        case 'e':

                            Console.Clear();
                            lista.Contar();

                            Console.Write("\n\nPresiona Enter para volver al menu");
                            Console.ReadKey();
                            Console.Clear();

                            break;

                        case 'f':

                            Console.Clear();
                            lista.Buscar();

                            Console.Write("\n\nPresiona Enter para volver al menu");
                            Console.ReadKey();
                            Console.Clear();
                            break;

                        case 'g':

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

                } while (OPS != 'g');
            }
        }
    }

}
