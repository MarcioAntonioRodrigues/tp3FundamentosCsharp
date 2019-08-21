using System;
using System.Collections.Generic;
using System.Text;

namespace tp3_fundamentos
{
    class RepositorioPessoa
    {
        public List<Pessoa> PessoasList { get; set; }

        public Pessoa getPessoa(List<Pessoa> PessoasList, string nome)
        {
            foreach(Pessoa pessoa in PessoasList)
            {
                if(pessoa.Nome == nome)
                {
                    return pessoa;
                }
            }
           return null;
        }

        public void addPessoa(List<Pessoa> listPessoa, Pessoa pessoa)
        {
            listPessoa.Add(pessoa);
        }

        public void list(List<Pessoa> PessoasList)
        {
            foreach (Pessoa pessoa in PessoasList)
            {
                Console.WriteLine("Nome: " + pessoa.Nome + " " + pessoa.Sobrenome + "\nAniversário: " + pessoa.Data);
            }
        }
    }
}
