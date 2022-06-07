using System;

namespace MethodOverloading
{
    class Program
    {
        //public static int Add(int x, int y)
        //{
        //    return x + y;
        //}

        //allows as many parameters as needed
        public static int Add(params int[] numbers)
        {
            var sum = 0;
            foreach (var num in numbers)
            {
                sum += sum;
            }
            return sum;
        }

        public static double Add(double x, double y)
        {
            return x + y;
        }

        public static string Add(int x, int y, bool dollars)
        {

            if (dollars)
            {
                return $"{x + y} dollars";
            }
            else
            {
                return $"{x + y} dollar";
            }
        }

        




        static void Main(string[] args)
        {
            //calls first Add method
            Console.WriteLine(Add(3, 4)); //7

            //calls second Add method
            Console.WriteLine(Add(3.543, 634.734)); //638.277

            //calls third Add method for multiple dollars
            Console.WriteLine(Add(4, 6, true)); //10 dollars

            //calls third Add method for single dollar
            Console.WriteLine(Add(1, 0, false)); // 1 dollar

            Console.ReadLine();
        }
    }
}

