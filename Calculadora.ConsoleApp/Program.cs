﻿internal class Program
{
    private static void Main(string[] args)
    {

        string[] operacoesRealizadas = new string[100];
        int contador = 0;

        while (true)
        {

            Console.Clear();

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

            string opcao = Console.ReadLine().ToLower();

            Console.WriteLine($"Operação escolhida: {opcao}");

            if (opcao != "1" && opcao != "2" && opcao != "3" && opcao != "4" && opcao != "5" && opcao != "6" && opcao != "s")
            {
                Console.WriteLine("\n Operação inválida!");
                Console.ReadLine();
            }
            else
            {
                if (opcao == "5")
                {
                    Console.WriteLine("\n..............................");
                    Console.WriteLine("Tabuada");
                    Console.WriteLine("..............................");

                    Console.Write("Digite o número desejado: ");
                    int numeroTabuada = Convert.ToInt32(Console.ReadLine());

                    for (int i = 1; i <= 10; i++)
                    {
                        string resultadoTabuada = $"{numeroTabuada} x {i} = {numeroTabuada * i} \n";
                        Console.WriteLine(resultadoTabuada);
                        operacoesRealizadas[contador]+=resultadoTabuada;
                    }
                    contador++;
                    Console.ReadLine();
                    continue;
                }

                bool historicoVazio = true;

                if (opcao == "6")
                {
                    Console.WriteLine("\n ..............................");
                    Console.WriteLine("Histórico de operações");
                    Console.WriteLine("..............................");

                    for (int i = 0; i < operacoesRealizadas.Length; i++)
                    {
                        if (operacoesRealizadas[i] != null)
                        {
                            Console.WriteLine(operacoesRealizadas[i]);
                            historicoVazio = false;
                        }

                        else if (historicoVazio)
                        {
                            Console.WriteLine("Histórico vazio! Nenhuma operação realizada ainda!");
                            break;
                        }
                    }

                    Console.ReadLine();
                    continue;
                }
                Console.WriteLine("..............................");

                if (opcao == "s")
                    break;


                Console.WriteLine("Digite o primeiro número:");
                double primeiroNumero = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Digite o segundo número:");
                double segundoNumero = Convert.ToDouble(Console.ReadLine());

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
                    operacoesRealizadas[contador] = $"{primeiroNumero} - {segundoNumero} = {resultado} \n";
                    Console.WriteLine("\n O resultado é: " + resultado);
                }
                else if (opcao == "3")
                {
                    resultado = primeiroNumero * segundoNumero;
                    operacoesRealizadas[contador] = $"{primeiroNumero} * {segundoNumero} = {resultado} \n";
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
                    operacoesRealizadas[contador] = $"{primeiroNumero} / {segundoNumero} = {resultado} \n";
                    Console.WriteLine("\n O resultado é: " + resultado);
                }

                Console.WriteLine("..............................");

                contador++;

                Console.ReadLine();
            }

        }
    }
}