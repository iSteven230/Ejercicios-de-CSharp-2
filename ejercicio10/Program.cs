using System;

namespace ejercicio10
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, i, facto = 1, conta = 0;
            Console.WriteLine("digite el numero que le deseea sacar la factorial ");
            num1 = int.Parse(Console.ReadLine());
            for (i = 1; i <= num1; i++)
            {
                facto = facto * i;
                if (conta < 5)
                {
                    Console.Write("{0}*", conta);
                }
                else
                    Console.Write("{0}={1}", i, facto);
            }
        }
    }
}
