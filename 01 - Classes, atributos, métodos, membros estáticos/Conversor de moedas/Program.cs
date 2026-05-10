using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Conversor_de_moedas
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Qual é a cotação do dolar atual?  ");
            double cotacao = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            Console.Write("Quantos dólares você vai comprar? ");
            double compra = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double resultado = Calculadora.ValorAPagar(cotacao,compra);

            Console.WriteLine("Valor a ser pago em reais = " + resultado.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
