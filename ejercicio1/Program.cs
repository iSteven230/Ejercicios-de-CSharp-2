using System;

namespace ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            int conta = 0, num = 0, numM = 0;
            while (conta < 2)
            {
                conta++;
                Console.WriteLine("digite un numero");
                num = int.Parse(Console.ReadLine());
                if (num > numM)
                {
                    numM = num;
                }
            }
            Console.WriteLine("el numero mayor es {0}",numM);
        }
    }
}
