try
{
    Console.Write("Informe o primeiro número: ");
    int numero = int.Parse(Console.ReadLine());

    Console.Write("Informe o segundo número: ");
    int numero2 = int.Parse(Console.ReadLine());

    int resultado = numero + numero2;
    Console.WriteLine($"Seu resultado da soma é: {resultado}");
}
catch (DivideByZeroException)
{
    Console.WriteLine("Erro: Não é possível dividir por zero");
}
catch (FormatException)
{
    Console.WriteLine("Erro: Por favor, digite números válidos");
}
Console.ReadKey();
