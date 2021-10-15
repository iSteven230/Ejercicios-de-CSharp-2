using System;

namespace ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, suma = 0;
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("digite un numero");
                num = int.Parse(Console.ReadLine());
                suma = suma + num;
            }
            Console.WriteLine("la suma de todos los numeros es {0}", suma);
        }
    }
}
