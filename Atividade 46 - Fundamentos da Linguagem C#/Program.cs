List<string> nomes = new List<string>();


Console.WriteLine("Informe 10 nomes:");

for (int i = 0; i < 10; i++)
{
    string nome = Console.ReadLine();
    nomes.Add(nome);
}

Console.WriteLine("Os nomes foram armazenados:");

foreach (string nome in nomes)
{
    Console.Write(nome + ",");
}