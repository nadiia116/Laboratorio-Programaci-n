using System;

class Progrma
{
    static void Main(string[] args)
    {
        double[] vector = new double[8];

        for (int i = 0; i < vector.Length; i++)
        {
            Console.WriteLine("Ingrese un  número");
            vector[i] = int.Parse(Console.ReadLine());
            if (vector[i] > 0)
            {
                Console.WriteLine(vector[i] + " es un numero postivo");
            }
            if (vector[i] < 0)
            {
                Console.WriteLine(vector[i] + " es un numero negativo");
            }

        }
        
    }
}
   
