namespace ListaDeExercícios.Exercício02
{
    internal class Program
    {
        /*Crie um Programa Para Calcular o Volume de Um Cilindro
          Fórmula: V = PI* R * R* A
        */
        static void Main(string[] args)
        {
            # region   Imput de Dados
            Console.Write("Digite o Raio do Cilindro: ");
            double raio = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite a Altura do Cilindro: ");
            double altura = Convert.ToDouble(Console.ReadLine());
            #endregion

            #region Processamento
            double volume = Math.PI * Math.Pow(raio, 2) * altura;
            #endregion

            #region OutPut
            Console.WriteLine($"O Volume do Cilindro é de {volume}.");
            #endregion

            Console.ReadLine();
        }
    }
}
