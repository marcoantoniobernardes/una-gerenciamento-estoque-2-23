using System;
using System.Collections.Generic;

public class Produtos
{
    public string produto;
    public int quantidade;
    public Dictionary<string, int> listaEstoque = new Dictionary<string, int>();
    
    //
    public void Iniciar()
    {
        Console.WriteLine("Bem-vindo ao sistema de gestão de produtos!");

        while (true)
        {
            Console.WriteLine("Escolha uma opção:");
            Console.WriteLine("1. Adicionar ou alterar produto");
            Console.WriteLine("2. Exibir lista de produtos");
            Console.WriteLine("3. Remover produto");
            Console.WriteLine("4. Sair");

            string opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    Console.WriteLine("Produto: ");
                    produto = Console.ReadLine();
                    Console.WriteLine("Quantidade: ");
                    quantidade = int.Parse(Console.ReadLine());
                    AddAlterar(produto, quantidade);
                    break;

                case "2":
                    ExibirLista();
                    break;

                case "3":
                    Console.WriteLine("Digite o nome do produto que deseja remover: ");
                    produto = Console.ReadLine();
                    RemoverItem(produto);
                    break;

                case "4":
                    Console.WriteLine("Saindo ...");
                    return;

                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    break;
            }
        }
    }
    
    //adiciona ou alterna produto
    public void AddAlterar(string produto, int quantidade)
    {
        listaEstoque[produto] = quantidade;
    }
    
    public void ExibirLista()
    {
        Console.WriteLine("Lista: ");
        foreach (var par in listaEstoque)
        {
            Console.WriteLine($"{par.Key}: {par.Value}");
        }
    }
    
    public void RemoverItem(string produto)
    {
        listaEstoque.Remove(produto);
    }
}