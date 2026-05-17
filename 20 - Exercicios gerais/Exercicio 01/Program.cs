using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // instanciando um objeto carro
            Carro carro = new Carro();

            // faço um laço de repetição pra forçar o usuario a digitar certo
            do
            {
                try
                {
                    Console.Write("Entre com a placa do carro: ");
                    carro.SetPlaca(Console.ReadLine());
                    break;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
            }
            while (true);

            do
            {
                try
                {
                    Console.Write("Entre com a marca do carro: ");
                    carro.SetMarca(Console.ReadLine());
                    break;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
            }
            while (true);

            do
            {
                try
                {
                    Console.Write("Entre com o modelo do carro: ");
                    carro.SetModelo(Console.ReadLine());
                    break;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
            }
            while (true);

            do
            {
                try
                {
                    Console.Write("Entre com o ano de fabricação do carro: ");
                    carro.AlterarAno(int.Parse(Console.ReadLine()));
                    break;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
            }
            while (true);

            Console.WriteLine(carro);
            Console.ReadLine();
        }
    }
}
