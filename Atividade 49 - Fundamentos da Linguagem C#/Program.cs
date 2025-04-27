List<(string Nome, int Numero, int Votos)> candidatos = new List<(string, int, int)>();

Console.WriteLine("Cadastro de candidatos:");
Console.Write("Quantos candidatos deseja cadastrar? ");
int cadastro = int.Parse(Console.ReadLine());

for (int i = 0; i < cadastro; i++)
{
    Console.Write("Digite o nome do candidato: ");
    string nome = Console.ReadLine();
    Console.Write("Digite o numero do candidato: ");
    int numero = int.Parse(Console.ReadLine());
    candidatos.Add((nome, numero, 0));
    Console.WriteLine("Cadastro feito com sucesso!");
}

Console.WriteLine("Quantos votos serão cadastrados? ");
int quantidadeVotos = int.Parse(Console.ReadLine());

for (int i = 0; i < quantidadeVotos; i++)
{
    Console.Write("Candidatos disponiveis: ");
    foreach (var candidato in candidatos)
    {
        Console.Write($"Nome:{candidato.Nome},Numero:{candidato.Numero}");
    }

    Console.WriteLine("Digite o numero do candidato para votar: ");
    int voto = int.Parse(Console.ReadLine());


    for (int j = 0; j < candidatos.Count; j++)
    {
        if (candidatos[j].Numero == voto)
        {
            candidatos[j] = (candidatos[j].Nome, candidatos[j].Numero, candidatos[j].Votos + 1);
            Console.WriteLine("Voto cadastrado com sucesso!");
            break;
        }
    }
}
Console.WriteLine("Resultado da eleição: ");
foreach (var candidato in candidatos.OrderByDescending(c => c.Nome))
{
    Console.WriteLine($"{candidato.Nome} - {candidato.Numero} - {candidato.Votos}");
}