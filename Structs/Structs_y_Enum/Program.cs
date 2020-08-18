using System;

namespace Structs_y_Enum
{
        enum Estaciones { Primavera,Verano,Otoño,Invierno}; // Por defecto el valor de las key dentro de enum es '0'
        enum Bonus { Bajo=500,Normal=1000,Bueno=1500,Extra=3000};
    class Program
    {
        
        static void Main(string[] args)
        {

            Estaciones alergia = Estaciones.Primavera;    /* Variables de tipo 'enum', le asigno a una variable de tipo enum
                                                           * El nombre de la (variable enum).(nombre de la key)*/
            Console.WriteLine(alergia);
            
            string la_alergia = alergia.ToString();        /* Si quiero asignarle ese valor a una variable de tipo 'string' 
                                                            * necesito usar el metodo 'ToString()' para poder convertir de
                                                            * variable 'enum Estaciones' a 'String' */
            Console.WriteLine(la_alergia);

            Estaciones? sudor = null; /* Cuando queremos asignar un valor de tipo null a una variable de tipo 'enum' debo usar
                                       * el '?' luego del nombre de la variable 'enum' */


            // CLASE EMPLEADO
            Bonus Antonio = Bonus.Bajo;
            Console.WriteLine(Antonio);    // Asi me imprime el nombre de la key

            double bonusAntonio = (double)Antonio; /* Hago un casting de la variable, para que me  muestre su valor y no el nombre
                                                    * de la key */
            Console.WriteLine(bonusAntonio);
            
            Console.WriteLine((double)Antonio);  // Aca hago lo mismo pero haciendo el casting dentro del Console.Writeline

            var salarioAntonio = 1500 + (double)Antonio;
            
            Console.WriteLine(salarioAntonio);
            
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            Empleado empleado1 = new Empleado(Bonus.Extra, 1900.50);   // 1900.50 Es un salario inventado para el empleado1
            Console.WriteLine("El salario del empleado es: " + empleado1.getSalario());
        }
    }
    class Empleado
    {
        private double salario { get; set; }
        private double bonus { get; set; }

        public Empleado(Bonus bonusEmpleado, double salario)  //Constructor
        {
            bonus = (double)bonusEmpleado;      // Aca hago el casting a double
            this.salario = salario;
        }
        
        public double getSalario()
        {
            return salario + bonus;
        }
    }
}
