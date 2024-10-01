int opcao;

do
{
    Console.WriteLine("Menu de Opções:");
    Console.WriteLine("1. Exibir uma mensagem");
    Console.WriteLine("2. Fazer uma soma");
    Console.WriteLine("3. Sair");
    Console.Write("Escolha uma das opçôes acima: ");


    while (!int.TryParse(Console.ReadLine(), out opcao))
    {
        Console.WriteLine("Informe um número válido.");
        Console.Write("Selecione uma opção: ");
    }


    switch (opcao)
    {
        case 1:
            Console.WriteLine("\nOlá! Mensagem");
            break;

        case 2:
            Console.Write("Informe o primeiro número: ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Informe o segundo número: ");
            double num2 = Convert.ToDouble(Console.ReadLine());
            double soma = num1 + num2;
            Console.WriteLine($"A soma de {num1} e {num2} é: {soma}");
            break;

        case 3:
            Console.WriteLine("Desligando. Até logo!");
            break;

        default:
            Console.WriteLine("Opção inválida. Por favor, escolha uma opção válida.");
            break;
    }

    Console.WriteLine();
} while (opcao != 3);

Console.WriteLine("Aperte qualquer tecla para encerrar o programa");
Console.ReadKey();

