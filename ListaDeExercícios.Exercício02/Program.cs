﻿namespace ListaDeExercícios.Exercicio02
{
    internal class Program
    {
        /*Crie um Programa Para Calcular o Volume de Um Cilindro
          Fórmula: V = PI* R * R* A
        */
        static void Main(string[] args)
        {
            #region Menu
            Console.Clear();
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("                                             Calcule o Volume de Um Cilindro                                            ");
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
            #endregion

            # region   Imput de Dados
            Console.Write("Digite o Raio do Cilindro: ");
            double raio = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("");

            Console.Write("Digite a Altura do Cilindro: ");
            double altura = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("");
            #endregion

            #region Processamento
            double volume = Math.PI * Math.Pow(raio, 2) * altura;
            #endregion

            #region OutPut
            Console.WriteLine($"O Volume do Cilindro é de {volume}.");
            Console.WriteLine("");
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
            #endregion

            Console.ReadLine();
        }
    }
}
