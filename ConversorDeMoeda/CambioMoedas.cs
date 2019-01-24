namespace ConversorDeMoeda
{
    class CambioMoedas
    {
        static double iof = 6;
        public static double Conversor(double Cotacao, double Valor)
        {
            return Cotacao * Valor * (1 + iof / 100);
        }
    }
}
