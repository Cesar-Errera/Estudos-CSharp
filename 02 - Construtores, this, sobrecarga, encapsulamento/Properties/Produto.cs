using System.Globalization;

namespace Properties
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

        //Propriedade
        public string Nome
        {
            get { return _nome; }
            set
            {
                if (value != null && value.Length > 1) // esse "value" é o parametro do metodo set
                {
                    _nome = value;
                }
            }
        }

        // ------------------------------------------------------------------
        public double Preco
        {
            get
            {
                return _preco;
            }
        }

        public int Quantidade
        {
            get
            {
                return _quantidade;
            }

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
