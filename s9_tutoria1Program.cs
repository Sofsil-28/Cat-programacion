using System;

namespace s9_Tutoría01
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            string[] valores = { "-", "-", "o", "x" };
            int n = 10;
            int m = 15;
            double contadorn = 0, contadorm = 0; 

            string[,] tablero = new string[n, m];
            string[,] salida = new string[n, m];

            for (int i = 0; i < tablero.GetLength(0); i++)
            {
                for ( int j = 0; j < tablero.GetLength(1); j++)
                {
                    int indice = random.Next(0, valores.Length);
                    tablero[i, j] = valores[indice];
                    salida[i, j] = "-";
                }
            }

            Console.WriteLine("ENTRADA: ");
            for (int i = 0; i < tablero.GetLength(0); i++)
            {
                for ( int j = 0; j< tablero.GetLength(1); j++)
                {
                    Console.Write("|" + tablero[i, j]);
                }
                Console.Write("|\n");

            }

            //Proceso 
            for ( int i = 0; i < tablero.GetLength ( 0); i++)
            {
                for (int j = 0; j < tablero.GetLength(1) - 2; j++)
                {
                    if (tablero[i, j] == tablero[i, j + 1] && tablero[i, j + 1 ] == tablero[i, j +2])
                    {
                        if (tablero[i, j] == "x")
                        {
                            salida[i, j] = "1";
                            salida[i, j + 1] = "1";
                            salida[i, j + 2] = "1";
                        }
                        else if (tablero[i, j] == "o") 
                        {

                            salida[i, j] = "2";
                            salida[i, j + 1] = "2";
                            salida[i, j + 2] = "2";
                        }
                       
                    }
                    
                }
            }

                for (int i = 0; i < tablero.GetLength(0); i++)
                {
                    for (int j = 0; j < tablero.GetLength(1) ; j++)
                    {
                        if (tablero[i, j] == "x")
                    {
                        contadorm += 1; 
                    }
                        else if (tablero[i, j] == "o")
                    {
                        contadorn += 1; 
                    }

                    }
                    
                }

            double porcentajem = contadorm * 100 / (n * m);
            Console.WriteLine("porcentaje de xs" + Math.Round(porcentajem, 2));

            double porcentajen = contadorn * 100 / (n * m);
            Console.WriteLine("porcentaje de os" + Math.Round(porcentajen, 2));

            double porcentajer = 100 - (porcentajem + porcentajen);
            Console.WriteLine("porcentaje de Rayitas" + Math.Round(porcentajer, 2));

            for (int i = 0; i < tablero.GetLength(0)-2; i++)
            {
                for (int j = 0; j < tablero.GetLength(1) ; j++)
                {
                    if (tablero[i, j] == tablero[i+1, j ] && tablero[i+1, j ] == tablero[i +2, j ])
                    {
                        if (tablero[i, j] == "x")
                        {
                            salida[i, j] = "1";
                            salida[i +1, j ] = "1";
                            salida[i +2, j] = "1";
                        }
                        else if (tablero[i, j] == "o")
                        {

                            salida[i, j] = "2";
                            salida[i +1, j ] = "2";
                            salida[i + 2, j ] = "2";
                        }

                    }

                }
            }

            Console.WriteLine("\nSALIDA: ");
            for (int i = 0; i < tablero.GetLength(0); i++)
            {
                for (int j = 0; j < tablero.GetLength(1); j++)
                {
                    Console.Write("|" + salida[i, j]);
                }
                Console.Write("|\n");

            }
            Console.Write("|\n");
        }
    }
}
