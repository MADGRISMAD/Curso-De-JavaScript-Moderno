using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programa_17
{
    class Program
    {
        public class colas
        {
            int Max, Frente, Final, Apuntador;
            float[] cola;
            public colas(int tamaño)
            {
                Max = tamaño;
                Frente = -1;
                Final = -1;
                cola = new float[tamaño];
                Console.WriteLine("la cola ha sido creada con exito.");
                Console.WriteLine("presione <enter> para continuar.");
            }

            public void encolar(float elemento)
            {
                if (Frente=0 || Final=(Max-1))
                {
                    Console.WriteLine("la cola esta llena");

                }
                else
                {
                    if (Frente = -1)
                    {
                        Frente=0;
                        Final = 0;

                    }
                    else
                    {
                        Final = Final + 1;

                    }
                    cola[Final] = elemento;
                }
            }
            public void desencolar()
            {
                if (Frente!=-1)
                {
                    Console.WriteLine("eliminando el dato :" + cola[Frente]);
                    cola[Frente] ="";
                    if (Frente = Final)
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
                    Console.WriteLine("la cola esta vacia");
                }
            }

            public void recorrido()
            {
                if (Frente!=-1)
                {
                    Apuntador = Frente;
                    while (Apuntador<=Final)
                    {
                        Console.WriteLine("elemento" + cola[Apuntador] + "posicion" + Apuntador);
                        Apuntador = Apuntador + 1;
                    }
                }
                else
                {
                    Console.WriteLine("la cola esta vacia");
                }
            }

            public void busqueda(float elemento)
            {
                if (Frente!=-1)
                {
                    Apuntador = Frente;
                    while (Apuntador<= Final)
                    {
                        if (elemento=Cola[Apuntador])
                        {
                            Console.WriteLine("dato encontrado en la posicion: " + Apuntador);
                            return;
                        }
                        Apuntador = Apuntador - 1;
                    }
                    Console.WriteLine("dato " + elemento + " no encontrado en la cola");
                }
                else
                {
                    Console.WriteLine("la cola esta vacia");
                }
            }
        }
        static void Main(string[] args)
        {
        }
    }
}
