using PrimeiroProjeto.Exercicio01;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiroProjeto.Exercicios02
{
    internal class ComprarPao
    {
        public int quantidadedePao{ get; set; }
        public int precodoPao { get; set; }
        public int total { get; set; }
        public int precodaCompra(Calculadora calculadora, int numqunt, int numpreco)
        {
            var testetexto = "millena";
             quantidadedePao = numqunt;
             precodoPao = numpreco;
             total = calculadora.multiplicar(quantidadedePao,precodoPao);
            return total;

        }

    }
}
