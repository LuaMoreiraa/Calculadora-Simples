using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    public class Operacoes : IOperacoes
    {
        public string Adicao(double a, double b)
        {
            double resultado = a + b;
            return ("O resultado da Adição foi " + resultado);
        }

        public string Subtracao(double a, double b) 
            {
                double resultado = a - b;
                return ("O resultado da Subtracao foi " + resultado);
            }

        public string Multipli(double a, double b)
        {
            {
                double resultado = a * b;
                return ("O resultado da Multiplicação foi " + resultado);
            }
        }
        public string Divisao(double a, double b)
        {
            if (b == 0)
            {
                return ("Erro: Não é possivel dividdir por zero");
            }

            double resultado = a / b;
            return ("O resultado da divisão foi :" + resultado);
        }
    }
}
