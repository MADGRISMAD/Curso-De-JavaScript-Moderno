using System;
using System.Collections;
using System.Diagnostics;


class Program
{
    static void Main()
    {

        GC.Collect(); //fuerza una inmediata recoleccion de de la basura de todas las generaciones

        {

            // Creates and initializes a new Queue.
            Queue myQ = new Queue();
            myQ.Enqueue("The");
            myQ.Enqueue("quick");
            myQ.Enqueue("brown");
            myQ.Enqueue("fox");

            // Displays the Queue.
            Console.Write("Queue values:");
            PrintValues(myQ);

            // Removes an element from the Queue.
            Console.WriteLine("(Dequeue)\t{0}", myQ.Dequeue());

            // Displays the Queue.
            Console.Write("Queue values:");
            PrintValues(myQ);

            // Removes another element from the Queue.
            Console.WriteLine("(Dequeue)\t{0}", myQ.Dequeue());

            // Displays the Queue.
            Console.Write("Queue values:");
            PrintValues(myQ);

            // Views the first element in the Queue but does not remove it.
            Console.WriteLine("(Peek)   \t{0}", myQ.Peek());

            // Displays the Queue.
            Console.Write("Queue values:");
            PrintValues(myQ);
        }

        void PrintValues(IEnumerable myCollection)
        {
            foreach (Object obj in myCollection)
                Console.Write("    {0}", obj);
            Console.WriteLine();

        }



        var stopwatch = Stopwatch.StartNew();
        stopwatch.Start();


        long ticks1 = stopwatch.ElapsedTicks;
        Console.WriteLine("\n" + ticks1 + " ticks transcurridos");

        TimeSpan ts = TimeSpan.FromTicks(ticks1);
        double minutes = ts.TotalMinutes;
        Console.WriteLine(ts + " segundos transcurridos");

        Console.WriteLine("\nMemoria total: {0} bytes", GC.GetTotalMemory(false));

        Console.ReadKey();

    }
}