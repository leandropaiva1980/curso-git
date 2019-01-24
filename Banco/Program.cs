using System;

namespace Banco
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta NovaConta;
            Console.Write("Entre com o número da conta: ");
            int NumeroConta = int.Parse(Console.ReadLine());
            Console.Write("Entre com o nome do correntista: ");
            string NomeCorrentista = Console.ReadLine();
            Console.Write("Haverá deposito inicial (s/n): ");
            char DepositoInicial = char.Parse(Console.ReadLine());

            //Analisa se haverá deposito inicial.
            if (DepositoInicial == 's')
            {
                Console.Write("Entre com o valor de deposito inicial: ");
                double ValorDeposito = double.Parse(Console.ReadLine());
                NovaConta = new Conta(NomeCorrentista,NumeroConta,ValorDeposito);
            }
            else
            {
                NovaConta = new Conta(NomeCorrentista, NumeroConta);
            }
            Console.WriteLine(); //Pular linha.
            Console.WriteLine("Dados da conta: \n" + NovaConta);
            Console.WriteLine(); //Pular linha.

            //Depositos
            Console.Write("Entre com valor para depósito: ");
            NovaConta.Depositar(double.Parse(Console.ReadLine()));
            Console.WriteLine("Dados da conta atualizados: \n" + NovaConta);
            Console.WriteLine(); //Pular linha.

            //Saques
            Console.Write("Entre com valor para sacar: ");
            NovaConta.Sacar(double.Parse(Console.ReadLine()));
            Console.WriteLine("Dados da conta atualizados: \n" + NovaConta);
            Console.WriteLine(); //Pular linha.
        }
    }
}
