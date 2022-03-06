using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

class Program
{
    
    public static int CalculateSumRecursively(int n, int m)
    {
        int sum = n;
        if (n < m)
        {
            n++;
            return sum += CalculateSumRecursively(n, m);
        }
        return sum;
    }
    static void Main(string[] args)
    {
        GC.Collect();
        var stopwatch = Stopwatch.StartNew(); 
        stopwatch.Start();
        stopwatch.Stop();
        Console.WriteLine("introduce el numero n: ");
        int n = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("introduce el numero m: ");
        int m = Convert.ToInt32(Console.ReadLine());
        stopwatch.Start();
        int sum = CalculateSumRecursively(n, m);
        Console.WriteLine(sum);

        long ticks1 = stopwatch.ElapsedTicks; 
        Console.WriteLine("\n" + ticks1 + " ticks transcurridos");

        TimeSpan ts = TimeSpan.FromTicks(ticks1);
        double minutes = ts.TotalMinutes; 
        Console.WriteLine(ts + " segundos transcurridos"); 

        Console.WriteLine("\nMemoria total: {0} bytes", GC.GetTotalMemory(false));
        Console.ReadKey();

    }
}
