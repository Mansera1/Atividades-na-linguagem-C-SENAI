int numero, dobro;

Console.WriteLine(" Escreva um numero:");

numero = int.Parse(Console.ReadLine());

dobro = numero * 2;

if (dobro >= 10 && dobro <= 20)
{
    Console.WriteLine("O dobro do numero esta no intervalo de 10 a 20");
}
else
{
    Console.WriteLine("O dobro do numero não esta no intervalo de 10 a 20");
}
