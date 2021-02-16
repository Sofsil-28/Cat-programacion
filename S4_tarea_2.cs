using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S4_Tarea2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random aleatorio = new Random();
            string respuesta = "s";
            int total = 0, dado1 = 0;

           

            dado1 = aleatorio.Next(1, 13);
                Console.WriteLine("Dados:" + dado1);


            total += dado1;
             Console.WriteLine("Total:" + total);

            dado1 = aleatorio.Next(1, 13);
            Console.WriteLine("Dados:" + dado1);


            total += dado1;
            Console.WriteLine("Total:" + total);

            dado1 = aleatorio.Next(1, 13);
            Console.WriteLine("Dados:" + dado1);


            total += dado1;
            Console.WriteLine("Total:" + total);

            while (respuesta == "s")
            {
                if ((dado1 % 2) == 0)
                {
                    Console.WriteLine("Perdiste ");
                    total = 0;
                    respuesta = "n";
                }
                else
                {
                    //if (dado1 = 10)

                   

                    Console.Write("Desea seguir jugando (s/n):  ");
                    respuesta = Console.ReadLine();
                    //profe no pude con el contador :c

                }

            }
        }
    }
}
