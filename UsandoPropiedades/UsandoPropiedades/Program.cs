using System;

namespace UsandoPropiedades
{
    class Program
    {
        static void Main(string[] args)
        {
            Empleado empleado1 = new Empleado("Adam");
            empleado1.SALARIO = 1200;
            Console.WriteLine($"El salario del empleado1 es: {empleado1.SALARIO}");
            empleado1.SALARIO += 500;
            Console.WriteLine($"El salario del empleado1 actualizado  es: {empleado1.SALARIO}");
            
            
            Empleado empleado2 = new Empleado("Enano");
            empleado2.SALARIO = 400;
            Console.WriteLine($"El salario del empleado2 es: {empleado2.SALARIO}");
            empleado2.SALARIO -= 1000;
            Console.WriteLine($"El salario del empleado2 actualizado  es: {empleado2.SALARIO}"); /* Ver como aunque le reste de mas
                                                                                                  * nunca me devuelve un negativo
                                                                                                  * porque asi lo especifique en 
                                                                                                  * el metodo */

        }
    }
    
    class Empleado
    {
        public Empleado(String nombre)     //CONSTRUCTOR 
        {
            this.nombre = nombre;
        }
        

        public double evaluaSalario(double salario)
        {
            if (salario < 0) return 0;
            else return salario;

                    
        }
        
        //DECLARANDO UNA PROPIEDAD, SIEMPRE EL NOMBRE  EN MAYUSCULA
        public double SALARIO
        {
            get => this.salario; 
            set => this.salario = evaluaSalario(value);
        }
        
        private double salario { get; set; }      //CAMPOS DE CLASE
        private string nombre { get; set; }
    }
}
