using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_.Domain
{
    public class Pessoa
    {

        public Pessoa(string Nome,string Sobrenome,string Email,Int64 Telefone, Int64 Celular)
        {
            this.Nome = Nome;
            this.Sobrenome = Sobrenome;
            this.Email = Email;
            this.Telefone = Telefone;
            this.Celular = Celular;
        }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Email { get; set; }
        public Int64 Telefone { get; set; }
        public Int64 Celular { get; set; }

    }
}
