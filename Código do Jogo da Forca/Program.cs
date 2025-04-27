string verifica;

do
{
    string[] palavras = { "PROGRAMACAO", "COMPUTADOR", "MANUTENCAO", "VIDEO GAME", "TELEVISAO", "PRAIA" };
    Random range = new Random();
    string palavraSecreta = palavras[range.Next(palavras.Length)];
    char[] palavraOculta = new string('_', palavraSecreta.Length).ToCharArray();
    List<char> letrasTentadas = new List<char>();
    int tentativasRestantes = 6;

    while (tentativasRestantes > 0 && new string(palavraOculta) != palavraSecreta)
    {
        Console.Clear();
        Console.Clear();
        Console.WriteLine("Jogo da Forca");
        Console.WriteLine("Palavra: " + string.Join(" ", palavraOculta));
        Console.WriteLine("Letras tentadas: " + string.Join(" ", letrasTentadas));
        Console.WriteLine("Tentativas restantes: " + tentativasRestantes);
        Console.Write("Digite uma letra ");

        char tentativa = char.ToUpper(Console.ReadKey().KeyChar);
        Console.WriteLine();

        if (letrasTentadas.Contains(tentativa))
        {
            Console.WriteLine("Você já tentou essa letra! Aperte enter para tentar novamente!");
            Console.ReadKey();
            continue;
        }

        letrasTentadas.Add(tentativa);

        if (palavraSecreta.Contains(tentativa))
        {
            for (int i = 0; i < palavraSecreta.Length; i++)
            {
                if (palavraSecreta[i] == tentativa)
                {
                    palavraOculta[i] = tentativa;
                }
            }
        }
        else
        {
            tentativasRestantes--;
        }
    }

    Console.Clear();

    if (new string(palavraOculta) == palavraSecreta)
    {
        Console.WriteLine("Parabéns! Você acertou a palavra: " + palavraSecreta);
        Console.WriteLine("Gostaria de jogar novamente? (Sim/Não)");
        verifica = Console.ReadLine().ToLower();
        if (verifica == "sim")
        {
            tentativasRestantes = 6;
            Console.Clear();
        }

    }
    else
    {
        Console.WriteLine("Você foi enforcado! A palavra correta era: " + palavraSecreta);
        Console.WriteLine("Gostaria de jogar novamente? (Sim/Não)");
        verifica = Console.ReadLine().ToLower();
        if (verifica == "sim")
        {
            tentativasRestantes = 6;
            Console.Clear();
        }
    }
} while (verifica == "sim");
