using System;

namespace ejercicio9
{
    class Program
    {
        static void Main(string[] args)
        {
            int suma = 0, num, sumaN = 0, promedio = 0;
            Console.WriteLine("digite un numero, para que calcule el promedio de los numeros ingresados");
            do
            {
                Console.WriteLine("digite otro numero, si digita 0 termina");
                num = int.Parse(Console.ReadLine());
                if (num != 0)
                {
                    sumaN++;
                    suma = suma + num;
                }
                promedio = suma / sumaN;
            } while (num != 0);
            Console.WriteLine("el promedio es {0}", promedio);
        }
    }
}
