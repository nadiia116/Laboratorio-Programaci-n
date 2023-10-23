

using System;
 
class Program
{
    static void Main(string[] args)
    {
        Circulo objcir;

        Console.WriteLine("Ingrese el radio del círculo: ");
        double radio = Convert.ToDouble(Console.ReadLine());
        objcir = new Circulo(radio);

        double perimetro = 0, area = 0, volumen = 0;
        

        objcir.CalcularGeometria(ref perimetro, ref area, ref volumen);

        Console.WriteLine("Perimetro: " + perimetro );
        Console.WriteLine("Área: " + area );
        Console.WriteLine("Volumen: " + volumen);
    }

   

    public class Circulo
    {
        

        private double radio { get; set; }

        public Circulo(double r)
        {
            
            this.radio = r;
        }

        private double ObtenerPerimetro(double r)
        {
            return 2 * Math.PI * r;
        }

        private double ObtenerArea(double r)
        {
            return Math.PI * Math.Pow(r, 2);
        }
        private double ObtenerVolumen(double r)
        {
            return (4 * Math.PI * Math.Pow(r, 3))/3;
        }


        public void CalcularGeometria(ref double unPerimetro, ref double unArea, ref double unVolumen)
        {
            unPerimetro = ObtenerPerimetro(radio);

            unArea = ObtenerArea(radio);

            unVolumen = ObtenerVolumen(radio);
        }
    }
}