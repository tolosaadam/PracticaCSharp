using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            // Definicion de variables comunes
            int edad;
            edad = 18;
            Console.WriteLine(edad);

            // Definicion de variables implicitas
            var nombrePersona = "Adam";  // Ahora tengo que respetar que la variable es un string
            Console.WriteLine(edad + " " + nombrePersona);
            
            // Conversion explicita (Tengo que usar un casting)
            double temperaturaSanjusto = 19.5;
            int temperatura;
            temperatura = (int)temperaturaSanjusto;   //Tengo que pasarle un (int) para definirla como entero
            Console.WriteLine(temperatura);

            // Conversion implicita  (No tengo que usar nada)
            int habitantesCiudad = 100000;
            long habitantesCiudadsanjusto = habitantesCiudad;
            Console.WriteLine(habitantesCiudadsanjusto);

            float pesoMaterial = 5.78F;  //Tengo que usar una "F" para indicar que es un float
            double pesoMaterialPrecision = pesoMaterial;
            Console.WriteLine(pesoMaterialPrecision);


        }
    }
}
