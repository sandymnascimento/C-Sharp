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
            ContaCorrente cliente1 = new ContaCorrente();
           
            cliente1.titular.Nome = "Plinio Arruda";
            cliente1.Agencia = 84271;
            cliente1.Conta = 2176;
            cliente1.titular.Cpf = 46830234496;

            Console.WriteLine("Titular: " + cliente1.titular.Nome);
            Console.WriteLine("CPF: " + cliente1.titular.Cpf);
            Console.WriteLine("Ag. "+ cliente1.Agencia + " Cc. " + cliente1.Conta + "\n");
                        
            ContaCorrente cliente2 = new ContaCorrente();
            Cliente cliente = new Cliente();

            cliente.Nome = "Marcelo Florentin";
            cliente.Cpf = 49836234496;
            cliente2.titular = cliente;
            cliente2.Agencia = 84971;
            cliente2.Conta = 2186;                       
       
            Console.WriteLine("Titular: " + cliente2.titular.Nome);
            Console.WriteLine("CPF: " + cliente2.titular.Cpf);
            Console.WriteLine("Ag. " + cliente2.Agencia + " Cc. " + cliente2.Conta + "\n");

            cliente1.Depositar(1000);
            cliente1.Transferir(cliente2, 459);
            cliente2.Sacar(158.96);
            Console.ReadLine();
        }
    }
}
