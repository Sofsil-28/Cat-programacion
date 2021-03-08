using System;

namespace S6_Tutoría
{
    class Program
    {
        static void Main(string[] args)
        {
          

            Random aleatorio = new Random();

            Console.Write("¿Cuantos jugadores hay ?:  ");
            int jugadores = int.Parse(Console.ReadLine());

            string[] nombres = new string[jugadores];
            int[] Puntajes = new int[jugadores];



          
            int contador = 0;
            int maximo = 0;
            double Ganador = 0;

            for(int i = 0;i<jugadores ;i++)
            {
                Console.WriteLine("por favor ingrese el nombre del jugador numero :  " + i+1);
                nombres[i] = Console.ReadLine();
            }


            if (jugadores >= 2 && jugadores <= 5)
            {
                while (contador < jugadores)

                {

                    Console.WriteLine("\n\nBienvenido jugador " + (nombres[contador]));


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

                    Puntajes[contador] = total;
                    contador++;

                    
                }

                for (int j = 0; j < Puntajes.Length; j++)
                {
                    for (int i = 0; i < Puntajes.Length - 1; i++)
                    {
                        if (Puntajes[i] < Puntajes[i + 1])
                        {
                            int tmp = Puntajes[i];
                            Puntajes[i] = Puntajes [i + 1];
                            Puntajes[i + 1] = tmp;

                            string tmn = nombres[i];
                            nombres[i] = nombres[i + 1];
                            nombres[i + 1] = tmn;


                        }


                    }

                }

                for (int n = 0; n < jugadores; n++)
                {

                 
                    Console.WriteLine(" jugador: " + nombres[n] + "\nTotal puntaje:" + Puntajes[n]  );
                }

                Console.WriteLine("Ganó el jugador: " + (nombres[0] +"\n El segundo puesto es: "+ nombres[1]));
            }
           
            else
            {
                Console.WriteLine("No juega ");
            }

        }
    }
}
