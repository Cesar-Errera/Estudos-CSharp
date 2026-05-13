using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulamento
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // todo atributo é definido como private
            // implementa-se metodos Get e Set para
            // cada atributo, conforme regras do negocio

            Produto p = new Produto("TV",500,10);

            // devemos impedir que o usuario faça isso
            // p.Quantidade = -10;

            // Como mudariamos o nome?
            // p._nome = "TV 4K"
            // Assim não funcionaria pois a variavel na classe é private

            p.SetNome("TV 4K");

            Console.WriteLine(p.GetNome());
            Console.WriteLine(p.GetPreco());
            Console.WriteLine(p.GetQuantidade());

        }
    }
}
