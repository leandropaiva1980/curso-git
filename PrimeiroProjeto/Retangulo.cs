using System;

namespace Formas
{
    class Retangulo
    {
        public double Largura;
        public double Altura;

        //Calcula área
        public double Area()
        {
            return (Largura * Altura);
        }

        //Calcula diagonal
        public double Diagonal()
        {                         
            double Hip = Math.Pow(Largura, 2) + Math.Pow(Altura, 2);
            return Math.Sqrt(Hip);
        }

        //Calcula perímetro
        public double Perimetro()
        {            
            return (Largura + Altura) * 2;
        }

    }
}
