using ByteBank.ByteBank.Sistema;
using ByteBank.Sistema;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Empregados
{
    public class Gerente : FuncionarioAutenticavel
    {
        public Gerente(string nome, long cpf) : base(nome, cpf, 18000.00)
        {

        }

    }
}
