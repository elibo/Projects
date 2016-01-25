using System;
using System.Collections;

namespace loteria
{
    class Program
    {


        static void Main(string[] args)
        {
            Random r = new Random();
            ArrayList num = new ArrayList();
            for (int i = 0; i < 6; i++)
            {
                int n = r.Next(1, 50);
                if (!num.Contains(n))
                    num.Add(n);
                else
                    i--;
            }
            Program p = new Program();
            imp(num);
   

            Console.ReadLine();
        }



        static void imp(ArrayList num)
        {
            Random r = new Random();
            int com = r.Next(1, 50);
            int re = r.Next(0, 10);
            Console.Write("Combinacion : ");
            foreach (int i in num)
            {
                
                Console.Write(i +" ");
            }
        }
    }
}
