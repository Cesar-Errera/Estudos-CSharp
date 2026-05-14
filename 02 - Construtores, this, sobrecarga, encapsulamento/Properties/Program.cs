using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // PROPRIEDADES -------------------------------------------------------------|
            // São definições de métodos encapsulados, porém expondo uma sintaxe similar |
            // à de atributos e não métodos                                              |
            //---------------------------------------------------------------------------|

            Produto p = new Produto("TV", 500, 10);

            p.Nome = "TV 4K";

            Console.WriteLine(p.Nome);
            Console.WriteLine(p.Preco);
        }
    }
}
