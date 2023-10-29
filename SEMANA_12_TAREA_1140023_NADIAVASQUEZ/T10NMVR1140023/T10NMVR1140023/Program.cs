using System;

class Program
{
    static void Main(string[] args)
    {
        TrianguloRectangulo objTriangulo;
        Console.WriteLine("Tarea semana 12");
        Console.WriteLine("Ingresar la longitud del cateto ");
        double catetoA = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Ingresar la longitud del ángulo opuesto ");
        double anguloOpuestoA = Convert.ToDouble(Console.ReadLine());
        objTriangulo = new TrianguloRectangulo(catetoA, anguloOpuestoA);

   
        Console.WriteLine("Cateto A: " + objTriangulo.ObtenerCatetoA() + " m");
        Console.WriteLine("Cateto B: " + objTriangulo.ObtenerCatetoB() + " m");
        Console.WriteLine("Hipotenusa: " + objTriangulo.ObtenerHipotenusa() + " m");
        Console.WriteLine("Angulo opuesto de A: " + objTriangulo.ObtenerAnguloOpuestoA() + " grados");
        Console.WriteLine("Angulo opuesto de B: " + objTriangulo.ObtenerAnguloOpuestoB() + " grados");
        Console.WriteLine("Area: " + objTriangulo.ObtenerArea() + " m^2");
    }
    public class TrianguloRectangulo
    {
        private double anguloOpuestoA { get; set; }

        private double catetoA { get; set; }


        public TrianguloRectangulo()
        {
            catetoA = 0;
            anguloOpuestoA = 0;
        }

        public TrianguloRectangulo(double catetoA, double anguloOpuestoA)
        {
            
            this.catetoA = catetoA;
            this.anguloOpuestoA = anguloOpuestoA;
        }

       
        public double ObtenerCatetoA()
        {
            return catetoA;
        }

     
        public double ObtenerCatetoB()
        {
            double catetoB = catetoA / Math.Tan(anguloOpuestoA * Math.PI / 180.0);
            return Math.Round(catetoB, 3);
        }

       
        public double ObtenerHipotenusa()
        {
            double catetoB = ObtenerCatetoB();
            double hipotenusa = Math.Sqrt(catetoA * catetoA + catetoB * catetoB);
            return Math.Round(hipotenusa, 3);
        }
        public double ObtenerArea()
        {
            double catetoB = ObtenerCatetoB();
            double area = 0.5 * catetoA * catetoB;
            return Math.Round(area, 3);
        }

        public double ObtenerAnguloOpuestoA()
        {
            return anguloOpuestoA;
        }
       

        public double ObtenerAnguloOpuestoB()
        {
            return 90 - anguloOpuestoA;
        }

        
       
    }
}