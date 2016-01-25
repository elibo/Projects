using System;


namespace asteriscos
{
    class Program
    {
        static void Main(string[] args)
        {

            int b = Int32.Parse(Console.ReadLine());

            int c = 1;

            for (int i = 0; i < b; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < b - i; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < c; j++)
                {
                    Console.Write("*");
                }
                c += 2;

            }

            Console.ReadLine();
        }
    }
}
