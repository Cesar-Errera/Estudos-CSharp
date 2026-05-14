using System.Globalization;

namespace Auto_Properties
{
    internal class Produto
    {
        // no privado usamos por padrão _XXX
        private string _nome;
        public double Preco { get; private set; }
        public int Quantidade { get; private set; }

        // ---------------------------------------------------------------

        //Construtores
        public Produto()
        {

        }

        public Produto(string nome, double preco, int quantidade)
        {
            _nome = nome;
            Preco = preco;
            Quantidade = quantidade;
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

        // ------------------------------------------------------------------------------

        // Métodos
        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }

        public void AdicionarProdutos(int quantidade)
        {
            Quantidade += quantidade;
        }

        public void RemoverProdutos(int quantidade)
        {
            Quantidade -= quantidade;
        }

        public override string ToString()
        {
            return _nome
                + ", $ "
                + Preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                + Quantidade
                + " unidades, Total: $ "
                + ValorTotalEmEstoque();
        }

    }
}
