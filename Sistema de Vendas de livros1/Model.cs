using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Vendas_de_livros1
{
    class Model
    {
        public Model()
        {

        }//Fim do Método Construtor

        //Inscrição
        public void Cadastro()
        {
            bool LoginC = false;
            string LoginU = "";
            int LoginS = 0;

            Console.WriteLine("Para o cadastro informe o seu email: ");
            string email = Console.ReadLine();

            Console.WriteLine("Informe o seu nome de usuário: ");
            string usuario = Console.ReadLine();

            Console.WriteLine("Digite uma senha: ");
            int senha = Convert.ToInt32(Console.ReadLine());

            LoginU = usuario;
            LoginS = senha;

            if (LoginU == usuario)
            {
                LoginC = true;
            }
            else
            {
                LoginC = false;
            }

        }

    }//Fim da Model
}//Fim do Projeto
