using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1
{
    public class Calculos
    {
        public Calculos()
        {
        }

        public int Somar(int a, int b)
        {
            return a + b;
        }

        public int Subtrair(int a, int b)
        {
            return b - a;
        }

        public float Dividir(int a, int b)
        {
            return b / a;
        }

        public int Multiplicar(int a, int b)
        {
            return a * b;
        }

        public string ValorParImpar(int a)
        {
            return a % 2 == 0 ? "par" : "impar";
        }
    }
}
