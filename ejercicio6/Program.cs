using System;

namespace ejercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 1, suma = 0;
            do
            {
                Console.WriteLine("digite un numero");
                num = int.Parse(Console.ReadLine());
                suma = suma + num;
            } while (num != 0);
            Console.WriteLine("la suma de todos los numeros es {0}", suma);
        }
    }
}
