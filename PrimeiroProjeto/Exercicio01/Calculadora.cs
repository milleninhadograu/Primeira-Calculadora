using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiroProjeto.Exercicio01
{
    internal class Calculadora
    {
        public Calculadora() {
            var num = 0;
            var num1 = 0;
            var soma = num + num1;



        }
        public double somar(double valor1, double valor2) 
        {
            return valor1 + valor2;
        }

        internal object dividir(int v1, int v2)
        {
            return v1 / v2;
        }
        public int subtrair(int v3, int v4) 
        { 
            return v3 - v4;
        }
        public int multiplicar(int v5, int v6)
        {
           var resultadoM = v5 * v6;
            return resultadoM;
            


        }

    }
}
