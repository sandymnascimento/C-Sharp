using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Empregados
{
    public class Coordenador : Funcionario
    {
        public Coordenador(string nome, long cpf) : base(nome, cpf, 13000.00)
        {

        }

    }
}
