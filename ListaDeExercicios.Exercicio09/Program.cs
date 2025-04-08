namespace ListaDeExercicios.Exercicio09
{
    internal class Program
    {
        /*
         * Escreva um Algoritmo que Leia Três Valores Inteiros e Diferentes e Mostre-os em Ordem Decrescente. 
        */
        static void Main(string[] args)
        {
                #region Menu
                Console.Clear();
                Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
                Console.WriteLine("                                      Mostre os Valores em Ordem Decrescente!                                           ");
                Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
                #endregion

                #region Imput de Dados
                Console.WriteLine("Digite o Primeiro Número: ");
                int numero1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Digite o Segundo Número: ");
                int numero2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Digite o Terceiro Número: ");
                int numero3 = Convert.ToInt32(Console.ReadLine());
                #endregion

                #region Processamento
                bool resultado321 = true;
                bool resultado231 = true;
                bool resultado123 = true;
                bool resultado132 = true;
                bool resultado213 = true;
                bool resultado312 = true;

                while (true)
                {
                    if (numero1 < numero2 && numero1 < numero3)
                    {
                        if (numero2 < numero3)
                        {
                            resultado321 = true;
                        }
                        else
                        {
                            resultado231 = true;
                        }
                    }
                    else if (numero2 < numero1 && numero2 < numero3)
                    {
                        if (numero1 < numero3)
                        {
                            resultado312 = true;
                        }
                        else
                        {
                            resultado132 = true;
                        }
                    }
                    else
                    {
                        if (numero1 < numero2)
                        {
                            resultado213 = true;
                        }
                        else
                        {
                            resultado123 = true;
                        }
                    }
                    break;
                }
                #endregion

                #region Saída de Dados
                if (resultado321 == true)
                {
                    Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
                    Console.WriteLine("");
                    Console.WriteLine($"                                      A Ordem Decrescente é {numero3} - {numero2} - {numero1}                          ");
                    Console.WriteLine("");
                    Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
                }
                else if (resultado231 == true)
                {
                    Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
                    Console.WriteLine("");
                    Console.WriteLine($"                                      A Ordem Decrescente é {numero2} - {numero3} - {numero1}                          ");
                    Console.WriteLine("");
                    Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
                }
                else if (resultado123 == true)
                {
                    Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
                    Console.WriteLine("");
                    Console.WriteLine($"                                      A Ordem Decrescente é {numero1} - {numero2} - {numero3}                          ");
                    Console.WriteLine("");
                    Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
                }
                else if (resultado132 == true)
                {
                    Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
                    Console.WriteLine("");
                    Console.WriteLine($"                                      A Ordem Decrescente é {numero1} - {numero3} - {numero2}                          ");
                    Console.WriteLine("");
                    Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
                }
                else if (resultado213 == true)
                {
                    Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
                    Console.WriteLine("");
                    Console.WriteLine($"                                      A Ordem Decrescente é {numero2} - {numero1} - {numero3}                          ");
                    Console.WriteLine("");
                    Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
                }
                else if (resultado312 == true)
                {
                    Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
                    Console.WriteLine("");
                    Console.WriteLine($"                                      A Ordem Decrescente é {numero3} - {numero1} - {numero2}                          ");
                    Console.WriteLine("");
                    Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
                }
                #endregion

                Console.ReadLine();
        }
    }
}
