using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Empregados
{
    internal abstract class Funcionario
    {
        public static int TotalFuncionarios;

        private string _nome;
        private long _cpf; 
        public double salario { get; protected set; }

        public Funcionario(string Nome, long Cpf, double Salario)
        {
            _nome = Nome;   
            _cpf = Cpf;
            salario = Salario;
            TotalFuncionarios++; 
        }
        public void AumentarSalario(double aumento)
        {
            double Aumento = aumento / 100 + 1;
            salario *= Aumento;
        }
        public string getNome()
        {
            return _nome;
        }
        public long getCpf()
        {
            return _cpf;
        }


    }
}
