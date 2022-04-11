using System;

namespace A6_2Methods
{
    class Program
    {
        private static void Main()
        {
            var calc = new Program();
            double ce;
            double f;
            int T;
            int num = 32;
            Console.WriteLine("Do you want to convert C° to F°(1)\n --or--\nConvert F° to C°(2)");
            T = int.Parse(Console.ReadLine());


            if (T == 1)
            {
                Console.WriteLine("What is the F° value?");
                f = double.Parse(Console.ReadLine());
                Console.WriteLine("The Value is:");
                Console.Write($"{calc.Cel(f,num)}°C");
            }
            else if(T == 2)
            {
                Console.WriteLine("What is the C° value?");
                ce = double.Parse(Console.ReadLine());
                Console.WriteLine("the Value is:");
                Console.WriteLine($" {calc.Fa(ce,num)}°F");
            }
            else
            {
                Console.WriteLine("Invalid input");
            }
        }

        public double Cel(double f, int num)
        {
         return 5.0/9.0 * f - num;
        
        }
        
        public int Fa(double ce, int num)
        {
           double A1 = 9.0 / 5.0 * ce + num;
            return Convert.ToInt32(A1);
        }
    }
}
