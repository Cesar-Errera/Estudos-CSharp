using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int agencia;
            string numeroConta, nomeTitular;
            double saldo;

            Console.Write("Digite o numero da gencia: ");
            agencia = int.Parse(Console.ReadLine());

            Console.Write("Digite o numero da conta: ");
            numeroConta = Console.ReadLine();

            Console.Write("Digite o nome do titular: ");
            nomeTitular = Console.ReadLine();

            Console.Write("Digite o saldo inicial: ");
            saldo = double.Parse(Console.ReadLine());

            ContaCorrente conta = new ContaCorrente(agencia, numeroConta, nomeTitular, saldo);
            Console.WriteLine(conta);

            Console.Write("\nDigite o valor do deposito: ");
            conta.Deposito(double.Parse(Console.ReadLine()));
            Console.WriteLine("Deposito realizado.");
            Console.WriteLine(conta);

            try
            {
                Console.Write("\nDigite o valor do saque: ");
                conta.Saque(double.Parse(Console.ReadLine()));
                Console.WriteLine("Saque realizado.");
                Console.WriteLine(conta);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadLine();
        }
    }
}
