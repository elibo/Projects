using System;


namespace numperfecto
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = Int32.Parse(Console.ReadLine());
            int c = 0;

            for (int i=1;i<num-1;i++) {
                if (num%i == 0)
                    c += i;
            }
 
           if (c == num)
                Console.WriteLine("{0} es un numero perfecto",num);
            else
                Console.WriteLine("{0} no es un numero perfecto",num);
            Console.ReadLine();

        }
    }
}
