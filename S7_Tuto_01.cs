using System;

namespace S7_Tutoria_01
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nombres = { "Nezuko", "Tanjiro", "Zenitsu", "Inosuke", "Genya", "Kanao", "Tomioka" };
            double[] estatura = { 153, 165, 164.5, 164, 180, 156, 176 };

            
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


            //distancia

            double total2 = 0;

            for (int i = 0; i < estatura.Length; i += 1)
            {
                total2 += estatura[i];
                Console.WriteLine(total2);
            }
            double promedio2 = total2 / estatura.Length;
            Console.WriteLine(promedio2);

            double[] distancia = new double[estatura.Length];

            //Nombre y estatura más cerca al promedio 

            int indice = 0;
            for (int i = 0; i < distancia.Length; i += 1)
            {
                distancia[i] = Math.Abs(estatura[i] - promedio2);
                Console.WriteLine(distancia[i]);

                if (distancia[i] < min)
                {
                    min = distancia[i]; indice = i;
                }

            }

            Console.WriteLine(nombres[indice]);

            //tutoría semana 7 
            Console.WriteLine("------tutoría semana 7 ------");
            //ordenar estaturas de forma ascendente

            Console.WriteLine("------estaturas forma ascendente------");

           

            for (int j = 0; j< estatura.Length; j++)
            {
                for (int i = 0; i < estatura.Length - 1; i++)
                {
                    if (estatura[i] < estatura[i + 1])
                    {
                        double tmp = estatura[i];
                        estatura[i] = estatura[i + 1];
                        estatura[i + 1] = tmp;

                        string tmn = nombres[i];
                        nombres[i] = nombres[i + 1];
                        nombres[i + 1] = tmn;

                        
                    }
                  
                    
                }
                
            }

            for (int j = 0; j < nombres .Length; j++)
            {
                Console.WriteLine(estatura[j] + nombres[j]);
            }






        }
    }
}
