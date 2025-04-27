int contador = 0;

for (int i = 0; i < 50; i++)
{
    if (i % 2 == 0)
    {
        contador = contador + 1;
    }
}

Console.WriteLine("A quantidade de números pares entre 1 e 50 é:" + contador);
