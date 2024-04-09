using System;
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
        private string Quantidade;
        private int Preco;

        public Livro()
        {
            ModificarCodigo = 0;
            ModificarTitulo = "";
            ModificarAutor = "";
            ModificarEditora = "";
            ModificarGenero = "";
            ModificarIsbn = "";
            ModificarQuantidade = "";
            ModificarPreco = 0;

        }//Fim do construtor

        //Métodos modificados = Gets e Sets

        public int ModificarCodigo
        {
            get { return this.Codigo; }
            set { this.Codigo = value; }

        }//Fim do modificar 

        public string ModificarTitulo
        {
            get { return this.Titulo; }
            set { this.Titulo = value; }

        }//Fim do modificar

        public string ModificarAutor
        {
            get { return this.Autor; }
            set { this.Autor = value; }

        }//Fim do modificar

        public string ModificarEditora
        {
            get { return this.Editora; }
            set { this.Editora = value; }

        }//Fim do modificar

        public string ModificarGenero
        {
            get { return this.Genero; }
            set { this.Genero = value; }

        }//Fim do modificar

        public string ModificarIsbn
        {
            get { return this.Isbn; }
            set { this.Isbn = value; }

        }//Fim do modificar

        public string ModificarQuantidade
        {
            get { return this.Quantidade; }
            set { this.Quantidade = value; }

        }//Fim do modificar

        public int ModificarPreco
        {
            get { return this.Preco; }
            set { this.Preco = value; }

        }//Fim do modificar


    }
}
