using System;

namespace ConsoleNadadorDesafio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Escreva o nome do nadador: ");
            string nome = Console.ReadLine();

            Console.Write("Escreva a idade do nadador: ");
            int idade = int.Parse(Console.ReadLine());
            
            if (idade >= 5 && idade <= 7)
            {
                Console.WriteLine("Sua categoria é infantil A");   
            }
            if (idade >= 8 && idade <= 10)
            {
                Console.WriteLine("Sua categoria é infantil B");
            }
            if (idade >= 11 && idade <= 13)
            {
                Console.WriteLine("Sua categoria é juvenil A");
            }
            if (idade >= 14 && idade <= 17)
            {
                Console.WriteLine("Sua categoria é juvenil B");
            }
            if (idade >= 18)
            {
                Console.WriteLine("Sua categoria é sênior");
            }      
        }
    }
}
