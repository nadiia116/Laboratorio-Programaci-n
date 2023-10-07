using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Tarea semana 9");
        Console.Write("Ingrese un número: ");
        int num = int.Parse(Console.ReadLine());

        if (0 >= num)
        {
            Console.WriteLine("El número debe ser mayor a 0");
        }
        else
        {
            double sum = 0;
            int n = 1;

            while (n <= num)
            {
                sum += 1.0 / n;
                n++;
            }
            Console.WriteLine("La primera serie matemática es: " + sum);
        }

        
        if (0>= num)
        {
            Console.WriteLine("El número debe ser un entero mayor que 0");
        }
        else
        {
            double sum2 = 0;

            for (int N = 1; N <= num; N++)
            {
                sum2 += 1.0 / Math.Pow(2, N);

            }
            Console.WriteLine("La segunda serie matemática es: " + sum2);
        }
    }
}