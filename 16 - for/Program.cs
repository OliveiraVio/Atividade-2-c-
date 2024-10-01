
Console.Write("Informe um número: ");

if (int.TryParse(Console.ReadLine(), out int numero) && numero >= 0)
{
    long fatorial = 1;


    for (int i = 1; i <= numero; i++)
    {
        fatorial *= i;
    }


    Console.WriteLine($"O fatorial de {numero} é: {fatorial}");
}
else
{
    Console.WriteLine("Informe um número inteiro positivo.");
}

Console.WriteLine("Aperte qualquer tecla para encerrar!");
Console.ReadKey();