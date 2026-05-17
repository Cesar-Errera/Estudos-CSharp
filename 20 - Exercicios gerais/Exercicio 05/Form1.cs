using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Exercicio_05
{
    public partial class Form1 : Form
    {
        // Listas
        List<Categoria> categorias = new List<Categoria>();
        List<Produto> produtos = new List<Produto>();

        public Form1()
        {
            InitializeComponent(); // Construtor do formulario
            CarregarCategorias();
        }

        // metodo pra ler o arquivo de categorias.txt
        private void CarregarCategorias()
        {
            // classe: file
            // metodo: ReadAllLines
            // vai ler todas as linhas do arquivo e colocar em um array
            string[] linhas = File.ReadAllLines("Categorias.txt");
            foreach (string l in linhas)
            {
                // para separar o ID da descrição "1, brinquedo"
                // precisamos separar pelo caractere da virgula 
                // usamos o metodo "Split"
                string[] partes = l.Split(',');

                // preciso pegar cada parte separadamente pra guardar em variavel
                int id = int.Parse(partes[0]);
                string descricao = partes[1];

                // adicionando na lista
                Categoria categoria = new Categoria(id,descricao);
                categorias.Add(categoria);
            }
            // precisamos ligar a lista categorias no combox do forms
            cmbCategoria.DataSource = categorias;
        }

        private void botaoCadastrar_Click(object sender, EventArgs e)
        {
            //Preciso pegar os valores que o usuario digitar no forms
            int codigo = int.Parse(txtCodigo.Text); //.Text pra pegar o texto digitado
            string descricao = txtDescricao.Text;

            //Preciso pegar a categoria que foi digitada no combox
            // precisa do cast (Categoria) porque o SelectedItem retorna object
            Categoria categoriaSelecionada = (Categoria)cmbCategoria.SelectedItem;

            // criando o objeto Produto e adicionando na lista
            Produto produto = new Produto(codigo, descricao, categoriaSelecionada);
            produtos.Add(produto);

            // avisa que cadastrou e limpa os campos
            MessageBox.Show("Produto cadastrado com sucesso!");
            txtCodigo.Clear();
            txtDescricao.Clear();
            cmbCategoria.SelectedIndex = 0;
        }

        private void botaoListar_Click(object sender, EventArgs e)
        {
            // string que vai receber os dados de todos os produtos
            string resultado = "=== Produtos Cadastrados ===\n\n";

            // percorre a lista de produtos
            foreach (Produto p in produtos)
            {
                resultado += $"Código: {p.Codigo}\n";
                resultado += $"Descrição: {p.Descricao}\n";
                // acessa a descrição da categoria que tá dentro do produto
                resultado += $"Categoria: {p.Categoria.Descricao}\n";
                resultado += "----------------------------\n";
            }

            // exibe tudo em uma janela
            MessageBox.Show(resultado);
        }
    }
}
