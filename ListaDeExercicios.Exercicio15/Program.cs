namespace ListaDeExercicios.Exercicio15
{
    internal class Program
    {
        /*
         * Escreva um programa que imprima os números de 1 a 100 em ordem crescente, substituindo os números
            múltiplos de 3 pela palavra "Fizz" e os múltiplos de 5 pela palavra "Buzz". Para números que são múltiplos de
            ambos, use "FizzBuzz".
        */
        static void Main(string[] args)
        {
            #region Menu
            Console.Clear();
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("                                                    Fizz & Buzz                                           ");
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
            #endregion

            #region Imput de Dados
            Console.WriteLine("                                             Aperte ENTER Para Iniciar ");
            Console.ReadLine();
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
            #endregion

            #region Processamento
            int contador3 = 0;
            int contador5 = 0;

            for (int numero = 1; numero <= 100; numero++)
            {
                contador3++;
                contador5++;

                bool x3 = contador3 == 3;
                bool x5 = contador5 == 5;

                if (x3 && x5)
                {
                    Console.WriteLine("                                                      FizzBuzz");
                    contador3 = 0;
                    contador5 = 0;
                }
                else if (x3)
                {
                    Console.WriteLine("                                                        Fizz");
                    contador3 = 0;
                }
                else if (x5)
                {
                    Console.WriteLine("                                                        Buzz");
                    contador5 = 0;
                }
                else
                {
                    Console.WriteLine("                                                         " + numero);
                }
            }
            Console.WriteLine();
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
            #endregion

            #region Saída de Dados
            {
                Console.WriteLine("                                             Aperte ENTER Para Encerrar ");
            }
            #endregion

            Console.ReadLine();
                
            
        }
    }
}
