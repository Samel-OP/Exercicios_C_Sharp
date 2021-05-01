using System;

namespace ConsoleIdade
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ecreva sua idade: ");
            int idade = int.Parse(Console.ReadLine());

            int meses = idade * 12;
            Console.WriteLine("Sua idade em meses é: " + meses);

            int dias = idade * 365;
            Console.WriteLine("Sua idade em dias é: " + dias);

            int horas = idade * 8760;
            Console.WriteLine("Sua idade em horas é: " + horas);

            int minutos = idade * 525600;
            Console.WriteLine("Sua idade em minutos é: " + minutos);
        }
    }
}
