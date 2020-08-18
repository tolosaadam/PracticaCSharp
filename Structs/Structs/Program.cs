using System;

namespace Structs
{
    class Program
    {
        static void Main(string[] args)
        {
            Empleado empleado1 = new Empleado(1200, 500);
            empleado1.cambiaSalario(empleado1, 300);    /* Solo modifico la copia de empleado1 en el "stack", por eso no me muestra
                                                         * lo que quiero, en cambio trabajando con clases, se modifica en el "heap" 
                                                         * - Es mas rapido acceder  a la memoria "stack" que a la "heap" 
                                                         * - Lo que almacenamos en el "stack" es temporal, en cambio en "heap" no 
                                                         * - "Stack" = 'pila' */
            
            Console.WriteLine(empleado1);

        }
    }
    public struct Empleado    //Struct en vez de Class
    {
        public double salarioBase, comision;
        public Empleado(int salarioBase, int comision)
        {
            this.salarioBase = salarioBase;
            this.comision = comision;
        }

        public override string ToString()
        {
            return string.Format("Salario base y comision del empleado ({0},{1})", this.salarioBase, this.comision);
        }
    
        public void cambiaSalario(Empleado empleado, double incremento)
        {
            empleado.salarioBase += incremento;
            empleado.comision += incremento;
        }
    }
}
