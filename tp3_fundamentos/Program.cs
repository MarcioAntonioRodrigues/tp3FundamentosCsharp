using System;
using System.Collections.Generic;

namespace tp3_fundamentos
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Pessoa> ListPessoa = new List<Pessoa>();
            Pessoa pessoa = new Pessoa();
            RepositorioPessoa repo = new RepositorioPessoa();

            action(pessoa, repo, ListPessoa);
        }
        public static void start()
        {
            Console.WriteLine("Gerenciador de aniversários " +
                          "\nSelecione uma das opções abaixo:" +
                          "\n1 - Pesquisar pessoas" +
                          "\n2 - Adicionar nova pessoa" +
                          "\n3 - sair");
        }

        public static void pesquisarPessoa(RepositorioPessoa repo, List<Pessoa> ListPessoa)
        {
            Console.WriteLine("Digite o nome, ou parte do nome da pessoa que deseja encontrar");
            string pessoaNome = Console.ReadLine();
            repo.getPessoa(ListPessoa, pessoaNome);
            Console.ReadKey();
            return;
        }

        public static void addPessoa(Pessoa pessoa, RepositorioPessoa repo, List<Pessoa> ListPessoa)
        {
            pessoa = new Pessoa();
            Console.WriteLine("Digite o nome da pessoa que deseja adicionar");
            pessoa.Nome = Console.ReadLine();
            Console.WriteLine("Digite o sobrenome da pessoa que deseja adicionar");
            pessoa.Sobrenome = Console.ReadLine();
            Console.WriteLine("Digite a data do aniversário no formato dd/MM/yyyy");
            pessoa.Data = Console.ReadLine();
            ListPessoa.Add(pessoa);
            Console.ReadKey();
        }

        public static void action(Pessoa pessoa, RepositorioPessoa repo, List<Pessoa> ListPessoa)
        {
            start();

            var choice = Console.ReadLine();

            if (choice == "1")
            {
                pesquisarPessoa(repo, ListPessoa);
            }
            else if (choice == "2")
            {
                addPessoa(pessoa, repo, ListPessoa);
            }
            else if(choice == "3")
            {
                return;
            }

            action(pessoa, repo, ListPessoa);
        }
    }
}
