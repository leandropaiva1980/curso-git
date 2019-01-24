using System;
using System.Globalization;

namespace Formas
{
    class Program
    {
        static void Main(string[] args)
        {
            //Pergunta o tamanho da matriz
            Console.Write("MATRIZ\n\nQtde de linhas: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Qtde de colunas: ");
            int m = int.Parse(Console.ReadLine());

            //Cria a matriz
            int[,] Matr = new int[n, m];

            //Popular a matriz
            for (int a = 0; a < n; a++)
            {
                Console.Write($"Informe os valores da {(a + 1)}ª linha: ");
                string[] Linha = Console.ReadLine().Split(' ');
                for (int b = 0; b < m; b++)
                {
                    Matr[a, b] = int.Parse(Linha[b]);
                }
            }

            //Posicoes
            int Numero = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (Matr[i, j] == Numero)
                    {
                        Console.WriteLine(); //Pular linha.

                        //Posicao
                        Console.WriteLine($"Position: {i}, {j}: ");

                        //Left
                        if (j != 0) { Console.WriteLine("Left: " + Matr[i, j - 1]); }

                        //Right
                        if (j != (m - 1)) { Console.WriteLine("Right: " + Matr[i, j + 1]); }

                        //Up
                        if (i != 0) { Console.WriteLine("Up: " + Matr[i - 1, j]); }

                        //Down
                        if (i != (n - 1)) { Console.WriteLine("Down: " + Matr[i + 1, j]); }
                    }
                }
            }

            Console.WriteLine(); //Jump line.






        }

    }
}