namespace ListaDeExercicios.Exercicio04
{
    /* Crie um Programa Para Converter a Temperatura da Escala Celsius Para a Escala Fahrenheit
       Fórmula: F = (C * 9/5) + 32
    */
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Menu
            Console.Clear();
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("                            Converta a Temperatura da Escala Celsius Para a Escala Fahrenheit                           ");
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
            #endregion

            #region Imput de Dados
            Console.WriteLine("Digite a Temperatura em °C: ");
            decimal temperaturaCelsius = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("");

            #endregion

            #region Processamento
            decimal temperaturaFahrenheit = (temperaturaCelsius * 9 / 5) + 32;
            #endregion

            #region Saída de Dados
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("");
            Console.WriteLine($"A Temperatura em Fahrenheit é: {temperaturaFahrenheit}°F.");
            Console.WriteLine("");
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
            #endregion

            Console.ReadLine();
        }
    }
}
