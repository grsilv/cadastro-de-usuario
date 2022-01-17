using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cadastro_de_usuário
{
    internal class Program
    {
        struct Pessoa
        {
            public string nome;
            public string sobrenome;
            public int idade;
            public string email;
            public string senha;
        }
        static void Main(string[] args)
        {
            #region informações
                Console.WriteLine("Preencha as informações");
                Console.WriteLine();

                Pessoa p1 = new Pessoa();

                Console.Write("Nome: ");
                p1.nome = Console.ReadLine();

                Console.Write("Sobrenome: ");
                p1.sobrenome = Console.ReadLine();

                Console.Write("Idade: ");
                p1.idade = int.Parse(Console.ReadLine());

                Console.Write("E-mail: ");
                p1.email = Console.ReadLine();

                Console.Write("Senha: ");
                p1.senha = Console.ReadLine();
            #endregion

            #region confirmação de senha
            Console.Clear();
            Console.Write("Por favor, confirme a senha de usuário: ");
            string confsenha = Console.ReadLine();
            #endregion

            #region while
            while (confsenha != p1.senha)
            {
                Console.Write("Senha incorreta. Tente de novo: ");
                confsenha = Console.ReadLine();
            }
            #endregion

            #region conclusão de cadastro
            Console.WriteLine("Cadastro concluído. Seja bem-vindo " + p1.nome + " " + p1.sobrenome);
            Console.WriteLine();

            Console.WriteLine("Pressione qualquer tecla do teclado para finalizar.");
            Console.ReadKey();
            #endregion

        }
    }
}
