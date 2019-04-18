using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio5_JavierRamirez
{
    class RobotFibonacci : ICalcular
    {
        public int Calcular(int numero)
        {
            int a, b, c;
            for(a=0, b=1; numero > 0; numero--)
            {
                c = a;
                a = b;
                b = a + c;
            }
            return b;
        }
    }
}
