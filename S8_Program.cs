using System;

namespace s8_String
{
    class Program
    {
        static void Main(string[] args)
        {
            //https://youtu.be/ZH-qP9W3GTk
            int contador = 0;
            Console.WriteLine("-----ingrese una frase  :  ");
            string frase = Console.ReadLine();
            frase = frase.ToUpper();
            string[] fraseU = { frase};
           

            Console.WriteLine("ingrese una palabra de la frase anteriormente ingresada   :  ");
            string palabra = Console.ReadLine();
            palabra = palabra.ToUpper();
            string[] palabraU = { palabra };



            string[] palaFrase = frase.Split(' ');

            for (int i = 0; i < palaFrase.Length; i++)
            {

                if (palaFrase[i] == palabra)
                {
                    contador += 1;
                    Console.WriteLine("encontrada la palabra ingresada en la pos:" + i  );
                }
               
               


            }
            Console.WriteLine("el número de veces:" + contador);





        }
    }
    
}
