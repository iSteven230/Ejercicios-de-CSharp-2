using System;

namespace ejercicio8
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 100; // Cuenta
            int x = 7; // Múltiplo
            int i; // Contador
            Console.WriteLine("los numeros mutiplos de 7 del 1 al 100");
            for (i = 1; i <= n; i++)
            {
                if (i % x == 0)
                    Console.WriteLine("{0}", i);
            }
        }
    }
}
