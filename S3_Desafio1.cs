using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana_4
{
    class Program
    {
		static void Main(string[] args)
		{
			// Entrada 

			// Entrada de las variables 

			Console.Write("Ingrese su salario  : ");
			int salario = int.Parse(Console.ReadLine());

			Console.Write("Ingrese tipo de contrato: ");
			int contrato = int.Parse(Console.ReadLine()); // 1 = Independiente | 2 = Dependiente



			double smmlv = 908526;
			double basec = 0;
			double Eps;
			double Pension;
			double Arl = 0;
			double deducciones;
			double SalarioReal;
			double SalarioAnual;

			if (salario >= smmlv)
			{
				basec = salario * 40 / 100;
			}
			if (salario < smmlv)
			{
				basec = smmlv;
			}

			// Entradas adicionales...
			switch (contrato)
			{
				case 1:
					// Independiente
					Console.Write("Ingrese un numero de 1 a 5 equivalente a la clase de riesgo: ");
					int riesgo = int.Parse(Console.ReadLine());
					switch (riesgo)
					{
						case 1:
							Arl = basec * 05.22 / 100;

							Console.WriteLine("Usted debe pagar " + Arl + " pesos de ARl   ");
							break;

						case 2:
							Arl = basec * 1.044 / 100;

							Console.WriteLine("Usted debe pagar " + Arl + " pesos de ARl   ");
							break;
						case 3:
							Arl = basec * 2.436 / 100;

							Console.WriteLine("Usted debe pagar " + Arl + " pesos de ARl   ");
							break;
						case 4:
							Arl = basec * 4.350 / 100;

							Console.WriteLine("Usted debe pagar " + Arl + " pesos de ARl   ");
							break;
						case 5:
							Arl = basec * 6.960 / 100;

							Console.WriteLine("Usted debe pagar " + Arl + " pesos de ARl   ");
							break;
					}


					Eps = basec * 12.5 / 100;
					Console.WriteLine("Usted debe pagar " + Eps + " pesos de EPS   ");

					Pension = basec * 16 / 100;
					Console.WriteLine("Usted debe pagar " + Pension + " pesos de Pensión   ");

					deducciones = Arl + Eps + Pension;
					Console.WriteLine("Usted tiene " + deducciones + "pesos de deducciones  ");

					SalarioReal = salario - deducciones;
					Console.WriteLine("Usted tiene " + SalarioReal + "pesos de Salario al mes   ");

					SalarioAnual = SalarioReal * 12;
					Console.WriteLine("Usted tiene " + SalarioAnual + "pesos de Salario Anual    ");
					break;


				case 2:
					// Dependiente

					Arl = 0;

					Eps = basec * 4 / 100;
					Console.WriteLine("Usted debe pagar " + Eps + " pesos de EPS   ");

					Pension = basec * 4 / 100;
					Console.WriteLine("Usted debe pagar " + Pension + " pesos de Pensión   ");

					deducciones = Arl + Eps + Pension;
					Console.WriteLine("Usted tiene " + deducciones + "pesos de deducciones  ");

					SalarioReal = salario - deducciones;
					Console.WriteLine("Usted tiene " + SalarioReal + "pesos de Salario al mes   ");

					SalarioAnual = SalarioReal * 12 + salario;
					Console.WriteLine("Usted tiene " + SalarioAnual + "pesos de Salario Anual    ");

					break;
			}






		}
    }
}
