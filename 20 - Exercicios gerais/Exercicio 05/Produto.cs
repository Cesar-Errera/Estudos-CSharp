using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_05
{
    internal class Produto
    {
        public int Codigo { get; set; }
        public string Descricao { get; set; }
        public Categoria Categoria { get; set; }

        public Produto(int codigo, string descricao, Categoria categoria)
        {
            Codigo = codigo;
            Descricao = descricao;
            Categoria = categoria;
        }
    }
}
