using System;


namespace Pascal
{
    class Program
    {
        public static int f(int n)
        {
            int f = 1;

            for (int i = 1; i <= n; i++)
            {
                f *= i;
            }

            return f;
        }

        public static int s(int num1, int num2)
        {

            int n = f(num1);
            int k = f(num2) * f(num1 - num2);
            return (n / k);

        }

        static void Main(string[] args)
        {
            int b = Int32.Parse(Console.ReadLine());
            int cols = 1;

            for (int i = 0; i < b; i++)
            {

                for (int j = 0; j < b - i; j++)
                {
                    Console.Write(" ");
                }

                for (int j = 0; j < cols; j++)
                {
                    Console.Write(" {0} ", s(i, j));
                }
                cols += 1;
                Console.WriteLine();
            }
            Console.ReadLine();

        }
    }
}
