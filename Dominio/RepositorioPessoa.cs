using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio
{
    public class RepositorioPessoa
    {
        private static List<Pessoa> PessoasList { get; set; }

        public void getPessoa(List<Pessoa> PessoasList, string nome)
        {
            bool flag = false;
            var count = 0;
            if (PessoasList.Count == 0)
            {
                Console.WriteLine("Ninguém foi encontrado.\n");
            }
            else
            {
                List<Pessoa> CopyList = new List<Pessoa>();
                foreach (Pessoa pessoa in PessoasList)
                {
                    if (pessoa.Nome == nome)
                    {
                        flag = true;
                        CopyList.Add(pessoa);
                        //writePessoa(pessoa);
                        //return;
                    }
                }
                Console.WriteLine("Selecione uma das opções abaixo para visualizar os dados de uma das pessoas encontradas:");
                foreach (Pessoa copy in CopyList)
                {
                    writeNameOf(copy, count);
                    count ++;
                }
                int nameOption = Int32.Parse(Console.ReadLine());
                writeChosen(CopyList[nameOption]);
            }
                if(!flag)Console.WriteLine("Ninguém foi encontrado.\n");
        }

        public void list(List<Pessoa> PessoasList)
        {
            foreach (Pessoa pessoa in PessoasList)
            {
                Console.WriteLine("Nome: " + pessoa.Nome + " " + pessoa.Sobrenome + "\nAniversário: " + pessoa.Data);
            }
        }

        public void writeNameOf(Pessoa pessoa, int count)
        {
            Console.WriteLine(count + " - " + pessoa.Nome);
        }

        public void writeChosen(Pessoa pessoa)
        {
            int birthdaytTime = Pessoa.calculateBirthday(pessoa.Data);
            Console.WriteLine("Nome: " + pessoa.Nome + " " + pessoa.Sobrenome + "\nAniversário: " + pessoa.Data 
                + "\nFaltam " + birthdaytTime + " dias para esse aniversário.");
            
        }
    }
}
