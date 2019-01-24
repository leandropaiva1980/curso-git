using System;

namespace ConversorDeMoeda
{
    class Program
    {
        static void Main(string[] args)
        {
            double Resultado;
            Console.Write("Qual a cotação do dolar hoje? ");
            double Cotacao = double.Parse(Console.ReadLine());
            Console.Write("Quantos dolares você vai comprar? ");
            double Valor = double.Parse(Console.ReadLine());
            Resultado = CambioMoedas.Conversor(Cotacao, Valor);
            Console.Write("Valor a ser pago em reais: " + Resultado.ToString("F2") + '\n');
        }
    }
}