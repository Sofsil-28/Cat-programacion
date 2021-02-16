using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S4_Tarea1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random aleatorio = new Random();
            string respuesta = "s";
            int total = 0, dado1 = 0, dado2 = 0,totseis=0 ;
           
                

            while (respuesta == "s")
            {

                dado1 = aleatorio.Next(1, 7);
                Console.WriteLine("Dados:" + dado1);
                dado2 = aleatorio.Next(1, 11);
                Console.WriteLine("Dados:" + dado2);

                total += dado1 + dado2;
                Console.WriteLine("Total:" + total);

                if ( (dado1 == 1) && (dado2 == 1) )
                {
                    Console.WriteLine("Perdiste ");
                    total = 0;
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
