namespace Prime.Services
{
    public class Temperature
    {
        public static class ConversorTemperatura
        {
            public static double FahrenheitParaCelsius(double temperatura)
                //=> (temperatura - 32) / 1.8; // Simulação de falha
                => Math.Round((temperatura - 32) / 1.8, 2);
            
            public static double FahrenheitToCelsius(double temperatura)
                => (temperatura - 32) / 1.8; // Simulação de falha
        }
    }
}
