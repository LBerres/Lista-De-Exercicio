namespace ListaDeExercícios.Exercício02
{
    internal class Program
    {

        // Crie um Programa Para Calcular o Volume de Um Cilindro
        // V = PI * R * R * A
        static void Main(string[] args)
        {
            // Imput de Dados
            Console.Write("Digite o Raio do Cilindro: ");
            double raio = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite a Altura do Cilindro: ");
            double altura = Convert.ToDouble(Console.ReadLine());

            // Processamento
            double volume = Math.PI * Math.Pow(raio, 2) * altura;

            // Output

        }
    }
}
