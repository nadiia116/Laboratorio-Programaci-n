class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ingrese un numero ");
        int n = Convert.ToInt32(Console.ReadLine());
        int A = 0; int B=1; int C = 0;  int i = 2;
        string resultado= " ";
        if(n>0)
        {
            resultado = A.ToString();

            if (n > 1)
            {
                resultado += B.ToString();
                while (i>n)
                {
                    C = A + B;
                    resultado += C.ToString();
                    A=B; B=C;
                    i = i + 1;

                }
                Console.WriteLine("Resultado " + resultado);
            }
            else
            {
                Console.WriteLine("Resultado " + resultado);
            }
        }
        else
        {
            Console.WriteLine("Resultado " +resultado);
        }
    }
}
//        Console.WriteLine("Laboratoio Semana 8");
//        Console.WriteLine("\n Ingrese un numero");

//        int num = Convert.ToInt32(Console.ReadLine());
//        while (num != 0)
//        {
//            Console.WriteLine("El numro ingresado es:" + num);
//            if (num > 0)
//            {
//                Console.WriteLine("\nPositivo");
//            }
//            else if (num < 0)
//            {
//                Console.WriteLine("\nNegativo");
//            }
//            Console.WriteLine("\n Ingrese otro numero");
//            num = Convert.ToInt32(Console.ReadLine());

//        }

//    }     
//}

//    //do
//        //{
//        //    Console.WriteLine("El numro ingresado es:" + num);
//        //    Console.WriteLine("\n Ingrese otro numero");

//        //    num = Convert.ToInt32(Console.ReadLine());

//        //} while (num != 0);