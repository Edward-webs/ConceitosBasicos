using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.dominio
{
    public class VerificadorDeNumero
    {
        public bool EhPar(int valor)
        {
            if (valor % 2 == 0)
            {
                return true;
            }
            return false;
        }
    }
}