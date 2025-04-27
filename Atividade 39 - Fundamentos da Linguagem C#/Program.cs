int quilometros;
double m, km, cm, mm;

Console.WriteLine("Escolha o tipo de conversão de Quilômetros");

Console.WriteLine("1:Converter para Metros");

Console.WriteLine("2:Converter para Centimetros");

Console.WriteLine("3:Converter para Millimetros");

quilometros = int.Parse(Console.ReadLine());

switch (quilometros)
{
    case 1:
        Console.WriteLine("1:Converter para Metros");

        Console.WriteLine("Informe o valor em Quilômetros");

        km = Convert.ToDouble(Console.ReadLine());

        m = km / 0.0010000;

        Console.WriteLine("O valor em metros é " + m);
        break;

    case 2:
        Console.WriteLine("2:Converter para Centimetros");

        Console.WriteLine("Informe o valor em Quilômetros:");
        km = Convert.ToDouble(Console.ReadLine());

        cm = km / 0.000010000;

        Console.WriteLine("O valor em centimetros é " + cm);
        break;

    case 3:
        Console.WriteLine("3:Converter para Millimetros");

        Console.WriteLine("Informe o valor em Quilômetros:");
        km = Convert.ToDouble(Console.ReadLine());

        mm = km / 0.0000010000;

        Console.WriteLine("O valor em milimetros é " + mm);
        break;

}
