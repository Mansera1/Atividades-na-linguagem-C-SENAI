int temperatura;
double tk, tc, tf;

Console.WriteLine("Escolha o tipo de conversão de temperatura");

Console.WriteLine("1:Converter graus Kelvin em Celsius");

Console.WriteLine("2:Converter graus Kelvin em Fahrenheit");

Console.WriteLine("3:Converter graus em Fahrenheit em Kelvin");

Console.WriteLine("4:Converter graus celsius em Fahrenheit");

Console.WriteLine("5:Converter graus celsius em Kelvin");

temperatura = int.Parse(Console.ReadLine());

switch (temperatura)
{
    case 1:
        Console.WriteLine("1:Converter graus Kelvin em Celsius");

        Console.WriteLine("Informe a temperatura em Kelvin:");

        tk = Convert.ToDouble(Console.ReadLine());

        tc = tk - 273.15;

        Console.WriteLine("A temperatura em Celcius:" + tc);
        break;

    case 2:
        Console.WriteLine("2:Converter graus Kelvin em Fahrenheit");

        Console.WriteLine("Informe a temperatura em Kelvin:");
        tk = Convert.ToDouble(Console.ReadLine());

        tf = (tk - 273.15) * 9 / 5 + 32;

        Console.WriteLine("A temperatura em Fahrenheit:" + tf);
        break;

    case 3:
        Console.WriteLine("3:Converter graus em Fahrenheit em Kelvin");

        Console.WriteLine("Informe a temperatura em Fahrenheit:");
        tf = Convert.ToDouble(Console.ReadLine());

        tk = (tf + 459.67) * 5 / 9;

        Console.WriteLine("A temperatura em Kelvin:" + tk);
        break;

    case 4:
        Console.WriteLine("4:Converter graus Celsius em Fahrenheit");

        Console.WriteLine("Informe a temperatura em Celsius:");
        tc = Convert.ToDouble(Console.ReadLine());

        tf = (tc * 1.8) + 32;

        Console.WriteLine("A temperatura em Fahrenheit:" + tf);
        break;

    case 5:
        Console.WriteLine("5:Converter graus Celsius em Kelvin");

        Console.WriteLine("Informe a temperatura em Celsius:");
        tc = Convert.ToInt32(Console.ReadLine());

        tk = tc + 273;

        Console.WriteLine("A temperatura em Kelvin:" + tk);
        break;
}
