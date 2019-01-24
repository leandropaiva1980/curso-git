using System;

namespace Aluguel
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many rooms will be rented? ");
            int qtdeQuartos = int.Parse(Console.ReadLine());

            Quarto[] quartos = new Quarto[10];

            for (int i = 0; i < qtdeQuartos; i++)
            {
                Console.WriteLine($"Rent #{(i + 1)}: ");
                Console.Write("Nome: "); string nome = Console.ReadLine();
                Console.Write("E-mail: "); string email = Console.ReadLine();
                Console.Write("Room: "); int room = int.Parse(Console.ReadLine());
                quartos[room] = new Quarto();
                quartos[room].Inquilino = nome;
                quartos[room].Email = email;
                quartos[room].IdQuarto = room;

                Console.WriteLine(); //Pular linha.
            }

            for (int i = 0; i < 10; i++)
            {
                if (quartos[i] != null) { Console.WriteLine($"{i}: {quartos[i]}"); }
            }
        }
    }
}
