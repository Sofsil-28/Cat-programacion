using System;

namespace S6_CASA_01
{
    class Program
    {
        static void Main(string[] args)
        {
           //https://youtu.be/ldSPTJ2YnwA
            
            Random aleatorio = new Random();
            string respuesta = "s";
            int total = 0, dado = 0, dadoE = 2;
            int vida = 3;

            Console.Write("¿Desea empezar el juego ? (s/n):  ");
            respuesta = Console.ReadLine();

           

            while (respuesta == "s")
            {
               

                if (dadoE > 0)
                {
                    Console.Write("Tienes " + dadoE + " Dados especiales" + "¿Desea jugar con el dado especial ? (s/n):  ");
                    respuesta = Console.ReadLine();
                }
                if (respuesta == "s" && dadoE> 0)
                {
                    dadoE = dadoE - 1;
                    dado = aleatorio.Next(1, 13);
                    Console.WriteLine("Dado Especial :" + dado);
                }

                else
                {


                    dado = aleatorio.Next(1, 7);
                    Console.WriteLine("Dado:" + dado);
                }
                
                    total += dado;
                    Console.WriteLine("Total:" + total);

                

                        for (int ContDado = 0; dado == 1; ContDado ++)
                        {
                             Console.WriteLine("cont1:" + ContDado);

                            bool D = (ContDado == 2);
                            

                            if (D)
                            {
                                vida = vida - 1;
                                
                                total = total - 10;

                                ContDado = 0;
                                D = false;
                               dado = 0; 
                            }

                            


                        }
                        

                        for (int ContDado = 0; dado == 6; ContDado += 1)
                        {
                            bool F = (ContDado == 2);

                            if (F)
                            {
                                vida = vida + 1;
                               
                                ContDado = 0;
                                F = false;
                                

                                
                            }
                            dado = 0;
                        }

                if (vida == 4)
                {
                    vida = 3;
                }

                Console.WriteLine("vidas:" + vida);
                if (vida == 0)
                {


                    Console.WriteLine("Perdiste ");

                    respuesta = "n";
                }

                else
                {
                    if (total >= 100)
                    {
                        Console.WriteLine("Ganaste");

                        respuesta = "n";
                    }


                    Console.Write("Desea seguir jugando (s/n):  ");
                    respuesta = Console.ReadLine();

                }

            }

        }
    }
}
