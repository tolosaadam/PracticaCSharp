using System;

namespace ELSE_IF
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Que edad tienes?");
            
            int edad = int.Parse(Console.ReadLine());

            if (edad < 18)
            {
                Console.WriteLine("Eres un niño");
            }
            else if (edad < 30)
            {
                Console.WriteLine("Eres un joven");
            }
            else if (edad < 60)
            {
                Console.WriteLine("Eeres maduro");
            }
            else 
            {
                Console.WriteLine("Debes cuidarte ya");
            }
                


        }
    }
}
