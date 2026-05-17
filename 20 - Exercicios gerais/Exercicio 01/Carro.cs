using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Exercicio_01
{
    internal class Carro
    {
        public string Placa { get; private set; }
        public string Marca { get; private set; }
        public string Modelo { get; private set; }
        public int AnoFabricacao { get; private set; }

        // Construtores
        public Carro()
        {

        }

        public Carro (string placa, string marca, string modelo, int anoFabricacao)
        {
            // aqui eu já vou fazer o uso dos métodos, porque eu já consigo fazer a validação
            SetPlaca(placa);
            SetMarca(marca);
            SetModelo(modelo);
            AlterarAno(anoFabricacao); 
        }

        // funçao pra não deixar que fique sem placa
        public void SetPlaca(string novaPlaca)
        {
            if (string.IsNullOrWhiteSpace(novaPlaca))
            {
                throw new ArgumentException("Placa inválida! Não pode ser vazia");
            }
            Placa = novaPlaca;
        }

        // funçao pra não deixar que fique sem marca
        public void SetMarca(string novaMarca)
        {
            if (string.IsNullOrWhiteSpace(novaMarca))
            {
                throw new ArgumentException("Marca inválida! Não pode ser vazia");
            }
            Marca = novaMarca;
        }

        // funçao pra não deixar que fique sem modelo
        public void SetModelo(string novoModelo)
        {
            if (string.IsNullOrWhiteSpace(novoModelo))
            {
                throw new ArgumentException("Modelo inválido! Não pode ser vazio");
            }
            Modelo = novoModelo;
        }

        // função que vai validar o AnoFabricacao
        public void AlterarAno(int novoAno)
        {
            if (novoAno <= 2000)
            {
                throw new ArgumentException("Ano inválido. Deve ser maior que 2000");

            }
            AnoFabricacao = novoAno;
        }

        // To string
        public override string ToString()
        {
            return "\n=== Dados do Carro ===" +
                   "\nPlaca: " + Placa +
                   "\nAno de fabricacao: " + AnoFabricacao +
                   "\nMarca: " + Marca +
                   "\nModelo: " + Modelo;
        }
    }
}
