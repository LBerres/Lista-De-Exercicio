namespace ListaDeExercicios.Exercicio13
{
    internal class Program
    {
        /*
         * Escreva um algoritmo que leia um valor inicial A e imprima a sequência de valores do cálculo de A! e o seu
                resultado.
                a. Ex: 5! = 5 X 4 X 3 X 2 X 1 = 120
                b. Pesquise sobre “fatorial”
        */
        static void Main(string[] args)
        {
            #region Menu
            Console.Clear();
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("                                          Encontrando o Fatorial do Número");
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
            #endregion

            #region Imput de Dados
            Console.WriteLine("Digite Um Número: ");
            int numero = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine();
            #endregion

            #region Processamento
            int fatorial = 1;

            Console.Write($"{numero}! : ");
            Console.WriteLine();

            for (int i = 1; i <= numero; i++)
            {
                Console.Write($"                                                    {fatorial} x {i} = ");
                fatorial *= i;
                Console.WriteLine(fatorial);
            }

            #endregion

            #region Saída de Dados
            Console.WriteLine();
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine($"                                              O Fatoreal do {numero} é = {fatorial}");
            Console.WriteLine();
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");

            #endregion

            Console.ReadLine();
        }
    }
}
