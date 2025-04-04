namespace ListaDeExercicios.Exercicio07
{
    /*
       Crie Um Programa Para Verificar Se Um Número É Primo.

        Regra geral para verificar se um número é primo:
        1. Se o Número for menor que 2, então não é primo.
        2. Se o Número for 2, então é primo.
        3. Se o Número for divisível por 2 ou 3, então não é primo.
        4. Verifique se o Número é divisível por qualquer número ímpar de 5 até a raiz quadrada do Número.
    */
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Menu
            Console.Clear();
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("                                         Verifique se um Número É Primo.                                                ");
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
            #endregion

            #region Imput de Dados
            Console.WriteLine("Digite um Número: ");
            int numero = Convert.ToInt32(Console.ReadLine());
            #endregion

            #region Processamento

            bool primo = true;

            if (numero < 2)
            {
                primo = false;
            }

            else if (numero == 2 || numero == 3)
            {
                primo = true;
            }

            else if (numero % 2 == 0 || numero % 3 == 0)
            {
                primo = false;
            }

            for (int numeroFixo = 5; numeroFixo * numeroFixo <= numero; numeroFixo += 6)
            {
                if (numero % numeroFixo == 0 || numero / (numeroFixo + 2) == 0)
                    primo = false;
                break;
            }
            #endregion

            #region Saída de Dados
            if (primo == true)
            {
                Console.Clear();
                Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
                Console.WriteLine("");
                Console.WriteLine($"                                              O Número {numero} É Primo.                                                ");
                Console.WriteLine("");
                Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
            }
            else
            {
                Console.Clear();
                Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
                Console.WriteLine("");
                Console.WriteLine($"                                            O Número {numero} Não É Primo.                                             ");
                Console.WriteLine("");
                Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
            }
            #endregion

            Console.ReadLine();

        }
    }
}
