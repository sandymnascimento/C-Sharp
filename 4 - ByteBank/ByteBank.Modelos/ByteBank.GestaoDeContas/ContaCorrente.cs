using ByteBank.Exceções;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    /// <summary>
    /// Define uma Conta Corrente do banco ByteBank
    /// </summary>
    public class ContaCorrente
    {        
        public Cliente titular = new Cliente();
        private double _saldo = 0;    
        public Cliente Titular { get; set; }
        public uint Agencia { get; } // CRIA UM CAMPO READONLY
        public uint Conta { get; }
        public int ContSaquesInvalidos { get; private set; }
        public static int TotalContasCriadas { get; private set; }
        public static double TaxaOperacao { get; private set; }

        /// <summary>
        /// Cria uma instância de ContaCorrente com os argumentos utilizados
        /// </summary>
        /// <param name="agencia">Representa o valor da propriedade <see cref="Agencia"/>, o valor deve conter quatro digitos e ser maior que 100.</param>
        /// <param name="conta">Representa o valor da propriedade <see cref="Conta", o valor deve conter cinco digitos e ser maior que 1000./></param>
        /// <exception cref="ArgumentException"></exception>
        public ContaCorrente(uint agencia, uint conta)
        {
            if (conta < 1000)
                throw new ArgumentException("Número de conta com tamanho inválido.", nameof(conta)); // diz que é uam exceção por causa do ARGUMENTO (ag./cc)
            else if (agencia < 100)
                throw new ArgumentException("Número de agencia com tamanho inválido.", nameof(agencia));

            Agencia = agencia;
            Conta = conta;

            TotalContasCriadas++;
            TaxaOperacao = 30 / TotalContasCriadas;
        }
      
        public double GetSaldo()
        {
            return _saldo;
        }
        /// <summary>
        /// Realiza o saque e atualiza o valor da propriedade <see cref="_saldo"/>
        /// <exception cref="ArgumentException">Exceção lançada quando um valor negativo é utilizado no argumento <paramref name="valor"/>. </exception>
        /// <exception cref="SaldoInsufienteException">Exceção lançada quando o valor de <paramref name="valor"/> é maior que o valor da propriedade <see cref="Saldo">. </exception>
        /// </summary>
        /// <param name="valor"> Representa o valor do saque, deve ser maior que 0 e menor que <see cref="Saldo"/>. </param>
        public void Sacar(double valor)
        {
            if (valor <= 0)
            {
                throw new ArgumentException("É necessário inserir um valor positivo para efetuar a operação.", nameof(valor));
            }
            if (valor > _saldo)
            {
                ContSaquesInvalidos++;
                throw new SaldoInsuficienteException("O valor a ser sacado é superior ao disponível.");
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
                Sacar(valor);
        }
        public void Transferir(ContaCorrente destino, double valor)
        {
            if (valor <= 0)
                Sacar(valor);

            if (valor > _saldo)
                throw new SaldoInsuficienteException("O valor a ser transferido é superior ao disponível.");
                        
            _saldo -= valor;
            destino.Depositar(valor);        
        }
    }
}
