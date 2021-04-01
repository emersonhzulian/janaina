using System;

namespace Forca
{
    class Program
    {
        static void Main(string[] args)
        {
            string palavra;
            char letra;

            Console.WriteLine("escolha uma palavra");

            palavra= Console.ReadLine();
            
            Console.WriteLine("tem "+ palavra.Length + " letra");

            DesenhaForca(palavra.Length);

            Console.WriteLine("escolha uma letra");

            letra = Console.ReadKey().KeyChar;

            Console.WriteLine(letra);

            Console.WriteLine("-------------------");

            for(int i= 0; i < palavra.Length; i++)
            {
                if(letra == palavra[i])
                { 

                }
            }

        
        }

        static void DesenhaForca(int qtdLetras)
        {
            for (int i = 0; i<qtdLetras; i++)
            {
                Console.Write("_");
            }
            Console.WriteLine();
        }
    }
}
