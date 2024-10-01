int numero;
do
{
    Console.Write("Tente adivinhar o número secreto (Tem que ser um número inteiro): ");
    numero = int.Parse(Console.ReadLine());

    Console.WriteLine($"Você digitou: {numero}");
} while (numero != 7);

Console.WriteLine("Você acertou o número secreto!!");
Console.ReadKey();