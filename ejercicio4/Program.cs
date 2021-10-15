using System;

namespace ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            do
            {
                Console.WriteLine("digite un numero, si digita 0 termina");
                num = int.Parse(Console.ReadLine());
            } while (num != 0);
        }
    }
}
