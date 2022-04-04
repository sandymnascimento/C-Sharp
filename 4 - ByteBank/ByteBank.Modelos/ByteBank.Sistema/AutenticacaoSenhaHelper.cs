using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Modelos.ByteBank.Sistema
{
    internal class AutenticacaoSenhaHelper
    {
        public bool ComparaSenhas(string senhaConta, string senhaTentativa)
        {
            return senhaConta == senhaTentativa;
        }
    }
}
