using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarea3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Entradas 

            // Variable t "hipotenusa"
            Console.Write("Ingrese el valor de t: ");
            double t = double.Parse(Console.ReadLine());


            //Variable a  
            Console.Write("Ingrese el valor del ángulo a : ");
            double a = double.Parse(Console.ReadLine());

            //proceso

            //pasar el ángulo a a radianes
            double aRad = a * Math.PI / 180;

            //Encontrar  cateto opuesto "y"
            double y = t * Math.Sin(aRad);
            Console.WriteLine(" El valor de y es igual a: " + y);

            // Encontrar cateto adyacente "z"
            double z = t * Math.Cos(aRad);
            Console.WriteLine(" El valor de z es igual a: " + z);

            //Encontrar el ángulo c

            double c = 180 - (a + 90);
             Console.WriteLine("El ángulo c es igual:  " + c);

            

        }
    }
}
