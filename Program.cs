

using System;
using System.Net.Mail;

namespace Calculadora;

class Program{
    static void Main(string[] args) {

        Console.WriteLine("Bem vindo a calculadora!");

        Console.WriteLine("Digite uma operação a ser feita!");
        Console.WriteLine("1 SOMAR");
        Console.WriteLine("2 SUBTRAIR");
        Console.WriteLine("3 MULTIPLICADOR");
        Console.WriteLine("4 DIVIDIR");

        string resp = Console.ReadLine();

        if (resp == "1") {
            Console.WriteLine("Digite os valores a ser somados:");
            double valor1 = double.Parse(Console.ReadLine());
            double valor2 = double.Parse(Console.ReadLine());
            double soma = valor1 + valor2;
            Console.WriteLine("A soma é: " + soma);
        }

        if (resp == "2") {
          Console.WriteLine("Digite os valores a ser somados:");
          double val1 = double.Parse(Console.ReadLine());
          double val2 = double.Parse(Console.ReadLine());
          double sm = val1 - val2;
            Console.WriteLine("A soma é: " + sm);

        }

        if  (resp == "3") {
            Console.WriteLine("Digite os valores a ser somados:");
            double valr1 = double.Parse(Console.ReadLine());
            double valr2 = double.Parse(Console.ReadLine());
            double sm = valr1 * valr2;
            Console.WriteLine("A soma é: " + sm);

        }

        if (resp == "4") {
           Console.WriteLine("Digite o valor a ser somados:");
           double vl1 = double.Parse(Console.ReadLine());
           double vl2 = double.Parse(Console.ReadLine());
           double sm = vl1 / vl2;
           Console.WriteLine("A soma é:" + sm);

        }

    }
}




