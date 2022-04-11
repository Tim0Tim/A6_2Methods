using System;

namespace A6_2Methods
{
    class Program
    {
        public double ce;
        public double f;
        public static double Main()
        {
            var calc = new Program();
            double ce;
            double f;
            int T;
            double num = 32;
            Console.WriteLine("Do you want to convert Celsius to Fahrenheit(1) \n--or--\n Convert Fahrenheit to Celsius(2)");
            T = int.Parse(Console.ReadLine());


            if (T == 1)
            {
                Console.WriteLine("What is the Fahrenheit value?");
                f = double.Parse(Console.ReadLine());
                Console.WriteLine("The Value is:");
                return calc.Cel(f,num);
                Console.Write(" °C");
            }
            else if(T == 2)
            {
                Console.WriteLine("What is the Celcius value?");
                ce = double.Parse(Console.ReadLine());
                Console.WriteLine("the Value is:");
                return calc.Fa(ce,num);
                Console.Write(" °F");
            }
            else
            {
                Console.WriteLine("Invalid input");
                return null;
            }
        }

        public double Cel(double f, double num)
        {
         return 5.0/9.0 * f - num;
        
        }
        
        public double Fa(double ce, double num)
        {
            return 9.0 / 5.0 * ce + num;
        }
    }
}
