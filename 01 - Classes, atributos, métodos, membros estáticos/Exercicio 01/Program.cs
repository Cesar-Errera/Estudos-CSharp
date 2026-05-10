using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoa p1 = new Pessoa();
            Pessoa p2 = new Pessoa();

            Console.Write("Digite o nome do funcionário 1: ");
            p1.Nome = Console.ReadLine();
            Console.Write("Digite a idade do funcionário 1: ");
            p1.Idade = int.Parse(Console.ReadLine());

            Console.Write("Digite o nome do funcionário 2: ");
            p2.Nome = Console.ReadLine();
            Console.Write("Digite a idade do funcionário 2: ");
            p2.Idade = int.Parse(Console.ReadLine());

            // Condição

            if (p1.Idade > p2.Idade)
            {
                Console.Write($"A pessoa mais velha é: {p1.Nome}");
            }
            else
            {
                Console.Write($"A pessoa mais velha é: {p2.Nome}");
            }

        }
    }
}
