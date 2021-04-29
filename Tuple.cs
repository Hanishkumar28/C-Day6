using System;

namespace Day6
{
    class Program
    {
        public void calcMulti(double a, double b)
        {
            Console.WriteLine(new Tuple<double, double, double, double>((a + b),(a - b),(a * b),(a / b)));
        }
        static void Main(string[] args)
        {
            Program obj1 = new Program();
            obj1.calcMulti(10, 2);
        }

    }
}
