namespace ListaDeExercicios.Exercicio11
{
    /*
     * Faça um Algoritmo Para Receber um Número Qualquer e Informar na Tela se é Par ou Ímpar. 
    */
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Menu
            Console.Clear();
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("                                             O Número é Ímpar ou Par?                                                   ");
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
            #endregion

            #region Imput de Dados
            Console.WriteLine("Digite um número inteiro: ");
            int numero = Convert.ToInt32(Console.ReadLine());
            #endregion

            #region Processamento
            bool par = false;
            bool impar = false;

            if ((numero / 2) * 2 == numero)
            {
                par = true;
            }
            else
            {
                impar = true;
            }
            #endregion

            #region Saída de Dados
            if (par)
            {
                Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
                Console.WriteLine($"                                             O número {numero} é Par!                                                  ");
                Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
            }
            else if (impar)
            {
                Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
                Console.WriteLine($"                                            O número {numero} é Ímpar!                                                 ");
                Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
            }
            else
            {
                Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
                Console.WriteLine("                                                    Número inválido!                                                    ");
                Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
            }
            #endregion

            Console.ReadLine();
        }
    }
}
