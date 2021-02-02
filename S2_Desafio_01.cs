using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S2_T1
{
    class Program
    {
        static void Main(string[] args)
        {    // tarifas parque arví 
            //Entrada 

            double salario = 908526;

            // Entrada del usuario de la variable X (smmlv)
            Console.Write("Ingrese su salario  X: ");
            double x = double.Parse(Console.ReadLine());

            if (x < salario * 2)
            {
                Console.WriteLine("Usted es tarifa A y debe pagar 2.500 pesos ");
            }
            else if ( salario * 2 <= x && x < salario * 4 ) 
            {
                Console.WriteLine("Usted es tarifa B y debe pagar 4.200 pesos ");
            }
            else if(salario * 4 <= x )
            {
                Console.WriteLine("Usted es tarifa c y debe pagar 10.800 pesos ");

            }
        }
    }
}
