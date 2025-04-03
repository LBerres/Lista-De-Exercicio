namespace ListaDeExercício.Exercício01
{
    internal class Program
    {
        // Crie um Programa Para Calcular o Volume de Uma Caixa Retangular
        // VOLUME_DA_CAIXA = COMPRIMENTO * LARGURA * ALTURA
        static void Main(string[] args)
        {
            #region Input de Dados
            Console.WriteLine("Digire o Comprimento da Caixa: ");
            decimal comprimento = Convert.ToDecimal(Console.ReadLine());
            

            Console.WriteLine("Digire a Largura da Caixa: ");
            decimal largura = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Digire a Altura da Caixa: ");
            decimal altura = Convert.ToDecimal(Console.ReadLine());

            #endregion

            #region Processamento

            decimal resultado = comprimento * largura * altura;

            #endregion

            #region OutPut

            Console.WriteLine($"O Volume da Caixa é de {resultado}.");
            #endregion

            Console.ReadLine();
        }
    }
}
