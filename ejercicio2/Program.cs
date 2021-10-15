using System;

namespace ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("digite un numero para saber si es par o impar");
            num = int.Parse(Console.ReadLine());
            if (num % 2 == 0)
            {
                Console.WriteLine("este numero es par");
            }
            else
                Console.WriteLine("este numero es impar");
        }
    }
}
