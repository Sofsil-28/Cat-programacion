using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S5_Tarea_Euler
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.Write("Ingrese el valor de x:  ");
            double x = double.Parse(Console.ReadLine());


            int n = 100;
            double s = 0,d = -1;
            
            //double x = 3;


            //e es igual a 
            for (int r = 0; r <= n; r++)
            {


                //double y = Factorial(x);

                //sumatoria

                s += (Math.Pow(d, r) / Factorial((2*r) + 1)* Math.Pow(x, (2*r)+1));
                

                Console.WriteLine("\nIteracion" + r);
                Console.WriteLine(s);

            }

            // Factorial 

            static double Factorial(double valor)
            {

                double total = 1;
                for (int i = 1; i <= valor; i++)
                {
                    total *= i;



                }
                return total;
            }
        }
    }
}