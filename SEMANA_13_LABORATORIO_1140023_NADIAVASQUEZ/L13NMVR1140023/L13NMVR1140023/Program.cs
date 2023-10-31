using System;
internal class Program
{
    static void Main(string[] args)
    {
        double[] vector = new double[8];
        double suma = 0;
        double promedio = 0;
        double notamasalta = 0;
        Console.WriteLine("EJERCICIO 1");

        for (int i = 0; i < vector.Length; i++)
        {
            Console.Write("Ingrese la nota del laboratorio " + (i + 1) + ": ");
            vector[i] = double.Parse(Console.ReadLine());
            suma += vector[i];
            if (vector[i] > notamasalta) 
            {
                notamasalta = vector[i];
            }
        }
        promedio = suma / vector.Length;

        Console.WriteLine("El promedio es: " + promedio);
        Console.WriteLine("La nota mas alta es: " + notamasalta);
        Console.WriteLine("Segunda parte");

        Console.WriteLine("EJERCICIO 2");
        int contador = 0;

        Console.WriteLine("Escriba una palabra");
        string palabra = Console.ReadLine();

        Console.WriteLine("Escriba una letra");
        string letra = Console.ReadLine();


        string[] vector_palabra = new string[palabra.Length];

        for (int i = 0; i < palabra.Length; i++)
        {
            vector_palabra[i] = palabra[i].ToString();
        }

        for (int i = 0; i < vector_palabra.Length; i++)
        {
            if (vector_palabra[i].Equals(letra))
            {
                contador++;
            }
        }
        Console.WriteLine("Número de letras: " + contador);
        if (contador > 0)
        {
            Console.WriteLine("la letra existe en la palabra ingresada");
        }
        else
        {
            Console.WriteLine("La letra no existe en la palabra ingresada");
        }




    }
}














