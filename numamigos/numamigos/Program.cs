using System;


namespace numamigos
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1=Int32.Parse(Console.ReadLine());
            int n2 = Int32.Parse(Console.ReadLine());
            int s1 = 0;
            int s2 = 0;
            for (int i=1;i<n1-1;i++) {
                if (n1 % i == 0)
                    s1 += i;

            }
           
            for (int i = 1; i < n2-1; i++)
            {
                if (n2 % i == 0)
                    s2 += i;

            }
           
           if (s1 == n2 && n1==s2)
                Console.WriteLine("{0} y {1} son numeros amigos",n1,n2);
            else
                Console.WriteLine("{0} y {1} no son numeros amigos", n1, n2);

            Console.ReadLine();
        }
    }
}
