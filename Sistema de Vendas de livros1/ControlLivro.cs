﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Vendas_de_livros1
{
    class ControlLivro
    {
        Livro model;//Conectar com a classe pessoa
        private int opcao;
        public ControlLivro()
        {
            model = new Livro();//Acesso a todos os métodos da classe pessoa
            ModificarOpcao = 0;
        }//Fim do construtor

        public int ModificarOpcao
        {
            get { return opcao; }
            set { opcao = value; }
        }

        public void Menu()
        {
            Console.WriteLine("Menu - Livro" +
                              "\nEscolha uma das opções a baixo: " +
                              "\n1. Cadastrar Livro" +
                              "\n2. Consultar Livro" +
                              "\n3. Atualizar Quantidade" +
                              "\n4. Atualizar Preço" +
                              "\n5. Excluir");
            ModificarOpcao = Convert.ToInt32(Console.ReadLine());
        }//Fim do Menu

        public void Operacao()
        {
            Menu();//Mostrar o menu
            switch (ModificarOpcao)
            {
                case 1:
                    Console.WriteLine("Informe o Codigo do Livro: ");
                    int Codigo = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Infome o Titulo do Livro: ");
                    string Titulo = Console.ReadLine();

                    Console.WriteLine("Informe o Autor do Livro: ");
                    string Autor = Console.ReadLine();

                    Console.WriteLine("Informe a Editora do Livro: ");
                    string Editora = Console.ReadLine();

                    Console.WriteLine("Informe o Gênero do livro: ");
                    string Genero = Console.ReadLine();

                    Console.WriteLine("Informe o Isbn: ");
                    string Isbn = Console.ReadLine();

                    Console.WriteLine("Informe a Quantidade de Livros: ");
                    int Quantidade = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Infome o Preço do Livro: ");
                    int Preco = Convert.ToInt32(Console.ReadLine());

                    //Chamar o método cadastrar
                    model.CadastrarLivro(Codigo,Titulo,Autor,Editora,Genero,Isbn,Quantidade,Preco);
                    break;

                case 2:
                    Console.WriteLine("Informe o Titulo que deseja consultar: ");
                    Titulo = Console.ReadLine();

                    //Mostrar os dados
                    Console.WriteLine(model.ConsultarLivro(Titulo));
                    break;

                case 3:
                    Console.WriteLine("Informe o Titulo: ");
                    Titulo = Console.ReadLine();

                    Console.WriteLine("Informe a Quantidade de Livros: ");
                    Quantidade = Convert.ToInt32(Console.ReadLine());

                    //Atualizar
                    model.AtualizarQuantidade(Titulo, Quantidade);
                    break;

                case 4:
                    Console.WriteLine("Informe o Titulo: ");
                    Titulo = Console.ReadLine();

                    Console.WriteLine("Informe o Preço dos Livros: ");
                    Preco = Convert.ToInt32(Console.ReadLine());

                    //Atualizar
                    model.AtualizarQuantidade(Titulo, Preco);
                    break;

                case 5:
                    Console.WriteLine("Informe o Titulo: ");
                    Titulo = Console.ReadLine();

                    //Excluir
                    model.Excluir(Titulo);
                    break;
            }
        }
    }
}
