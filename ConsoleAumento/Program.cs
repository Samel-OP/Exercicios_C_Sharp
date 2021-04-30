using System;

namespace ConsoleAumento
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Escreva o nome do funcionário: ");
            string nome = Console.ReadLine();

            Console.Write("Escreva seu salário: ");
            float salario = float.Parse(Console.ReadLine());

            if(salario <= 500)
            {
                double aumento = salario + (salario * 0.3);
                Console.WriteLine(nome + " agora seu salário é R$" + aumento);
            }
            else
            {
                Console.WriteLine(nome + ", você não tem direito a aumento");
            }
        }
    }
}
