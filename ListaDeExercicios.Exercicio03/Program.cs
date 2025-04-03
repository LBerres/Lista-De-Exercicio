namespace ListaDeExercicios.Exercicio03
{
    /* Crie um Programa Que Calcule O Consumo de Combustível Por Quilômetro Percorrido em uma Viagem.
     * O Programa Deve Solicitar ao Usuário:
    
        ● A Quilometragem Inicial do Veículo no Início da Viagem.
        ● A Quilometragem Final ao Término da Viagem.
        ● A Quantidade de Combustível Consumida Durante a Viagem (em Litros).
    */
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Menu
            Console.Clear();
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("                                Calcule O Consumo de Combustível Por Quilômetro Percorrido                              ");
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
            #endregion

            #region Imput de Dados
            Console.Write("Digite a Quilometragem Inicial do Veículo: ");
            decimal KMInicial = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("");


            Console.Write("Digite a Quilometragem Final do Veículo: ");
            decimal KMFinal = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("");


            Console.Write("Digite a Quantidade de Combustível Consumida Durante a Viagem (em Litros): ");
            decimal combustivelConsumido = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("");
            #endregion

            #region Processamento
            decimal distanciaPercorrida = KMFinal - KMInicial;
            decimal consumoPorKm = combustivelConsumido / distanciaPercorrida;

            Console.WriteLine($"O Veículo Consumiu: {consumoPorKm} Litros por KM.");
            Console.WriteLine("");
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
            #endregion

            Console.ReadLine();
        }
    }
}
