using ByteBank.Empregados;
using ByteBank.Sistema;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.ByteBank.Sistema
{
    internal abstract class FuncionarioAutenticavel : Funcionario, IAutenticacao
    {
        public string senha { get; private set; }
        public FuncionarioAutenticavel(string nome, long cpf, double salario) : base (nome, cpf, salario) { }

        public void CriarSenha(string Senha)
        {
            if (senha == null)
                senha = Senha;
            else
                Console.WriteLine("Funcionário já possui senha cadastrada.");

        }
        public bool Autenticar(string Senha)
        {
            return senha == Senha;
        }
    }
}
