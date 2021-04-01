using System;
using System.Collections.Generic;

namespace Exercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa teste1 = new Pessoa();

            teste1.numeroPreferido = 1;
            teste1.nome = "janaina";
            teste1.cidade = "Araras";



            Console.WriteLine(teste1.EscreveTudo());



            int i = 10;
            Teste(i);
            Console.WriteLine(i);

            Teste2(teste1);
            Console.WriteLine(teste1.numeroPreferido);

            Console.ReadKey();

        }

        static void Teste(int a)
        {
            a = 5;
        }

        static void Teste2(Pessoa a)
        {
            a.numeroPreferido = 5;
        }



    }


    class Pessoa
    {
        public int numeroPreferido;
        public string nome;
        public string cidade;

        public string EscreveTudo()
        {
            return "Ola, meu nome é " + nome + " e eu moro na cidade " + cidade + " meu numero preferido é " + numeroPreferido;
        }
    }
}
