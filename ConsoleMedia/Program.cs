using System;

namespace ConsoleMedia
{
    class Program
    {
        static void Main(string[] args)
        {
            //Inserir nome
            
            Console.WriteLine("Escreva seu nome:");
            string nome = Console.ReadLine();

            //Fornecimento das 3 notas 

            Console.WriteLine("Escreva sua primeira nota:");
            float nota1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Escreva sua segunda nota:");
            float nota2 = float.Parse(Console.ReadLine());

            Console.WriteLine("Escreva sua terceira nota:");
            float nota3 = float.Parse(Console.ReadLine());

            //Cálculo da média

            float soma = nota1 + nota2 + nota3;

            float media = soma / 3;

            Console.WriteLine(nome + " sua média é de " + media);

            //Aviso ao usuário

            if (media >= 5)
            {
                Console.WriteLine("Parabéns, você foi aprovado");
            }
            else 
            {
                Console.WriteLine("Infelizmente, você foi reprovado");
            }
        }
    }
}
