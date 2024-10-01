
Console.Write("Escolha um número entre 1 a 12: ");
int NumeroMes = int.Parse(Console.ReadLine());

switch (NumeroMes)
{
    case 1:
        Console.WriteLine($"Você escolheu o mês: Janeiro, sua estação é Verão");
        break;
    case 2:
        Console.WriteLine($"Você escolheu o mês: Fevereiro, sua estação é Verão");
        break;
    case 3:
        Console.WriteLine($"Você escolheu o mês: Março, sua estação é Outono");
        break;
    case 4:
        Console.WriteLine($"Você escolheu o mês: Abril, sua estação é Outono");
        break;
    case 5:
        Console.WriteLine($"Você escolheu o mês: Maio, sua estação é Outono");
        break;
    case 6:
        Console.WriteLine($"Você escolheu o mês: Junho, sua estação é Inverno");
        break;
    case 7:
        Console.WriteLine($"Você escolheu o mês: Julho, sua estação é Inverno");
        break;
    case 8:
        Console.WriteLine($"Você escolheu o mês: Agosto, sua estação é Inverno");
        break;
    case 9:
        Console.WriteLine($"Você escolheu o mês: Setembro, sua estação é Primavera");
        break;
    case 10:
        Console.WriteLine($"Você escolheu o mês: Outubro, sua estação é Primavera");
        break;
    case 11:
        Console.WriteLine($"Você escolheu o mês: Novembro, sua estação é Primavera");
        break;
    case 12:
        Console.WriteLine($"Você escolheu o mês: Dezembro, sua estação é Verão");
        break;
    default:
        Console.WriteLine("O número que você escolheu não é permitido");
        Console.WriteLine("Escolha um número entre 1 e 12");
        break;
}

Console.WriteLine("Clique uma tecla para encerrar");
Console.ReadKey();