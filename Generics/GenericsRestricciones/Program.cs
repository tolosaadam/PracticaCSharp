using System;

namespace GenericsRestricciones
{
    class Program
    {
        static void Main(string[] args)
        {

            AlmacenEmpleados<Director> empleados = new AlmacenEmpleados<Director>(3);
            empleados.agregar(new Director(2500));     //Agrego a la lista del array los diferentes "Directores"
            empleados.agregar(new Director(3500));
            empleados.agregar(new Director(4500));

            Director empleado1 = empleados.getEmpleado(0);    /* Le digo que empleado1 es lo que me devuelve el array
                                                               * de AlmacenEmpleados<Director> en la posicion 0*/
            Console.WriteLine(empleado1.getSalario());        /* Y aca imprimo en pantalla el metodo para obtener el salario
                                                               * del empleado1 */
             

            
            /*  AlmacenEmpleados<Estudiante> estudiantes = new AlmacenEmpelados<Estudiante>(3);
             *  Esto me da error porque no puedo guardar en la clase "AlmacenEmpleados" una clase que no implemente
             *  el metodo de la interfaz 'IparaEmpleados' como lo defini anteriormente en la clase 
             *    "" class AlmacenEmpelados <T> where T : IParaEmpleados "" */



        }
    }

    class AlmacenEmpleados <T> where T : IParaEmpleados /* Usando restricciones dentro de las clases genericas
                                                         * Esta clase es capaz de almacenar objetos de diferentes tipos
                                                         * porque es generica, pero estos objetos esta obligados a implementar
                                                         * la intefaz 'IparaEmpleados'  (Osea a objetos obligados a tener salario)*/
            {

        private int y = 0;
        private T[] datosEmpleado;
        public AlmacenEmpleados(int z)
        {
            datosEmpleado = new T[z];

        }
        public void agregar(T obj)
        {
            datosEmpleado[y] = obj;
            y++;
        }
        public T getEmpleado(int y)
        {
            return datosEmpleado[y];
        }
    }
    interface IParaEmpleados
    {
        double getSalario();
    }
    class Director: IParaEmpleados
    {
        private double salario;
        public Director(double salario)
        {
            this.salario = salario;
        }
    
        public double getSalario()
        {
            return salario;
        }
    }

    class Secretaria : IParaEmpleados
    {
        private double salario;
        public Secretaria(double salario)
        {
            this.salario = salario;
        }
        public double getSalario()
        {
            return salario;
        }
    }

    class Electricista : IParaEmpleados
    {
        private double salario;
        public Electricista(double salario)
        {
            this.salario = salario;
        }
        public double getSalario()
        {
            return salario;
        }
    }

    class Estudiante
    {
        private double edad;
        public Estudiante(double edad)
        {
            this.edad = edad;
        }
        public double getEdad()
        {
            return edad;
        }
    }
}
