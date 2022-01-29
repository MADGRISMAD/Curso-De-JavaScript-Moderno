using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace co2_15
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            a = int.Parse(args[0]);
            b = int.Parse(args[1]);
            c = a + b;
            Console.Write("{0}+{1}={2}", a, b, c);
        }
    }
}
