using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;


namespace Aluno
{
    class Aluno
    {
        public string Nome;
        public int Nota1;
        public int Nota2;
        public int Nota3;

        public override string ToString()
        {
            double soma = Nota1 + Nota2 + Nota3;

            //Se aprovado
            if (soma >= 60)
            {
                return $"NOTA FINAL: {soma.ToString("F2",CultureInfo.InvariantCulture)}" +
                       $"\nAPROVADO";
            }
            else
            {
                return $"NOTA FINAL: {soma.ToString("F2", CultureInfo.InvariantCulture)}" +
                       $"\nREPROVADO \nFaltaram: " + (60 - soma).ToString("f2", CultureInfo.InvariantCulture) +
                       $" Pontos";
            }
        }
                
    }
}
