namespace ListaDeExercicios.Exercicio12
{
    /*
     * Escrever um Algoritmo que Gera e Escreve os Números Ípares Entre 100 e 200.
    */
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Menu
            Console.Clear();
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("                                    Quais São os Números Ímpares de 100 a 200?                                          ");
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
            #endregion

            #region Imput de Dados
            Console.WriteLine("                                          Pressione Enter Para Continuar");
            Console.ReadLine();
            #endregion

            #region Processamento
            Console.WriteLine("                                                    Estes Números ");
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
                        Console.WriteLine();


            for (int numeros = 100; numeros <= 200; numeros++)
            {
                if ((numeros / 2) * 2 != numeros)
                {
                    Console.WriteLine("                                                        " + numeros + "                                         ");
                }
            }
            Console.WriteLine();
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("                                                    São Ímpares!");
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
            #endregion

            #region Saída de Dados

            Console.WriteLine("                                            Pressione Enter Para Finalizar");


            #endregion

            Console.ReadLine();
        }
    }
}
