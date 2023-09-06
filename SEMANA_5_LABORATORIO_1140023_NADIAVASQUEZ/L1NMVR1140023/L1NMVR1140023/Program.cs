using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        /*
        Console.WriteLine("Hola mundo");
        Console.WriteLine("Soy Nadia");

        Console.Write("Hola mundo");
        Console.Write(" soy Nadia");

        Console.ReadKey();
        Console.ReadLine();*/

        Console.WriteLine("Ingrese su nombre ");
        string Nombre = Console.ReadLine();

        Console.WriteLine("Hola mundo");
        Console.WriteLine("Soy " + Nombre);

        Console.Write("Hola mundo ");
        Console.Write(" soy " + Nombre);
        Console.ReadKey();



    }
        
}