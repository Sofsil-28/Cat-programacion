using System;

namespace S5_t01
{
    class Program
    {
        static void Main(string[] args)
        {
            //https://upbeduco-my.sharepoint.com/:p:/g/personal/sofia_silvaa_upb_edu_co/EQyCNisxFLtCgzrryKGlRugBHidGpMGF5k3WrKIjuPa-wA?e=yq5ppM
            Random aleatorio = new Random();
            
            Console.Write("¿Cuantos jugadores hay ?:  ");
            double jugadores = double.Parse(Console.ReadLine());

            jugadores = 6;
            int contador = 0;
            int maximo = 0;
            int Ganador = 0;

            if (jugadores >=2 && jugadores <= 5)
            {
                while (contador < jugadores)

                {

                    Console.WriteLine("\n\nBienvenido jugador " + (contador + 1));


                    string respuesta = "s";
                    int total = 0, carta1 = 0, carta2 = 0, carta3 = 0;
                    carta1 = aleatorio.Next(1, 11);
                    Console.WriteLine("Cartas:" + carta1);
                    carta2 = aleatorio.Next(1, 11);
                    Console.WriteLine("Cartas:" + carta2);

                    total += carta1 + carta2;
                    Console.WriteLine("Total:" + total);

                    Console.Write("Desea parar   (s/n):  ");
                    respuesta = Console.ReadLine();

                    if (respuesta == "s")
                    {
                        Console.WriteLine("Blackjack");
                    }
                    else
                    {
                        Console.Write("Desea más cartas  (s/n):  ");
                        respuesta = Console.ReadLine();
                        while (respuesta == "s")
                        {

                            carta3 = aleatorio.Next(1, 11);

                            Console.WriteLine("Cartas:" + carta3);

                            total += carta3;
                            Console.WriteLine("Total:" + total);

                            if (total > 21)
                            {
                                Console.WriteLine("you lose ");
                                total = 0;
                                respuesta = "n";
                            }
                            else
                            {
                                Console.Write("Desea más cartas  (s/n):  ");
                                respuesta = Console.ReadLine();
                            }
                            if (respuesta == "n")
                            {
                                Console.WriteLine("Blackjack");
                            }
                        }
                    }

                    if (total > maximo)
                    {
                        maximo = total;
                        Ganador = contador;
                    }
                    contador++;

                }

                Console.WriteLine("Ganó el jugador: " + (Ganador + 1));

            }
            else
            {
                Console.WriteLine("No juega ");
            }
           

        }
    }
}
