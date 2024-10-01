
Console.Write("Informe um número positivo: ");
int numero = int.Parse(Console.ReadLine());
int numero2 = numero * 10;


Console.WriteLine($"\nNumeros de 0 até {numero}");
for (int i = 0; i <= numero2; i += numero)
{
    Console.WriteLine(i);
}

Console.WriteLine("Digite uma tecla para sair! ");
Console.ReadKey();