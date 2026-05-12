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
            Console.WriteLine("Entre com os dados do produto:");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade em estoque: ");
            int quantidade = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            // Construtor aqui !!
            Produto p = new Produto(nome, preco, quantidade);

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
