using System;
using static System.Math;  /* Para poder utilizar los metodos de math sin usar la palabra de la clase "MATH"*/
using static System.Console; /* Para poder utilizar los metodos de Console sin usar la palabra de la clase "Console" */
                            

namespace CONCEPTOS_PO
{
    class Program         /* TRABAJANDO CON DIFERENTES FICHEROS (PROGRAM, PUNTO)*/
    {
        static void Main(string[] args)
        {
            realizarTarea();
            WriteLine($"Numero de objetos creados: {Punto.contarObjetos()}");   /*Accedo desde la clase y no 
                                                                                         * desde un objeto
                                                                                         * porque 
                                                                                         * es un metodo estatico*/
            double raiz = Sqrt(9);
            double potencia = Pow(3,4);
            WriteLine($"La potencia es: {potencia}, y la raiz: {raiz}");

            var miVariable = new { Nombre = "Juan", Edad = 19 };  /* CLASES ANONIMAS,  Para crear una variable objeto
                                                                     * tengo que hacerlo usando la palabra "var" y
                                                                     * para acceder a los atributos de los objetos lo hago con
                                                                     * (el nombre del objeto).(nombre de atributo) 
                                                                     * El compilador determina por si solo el tipo de variable
                                                                     * depende el valor que le pase */
            Console.WriteLine(miVariable.Nombre + " " +  miVariable.Edad);
            
            var miOtraVariable = new { Nombre = "Ana", Edad = 25 }; /* El compilador ya sabe que estos objetos
                                                                     * se tratan de la misma clase anonima
                                                                     * porque tienen la misma cantidad de campos, 
                                                                     * el mismo tipo de datos */
            
            miVariable = miOtraVariable;  /* Con esto compruebo que ambos objetos son de la misma clase */
            Console.WriteLine(miOtraVariable);
            Console.WriteLine(miVariable);


        }
        static void realizarTarea()
        {
            Punto origen = new Punto();
            Punto destino = new Punto(150,90);
            Punto otroPunto = new Punto();
            double distancia = origen.calcularDistancia(destino);
            WriteLine($"La distancia entre los dos puntos es: {distancia}");
        }
    }
}
