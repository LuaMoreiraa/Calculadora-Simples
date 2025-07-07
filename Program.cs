using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Operacoes operacoes = new Operacoes();
            bool continuacao = true;

            while (continuacao)
            {
                Console.WriteLine("SEJA VEM VINDO A");
                Console.WriteLine("CALCULADORA");
                Console.WriteLine("1-ADIÇÃO");
                Console.WriteLine("2-SUBTRAÇÃO");
                Console.WriteLine("3- MULTIPLICAÇÃO");
                Console.WriteLine("4-DIVISÃO");
                Console.WriteLine("5- SAIR DA CALCULADORA");
                Console.WriteLine("ESCOLHA UMA DAS OPERAÇÕES :");

                string escolha = Console.ReadLine();

                try
                {
                    if (escolha == "5")
                    {
                        continuacao = false;
                        Console.WriteLine("Encerranddo calculadora.");
                        break;
                    }

                    Console.WriteLine("Digite o primeiro número:");
                    double num1 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Digite o segundo numero:");
                    double num2 = Convert.ToDouble(Console.ReadLine());

                    string resultado = "";

                    switch (escolha)
                    {
                        case "1":
                            resultado = operacoes.Adicao(num1, num2);
                            break;
                        case "2":
                            resultado = operacoes.Subtracao(num1, num2);
                            break;
                        case "3":
                            resultado = operacoes.Multipli(num1, num2);
                            break;
                        case "4":
                            resultado = operacoes.Divisao(num1, num2);
                            break;
                        default:
                            Console.WriteLine("OÕpção invalida. Por favor, tente novamente");
                            continue;
                    }
                    Console.WriteLine(resultado);
                    Console.WriteLine();

                }

                catch (FormatException)
                {
                    Console.WriteLine("Erro: Invalido. Por favor, digite apenas números.");
                    Console.Clear();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Erro!");
                    Console.Clear();
                }

                Console.WriteLine("Quer fazer mais alguma operação?");
                Console.WriteLine("a - Sim");
                Console.WriteLine("b - Não");

                string resposta = Console.ReadLine().ToLower();
                continuacao = resposta == "a";
                Console.Clear();
            }
        }
    }
}


