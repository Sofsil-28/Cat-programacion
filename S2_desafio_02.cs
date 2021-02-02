using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S2_t2
{
    class Program
    {
        static void Main(string[] args)
        {
            // entradas 
            // salario mensual (s)

            double s = 908526;

            //salario diario (d)
            double d = 30284.20;

            //cuota
            double cuota; 

            // entrada de la variable z
            Console.Write("Ingrese su salario  z: ");
            double z = double.Parse(Console.ReadLine());

            if (z < s * 2)
            {
                cuota = d * 11.7 / 100;
                Console.WriteLine("Usted es tarifa A ");
                Console.WriteLine("Usted debe pagar " + cuota + " pesos de cuota moderadora  ");
            }
            else if (s * 2 <= z && z < s * 5)
            {
                cuota = d * 46.10 / 100;
                Console.WriteLine("Usted es tarifa B ");
                Console.WriteLine("Usted debe pagar " + cuota + " pesos de cuota moderadora  ");
            }
            else  if (s * 5 <= z)
            {
                cuota = d * 121.50 / 100;
                Console.WriteLine("Usted es tarifa C ");
                Console.WriteLine("Usted debe pagar " + cuota + " pesos de cuota moderadora  ");
            }
        }
        
    }
}
