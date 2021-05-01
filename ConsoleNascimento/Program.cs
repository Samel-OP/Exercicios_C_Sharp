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

            int ano = DateTime.Now.Year;

            int idade = ano - nascimento;

            int semanaIdade = idade * 52;

            Console.Write(nome + " sua idade é " + idade + " anos");

            if (idade >= 18 && idade <= 59)
            {
                Console.WriteLine(" - Adulto");
            }
            else if (idade > 60)
            {
                Console.WriteLine(" - Idoso");
            }
            else
            {
                Console.WriteLine(" - Menor de idade");
            }

            Console.WriteLine(nome + " sua idade convertida em semanas é igual a " + semanaIdade + " semanas");
        }
    }
}
