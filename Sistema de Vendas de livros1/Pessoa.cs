using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Vendas_de_livros1
{
    class Pessoa
    {
        //Encapsulamento = Deixar as variáveis privadas
        private long CPF;
        private string Nome;
        private string Endereco;
        private string Telefone;
        private DateTime dtNascimento;
        private string Login;
        private string Senha;
        private string Situacao;//Ativo ou inativo
        private string posicao;//Atendente ou administrador ou cliente

        //Metodo construtor
        public Pessoa()
        {
            ModificarCPF = 0;
            ModificarNome = "";
            ModificarEndereco = "";
            ModificarTelefone = "";
            ModificardtNascimento = new DateTime();//"00/00/00 00:00:00"
            ModificarLogin = "";
            ModificarSenha = "";
            ModificarSituacao = "";
            ModificarPosicao = "";

        }//Fim do construtor


        //Métodos modificados = Gets e Sets

        public long ModificarCPF
        {
            get { return this.CPF; }
            set { this.CPF = value; }

        }//Fim do modificar 

        public string ModificarNome
        {
            get { return this.Nome; }
            set { this.Nome = value; }

        }//Fim do modificar

        public string ModificarEndereco
        {
            get { return this.Endereco; }
            set { this.Endereco = value; }

        }//Fim do modificar

        public string ModificarTelefone
        {
            get { return this.Telefone; }
            set { this.Telefone = value; }

        }//Fim do modificar

        public DateTime ModificardtNascimento
        {
            get { return this.dtNascimento; }
            set { this.dtNascimento = value; }

        }//Fim do modificar

        public string ModificarLogin
        {
            get { return this.Login; }
            set { this.Login = value; }

        }//Fim do modificar

        public string ModificarSenha
        {
            get { return this.Senha; }
            set { this.Senha = value; }

        }//Fim do modificar

        public string ModificarSituacao
        {
            get { return this.Situacao; }
            set { this.Situacao = value; }

        }//Fim do modificar

        public string ModificarPosicao
        {
            get { return this.posicao; }
            set { this.posicao = value; }

        }//Fim do modificar

        //Métodos - CRUD

        public void Cadastrar(long CPF, string Nome, string Telefone, string Endereco, DateTime dtNascimento, string Login, string Senha, string posicao)
        {
            ModificarCPF = CPF;
            ModificarNome = Nome;
            ModificarTelefone =  Telefone;
            ModificarEndereco = Endereco;
            ModificardtNascimento = dtNascimento;
            ModificarLogin = Login;
            ModificarSenha = Senha;
            ModificarSituacao = "Ativo";
            ModificarPosicao = posicao;

        }//Fim do Métodos

        public string ConsultarIndividual(long CPF)
        {
            string consulta = "";
            if (ModificarCPF == CPF)
            {
                string Consulta = "\nNome: " + ModificarNome +
                                  "\nTelefone: " + ModificarTelefone +
                                  "\nEndereço: " + ModificarEndereco +
                                  "\nData Nascimento: " + ModificardtNascimento +
                                  "\nLogin: " + ModificarLogin +
                                  "\nSenha: " + ModificarSenha +
                                  "\nSituação: " + ModificarSituacao +
                                  "\nPosição: " + ModificarPosicao;
            }
            else
            {
                consulta = "Número de CPF não é válido!";
            }
            return consulta;
        }

        public void AtualizarNome(long CPF, string Nome)
        {
            if(ModificarCPF == CPF)
            {
                ModificarNome = Nome;
            }
        }//Fim do método

        public void AtualizarTelefone(long CPF, string Telefone)
        {
            if (ModificarCPF == CPF)
            {
                ModificarTelefone = Telefone;
            }
        }//Fim do método

        public void AtualizarEndereco(long CPF, string Endereco)
        {
            if (ModificarCPF == CPF)
            {
                ModificarEndereco = Endereco;
            }
        }//Fim do método

        public void AtualizardtNascimento(long CPF, DateTime dtNascimento)
        {
            if (ModificarCPF == CPF)
            {
                ModificardtNascimento = dtNascimento;
            }
        }//Fim do método

        public void AtualizarSenha(long CPF, string Senha)
        {
            if (ModificarCPF == CPF)
            {
                ModificarSenha = Senha;
            }
        }//Fim do método

        public void AtualizarSituacao(long CPF, string Situacao)
        {
            if (ModificarCPF == CPF)
            {
                ModificarSituacao = Situacao;
            }
        }//Fim do método

        public void AtualizarPosicao(long CPF, string Posicao)
        {
            if (ModificarCPF == CPF)
            {
                ModificarPosicao = Posicao;
            }
        }//Fim do método

        public void Excluir(long CPF)
        {
            if(ModificarCPF == CPF)
            {
                ModificarSituacao = "Inativo";
            }
        }

    }//Fim da classe 
}//fim do projeto
