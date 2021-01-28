using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarea4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Entradas 

            // Variable z "cateto opuesto"
            Console.Write("Ingrese el valor de z: ");
            double z = double.Parse(Console.ReadLine());


            //Variable c "ángulo dado"  
            Console.Write("Ingrese el valor del ángulo c : ");
            double c = double.Parse(Console.ReadLine());

            //proceso

            //pasar el ángulo c a radianes
            double cRad = c * Math.PI / 180;

            //Encontrar  t "hipotenusa" 
            double t = z / Math.Sin(cRad);
            Console.WriteLine(" El valor de la hipotenusa es igual a: " + t);

            // Encontrar cateto adyacente "y"
            double y = z / Math.Tan(cRad);
            Console.WriteLine(" El valor de y es igual a: " + y);

            //Encontrar el ángulo a

            double a = 180 - (c + 90);
            Console.WriteLine("El ángulo a es igual:  " + a);

        }
    }
}
