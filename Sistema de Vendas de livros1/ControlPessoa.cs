using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Vendas_de_livros1
{
    class ControlPessoa
    {
        Pessoa model;//Conectar com a classe pessoa
        private int opcao;
        public ControlPessoa()
        {
            model = new Pessoa();//Acesso a todos os métodos da classe pessoa
            ModificarOpcao = 0;
        }//Fim do construtor

        public int ModificarOpcao
        {
            get { return opcao; }
            set { opcao = value; }
        }

        public void Menu()
        {
            Console.WriteLine("Menu - Pessoa"                     + 
                              "\nEscolha uma das opções a baixo: "+
                              "\n1. Cadastrar pessoa"             +
                              "\n2. Consultar pessoa"             +
                              "\n3. Atualizar nome"               +
                              "\n4. Atualizar telefone"           +
                              "\n5. Atualizar endereço"           +
                              "\n6. Atualizar data de nascimento" +
                              "\n7. Atualizar senha"              +
                              "\n8. Atualizar situação"           +
                              "\n9. Excluir");
            ModificarOpcao = Convert.ToInt32(Console.ReadLine());
        }//Fim do Menu

        public void Operacao()
        {
            Menu();//Mostrar o menu
            switch (ModificarOpcao)
            {
                case 1:
                    Console.WriteLine("Informe o CPF: ");
                    long CPF = Convert.ToInt64(Console.ReadLine());

                    Console.WriteLine("Infome o seu Nome: ");
                    string nome = Console.ReadLine();

                    Console.WriteLine("Informe o seu telefone: ");
                    string telefone  = Console.ReadLine();

                    Console.WriteLine("Informe o seu Endereço: ");
                    string endereco = Console.ReadLine();

                    Console.WriteLine("Informe a seua data de nascimento: ");
                    DateTime data = Convert.ToDateTime(Console.ReadLine());

                    Console.WriteLine("Informe o seu Login: ");
                    string login = Console.ReadLine();

                    Console.WriteLine("Informe a sua senha: ");
                    string senha = Console.ReadLine();

                    Console.WriteLine("Infome o seu cargo: ");
                    string cargo = Console.ReadLine();

                    //Chamar o método cadastrar
                    model.Cadastrar(CPF, nome, telefone, endereco, data, login, senha, cargo);
                    break;

                case 2:
                    Console.WriteLine("Informe o CPF que deseja consultar: ");
                    CPF = Convert.ToInt64(Console.ReadLine());

                    //Mostrar os dados
                    Console.WriteLine(model.ConsultarIndividual(CPF));
                    break;
                case 3:
                    Console.WriteLine("Informe o CPF: ");
                    CPF = Convert.ToInt64(Console.ReadLine());

                    Console.WriteLine("Informe o novo nome: ");
                    nome = Console.ReadLine();

                    //Atualizar
                    model.AtualizarNome(CPF, nome);
                    break;
                case 4:
                    Console.WriteLine("Informe o CPF: ");
                    CPF = Convert.ToInt64(Console.ReadLine());

                    Console.WriteLine("Informe o novo telefone: ");
                    telefone = Console.ReadLine();

                    //Atualizar
                    model.AtualizarTelefone(CPF, telefone);
                    break;
                case 5:
                    Console.WriteLine("Informe o CPF: ");
                    CPF = Convert.ToInt64(Console.ReadLine());

                    Console.WriteLine("Informe o novo Endereço: ");
                    endereco = Console.ReadLine();

                    //Atualizar
                    model.AtualizarEndereco(CPF, endereco);
                    break;
                case 6:
                    Console.WriteLine("Informe o CPF: ");
                    CPF = Convert.ToInt64(Console.ReadLine());

                    Console.WriteLine("Informe o nova data de nascimento: ");
                    data = Convert.ToDateTime(Console.ReadLine()); 

                    //Atualizar
                    model.AtualizardtNascimento(CPF, data);
                    break;
                case 7:
                    Console.WriteLine("Informe o CPF: ");
                    CPF = Convert.ToInt64(Console.ReadLine());

                    Console.WriteLine("Informe a nova senha: ");
                    senha = Console.ReadLine();

                    //Atualizar
                    model.AtualizarSenha(CPF, senha);
                    break;
                case 8:
                    Console.WriteLine("Informe o CPF: ");
                    CPF = Convert.ToInt64(Console.ReadLine());

                    Console.WriteLine("Informe a nova cargo: ");
                    cargo = Console.ReadLine();

                    //Atualizar
                    model.AtualizarPosicao(CPF, cargo);
                    break;
                case 9:
                    Console.WriteLine("Informe o CPF: ");
                    CPF = Convert.ToInt64(Console.ReadLine());

                    //Excluir
                    model.Excluir(CPF);
                    break;
            }//Fim do switch

        }//Fim da Operação

    }//Fim da Classe
}//Fim do projeto
