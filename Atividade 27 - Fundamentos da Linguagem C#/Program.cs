int idade, anosCategoriaB;
string possuiCategoriaB, cometeuInfracoes;

Console.WriteLine("Digite sua idade: ");

idade = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Voce possui CNH na categoria B? (Sim/Não):");

possuiCategoriaB = Convert.ToString(Console.ReadLine());

if (possuiCategoriaB == "Sim")
{
    Console.WriteLine("Há quantos anos você possui a CNH na categoria B?");

    anosCategoriaB = Convert.ToInt16(Console.ReadLine());
}
else
{
    anosCategoriaB = 0;
}

Console.WriteLine("Você cometeu infrações graves ou gravíssimas nos últimos 12 meses? (Sim/Não)");

cometeuInfracoes = Convert.ToString(Console.ReadLine());

if (idade >= 21 && anosCategoriaB >= 2 && cometeuInfracoes == "Não")
{
    Console.WriteLine("Voce pode tirar a CNH de categoria D");
}
else
{
    Console.WriteLine("Voce NÃO pode tirar a CNH de categoria C");
}
