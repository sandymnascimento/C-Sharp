using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    /// <summary>
    /// Define um cliente do ByteBank, armazenando os principais dados.
    /// </summary>
    public class Cliente
    {
        public string Nome { get; set; }
        private long _cpf;
        public long Cpf {
            get 
            { 
                return _cpf; 
            } 
            set
            {
                if (value.ToString().Length == 11)
                    _cpf = value;
                else
                    Console.WriteLine("O valor de CPF inserido é inválido!");
            }
        }

    }

}
