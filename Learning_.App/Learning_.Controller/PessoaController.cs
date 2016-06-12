using Learning_.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_.Controller
{
    public class PessoaController
    {
        static List<Pessoa> _listPessoas = new List<Pessoa>();

        public bool criarPessoa(string nome, string sobrenome, string email, Int64 telefone, Int64 celular)
        {
            Pessoa _pessoa = new Pessoa(nome, sobrenome, email, telefone, celular);
            if (criarListaPessoa(_pessoa))
                return true;
            else
                return false;
        }

        public bool criarListaPessoa(Pessoa pessoa)
        {
            try
            {
                _listPessoas.Add(pessoa);
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Pessoa buscarPessoa(string nome)
        {
            Pessoa _pessoa;
            return _pessoa = _listPessoas.Where(p => p.Nome.ToLower() == nome.ToLower()).FirstOrDefault();
        }

        public List<Pessoa> listaPessoas()
        {
           return _listPessoas;
        }
    }
}
