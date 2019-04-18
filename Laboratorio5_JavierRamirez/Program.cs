using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio5_JavierRamirez
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero, n, i, operacion;
            Console.WriteLine("Número inicial:");
            numero = int.Parse(Console.ReadLine());
            Calculadora calculadora = new Calculadora(numero);
            calculadora.calculadoras.Add(new PersonaQueSuma5());
            calculadora.calculadoras.Add(new RobotFibonacci());
            calculadora.calculadoras.Add(new PerroFactorial());
            calculadora.calculadoras.Add(new Cuadrado());
            calculadora.calculadoras.Add(new Cubo());
            Console.WriteLine("Número de operaciones:");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("\n");
            Console.WriteLine("Operaciones:\n");
            Console.WriteLine(" (1) Sumar 5");
            Console.WriteLine(" (2) Fibonacci");
            Console.WriteLine(" (3) Factorial");
            Console.WriteLine(" (4) Potencia de 2");
            Console.WriteLine(" (5) Potencia de 3\n");
            for (i=1; i<=n; i++)
            {
                Console.WriteLine("Seleccione operacion (1 - 5):");
                operacion = int.Parse(Console.ReadLine());
                calculadora.Calcular(operacion-1);
                Console.WriteLine("{0}° Operación:   {1}", i, calculadora.GetNumero());
            }
            Console.WriteLine("\n\nResultado Final: {0}", calculadora.GetNumero());
            Console.Read();
        }
    }
}
