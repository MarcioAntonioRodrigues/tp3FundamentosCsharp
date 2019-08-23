using System;
using System.Collections.Generic;
using System.Text;

namespace tp3_fundamentos
{
    class RepositorioPessoa
    {
        public List<Pessoa> PessoasList { get; set; }

        public void getPessoa(List<Pessoa> PessoasList, string nome)
        {
            if(PessoasList.Count == 0)
            {
                Console.WriteLine("Ninguém foi encontrado.\n");
            }
            else
            {
                foreach(Pessoa pessoa in PessoasList)
                {
                    if(pessoa.Nome == nome)
                    {
                        writePessoa(pessoa);
                        return;
                    }
                }
                Console.WriteLine("Ninguém foi encontrado.\n");
            }
        }

        //public void addPessoa(List<Pessoa> listPessoa, Pessoa pessoa)
        //{
        //    pessoa = new Pessoa();
        //    listPessoa.Add(pessoa);
        //    writePessoa(pessoa);
        //}

        public void list(List<Pessoa> PessoasList)
        {
            foreach (Pessoa pessoa in PessoasList)
            {
                Console.WriteLine("Nome: " + pessoa.Nome + " " + pessoa.Sobrenome + "\nAniversário: " + pessoa.Data);
            }
        }

        public void writePessoa(Pessoa pessoa)
        {
            Console.WriteLine("Nome completo: " + pessoa.Nome + " " + pessoa.Sobrenome + "" +
                                "\nData do aniversário: " + pessoa.Data);
        }
    }
}
