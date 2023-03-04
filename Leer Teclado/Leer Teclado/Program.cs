using System;

namespace LeerTeclado
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Suma de dos numeros");
            Console.Write("ingresa numero 1: ");
            string dato = Console.ReadLine();
            int n1 = int.Parse(dato);

            Console.WriteLine("ingrese numero 2: ");
            dato = Console.ReadLine();
            int n2 = int.Parse(dato);
            int suma = n1 + n2;
            Console.WriteLine("el resultado es: {0}", suma);
        }

    }
}


  