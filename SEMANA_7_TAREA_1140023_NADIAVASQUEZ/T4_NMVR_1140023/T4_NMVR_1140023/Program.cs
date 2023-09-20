using System;
using System.ComponentModel.Design;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Tarea: Problema 1");
        Console.WriteLine("Ingrese la Velocidad final (m/s), si no cuenta con el dato coloque: NA");
        string vef = Console.ReadLine();
     

        Console.WriteLine("Ingrese la Velocidad inicial (m/s), si no cuenta con el dato coloque: NA");
        string veo = Console.ReadLine();
        

        Console.WriteLine("Ingrese la aceleracion (m/s^2), si no cuenta con el dato coloque: NA");
        string ace = Console.ReadLine();
        

        Console.WriteLine("Ingrese el tiempo (s), si no cuenta con el dato coloque: NA");
        string tp = Console.ReadLine();


        if (vef != "NA" && veo != "NA" && ace != "NA" && tp != "NA")
        {
            Console.WriteLine("Error: solo debe ingresar tres de las cuatro variables");
        } 
        else
        {
            if (vef == "NA" && veo == "NA" && ace == "NA" && tp == "NA")
            {
               Console.WriteLine("Error: debe ingresar tres de las cuatro variables");
            }
            else if (vef=="NA")
            {
                decimal vo = Convert.ToDecimal(veo);
                decimal a = Convert.ToDecimal(ace);
                decimal t = Convert.ToDecimal(tp);
                decimal resultadovef = vo + (a * t);
                Console.WriteLine("Resultado de la velocidad final en (m/s): " + resultadovef );

            }
            else if (veo == "NA")
            {
                decimal vf = Convert.ToDecimal(vef);
                decimal a = Convert.ToDecimal(ace);
                decimal t = Convert.ToDecimal(tp);
                decimal resultadoveo = vf - (a * t);
                Console.WriteLine("Resultado de la velocidad final en (m/s): " + resultadoveo);

            }
            else if (ace == "NA")
            {
                decimal vf = Convert.ToDecimal(vef);
                decimal vo = Convert.ToDecimal(veo);
                decimal t = Convert.ToDecimal(tp);
                decimal resultadoace = (vf - vo) / t;
                Console.WriteLine("Resultado de la aceleracion en (m/s^2): " + resultadoace);

            }
            else if (tp == "NA")
            {
                decimal vf = Convert.ToDecimal(vef);
                decimal vo = Convert.ToDecimal(veo);
                decimal a = Convert.ToDecimal(ace);
                decimal resultadotp = (vf - vo) / a;
                Console.WriteLine("Resultado del tiempo en (s): " + resultadotp);

            }
        }
        
       

    }
}
