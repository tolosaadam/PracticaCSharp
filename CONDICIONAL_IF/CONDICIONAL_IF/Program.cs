using System;
using System.Dynamic;
using System.Reflection;

namespace CONDICIONAL_IF
{
    class Program
    {
        static void Main(string[] args)
        {
            bool haceFrio;

            haceFrio = false;

            Console.WriteLine(!haceFrio);     /* ! hace la negacion de la variable ( si es true lo hace false
                                               * y al revez */
        
            
            /* El ejercicio de abajo  es otra cosa */
        
            Console.WriteLine("Vamos a ver si puedes conducir un vehiculo");
            
            Console.WriteLine("Introduce  tu edad, porfavor");

            int edad = int.Parse(Console.ReadLine());   /* Cuando pido un int siempre parsear readline
                                                         * readline siempre devuelve un string */
            if (edad >= 18 )   /*  && = and     || = or*/
            {
                Console.WriteLine("Tienes carnet?");
                string carnet = Console.ReadLine();
                if (carnet == "si")
                {
                    Console.WriteLine("Puedes conducir vehiculos");
                }
                else 
                {
                    Console.WriteLine("Si no tienes carnet no puedes conducir un vehiculo");    
                }
            }   
            else
            {
                Console.WriteLine("No puedes conducir vehiculos porque eres menor de edad");
            }

            primerMetodo();  /* llamando al metodo "primerMetodo" */
        

        }
        static void primerMetodo()
        {
            Console.WriteLine("Introduce el primer parcial");
            float parcial1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduce el segundo parcial");
            float parcial2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduce el tercer parcial");
            float parcial3 = int.Parse(Console.ReadLine());

            if (parcial1 >= 5 || parcial2 >= 5 || parcial3 >= 5)
            {
                Console.WriteLine("La nota media es: " + (parcial1+parcial2+parcial3)/3);

            }
            else
            {
                Console.WriteLine("Vuelve en septiembre");

            }
        } 
    
    }

}





                
            
            

    



            
            
            
            
               



