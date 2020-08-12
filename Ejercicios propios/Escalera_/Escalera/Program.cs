using System;


namespace Escalera
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(Escalones(10));
        }
        public static int Escalones(int n)
        {
            int a = 0;
            int b = 1;
            
            for (int i = 0; i < n+1; i++)
            {
                int temp = a;
                a = b;
                b = temp + b;
            }
            return a;
        }
    }
}
