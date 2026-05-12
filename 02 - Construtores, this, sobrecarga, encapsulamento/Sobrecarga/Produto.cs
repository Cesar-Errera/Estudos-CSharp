using System.Globalization;

namespace Exercicio_Estoque
{
    internal class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;


        //Construtor 
        public Produto(string nome, double preco, int quantidade)
        {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        //Sobrecarga!! Construtor na mesma classe
        //com o mesmo nome do primeiro construtor
        public Produto(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
            Quantidade = 0; // ou pode excluir essa linha pq é padrão
        }

        // Métodos
        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }

        public void AdicionarProdutos(int quantidade)
        {
            Quantidade = Quantidade + quantidade;
        }

        public void RemoverProdutos(int quantidade)
        {
            Quantidade = Quantidade - quantidade;
        }

        public override string ToString()
        {
            return Nome
                + ", $ "
                + Preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                + Quantidade
                + " unidades, Total: $ "
                + ValorTotalEmEstoque();
        }

    }
}

