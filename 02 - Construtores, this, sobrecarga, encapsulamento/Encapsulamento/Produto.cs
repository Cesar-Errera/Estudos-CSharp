using System.Globalization;

namespace Encapsulamento
{
    internal class Produto
    {
        // no privado usamos por padrão _XXX
        private string _nome;
        private double _preco;
        private int _quantidade;

        // ---------------------------------------------------------------

        //Construtores
        public Produto()
        {

        }

        public Produto(string nome, double preco, int quantidade)
        {
            _nome = nome;
            _preco = preco;
            _quantidade = quantidade;
        }

        // ------------------------------------------------------------------

        // Encapsulamento

        //usando Get() - nome
        public string GetNome()
        {
            return _nome;
        }

        //usando Set() - nome
        public void SetNome(string nome)
        {
            if (nome != null && nome.Length > 1) // impede nome nulo e menor que 1 caracter
            {
                _nome = nome;
            } 
        }

        public double GetPreco()
        {
            return _preco;
        }

        public int GetQuantidade()
        {
            return _quantidade;
        }

        // ------------------------------------------------------------------------------

        // Métodos
        public double ValorTotalEmEstoque()
        {
            return _preco * _quantidade;
        }

        public void AdicionarProdutos(int quantidade)
        {
            _quantidade += quantidade;
        }

        public void RemoverProdutos(int quantidade)
        {
            _quantidade -= quantidade;
        }

        public override string ToString()
        {
            return _nome
                + ", $ "
                + _preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                + _quantidade
                + " unidades, Total: $ "
                + ValorTotalEmEstoque();
        }

    }
}
