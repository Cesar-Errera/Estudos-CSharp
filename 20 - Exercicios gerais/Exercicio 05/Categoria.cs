using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_05
{
    internal class Categoria
    {
        public int Id { get; set; }
        public string Descricao { get; set; }

        public Categoria(int id, string descricao)
        {
            Id = id;
            Descricao = descricao;
        }

        // o to string é importante
        // ele que faz o ComBox exibir o nome da categoria e nao "Exercicio_05.Categoria"
        public override string ToString()
        {
            return Descricao;
        }
    }
}
