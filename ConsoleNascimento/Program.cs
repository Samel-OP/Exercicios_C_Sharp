using System;

namespace ConsoleNascimento
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Escreva seu nome: ");
            string nome = (Console.ReadLine());

            Console.Write("Escreva seu ano de nascimento: ");
            int nascimento = int.Parse(Console.ReadLine());

            Console.Write("Escreva o ano atual: ");
            int ano = int.Parse(Console.ReadLine());

            int idade = ano - nascimento;

            float semanaIdade = idade * 52;
          
            Console.Write(nome + " sua idade é " + idade + " anos");

             if (idade >= 18)
            {
                Console.WriteLine(" - Você é adulto");             
            }
            // Tentei fazer um com idoso mas não consegui ;-; else if(idade >= 60)
            //    {
            //       Console.WriteLine("Você é Idoso");  
            //    }
            else
            {
                Console.WriteLine(" - Você é menor de idade"); 
            }

            Console.WriteLine(nome + " sua idade convertida em semana é igual a " + semanaIdade + " semanas");
        }
    }
}
