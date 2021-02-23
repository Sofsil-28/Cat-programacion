using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S5_Tut
{
    class Program
    {
        static void Main(string[] args)
        {
            //inicio
            Random random = new Random();
            int a = random.Next(0, 11);
            Console.WriteLine("a:" + a);
            int b = random.Next(0, 11);
            Console.WriteLine("b:" + b);
            int sumacorrecta = a + b;

            Console.Write("¿cuanto es la suma de a + b ? :  ");

            int respuesta = int.Parse(Console.ReadLine());
            int contador = 0;

            while (contador < 2 && respuesta != sumacorrecta)
            {
                Console.WriteLine("Validación incorrecta no puede continuar  :");
                contador += 1;

                a = random.Next(0, 11);
                Console.WriteLine("a:" + a);
                b = random.Next(0, 11);
                Console.WriteLine("b:" + b);
                sumacorrecta = a + b;

                Console.Write("¿cuanto es la suma de a + b ? :  ");

                respuesta = int.Parse(Console.ReadLine());



            }

            if (contador >= 2)
            {
                Console.WriteLine("perdiste :");
            }

            if (respuesta == sumacorrecta)
            {
                Console.WriteLine(" puede continuar  :");
            }





        }
    }
}
