namespace CoversorDolarEEuro062020
{
    public static class Conversor
    {
        public static float DolarCotação = 5.26f;
        public static float EuroCotação = 5.91f;
        public static float ConverterDolarParaReal(float Valor){
            return Valor * DolarCotação;
        }
        public static float ConverterRealParaDolar(float Valor){
            return Valor / DolarCotação;
        }
        public static float ConverterEuroParaReal(float Valor){
            return Valor * EuroCotação;
        }
        public static float ConverterRealParaEuro(float Valor){
            return Valor / EuroCotação;
        }
    }
}