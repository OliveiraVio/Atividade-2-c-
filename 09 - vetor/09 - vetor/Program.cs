string[] diasemana = new string[] {


    "SEGUNDA",
    "TERÇA",
    "QUARTA ",
    "QUINTA",
    "SEXTA",
    "SÁBADO",
    "DOMINGO" };

string[] tarefas = new string[7];

for (int i = 0; i < diasemana.Length; i++)
{
    Console.Write($"Informe sua tarefa de {diasemana[i]}: ");
    tarefas[i] = Console.ReadLine();
}

Console.WriteLine("\nTarefas da semana:");
for (int i = 0; i < diasemana.Length; i++)
{
    Console.WriteLine($"{diasemana[i]}: {tarefas[i]}");
}

Console.ReadKey();
