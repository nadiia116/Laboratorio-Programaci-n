using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ejercicio 1: operaciones aritmeticas");
        Console.WriteLine("Ingrese un número: ");
        string numero1 = Console.ReadLine();
        int num1= Convert.ToInt32(numero1);

        Console.WriteLine("Ingrese un número: ");
        string numero2 = Console.ReadLine();
        int num2 = Convert.ToInt32(numero2);

        Console.WriteLine("Ingrese un número: ");
        string numero3 = Console.ReadLine();
        int num3 = Convert.ToInt32(numero3);

        int suma = num1 + num2;

        Console.WriteLine("Suma: " + num1 + " + " + num2 + " = " + suma);

        int resta = num1 - num2;

        Console.WriteLine("Resta: " + num1 + " - " + num2 + " = " + resta);

        int multiplicacion = num1 * num2;

        Console.WriteLine("Multiplicación: " + num1 + " * " + num2 + " = " + multiplicacion);

        int division = num1 / num2;

        Console.WriteLine("División: " + num1 + " / " + num2 + " = " + division);

        int mod = num1 % num2;

        Console.WriteLine("Mod: " + num1 + " % " + num2 + " = " + mod);

        Console.WriteLine("Ejercicio 2: operaciones booleanas");
        if (num1 > num2)
        {
            Console.WriteLine(num1 + " es mayor que: " + num2);
        }
        else if  (num1 < num2)
        {
            Console.WriteLine(num1 + " es menor que: " + num2);
        }
        else if (num1 == num2)
        {
            Console.WriteLine(num1 + " es igual que: " + num2);
        }
        Console.WriteLine("Ejercicio 3: Jerarquía de operaciones");

        int resultado1 = num1 * (num2 + num3);
        Console.WriteLine("Resultado i: "+resultado1);

        decimal resultado2 = num1 / (num2 * num3);
        Console.WriteLine("Resultado iii: " + resultado2);
        Console.ReadKey();


    }
}