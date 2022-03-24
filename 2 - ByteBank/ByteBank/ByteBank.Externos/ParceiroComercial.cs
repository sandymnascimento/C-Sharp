using ByteBank.Sistema;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.ByteBank.Externos
{
    internal class ParceiroComercial : IAutenticacao
    {
        public string Nome { get; private set; }
        public string Empresa { get; set; }
        public string Senha { get; set; }

        public ParceiroComercial(string nome)
        {
            Nome = nome;
        }
        public bool Autenticar(string senha)
        {
           return Senha == senha;
        }
    }
}
