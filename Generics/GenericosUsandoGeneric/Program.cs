using System;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            AlmacenObjetos<Empleado> archivos = new AlmacenObjetos<Empleado>(4);
            AlmacenObjetos<String> archivosString = new AlmacenObjetos<String>(4);
            archivosString.agregar("Adam");
            archivosString.agregar("Adam1");
            archivosString.agregar("Adam2");
            archivosString.agregar("Adam3");


            string nombrePersona = archivosString.getObjeto(2);   /* Haciendo casting a string, porque el metodo "getObjeto" 
                                                                     * me devuelve un object y estoy tratando de guardarlo en una variable
                                                                     * de tipo string */
            Console.WriteLine(nombrePersona);  



            archivos.agregar(new Empleado(5000));     // Agregando el empleado directamente al array, sin instanciarlo primero

            archivos.agregar(new Empleado(4000));
            archivos.agregar(new Empleado(6000));
            archivos.agregar(new Empleado(7000));

            Empleado empleado = archivos.getObjeto(3);
            Console.WriteLine(empleado.getSalario());      /* Me esta devolviendo el salaro del empleado que esta en la posicion 5
                                                            * del array */


            //     CLASE GENERICA
            /*Pude que un array de una misma clase "AlmacenObjetos almacene diferente tipos de dato (Empleados, strings ) 
             Sin necesidad de hacer ningun tipo de casting */

            AlmacenObjetos<DateTime> archivosDateTime = new AlmacenObjetos<DateTime>(4);   /* Tambien puedo usar date time
                                                                                            * siempre especificandolo dentro de
                                                                                            * <> el tipo de dato 
                                                                                            * (Otro ejemplo de que puedo usar
                                                                                            * cualquier tipo de dato
                                                                                            * con clases genericas */
            archivosDateTime.agregar(new DateTime());
            archivosDateTime.agregar(new DateTime());
            archivosDateTime.agregar(new DateTime());
            archivosDateTime.agregar(new DateTime());
            DateTime nombreDateTime = archivosDateTime.getObjeto(2);
            Console.WriteLine(nombreDateTime);
        }
    }

    class AlmacenObjetos<T>
    {
        private  T [] datosElemento;
        private int y = 0;                     
        public AlmacenObjetos(int z)      
        {
            datosElemento = new T[z];   
        }

        public void agregar(T obj)  
        {
            datosElemento[y] = obj;
            y++;
        }

        public T getObjeto(int i)   
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
