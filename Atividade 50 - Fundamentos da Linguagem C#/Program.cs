using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<(string Titulo, string Autor, int Ano)> listaTitulos = new List<(string, string, int)>();
        int escolha;

        do
        {
            Console.Clear();
            Console.WriteLine("Menu:");
            Console.WriteLine("1: Adicionar um livro");
            Console.WriteLine("2: Remover um livro");
            Console.WriteLine("3: Mostrar os livros disponíveis");
            Console.WriteLine("4: Pesquisar um livro");
            Console.WriteLine("5: Sair");

            Console.Write("\nEscolha uma opção: ");
            if (!int.TryParse(Console.ReadLine(), out escolha))
            {
                Console.WriteLine("Entrada inválida. Pressione qualquer tecla para continuar...");
                Console.ReadKey();
                continue;
            }

            switch (escolha)
            {
                case 1:
                    int opcaoAdicionar;
                    do
                    {
                        Console.Clear();
                        Console.WriteLine("Adicionar um livro:");
                        Console.Write("Informe o título do livro: ");
                        string titulo = Console.ReadLine();
                        Console.Write("Informe o autor do livro: ");
                        string autor = Console.ReadLine();
                        Console.Write("Informe o ano do livro: ");
                        int ano = int.Parse(Console.ReadLine());
                        listaTitulos.Add((titulo, autor, ano));
                        Console.WriteLine("\nLivro adicionado com sucesso!");

                        Console.WriteLine("\nDigite 1 para adicionar outro ou qualquer outra tecla para voltar ao menu.");
                        if (!int.TryParse(Console.ReadLine(), out opcaoAdicionar) || opcaoAdicionar != 1)
                            break;

                    } while (true);
                    break;

                case 2:
                    int opcaoRemover;
                    do
                    {
                        Console.Clear();
                        Console.WriteLine("Remover um livro:");
                        Console.Write("Informe o título do livro: ");
                        string titulo = Console.ReadLine();
                        Console.Write("Informe o autor do livro: ");
                        string autor = Console.ReadLine();
                        Console.Write("Informe o ano do livro: ");
                        int ano = int.Parse(Console.ReadLine());

                        var livroParaRemover = listaTitulos.FirstOrDefault(l => l.Titulo == titulo && l.Autor == autor && l.Ano == ano);

                        if (!livroParaRemover.Equals(default((string, string, int))))
                        {
                            listaTitulos.Remove(livroParaRemover);
                            Console.WriteLine("\nLivro removido com sucesso!");
                        }
                        else
                        {
                            Console.WriteLine("\nLivro não encontrado.");
                        }

                        Console.WriteLine("\nDigite 2 para remover outro ou qualquer outra tecla para voltar ao menu.");
                        if (!int.TryParse(Console.ReadLine(), out opcaoRemover) || opcaoRemover != 2)
                            break;

                    } while (true);
                    break;

                case 3:
                    Console.Clear();
                    Console.WriteLine("Livros disponíveis:");
                    if (listaTitulos.Count == 0)
                    {
                        Console.WriteLine("Nenhum livro cadastrado.");
                    }
                    else
                    {
                        foreach (var livro in listaTitulos)
                        {
                            Console.WriteLine($"Título: {livro.Titulo}, Autor: {livro.Autor}, Ano: {livro.Ano}");
                        }
                    }
                    Console.WriteLine("\nPressione qualquer tecla para voltar ao menu...");
                    Console.ReadKey();
                    break;

                case 4:
                    Console.Clear();
                    Console.WriteLine("Pesquisar um livro:");
                    Console.Write("Informe o título para pesquisar: ");
                    string tituloPesquisa = Console.ReadLine();

                    var livrosEncontrados = listaTitulos
                        .Where(l => l.Titulo.Contains(tituloPesquisa, StringComparison.OrdinalIgnoreCase))
                        .ToList();

                    if (livrosEncontrados.Count > 0)
                    {
                        foreach (var livro in livrosEncontrados)
                        {
                            Console.WriteLine($"Título: {livro.Titulo}, Autor: {livro.Autor}, Ano: {livro.Ano}");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Nenhum livro encontrado com esse título.");
                    }
                    Console.WriteLine("\nPressione qualquer tecla para voltar ao menu...");
                    Console.ReadKey();
                    break;

                case 5:
                    Console.WriteLine("\nSaindo do programa...");
                    break;

                default:
                    Console.WriteLine("\nOpção inválida. Pressione qualquer tecla para tentar novamente...");
                    Console.ReadKey();
                    break;
            }

        } while (escolha != 5);
    }
}
