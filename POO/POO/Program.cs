using System;

namespace POO
{
    class Program
    {
        static void Main(string[] args)
        {
            Circulo circuloUno;    //Creacion de objeto de tipo circulo. Variable objeto de tipo circulo
            Circulo circuloDos = new Circulo();  // Segunda variable de tipo objeto
            circuloUno = new Circulo();  /*Iniciacion de variable objeto de tipo circulo. (Instanciar una clase)
                                          * -Instanciacion
                                          * -Ejemplarizacion
                                          * -Creacion de ejemplar de clase */
            Console.WriteLine(circuloUno.CalculoArea(5));
            Console.WriteLine(circuloDos.CalculoArea(9));

            ConversorEuroDolar obj = new ConversorEuroDolar();
            
            Console.WriteLine(obj.Convierte(50));

            obj.cambiaValorEuro(1.45);  /* Cambiando el valor del euro con un metodo*/
            

            
            
        
        }

    }
    class Circulo
    {
        public const double pi = 3.1416;     // Propiedad de la clase circulo , CAMPO DE CLASE
        // Se la define con "Const" para que sea una constante y no una variable, ya que necesito que nunca se cambie
        // Se usa "private" para que solo sea accesible desde la clase donde se definio
        public double CalculoArea(int radio)  //Metodo de clase , Que pueden hacer los objetos de tipo circulo
        {
            return pi * radio * radio;
        }



    }
    class ConversorEuroDolar
    {
        private double euro = 1.253;   /* El valor del euro es privado y aun asi con un metodo
                                        * dentro de la clase puedo cambiar su valor, y agregarle condicioens*/
        public double Convierte(double cantidad) 
        {
            return cantidad * euro;
        }
        public void cambiaValorEuro(double nuevoValor)  /* Uso este metodo para poder decirle
                                                         * que si el valor que le paso es negativo no me cambie
                                                         * el valor de euro (para controlar errores)*/
        {
            if (nuevoValor < 0)
            {

            }
            else
            {
                euro = nuevoValor;
            }
        }

    }
}


