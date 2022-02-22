using System;


namespace Static_var_and_fun
{
    class number
    {
        // Create static variable
        public static int num;
        //Create static method
        public static void power()
        {
            Console.WriteLine("el cuadrado de {0} = {1}", num, num * num);
            Console.ReadLine();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number\t");
            number.num = Convert.ToInt32(Console.ReadLine());
            number.power();
        }
    }
}