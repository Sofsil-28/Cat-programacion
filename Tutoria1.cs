using System;

namespace tarea1
{
    class Program
    {
        static void Main(string[] args)
        {
			// Entrada del usuario de la variable X1
			Console.Write("Ingrese X1: ");
			double x1 = double.Parse(Console.ReadLine());

			// Entrada del usuario de la variable Y1
			Console.Write("Ingrese Y1: ");
			double y1 = double.Parse(Console.ReadLine());

			// Entrada del usuario de las variables restantes
			// ...

			// Entrada del usuario de la variable X1
			Console.Write("Ingrese x2: ");
			double x2 = double.Parse(Console.ReadLine());

			// Entrada del usuario de la variable Y1
			Console.Write("Ingrese Y2: ");
			double y2 = double.Parse(Console.ReadLine());

			// Entrada del usuario de las variables restantes
			// ...


			double m = (y2 - y1) / (x2 - x1);

			Console.WriteLine("El equivalente de la pendiente es " + m);

			//y= mx +b 
			//y-mx = b 

			double b = (y1 - m*x1 );
			Console.WriteLine("El equivalente del intercepto es " + b);

			double d = Math.Sqrt((x2-x1)* (x2 - x1) + (y2-y1)* (y2 - y1));
			Console.WriteLine("El equivalente de la distancia " + d);
		}
	
	}
}
