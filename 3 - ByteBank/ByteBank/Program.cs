using ByteBank.Exceções;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                ContaCorrente cliente1 = new ContaCorrente(2176, 84271);

                cliente1.titular.Nome = "Plinio Arruda";
                cliente1.titular.Cpf = 46830234496;

                Console.WriteLine("Titular: " + cliente1.titular.Nome);
                Console.WriteLine("CPF: " + cliente1.titular.Cpf);
                Console.WriteLine("Ag. " + cliente1.Agencia + " Cc. " + cliente1.Conta + "\n");

                ContaCorrente cliente2 = new ContaCorrente(2186, 84971);
                Cliente cliente = new Cliente();

                cliente.Nome = "Marcelo Florentin";
                cliente.Cpf = 49836234496;
                cliente2.titular = cliente;

                Console.WriteLine("Titular: " + cliente2.titular.Nome);
                Console.WriteLine("CPF: " + cliente2.titular.Cpf);
                Console.WriteLine("Ag. " + cliente2.Agencia + " Cc. " + cliente2.Conta + "\n");

                cliente1.Depositar(1000);
                cliente1.Transferir(cliente2, 459);
                cliente2.Sacar(158.96);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Argumento com valor inválido: " + ex.ParamName);
            }
            catch(SaldoInsuficienteException ex)
            {
                Console.WriteLine("Não foi possível realizar a operação. ");
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            { 
                Console.WriteLine(ex.Message); 
            }
            
            
            Console.ReadLine();
        }
    }
}
