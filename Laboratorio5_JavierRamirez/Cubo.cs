using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio5_JavierRamirez
{
    class Cubo : ICalcular
    {
        public int Calcular(int numero)
        {
            return (int) Math.Pow(numero, 3);
        }
    }
}
