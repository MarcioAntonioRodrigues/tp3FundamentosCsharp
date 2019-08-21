using System;
using System.Collections.Generic;

namespace tp3_fundamentos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Gerenciador de aniversários " +
                            "\nSelecione uma das opções abaixo:" +
                            "\n1 - Pesquisar pessoas" +
                            "\n2 - Adicionar nova pessoa" +
                            "\n3 - sair");

            List<Pessoa> ListPessoa = new List<Pessoa>();

            Pessoa pessoa = new Pessoa();
            Console.WriteLine("Digite seu nome");
            pessoa.Nome = Console.ReadLine();

            Console.WriteLine("Digite seu sobrenome");
            pessoa.Sobrenome = Console.ReadLine();

            Console.WriteLine("Digite sua data de aniversário");
            pessoa.Data = Console.ReadLine();

            RepositorioPessoa repo = new RepositorioPessoa();
            repo.addPessoa(ListPessoa, pessoa);

            repo.list(ListPessoa);

            //foreach (Pessoa pessoa1 in ListPessoa)
            //{
            //    Console.WriteLine(pessoa1.Nome);
            //}

            Console.ReadKey();

        }
    }
}
