using System;

namespace Switch_case
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Elige medio de transporte (Coche,Tren,Avion)");
            string medioTransporte = Console.ReadLine();
            switch (medioTransporte)
            {
                case "Coche":
                    Console.WriteLine("Velocidad media 100Km/h");
                    break;
                case "Tren":
                    Console.WriteLine("Velocidad media 200Km/h");
                    break;
                case "Avion":
                    Console.WriteLine("Velocidad media 800km/h");
                    break;
                default:
                    Console.WriteLine("El medio de transporte no esta disponible");
                    break;

                    
            }

            metodoUno();
        }
        static void metodoUno()
        {
            Console.WriteLine("Ingrese n° de mes para calculo de la comision");
            int mes = int.Parse(Console.ReadLine());
            switch (mes)
            {
                case 1:
                    Console.WriteLine("Mes escogido 'enero'");
                    break;
                case 2:
                    Console.WriteLine("Mes escogido 'febrero'");
                    break;
                case 3:
                    Console.WriteLine("Mes escogido 'marzo'");
                    break;
                case 4:
                    Console.WriteLine("Mes escogido 'abril'");
                    break;
                case 5:
                    Console.WriteLine("Mes escogido 'mayo'");
                    break;
                case 6:
                    Console.WriteLine("Mes escogido 'junio'");
                    break;
                case 7:
                    Console.WriteLine("Mes escogido 'julio'");
                    break;
                case 8:
                    Console.WriteLine("Mes escogido 'agosto'");
                    break;
                case 9:
                    Console.WriteLine("Mes escogido 'septiembre'");
                    break;
                case 10:
                    Console.WriteLine("Mes escogido 'octubre'");
                    break;
                case 11:
                    Console.WriteLine("Mes escogido 'noviembre'");
                    break;
                case 12:
                    Console.WriteLine("Mes escogido 'diciembre'");
                    break;
                default:
                    Console.WriteLine("Mes incorrecto");
                    break;
            }

        }
            
        
    }
}


