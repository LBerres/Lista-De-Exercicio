namespace ListaDeExercício.Exercicio01
{
    internal class Program
    {
        /* Crie um Programa Para Calcular o Volume de Uma Caixa Retangular
           Fórmula: VOLUME_DA_CAIXA = COMPRIMENTO * LARGURA * ALTURA
        */
        static void Main(string[] args)
        {
            #region Menu
            Console.Clear();
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("                                        Calcule o Volume de Uma Caixa Retangular                                       ");
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
            #endregion

            #region Input de Dados
            Console.WriteLine("Digire o Comprimento da Caixa: ");
            decimal comprimento = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("");


            Console.WriteLine("Digire a Largura da Caixa: ");
            decimal largura = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("");



            Console.WriteLine("Digire a Altura da Caixa: ");
            decimal altura = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("");


            #endregion

            #region Processamento

            decimal resultado = comprimento * largura * altura;

            #endregion

            #region OutPut
            Console.WriteLine($"O Volume da Caixa é de {resultado}.");
            Console.WriteLine("");
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
            #endregion

            Console.ReadLine();
        }
    }
}
