using System;

namespace While
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Deseas entrar en el bucle While?");
            string respuesta = Console.ReadLine();

            while (respuesta != "no")
            {
                Console.WriteLine("Estas ejecutando el interior del bucle While");
                Console.WriteLine("Introduce un nombre porfavor");
                string nombre = Console.ReadLine();
                Console.WriteLine($"Saldras del bucle cuando {nombre} escribas 'no'");
                Console.WriteLine("Deseas repetir otra vez?");
                respuesta = Console.ReadLine();

            }
            Console.WriteLine("Has salido del bucle");
            
            metodoUno();
            metodoDOS();
        }
        static void metodoUno()      /* ESTO ES OTRA COSA */
        {
            Random numero = new Random();
            int numeroAleatorio = numero.Next(0, 100);
            int numeroUsuario = 101;
            int contadorIntentos = 0;
            Console.WriteLine("Se a generado un numero aleatorio");
            Console.WriteLine("Deseas adivinarlo?");
            string respuestaUno = Console.ReadLine();
            if (respuestaUno == "si")
            {

                while(numeroUsuario != numeroAleatorio)
                {
                    Console.WriteLine("Ingresa el numero que crees correcto entre 0 y 100");
                    try
                    {
                        numeroUsuario = int.Parse(Console.ReadLine());
                    
                        if (numeroUsuario > numeroAleatorio)
                        {
                            Console.WriteLine($"El numero aleatorio es menor a {numeroUsuario}");
                        }
                        else if (numeroUsuario < numeroAleatorio)
                        {
                            Console.WriteLine($"El numero aleatorio es mayor a {numeroUsuario}");
                        }
                        contadorIntentos++;
                    }
                    catch(Exception ex) when  (ex.GetType()!=typeof(FormatException))  /* la variable "ex" es donde se guarda 
                                                                                        * el error, ESTO ES UNA EXEPCION 
                                                                                        * CON FILTROS */
                                                                                        
                    {
                        Console.WriteLine("Numero incorrecto");
                        Console.WriteLine(ex.Message);     /* capturar el mensaje de error */
                    }
                    catch(FormatException ex)
                    {
                        Console.WriteLine("No has introducido un valor numerico");
                        Console.WriteLine(ex.Message);  
                    }    
                    
                }
                Console.WriteLine($"Muy bien has adivinado el numero {numeroAleatorio}! y usaste {contadorIntentos} intentos");
            }

            Console.WriteLine("Hasta luego!");

        }
        static void metodoDOS()     /* ESTO ES OTRA COSA */
        {
            int z = 10;
            do                                          /* BUCLE DO WHILE "HAZ MIENTRAS" */
            {
                Console.WriteLine($"Impresion {z}");  
                z++;
            }
            while (z < 15);

        }
    }
}


