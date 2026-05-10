using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Exercicio_Estoque
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto();

            Console.WriteLine("Entre com os dados do produto:");
            Console.Write("Nome: ");
            p.Nome = Console.ReadLine();
            Console.Write("Preço: ");
            p.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade em estoque: ");
            p.Quantidade = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine();
            Console.WriteLine("Dados do produto: " + p);

            Console.WriteLine();
            Console.WriteLine("Digite o número de produtos a ser adicionado: ");
            int qtd = int.Parse(Console.ReadLine());

            p.AdicionarProdutos(qtd);
            Console.WriteLine();
            Console.WriteLine("Dados armazenados: " + p);

            Console.WriteLine();
            Console.WriteLine("Digite o número de produtos a ser removidos: ");
            qtd = int.Parse(Console.ReadLine());

            p.RemoverProdutos(qtd);
            Console.WriteLine();
            Console.WriteLine("Dados armazenados: " + p);

        }
    }
}
