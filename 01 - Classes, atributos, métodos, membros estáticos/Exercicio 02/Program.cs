using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Funcionario f1 = new Funcionario();
            Funcionario f2 = new Funcionario();

            Console.Write("Digite o nome do funcionário 1: ");
            f1.Nome = Console.ReadLine();
            Console.WriteLine("Digite o salário do funcionario 1: ");
            f1.Salario = double.Parse(Console.ReadLine());

            Console.Write("Digite o nome do funcionário 2: ");
            f2.Nome = Console.ReadLine();
            Console.WriteLine("Digite o salário do funcionario 2: ");
            f2.Salario = double.Parse(Console.ReadLine());

            // calculo
            double medio = (f1.Salario + f2.Salario) / 2;
            Console.WriteLine($"O salário médio = {medio}");

        }
    }
}
