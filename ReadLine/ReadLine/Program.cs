using System;

namespace ReadLine
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingresa el primer numero");
            int num1 = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Ingresa el segundo numero");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("La suma de los 2 numeros es " + (num1 + num2));
        }
    }
}
