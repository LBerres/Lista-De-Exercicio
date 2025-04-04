namespace ListaDeExercicios.Exercicio06
{
    /* Crie um Programa Para Calcular a Média Ponderada de Duas Provas Realizadas por um Aluno.
       Fórmula: M= (N1 * P1) + (N2 * P2) / (P1 + P2)
    */
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Menu
            Console.Clear();
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("                            Calcule a Média Ponderada de Duas Provas Realizadas por um Aluno                            ");
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
            #endregion

            #region Imput de Dados
            Console.WriteLine("Digite a Nota da Primeira Prova: ");
            decimal nota1 = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("");

            Console.WriteLine("Digite a Nota da Segunda Prova: ");
            decimal nota2 = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("");

            Console.WriteLine("Digite o Peso da Primeira Prova: ");
            decimal peso1 = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("");

            Console.WriteLine("Digite o Peso da Segunda Prova: ");
            decimal peso2 = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("");
            #endregion

            #region Processamento
            decimal mediaPonderada = (nota1 * peso1 + nota2 * peso2) / (peso1 + peso2);
            #endregion

            #region Saída de Dados
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("");
            Console.WriteLine($"                                    A Média Ponderada das Provas é: {mediaPonderada}.                                  ");
            Console.WriteLine("");
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
            #endregion

            Console.ReadLine();

        }
    }
}
