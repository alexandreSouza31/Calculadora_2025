internal class Program
{
    private static void Main(string[] args)
    {

        string[] operacoesRealizadas = new string[100];
        int contador = 0;

        while (true)
        {

            Console.Clear();
            Console.WriteLine($"Arrey na posição 0: {operacoesRealizadas[0]}");
            Console.WriteLine($"Arrey na posição 0: {operacoesRealizadas[1]}");

            Console.WriteLine("------------------------------");
            Console.WriteLine("Calculadora Tabajara 2025!");
            Console.WriteLine("------------------------------");

            Console.WriteLine("Escolha a operação:");
            Console.WriteLine("1 - Somar");
            Console.WriteLine("2 - Subtrair");
            Console.WriteLine("3 - Multiplicar");
            Console.WriteLine("4 - Dividir");
            Console.WriteLine("5 - Tabuada");
            Console.WriteLine("6 - Histórico de operações");
            Console.WriteLine("S - Sair \n");

            string opcao = Console.ReadLine();

            Console.WriteLine($"Operação escolhida: {opcao}");

            if (opcao == "5")
            {
                Console.WriteLine("\n ..............................");
                Console.WriteLine("Tabuada");
                Console.WriteLine("..............................");

                Console.Write("Digite o número desejado: ");
                string strNumeroTabuada = Console.ReadLine();
                int numeroTabuada = Convert.ToInt32(strNumeroTabuada);

                for (int i = 1; i <= 10; i++)
                {
                    Console.WriteLine($"{numeroTabuada} x {i} = {numeroTabuada * i}");
                }

                Console.ReadLine();
                continue;
            }

            if (opcao == "6")
            {
                Console.WriteLine("\n ..............................");
                Console.WriteLine("Histórico de operações");
                Console.WriteLine("..............................");

                for (int i = 0; i < operacoesRealizadas.Length; i++)
                {
                    if (operacoesRealizadas[i] != null) { 
                    Console.WriteLine(operacoesRealizadas[i]);
                    break;
                    }
                
                    else if (operacoesRealizadas[i] == null)
                    {
                        Console.WriteLine("Histórico vazio! Nenhuma operação realizada ainda!");
                        break;
                    }
                }

                Console.ReadLine();
                continue;
            }
            Console.WriteLine("..............................");

            if (opcao == "S" || opcao == "s")
                break;


            Console.WriteLine("Digite o primeiro número:");
            string strPrimeiroNumero = Console.ReadLine();
            double primeiroNumero = Convert.ToDouble(strPrimeiroNumero);

            Console.WriteLine("Digite o segundo número:");
            string strSegundoNumero = Console.ReadLine();
            double segundoNumero = Convert.ToDouble(strSegundoNumero);

            double resultado;

            if (opcao == "1")
            {
                resultado = primeiroNumero + segundoNumero;
                operacoesRealizadas[contador] = $"{primeiroNumero} + {segundoNumero} = {resultado} \n";
                Console.WriteLine("\n O resultado é: " + resultado);
            }
            else if (opcao == "2")
            {
                resultado = primeiroNumero - segundoNumero;
                operacoesRealizadas[contador] =$"{primeiroNumero} - {segundoNumero} = {resultado} \n";
                Console.WriteLine("\n O resultado é: " + resultado);
            }
            else if (opcao == "3")
            {
                resultado = primeiroNumero * segundoNumero;
                operacoesRealizadas[contador] =$"{primeiroNumero} * {segundoNumero} = {resultado} \n";
                Console.WriteLine("\n O resultado é: " + resultado);
            }
            else if (opcao == "4" & segundoNumero == 0)
            {
                Console.WriteLine("\n Não é possível dividir por zero!");
                Console.ReadLine();
                continue;
            }

            else if (opcao == "4")

            {
                resultado = primeiroNumero / segundoNumero;
                operacoesRealizadas[contador] =$"{primeiroNumero} / {segundoNumero} = {resultado} \n";
                Console.WriteLine("\n O resultado é: " + resultado);
            }

            else
             { 
                Console.WriteLine("\n Operação inválida!"); 
            }
            Console.WriteLine("..............................");
            
            contador++;

            Console.ReadLine();
        }
    }
}