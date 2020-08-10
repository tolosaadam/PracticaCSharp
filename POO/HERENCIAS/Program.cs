using System;

namespace HERENCIAS
{
    class Program                                                   /* EL MOTIVO DE LA HERENCIA ES PARA PODER
                                                                     * RETUILIZAR CODIGO */
    {
        static void Main(string[] args)
        {
            Caballo caballo1 = new Caballo();
            
            Humano humano1 = new Humano();
            
            Gorila gorila1 = new Gorila();
            
            

        }
    }
    
    class Mamiferos
    {
        public void respirar()
        {
            Console.WriteLine("Soy capaz de respirar");
        }
        public void cuidarCrias()
        {
            Console.WriteLine("Cuido de mis crias hasta que se valgan por si solas" );
        }
    }
    class Caballo : Mamiferos

    {
        public void galopar()
        {
            Console.WriteLine("Soy capaz de galopar");
        }
    }
    
    class Humano : Mamiferos
    {
        public void pensar()
        {
            Console.WriteLine("Soy capaz de pensar");
        }
    }

    class Gorila : Mamiferos
    {
        public void trepar()
        {
            Console.WriteLine("Soy capaz de pensar");
        }
    }
}
