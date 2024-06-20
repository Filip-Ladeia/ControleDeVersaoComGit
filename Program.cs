using System;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem vindo à calculadora!");

            Console.WriteLine("Digite uma operação a ser feita!");
            Console.WriteLine("1 - SOMAR");
            Console.WriteLine("2 - SUBTRAIR");
            Console.WriteLine("3 - MULTIPLICAR");
            Console.WriteLine("4 - DIVIDIR");

            string resp = Console.ReadLine();

            switch (resp)
            {
                case "1":
                    Console.WriteLine("Digite os valores a serem somados:");
                    double[] valoresSoma = LerValores();
                    Console.WriteLine("A soma é: " + (valoresSoma[0] + valoresSoma[1]));
                    break;
                case "2":
                    Console.WriteLine("Digite os valores a serem subtraídos:");
                    double[] valoresSubtracao = LerValores();
                    Console.WriteLine("A subtração é: " + (valoresSubtracao[0] - valoresSubtracao[1]));
                    break;
                case "3":
                    Console.WriteLine("Digite os valores a serem multiplicados:");
                    double[] valoresMultiplicacao = LerValores();
                    Console.WriteLine("A multiplicação é: " + (valoresMultiplicacao[0] * valoresMultiplicacao[1]));
                    break;
                case "4":
                    Console.WriteLine("Digite os valores a serem divididos:");
                    double[] valoresDivisao = LerValores();
                    if (valoresDivisao[1] != 0)
                    {
                        Console.WriteLine("A divisão é: " + (valoresDivisao[0] / valoresDivisao[1]));
                    }
                    else
                    {
                        Console.WriteLine("Erro: Divisão por zero não é permitida.");
                    }
                    break;
                default:
                    Console.WriteLine("Operação inválida.");
                    break;
            }
        }

        static double[] LerValores()
        {
            double valor1, valor2;
            while (true)
            {
                try
                {
                    valor1 = double.Parse(Console.ReadLine());
                    valor2 = double.Parse(Console.ReadLine());
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Entrada inválida. Digite novamente os valores.");
                }
            }
            return new double[] { valor1, valor2 };
        }
    }
}


