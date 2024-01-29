// Софія Сироїд В. 1-ІПЗ-21
#nullable enable
using System;

namespace First
{
    public static class FirstEx
    {

        public static double W1(double a)
        {
            double y;
            if (a > 0) y = Math.Pow(a, 2);
            else if (a == 0) y = 0;
            else y = Math.Abs(a);

            return y;
        }
        public static int W2(int a)
        {
            char[] b = a.ToString().ToCharArray();
            Array.Sort(b);
            Array.Reverse(b);
            return int.Parse(b);
        }

        public static int Main(string[] argv)
        {
            Console.WriteLine("Task 1: (write double number)");
            string? b2 = Console.ReadLine();
            double b1 = double.Parse(b2);
            Console.WriteLine(W1(b1));

            Console.WriteLine("Task 2: (write int number)");
            string? b = Console.ReadLine();
            if (b is null) {return -1;}
            Console.WriteLine(W2(int.Parse(b)));

            return 0;
        }
    }
}