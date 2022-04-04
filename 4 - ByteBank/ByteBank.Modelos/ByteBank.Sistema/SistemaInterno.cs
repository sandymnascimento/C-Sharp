using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Sistema
{
    public class SistemaInterno
    {
        public bool Logar(IAutenticacao usuario, string senha)
        {
            bool usuarioAutenticado = usuario.Autenticar(senha);

            if (usuarioAutenticado)
            {
                Console.WriteLine("Acesso confirmado! Bem-vindo ao sistema.");
                return true;
            }           
            else
            {
                Console.WriteLine("Senha incorreta, tente novamente.");
                return false;
            }
           
        }
    }    
}
