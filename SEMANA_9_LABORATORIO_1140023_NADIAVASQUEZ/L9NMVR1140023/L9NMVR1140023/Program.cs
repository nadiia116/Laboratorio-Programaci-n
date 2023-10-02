using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ingrese un numero ");
        int n = Convert.ToInt32(Console.ReadLine());
        string texto = "";
        if (n>0)
        {
            int contador =1;
            int sumatoria = 0;

            while (contador <= n)
            {
                texto = texto + contador + "+";
                sumatoria= sumatoria + contador;
                contador++;
                
            }
            Console.WriteLine(texto);

        }
        
            for (int i = 1; i <= 10; i++)
            {
                Console.Write("\nTabla del " + i + ":\t");
                for (int j = 1; j <= n; j++)
                {
                    Console.Write(i * j + "\t");
                }
            }
            Console.ReadLine();
        }
    }


