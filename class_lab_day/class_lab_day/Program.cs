using System;

namespace class_lab_day
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            Console.WriteLine("Eded 1 :: ");
            int num1 = Convert.ToInt32( Console.ReadLine());
            Console.WriteLine("Eded 2 :: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Eded 3 :: ");
            int num3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Eded 4 :: ");
            int num4 = Convert.ToInt32(Console.ReadLine());

            if(num1 % 2 == 1)
            {
                sum += num1;
            }

            if (num2 % 2 == 1)
            {
                sum += num2;
            }

            if (num3 % 2 == 1)
            {
                sum += num3;
            }

            if (num4 % 2 == 1)
            {
                sum += num4;
            }

            Console.WriteLine("sum = " + sum );
        }
    }
}
