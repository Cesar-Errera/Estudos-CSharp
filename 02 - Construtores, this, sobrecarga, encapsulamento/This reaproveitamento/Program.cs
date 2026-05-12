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


            // Construtor de 2 argumentos
            Produto p = new Produto(nome, preco);

            // Produto p = new Produto(nome, preco,20);
            // assim também funcionaria
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
