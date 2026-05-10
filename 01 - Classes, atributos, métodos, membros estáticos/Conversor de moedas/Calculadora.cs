using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversor_de_moedas
{
    internal class Calculadora
    {
        public static double Iof = 6.0;
        
        public static double ValorAPagar(double cotacao, double compra)
        {
            double total = compra * cotacao;
            return total + total * Iof / 100;
        }
    }
}
