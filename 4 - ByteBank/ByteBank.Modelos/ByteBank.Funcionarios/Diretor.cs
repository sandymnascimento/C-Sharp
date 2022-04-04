using ByteBank.ByteBank.Sistema;
using ByteBank.Sistema;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Empregados
{
    public class Diretor : FuncionarioAutenticavel 
    {
        // o construtor vai chamar a base antes de tudo, usado na presença de argumentos
        public Diretor(string nome, long cpf) : base(nome, cpf, 25000.00) 
        {
            
        }
        
    }
}
