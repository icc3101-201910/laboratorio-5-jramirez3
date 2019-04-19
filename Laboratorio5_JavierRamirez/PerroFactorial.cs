using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio5_JavierRamirez
{
    class PerroFactorial : ICalcular
    {
        public int Calcular(int numero)
        {
            if (numero > 13)
                numero = 13;

            int n;
            for(n = 1; numero > 0; numero--)
            {
                n *= numero;
            }
            return n;
        }
    }
}
