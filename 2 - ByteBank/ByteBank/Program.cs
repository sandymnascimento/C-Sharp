using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank.Empregados;
using ByteBank.Sistema;

namespace ByteBank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Diretor dir = new Diretor("Laura Romão", 46875134825);
            Gerente gte = new Gerente("Viviane Marques", 43813167825);
            Coordenador coord = new Coordenador("Claudia Arruda", 46875139574);
            Analista anl = new Analista("Pedro Joaquim", 46674354825);

            dir.CriarSenha("diretoralaura");
            SistemaInterno sistemaInterno = new SistemaInterno();
            sistemaInterno.logar(dir, "diretoralaura");

            Console.ReadLine();
        }
    }
}
