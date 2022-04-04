using ByteBank.Modelos.ByteBank.Sistema;
using ByteBank.Sistema;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.ByteBank.Externos
{
    public class ParceiroComercial : IAutenticacao
    {
        public string Nome { get; private set; }
        public string Empresa { get; set; }
        public string Senha { get; set; }

        private AutenticacaoSenhaHelper _autenticacao = new AutenticacaoSenhaHelper();


        public ParceiroComercial(string nome)
        {
            Nome = nome;
        }
        public bool Autenticar(string senha)
        {
            return _autenticacao.ComparaSenhas(senha, Senha);
        }
    }
}
