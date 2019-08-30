using System;

namespace Dominio
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public DateTime Data { get; set; }

        public static int calculateBirthday(DateTime birthday)
        {
           return DateTime.Now.Subtract(birthday).Days;
        }
    }
}
