using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    internal class ContaCorrente
    {
        public Cliente titular = new Cliente();
        private double _saldo = 0;
        private int _agencia;
        private int _conta;

        public Cliente Titular { get; set; }
        public int Agencia { get; set; }
        public int Conta { get; set; }

        public double GetSaldo()
        {
            return _saldo;
        }
        public void Sacar(double valor)
        {
            if (valor > _saldo)
            {
                Console.WriteLine("Não foi possível realizar a operação. O valor a ser sacado é superior ao disponível.");
                return; 
            }
            _saldo -= valor;
            Console.WriteLine(titular.Nome + ", saque efetuado com sucesso! Novo saldo: " + _saldo);            
        }
        public void Depositar(double valor)
        {
            if (valor > 0)
            {
                _saldo += valor;
                Console.WriteLine(titular.Nome + ", o valor foi recebido com sucesso! Novo saldo: " + _saldo);
            }                
            else
                Console.WriteLine("É necessário inserir um valor positivo para efetuar o depósito.");
        }
        public void Transferir(ContaCorrente destino, double valor)
        {
            if(valor <= _saldo)
            {
                _saldo -= valor;
                destino.Depositar(valor);
                return;
            }
            Console.WriteLine("Não foi possível realizar a operação.O valor a ser depositado é superior ao disponível.");
        }
    }
}
