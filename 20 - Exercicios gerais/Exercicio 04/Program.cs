using Exercicio_04;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            //Lista com as contas
            List<ContaCorrente> contas = new List<ContaCorrente>();
            string resp;

            do
            {
                int agencia;
                string numeroConta, nomeTitular;
                double saldo;

                Console.Write("Digite o numero da Agencia: ");

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

                contas.Add(conta);

                Console.Write("\nDeseja cadastrar outra conta? (S/N): ");
                resp = Console.ReadLine().ToUpper();

            
            } while (resp == "S");


            Console.WriteLine("\n=== Todas as Contas ===");
            foreach (ContaCorrente c in contas)
            {
                Console.WriteLine(c);
            }

            Console.Write("\nDigite o valor para depositar em todas as contas: ");
            double valorDeposito = double.Parse(Console.ReadLine());

            foreach (ContaCorrente c in contas)
            {
                c.Deposito(valorDeposito);
            }

            Console.Clear();
            Console.WriteLine("\n====== Contas Atualizadas após Deposito ======");
            foreach (ContaCorrente c in contas)
            {
                Console.WriteLine(c);
            }

            Console.ReadLine();

        }
    }
}
