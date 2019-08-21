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

            start();

            var choice = Console.ReadLine();

            if (choice == "1")
            {
                Console.WriteLine("Digite o nome, ou parte do nome da pessoa que deseja encontrar");
                string pessoaNome = Console.ReadLine();
                repo.getPessoa(ListPessoa, pessoaNome);
                Console.ReadKey();
            }
            if(choice == "2")
            {
                Console.WriteLine("Digite o nome da pessoa que deseja adicionar");
                pessoa.Nome = Console.ReadLine();
                Console.WriteLine("Digite o sobrenome da pessoa que deseja adicionar");
                pessoa.Sobrenome = Console.ReadLine();
                Console.WriteLine("Digite a data do aniversário no formato dd/MM/yyyy");
                pessoa.Data = Console.ReadLine();
                repo.addPessoa(ListPessoa, pessoa);
                start();
                Console.ReadKey();
            }



            //Console.WriteLine("Digite seu nome");
            //pessoa.Nome = Console.ReadLine();

            //Console.WriteLine("Digite seu sobrenome");
            //pessoa.Sobrenome = Console.ReadLine();

            //Console.WriteLine("Digite sua data de aniversário");
            //pessoa.Data = Console.ReadLine();



            //repo.list(ListPessoa);

            //Console.ReadKey();

        }
        public static void start()
        {
            Console.WriteLine("Gerenciador de aniversários " +
                          "\nSelecione uma das opções abaixo:" +
                          "\n1 - Pesquisar pessoas" +
                          "\n2 - Adicionar nova pessoa" +
                          "\n3 - sair");
        }

    }
}
