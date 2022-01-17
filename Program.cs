﻿using System;
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

            Console.WriteLine("E-mail: ");
            p1.email = Console.ReadLine();

            Console.WriteLine("Senha: ");
            p1.senha = Console.ReadLine();

            
            #endregion

            #region condição
            if (p1.idade < 18)
            {
                Console.WriteLine("Você não pode ser cadastrado. Idade mínima de 18 anos.");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Cadastro concluído. Seja bem-vindo " + p1.nome + " " + p1.sobrenome + "!");
                Console.WriteLine("Pressione uma tecla para finalizar.");
                Console.ReadKey();
            }
            #endregion
        }
    }
}
