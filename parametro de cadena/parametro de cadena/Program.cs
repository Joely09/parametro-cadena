using System;

namespace parametro_de_cadena
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa de cadena\n");
            Console.WriteLine("Escribe una cadena\n");
            string cadena = Console.ReadLine();
            string[] answer = new string[0];
            int f = 1;
            string[] arreglo= cadena.Split(" ");
           
            for(int i = 0;i<arreglo.Length;i++)
            {
                Console.WriteLine("Palabra {0}: {1}",i,arreglo[i]);



            }
            
        }
    }
}
