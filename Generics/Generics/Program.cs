using System;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            AlmacenObjetos archivos = new AlmacenObjetos(8);
            archivos.agregar("Adam");
            archivos.agregar("Adam1");
            archivos.agregar("Adam2");
            archivos.agregar("Adam3");


            string nombrePersona = (String)archivos.getObjeto(2);   /* Haciendo casting a string, porque el metodo "getObjeto" 
                                                                     * me devuelve un object y estoy tratando de guardarlo en una variable
                                                                     * de tipo string */
            Console.WriteLine(nombrePersona);



            archivos.agregar(new Empleado(5000));     // Agregando el empleado directamente al array, sin instanciarlo primero

            archivos.agregar(new Empleado(4000));
            archivos.agregar(new Empleado(6000));
            archivos.agregar(new Empleado(7000));

            Empleado empleado = (Empleado)archivos.getObjeto(5);
            Console.WriteLine(empleado.getSalario());      /* Me esta devolviendo el salaro del empleado que esta en la posicion 5
                                                            * del array */
        }
    }

    class AlmacenObjetos
    {
        private Object[] datosElemento;
        private int y = 0;                     /* Contador que nos va  a permitir guardar en las diferentes posiciones de un array
                                                * elementos */
        public AlmacenObjetos(int z)      // z = cantidad de elementos del array
        {
            datosElemento = new Object[z];   // Inicializando el array dependiendo el numero de elementos "z"
        }
    
        public void agregar(Object obj)   //Agregar un objeto al array
        {
            datosElemento[y] = obj;
            y++;
        }
    
        public Object getObjeto(int i)   //Obtener objeto del array dependiendo del valor que le pase (posicion en el array)
        {
            return datosElemento[i];
        }
    }

    class Empleado
    {
        private double salario;
        public Empleado(double salario)
        {
            this.salario = salario;
        }
    
        public double getSalario()
        {
            return salario;
        }
    }
}
