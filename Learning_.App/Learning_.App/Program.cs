using Learning_.Controller;
using Learning_.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_.App
{
    public class Program
    {
        static void Main(string[] args)
        {
            PessoaController _controller = new PessoaController();
            int _opcao = 0;
            bool _menu = true;

            while (_menu)
            {
                Console.WriteLine("Programa Iniciado. \n" +
                              "1-Cadastrar Pessoa\n" +
                              "2-Buscar Pessoa\n" +
                              "3-Listar Todas Pessoas\n" +
                              "0-Sair\n"
                              );
                _opcao = Convert.ToInt32(Console.ReadLine());

                switch (_opcao)
                {
                    #region Cadastrar Pessoa
                    case 1:
                        Console.WriteLine("Informe as seguintes informações");
                        Console.Write("Nome:");
                            string _nome = Console.ReadLine();
                        Console.Write("Sobrenome:");
                            string _sobrenome = Console.ReadLine();
                        Console.Write("Email:");
                          string _email = Console.ReadLine();
                        Console.Write("Telefone:");
                             Int64 _telefone = Convert.ToInt64(Console.ReadLine());
                        Console.Write("Celular:");
                             Int64 _celular = Convert.ToInt64(Console.ReadLine());
                        Console.Write("\n");

                       if(_controller.criarPessoa(_nome, _sobrenome, _email, _telefone, _celular))
                       {
                            Console.WriteLine("Registro salvo com sucesso.");
                       }
                       break;
                    #endregion

                    #region Buscar Pessoa
                    case 2:
                        Console.Write("Buscar Pessoa:");
                        Console.Write("Informe o nome:");
                            _nome = Console.ReadLine();
                        var _pessoa = _controller.buscarPessoa(_nome);

                        if (_pessoa != null)
                        {
                            Console.WriteLine("Registro Encontrado:");
                            Console.WriteLine("Nome: " + _pessoa.Nome);
                            Console.WriteLine("Sobrenome: " + _pessoa.Sobrenome);
                            Console.WriteLine("Telefone: " + _pessoa.Telefone);
                            Console.WriteLine("Celular: " + _pessoa.Celular);
                            Console.WriteLine("Celular: " + _pessoa.Email + "\n");
                        }
                        else
                        {
                            Console.WriteLine("Nenhum Registro Encontrado");
                        }
                        break;
                    #endregion

                    #region Lista de pessoas
                    case 3:
                        var _pessoas = _controller.listaPessoas();
                        foreach(var pessoa in _pessoas)
                        {
                            Console.Write("Pessoa Encontrada> Nome: " + pessoa.Nome);
                        }
                        break;
                    #endregion

                    case 0:
                        _menu = false;
                        break;
                    default:
                        break;
                }
            }

        }
    }
}
