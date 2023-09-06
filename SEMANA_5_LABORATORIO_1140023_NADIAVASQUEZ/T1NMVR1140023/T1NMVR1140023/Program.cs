using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Mi segundo programa");
        Console.WriteLine("Ingrese su nombre: ");
        string Nombre = Console.ReadLine();

        Console.WriteLine("Ingrese su edad");
        string Edad = Console.ReadLine();

        Console.WriteLine("Ingrese su carrera");
        string carrera = Console.ReadLine();
        Console.WriteLine("Ingrese su cerne");
        string carne = Console.ReadLine();

        Console.WriteLine("Nombre: " + Nombre);
        Console.WriteLine("Edad: " + Edad);
        Console.WriteLine("Carrera: " + carrera);
        Console.WriteLine("Carne: " + carne);
        Console.Write("Soy " + Nombre + " Tengo " + Edad + " años y estudio la carrera de " + carrera + " mi carne es " + carne);





    }
}