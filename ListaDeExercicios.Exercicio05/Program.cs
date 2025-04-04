namespace ListaDeExercicios.Exercicio05
{
    /* Crie um Programa Para Calcular o Salário Total de um Vendedor. Deverá Ser Informado o Salário Base e o Total de Vendas.
       A Comissão é Calculada com um Percentual (Informado Pelo Usuário) Sobre o Total de Vendas.
    */
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Menu
            Console.Clear();
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("                                          Calcule o Salário Total de um Vendedor                                        ");
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
            #endregion

            #region Imput de Dados
            Console.WriteLine("Digite o Salário Base em R$: ");
            decimal salarioBase = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("");

            Console.WriteLine("Digite o Total de Vendas em R$: ");
            decimal totalVendas = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("");

            Console.WriteLine("Digite o Percentual de Comissão (em %): ");
            decimal percentualComissao = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("");
            #endregion

            #region Processamento
            decimal comissao = (totalVendas * percentualComissao) / 100;
            decimal salarioTotal = salarioBase + comissao;
            #endregion

            #region Saída de Dados
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("");
            Console.WriteLine($"O Salário Total do Vendedor é de: R$ {salarioTotal}.");
            Console.WriteLine("");
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
            #endregion

            Console.ReadLine();

        }
    }
}
