﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Vendas_de_livros1
{
    class Livro
    {
        private int Codigo;
        private string Titulo;
        private string Autor;
        private string Editora;
        private string Genero;
        private string Isbn;
        private int Quantidade;
        private int Preco;
        private string Situacao;//Ativo ou inativo

        public Livro()
        {
            ConsultarCodigo = 0;
            ConsultarTitulo = "";
            ConsultarAutor = "";
            ConsultarEditora = "";
            ConsultarGenero = "";
            ConsultarIsbn = "";
            ConsultarQuantidade = 0;
            ConsultarPreco = 0;
            ModificarSituacao = "";

        }//Fim do construtor

        //Métodos modificados = Gets e Sets

        public int ConsultarCodigo
        {
            get { return this.Codigo; }
            set { this.Codigo = value; }

        }//Fim do modificar 

        public string ConsultarTitulo
        {
            get { return this.Titulo; }
            set { this.Titulo = value; }

        }//Fim do modificar

        public string ConsultarAutor
        {
            get { return this.Autor; }
            set { this.Autor = value; }

        }//Fim do modificar

        public string ConsultarEditora
        {
            get { return this.Editora; }
            set { this.Editora = value; }

        }//Fim do modificar

        public string ConsultarGenero
        {
            get { return this.Genero; }
            set { this.Genero = value; }

        }//Fim do modificar

        public string ConsultarIsbn
        {
            get { return this.Isbn; }
            set { this.Isbn = value; }

        }//Fim do modificar

        public int ConsultarQuantidade
        {
            get { return this.Quantidade; }
            set { this.Quantidade = value; }

        }//Fim do modificar

        public int ConsultarPreco
        {
            get { return this.Preco; }
            set { this.Preco = value; }

        }//Fim do modificar
        public string ModificarSituacao
        {
            get { return this.Situacao; }
            set { this.Situacao = value; }

        }//Fim do modificar

        public void CadastrarLivro(int Codigo, string Titulo, string Autor, string Editora, string Genero, string Isbn, int Quantidade, int Preco)
        {
            ConsultarCodigo = Codigo;
            ConsultarTitulo = Titulo;
            ConsultarAutor = Autor;
            ConsultarEditora = Editora;
            ConsultarGenero = Genero;
            ConsultarIsbn = Isbn;
            ConsultarQuantidade = Quantidade;
            ConsultarPreco = Preco;
            ModificarSituacao = "Ativo";

        }//Fim do Métodos

        public string ConsultarLivro(string Titulo)
        {
            string consulta = "";
            if (ConsultarTitulo == Titulo)
            {
                consulta = "\nCodigo: " + ConsultarCodigo +
                                  "\nTitulo: " + ConsultarTitulo +
                                  "\nAutor: " + ConsultarAutor +
                                  "\nEditora: " + ConsultarEditora +
                                  "\nGenêro: " + ConsultarGenero +
                                  "\nIsbn: " + ConsultarIsbn +
                                  "\nQuantidade: " + ConsultarQuantidade +
                                  "\nPreço: " + ConsultarPreco +
                                  "\nSituação: " + ModificarSituacao;
            }
            else
            {
                consulta = "Título inválido!";
            }
            return consulta;
        }
        public void AtualizarQuantidade(string Titulo, int Quantidade)
        {
            if (ConsultarTitulo == Titulo)
            {
                ConsultarQuantidade = Quantidade;
            }
        }//Fim do método

        public void AtualizarPreco(string Titulo, int Preco)
        {
            if (ConsultarTitulo == Titulo)
            {
                ConsultarPreco = Preco;
            }
        }//Fim do método

        public void Excluir(string Titulo)
        {
            if (ConsultarTitulo == Titulo)
            {
                ModificarSituacao = "Inativo";
            }
        }

    }
}
