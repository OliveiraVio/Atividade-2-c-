int numero1;

Console.WriteLine("Informe sua nota de 0 a 100: ");
int.TryParse(Console.ReadLine(), out numero1);

if (numero1 >= 90 && numero1 <= 100)
    Console.WriteLine($"\n A nota foi de {numero1} então sua classificação é: A ");

else if (numero1 >= 80 && numero1 <= 89)
    Console.WriteLine($"\n A nota foi de {numero1} então sua classificação é: B");

else if (numero1 >= 70 && numero1 <= 79)
    Console.WriteLine($"\n A nota foi de {numero1} então sua classificação é: C ");

else if (numero1 >= 60 && numero1 <= 69)
    Console.WriteLine($"\n A nota foi de {numero1} então sua classificação é: D");

else
    Console.WriteLine($"\n A nota foi de {numero1} então sua classificação é: F");

Console.ReadKey();