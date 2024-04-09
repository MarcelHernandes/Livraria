using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Vendas_de_livros1
{
    class Control
    {
        Model modelo;
        public Control()
        {
            modelo = new Model();

        }//Fim do Construtor
        public void Menu()
        {
            Console.WriteLine("\n\nEscolha uma das opções abaixo: \n" +
                              "0. Sair\n" +
                              "1. Cadastro \n" +
                              "2. Login \n");
        }//Menu
        public void Operacao()
        {
            int opcao = 0;
            do
            {

                Menu();//Mostrando as opções
                opcao = Convert.ToInt32(Console.ReadLine());

                switch (opcao)
                {
                    case 0:
                        Console.WriteLine("Obrigado!");
                        break;
                    case 1:
                        Console.WriteLine("Para o cadastro informe o seu email: ");
                        string email = Console.ReadLine();

                        Console.WriteLine("Informe o seu nome de usuário: ");
                        string usuario = Console.ReadLine();

                        Console.WriteLine("Digite uma senha: ");
                        int senha = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 2:
                        Console.ReadLine();
                        break;
                    default:
                        Console.WriteLine("Código digitado não é válido! ");
                        break;
                }//Fim do método

            } while (opcao != 0);
        }//Fim do Operacao
    }
}
