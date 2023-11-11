using System;
using System.Timers;

class Program
{
    static Random random = new Random();

    static void Main()
    {
        Console.Write("Ingrese la cantidad de partidas que desea jugar: ");
        int cantidadPartidas = int.Parse(Console.ReadLine());

        Console.Write("Ingrese la cantidad de tiros por partida: ");
        int tirosPorPartida = int.Parse(Console.ReadLine());

        if (tirosPorPartida %2 ==0)
        {
            int ganaParCasa = 0;
            int ganaParJugador = 0;
            int puntanjeFinalJugador = 0;


            for (int N = 0; N < cantidadPartidas; N++)
            {
                int puntajeJugador = 0;
                int puntajeCasa = 0;
                int tirosPares = 0;
                int tirosImpares = 0;
                int tirosIguales = 0;
                int tirosGanados = 0;





                Console.WriteLine("\nPartida" + (N + 1) + ":");

                for (int M = 0; M < tirosPorPartida; M=M+2)
                {
                    int dado1 = random.Next(1, 7);
                    int dado2 = random.Next(1, 7);
                    int sumaDados1 = dado1 + dado2;
                    int dado3 = random.Next(1, 7);
                    int dado4 = random.Next(1, 7);
                    int sumaDados2 = dado3 + dado4;



                    if (sumaDados1 % 2 == 0)
                    {
                        tirosPares++;
                    }
                    else
                    {
                        tirosImpares++;
                    }
                    if (sumaDados2 % 2 == 0)
                    {
                        tirosPares++;
                    }
                    else
                    {
                        tirosImpares++;
                    }
                    if (dado1 == dado2)
                    {
                        tirosIguales++;
                    }
                    if (dado3 == dado4)
                    {
                        tirosIguales++;
                    }
                    Console.WriteLine("Tiro: Dado 1: " + dado1 + " - Dado 2: " + dado2 + " - Suma: " + sumaDados1);
                    Console.WriteLine("Tiro: Dado 1: " + dado3 + " - Dado 2: " + dado4 + " - Suma: " + sumaDados2);


                    if (sumaDados1 == 12 && M == 0)
                    {
                        puntajeJugador += 12;
                        tirosGanados++;

                    }
                    else if (sumaDados1 == 6 && M == 0)
                    {
                        puntajeJugador += 12;
                        tirosGanados++;

                    }
                    else if (sumaDados1 == 4 && M == 0)
                    {
                        puntajeCasa += 12;

                    }
                    else if (sumaDados1 == 10 && M == 0)
                    {
                        puntajeCasa += 12;

                    }
                    else if (sumaDados1 == 11 && puntajeJugador == 0|| sumaDados2 == 11 && puntajeJugador == 0)
                    {
                        puntajeCasa += 6;
                        break;

                    }
                    else if  (sumaDados1 == 2|| sumaDados1 == 3|| sumaDados1 == 5|| sumaDados1 == 7|| sumaDados1 == 8|| sumaDados1 == 9)
                    {
                        puntajeJugador += sumaDados1;
                        tirosGanados++;
                    }
                    else if (sumaDados2 == 2 || sumaDados2 == 3 || sumaDados2 == 5 || sumaDados2 == 7 || sumaDados2 == 8 || sumaDados2 == 9)
                    {
                        puntajeCasa += sumaDados2;
                    }




                }
                

                if (puntajeJugador >puntajeCasa)
                {
                    Console.WriteLine("\nEl jugador gana la partida");
                    ganaParJugador++;
                }
                else if (puntajeJugador == puntajeCasa)
                {
                    Console.WriteLine("\nHay un empate, no hay ganador");
                   
                }
                else if (puntajeJugador <puntajeCasa)
                {
                    Console.WriteLine("\nLa casa gana la partida");
                    ganaParCasa++;
                }
                double probabilidad = (double)tirosGanados / tirosPorPartida * 100;
                Console.WriteLine("Tiros ganados por el jugador: " + tirosGanados);
                Console.WriteLine("Cantidad de tiros pares " + tirosPares);
                Console.WriteLine("Cantidad de tiros impares " + tirosImpares);
                Console.WriteLine("Cantidad de tiros con números iguales " + tirosIguales);
                Console.WriteLine("Probabilidad de ganar del jugador " + probabilidad+"%");
                Console.WriteLine("Puntaje del jugador: " + puntajeJugador);

                puntanjeFinalJugador += puntajeJugador;



            }
            if (ganaParJugador>ganaParCasa)
            {
                Console.WriteLine("\nGanador final: Jugador");
            }
            else
            {
                Console.WriteLine("\nGanador final: La casa");
            }
            Console.WriteLine("Punteo Final del Jugador: "+ puntanjeFinalJugador);

        }
        else
        {
            Console.WriteLine("El número de tiros debe ser par");
        }
    }
}

     
