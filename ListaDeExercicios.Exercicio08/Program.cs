using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ListaDeExercicios.Exercicio08
{
    /*
     * Faça um Algoritmo que Leia os Valores A, B, C e Imprima na Tela se a Soma de A + B é Menor que C.
    */
    internal class Program
    {
        static void Main(string[] args)
        {
                #region Menu
                Console.Clear();
                Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
                Console.WriteLine("                                         A Soma de A + B é Menor Que C ?                                                ");
                Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
                #endregion

                #region Imput de Dados
                Console.WriteLine("Digite o Número (A): ");
                int numeroA = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Digite o Número (B): ");
                int numeroB = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Digite o Número (C): ");
                int numeroC = Convert.ToInt32(Console.ReadLine());
                #endregion

                #region Processamento
                bool resultado = true;

                while (true)
                {

                    if (numeroA + numeroB < numeroC)
                    {
                        resultado = true;
                    }
                    else
                    {
                        resultado = false;
                    }
                    break;
                }
                #endregion

                #region Saída de Dados
                if (resultado == true)
                {
                    Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
                    Console.WriteLine("");
                    Console.WriteLine($"                                         A Soma é Menor Que o Número C!                                                ");
                    Console.WriteLine("");
                    Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
                }
                else if (resultado == false)
                {
                    Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
                    Console.WriteLine("");
                    Console.WriteLine($"                                       A Soma Não é Menor Que o Número C!                                              ");
                    Console.WriteLine("");
                    Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
                }
            #endregion

            Console.ReadLine();
        }
    }
}
