using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_03
{
    internal class ContaCorrente
    {
        public int Agencia { get; set; }
        public string NumeroDaConta { get; set; }
        public string NomeTitular { get; set; }
        public double Saldo { get; private set; }

        // Construtor
        public ContaCorrente(int agencia, string numerodaconta, string nometitular, double saldo)
        {
            Agencia = agencia;
            NumeroDaConta = numerodaconta;
            NomeTitular = nometitular;
            Saldo = saldo;
        }

        // Métodos
        public void Saque(double valor)
        {
            if (Saldo < valor)
            {
                throw new ArgumentException("Saldo insuficiente para o saque.");
            }
            Saldo -= valor;
        }

        public void Deposito(double valor)
        {
            Saldo += valor;
        }

        // to string
        public override string ToString()
        {
            return "\n=== Dados da conta ===" +
                    $"\nAgencia: {Agencia}" +
                    $"\nNumero da conta: {NumeroDaConta}" +
                    $"\nNome do titular: {NomeTitular}" +
                    $"\nSaldo: R$ {Saldo:F2}";
        }
    }
}
