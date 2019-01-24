using System;
using System.Collections.Generic;
using System.Text;

namespace Aluguel
{
    class Quarto
    {
        public int? IdQuarto { get; set; }
        public string Inquilino { get; set; }
        public string Email { get; set; }      

        public Quarto(int quarto, string nome, string email)
        {
            AlugaQuarto(quarto, nome, email);
        }

        public void AlugaQuarto(int quarto, string nome, string email)
        {
            IdQuarto = quarto;
            Inquilino = nome;
            Email = email;
        }

        public override string ToString()
        {
            return Inquilino + ", " + Email;
        }

    }
}
