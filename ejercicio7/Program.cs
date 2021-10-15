using System;

namespace ejercicio7
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, z;
            string respuesta = "S";
            while (respuesta == "S")
            {
                Console.WriteLine("Escribe el primer lado");
                x = int.Parse(Console.ReadLine());
                Console.WriteLine("\nEscribe el segundo lado");
                y = int.Parse(Console.ReadLine());
                Console.WriteLine("\nEscribe el tercer lado");
                z = int.Parse(Console.ReadLine());
                Console.WriteLine("\n");
                if ((x + y > z) && (x + z > y) && (y + z) > x)
                {
                    if (x == y && x == z)
                    {
                        Console.WriteLine("Equilátero");
                    }
                    else
                        if (x == y || x == z || y == z)
                    {
                        Console.WriteLine("Isósceles");
                    }
                    else
                        Console.WriteLine("Escaleno");
                }
                else
                {
                    Console.WriteLine("Esos números no forman un triángulo");
                }
                Console.WriteLine("\n");
                Console.WriteLine("presione S si desea escribir y N si desea terminar");
                respuesta = Console.ReadLine();
            }
        }
    }
}
