List<int> num = new List<int>(); 
int escolha;

do
{
    Console.WriteLine("1: Adicionar um número");
    Console.WriteLine("2: Remover um número");
    Console.WriteLine("3: Mostrar a lista de números");
    Console.WriteLine("4: Sair");

    escolha = Convert.ToInt32(Console.ReadLine());

    switch (escolha)
    {
        case 1:
            Console.WriteLine("Digite o número para adicionar:");
            int addNumero = Convert.ToInt32(Console.ReadLine());
            num.Add(addNumero);
            Console.WriteLine("Número adicionado.");
            break;

        case 2:
            Console.WriteLine("Digite o número para remover:");
            int removerNumero = Convert.ToInt32(Console.ReadLine());
            if (num.Remove(removerNumero))
            {
                Console.WriteLine("Número removido.");
            }
            else
            {
                Console.WriteLine("Número não encontrado na lista.");
            }
            break;

        case 3:
            Console.WriteLine("Lista de números:");
            if (num.Count > 0)
            {
                foreach (int numero in num)
                {
                    Console.Write(numero + ", ");
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("A lista está vazia.");
            }
            break;

        case 4:
            Console.WriteLine("Saindo...");
            break;

        default:
            Console.WriteLine("Opção inválida, tente novamente.");
            break;
    }

} while (escolha != 4);

