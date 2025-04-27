int idade;

Console.WriteLine("Informe a idade: ");

idade = int.Parse(Console.ReadLine());

if (idade >= 18)
{
    Console.WriteLine("Voce é maior de idade");
}
else
{
    Console.WriteLine("Voce é menor de idade");
}