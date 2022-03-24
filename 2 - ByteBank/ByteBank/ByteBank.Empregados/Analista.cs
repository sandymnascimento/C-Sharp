using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Empregados
{
    internal class Analista : Funcionario
    {
        public Analista(string nome, long cpf) : base(nome, cpf, 6000.00)
        {

        }

        
    }
}
