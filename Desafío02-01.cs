using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Entradas 

            // Variable y 
            Console.Write("Ingrese el valor y: ");
            double y = double.Parse(Console.ReadLine());


            //Variable z 
            Console.Write("Ingrese el valor z: ");
            double z = double.Parse(Console.ReadLine());

            //proceso

            //Encontrar  la hipotenusa "t"
            double t = Math.Sqrt((y * y) + (z * z));
            Console.WriteLine("La hipotenusa es igual a: " + t);

            //Encontrar ángulo c
            double c = Math.Asin(z / t);
            double cGrad = c * 180.0/Math.PI ;
            Console.WriteLine("El ángulo c es igual a:  " + cGrad);

            //Encontrar el ángulo a

            double a = 180 - (cGrad + 90);
            Console.WriteLine("El ángulo a es igual:  " + a);


        }
    }
}
