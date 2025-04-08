namespace ListaDeExercicios.Exercicio14
{
    internal class Program
    {
        /*
         * Escreva um Programa que Leia um Número e Imprima a Sequência de Fibonacci até Esse Número.
        */
        static void Main(string[] args)
        {
            #region Menu
            Console.Clear();
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("                                             Sequencia Fibonacci");
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
            #endregion

            #region Imput de Dados
            Console.WriteLine("Digite Um Número: ");
            int numero = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
            #endregion

            #region Processamento
            int a = 0, b = 1;
            #endregion

            #region Saída de Dados
            Console.WriteLine();
            Console.Write("                                 Sequência de Fibonacci: ");
            while (a <= numero)
            {
                Console.Write(a + " ");
                int i = a + b;
                a = b;
                b = i;
            }
            Console.Write("= " + numero);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
            #endregion

            Console.WriteLine("                                         Aperte ENTER Para Encerrar");
            Console.ReadLine();
        }
    }
}
