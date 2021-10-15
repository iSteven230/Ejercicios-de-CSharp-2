using System;

namespace ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, numM = 0;
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("digite un numero");
                num = int.Parse(Console.ReadLine());
                if (num > numM)
                {
                    numM = num;
                }
            }
            Console.WriteLine("el numero mayor es {0}", numM);
        }
    }
}
