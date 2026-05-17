using Exercicio_02;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_02
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // fazendo o uso da lista pra armazenar os carros
            List<Carro> carros = new List<Carro>();
            string resp;

            do
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

                // adiciono na lista
                carros.Add(carro);

                // pergunta
                Console.Write("Deseja cadastrar mais carros (S/N)?: ");
                resp = Console.ReadLine().ToUpper();


            } while (resp == "S");

            Console.WriteLine("\n=== Carros cadastrados ===");
            foreach (Carro c in carros)
            {
                Console.WriteLine(c);
            }

            Console.ReadLine();

            

            

            
        }
    }
}
