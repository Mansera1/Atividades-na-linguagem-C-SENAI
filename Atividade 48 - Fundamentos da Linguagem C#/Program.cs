List<int> numeros = new List<int>();
int maior = 0;
int menor = int.MaxValue; ;

Console.WriteLine("Infome 10 numeros:");

for (int i = 0; i < 10; i++)
{
    int numero = Convert.ToInt32(Console.ReadLine());
    numeros.Add(numero);
}

foreach (int numero in numeros)
{
    if (numero > maior)
    {
        maior = numero;
    }

    if (numero < menor)
    {
        menor = numero;
    }
}

Console.Write("O numero maior é: " + maior + " e o numero menor é: " + menor);
