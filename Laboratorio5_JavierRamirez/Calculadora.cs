using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio5_JavierRamirez
{
    class Calculadora
    {
        private int numero;
        public List<ICalcular> calculadoras;
        private Random rnd = new Random();

        public Calculadora(int n)
        {
            numero = n;
            calculadoras = new List<ICalcular>();
        }

        public int GetNumero()
        {
            return numero;
        }

        public void Calcular(int index)
        {
            numero = calculadoras[index].Calcular(numero);
        }
    }
}
