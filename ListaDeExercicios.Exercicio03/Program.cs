namespace ListaDeExercicios.Exercicio03
{
    /* Crie um Programa Que Calcule o Consumo de Combustível por Quilômetro Percorrido em uma Viagem.
     * O Programa Deve Solicitar ao Usuário:
    
        ● A Quilometragem Inicial do Veículo no Início da Viagem.
        ● A Quilometragem Final ao Término da Viagem.
        ● A Quantidade de Combustível Consumida Durante a Viagem (em Litros).
    */
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Imput de Dados
            Console.Write("Digite a Quilometragem Inicial do Veículo: ");
            decimal KMInicial = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Digite a Quilometragem Final do Veículo: ");
            decimal KMFinal = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Digite a Quantidade de Combustível Consumida Durante a Viagem (em Litros): ");
            decimal combustivelConsumido = Convert.ToDecimal(Console.ReadLine());
            #endregion

            #region Processamento
            decimal distanciaPercorrida = KMFinal - KMInicial;
            decimal consumoPorKm = combustivelConsumido / distanciaPercorrida;

            Console.WriteLine($"O Veículo Consumiu: {consumoPorKm} Litros por KM.");
            #endregion

            Console.ReadLine();
        }
    }
}
