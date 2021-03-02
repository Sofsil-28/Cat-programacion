using System;

namespace S6_Tutoria
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] nombres = { "Nezuko", "Tanjiro", "Zenitsu", "Inosuke", "Genya", "Kanao", "Tomioka" };
            double[] estatura = { 153, 165, 164.5, 164, 180, 156, 176 };

            double NombreC = 0;
            double min = 500;

            //promedio estatura

            double total = 0;

            total += estatura[0];
            total += estatura[1];
            total += estatura[2];
            total += estatura[3];
            total += estatura[4];
            total += estatura[5];
            total += estatura[6];

            double promedio = total / 7;
          
            Console.WriteLine("Promedio de estarura: " + promedio);

          

           

           

            double total2 = 0;

            for (int i = 0; i < estatura.Length; i += 1)
            {
             total2 += estatura[i];
             Console.WriteLine(total2);
            }
               double promedio2 = total2 / estatura.Length;
                Console.WriteLine(promedio2);

            double[] distancia = new double[estatura.Length];

            int indice = 0;
            for (int i = 0; i < distancia.Length;i +=1)
            {
                distancia[i] = Math.Abs( estatura[i] - promedio2);
                Console.WriteLine(distancia[i]);

                if (distancia[i] < min) 
                {
                    min = distancia[i]; indice = i; 
                }
                
            }

            Console.WriteLine(nombres[indice]);
          
        }
    }
}
