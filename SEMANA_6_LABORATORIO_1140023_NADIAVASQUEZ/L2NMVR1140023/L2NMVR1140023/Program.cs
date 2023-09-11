using System.Security.Cryptography.X509Certificates;

class Program
 
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ejercicio 2");
        int dia;
        string entrada;

        Console.WriteLine("Ingrese un numero:");
        entrada= Console.ReadLine();
        dia = Int32.Parse(entrada);
        
        if (dia != 1 && dia != 2 && dia != 3 && dia != 4 && dia != 5 && dia != 6 && dia != 7)
        {
            Console.WriteLine("Error: el numero debe estar entre 1 y 7");
        }
    
        if (dia==1)
        {
            Console.WriteLine("DIA: Lunes ");
        }
        else if (dia == 2)
        {
            Console.WriteLine("DIA: Martes ");
        }
        else if (dia == 3)
        {
            Console.WriteLine("DIA: Miercoles ");
        }
        else if (dia == 4)
        {
            Console.WriteLine("DIA: Jueves ");
        }
        else if (dia == 5)
        {
            Console.WriteLine("DIA: Viernes ");
        }
         else if (dia == 6)
        {
            Console.WriteLine("DIA: Sabado ");
        }
        else if (dia == 7)
        {
            Console.WriteLine("DIA: Domingo ");
        }
        Console.ReadKey();
    }

}