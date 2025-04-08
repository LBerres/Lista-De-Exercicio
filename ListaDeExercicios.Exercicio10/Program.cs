namespace ListaDeExercicios.Exercicio10
{
    internal class Program
    {
        /*
         * O IMC – Índice de Massa Corporal é um critério da Organização Mundial de Saúde para dar uma indicação sobre
            a condição de peso de uma pessoa adulta. A fórmula é IMC = peso / (altura) 2. Elabore um algoritmo que leia o
            peso e a altura de um adulto e mostre sua condição de acordo com a listagem abaixo:
            ● IMC em adultos Condição
            ● Abaixo de 18,5
            ● Abaixo do peso
            ● Entre 18,5 e 25 Peso normal
            ● Entre 25 e 30
            ● Acima do peso
            ● Acima de 30 obeso 
        */
        static void Main(string[] args)
        {
            #region Menu
            Console.Clear();
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("                                                 Calcule o Seu IMC!                                                     ");
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
            #endregion

            #region Imput de Dados
            Console.WriteLine("Digite o seu Peso (em kg): ");
            decimal peso = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Digite a sua Altura (em metros): ");
            decimal altura = Convert.ToDecimal(Console.ReadLine());

            decimal imc = peso / (altura * altura);
            #endregion

            #region Processamento
            bool abaixoDoPeso = false;
            bool pesoNormal = false;
            bool acimaDoPeso = false;
            bool obeso = false;

            if (imc < 18.5m)
            {
                abaixoDoPeso = true;
            }
            else if (imc >= 18.5m && imc < 25)
            {
                pesoNormal = true;
            }
            else if (imc >= 25 && imc < 30)
            {
                acimaDoPeso = true;
            }
            else if (imc >= 30)
            {
                obeso = true;
            }
            #endregion

            #region Saída de Dados
            if (abaixoDoPeso == true)
            {
                Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
                Console.WriteLine("                                         Você Está Abaixo do Peso!                                                      ");
                Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
            }
            else if (pesoNormal == true)
            {
                Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
                Console.WriteLine("                                          Você Está  Peso Normal!                                                       ");
                Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
            }
            else if (acimaDoPeso == true)
            {
                Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
                Console.WriteLine("                                          Você Está  Acima do Peso!                                                     ");
                Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
            }
            else if (obeso == true)
            {
                Console.Clear();
                Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
                Console.WriteLine("                                              Você Está  Obeso!                                                         ");
                Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
            }
            #endregion

            Console.ReadLine();
        }
    }
}
