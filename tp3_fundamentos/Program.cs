using Dominio;
using System;
using System.Collections.Generic;
using System.Globalization;

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
        private static void start()
        {
            Console.WriteLine("Gerenciador de aniversários " +
                          "\nSelecione uma das opções abaixo:" +
                          "\n1 - Pesquisar pessoas" +
                          "\n2 - Adicionar nova pessoa" +
                          "\n3 - sair");
        }

        private static void pesquisarPessoa(RepositorioPessoa repo, List<Pessoa> ListPessoa)
        {
            Console.WriteLine("Digite o nome, ou parte do nome da pessoa que deseja encontrar");
            string pessoaNome = Console.ReadLine();
            repo.getPessoa(ListPessoa, pessoaNome);
            Console.ReadKey();
            return;
        }

        private static void addPessoa(Pessoa pessoa, RepositorioPessoa repo, List<Pessoa> ListPessoa)
        {
            pessoa = new Pessoa();
            Console.WriteLine("Digite o nome da pessoa que deseja adicionar");
            pessoa.Nome = Console.ReadLine();
            Console.WriteLine("Digite o sobrenome da pessoa que deseja adicionar");
            pessoa.Sobrenome = Console.ReadLine();
            Console.WriteLine("Digite a data do aniversário no formato dd/MM/yyyy");
            string dataNiver = Console.ReadLine();
			try
			{
				pessoa.Data = DateTime.Parse(dataNiver, new CultureInfo("pt-BR"));
				Console.WriteLine("\nOs dados abaixo estão corretos?\n");
				Console.WriteLine("Nome: " + pessoa.Nome + " " + pessoa.Sobrenome +
								   "\nData de aniversário: " + pessoa.Data );
				Console.WriteLine("1 - Sim \n2 - Não");
				var option = Console.ReadLine();
				if(option == "1")
				{
					ListPessoa.Add(pessoa);
					Console.WriteLine("\nDados adicionados com sucesso!");
					Console.ReadLine();
				}
				else
				{
					Console.WriteLine("\nDados não foram adicionados!");
					Console.ReadLine();
				}
			}
			catch
			{
				Console.Write("Data inválida pressione qualquer tecla para voltar ao menu inicial.");
				Console.ReadLine();
			}
            
        }

        private static void action(Pessoa pessoa, RepositorioPessoa repo, List<Pessoa> ListPessoa)
        {
            Console.Clear();
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
