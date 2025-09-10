using System;
using System.Collections.Generic;

/// <summary>
/// Programa para gerenciar o inventário de um jogo:
/// - Inicializa um dicionário com itens.
/// - Remove um item específico do inventário.
/// - Adiciona um novo item ao inventário.
/// - Exibe a lista atualizada de itens.
///
/// Exemplo de entrada:
/// Dictionary<int, string> inventario = new Dictionary<int, string>()
/// {
///     { 1, "Espada Longa" },
///     { 2, "Arco Curto" },
///     { 3, "Escudo de Ferro" }
/// };
///
/// Saída esperada:
/// Itens no inventário inicial:
/// ID: 1 - Espada Longa
/// ID: 2 - Arco Curto
/// ID: 3 - Escudo de Ferro
/// ---------------------
/// Itens no inventário atualizado:
/// ID: 1 - Espada Longa
/// ID: 4 - Poção de Vida
/// ID: 3 - Escudo de Ferro
/// </summary>
static void Main(string[] args)
{
    // Inicializando o inventário
    Dictionary<int, string> inventario = new Dictionary<int, string>()
        {
            { 1, "Espada Longa" },
            { 2, "Arco Curto" },
            { 3, "Escudo de Ferro" }
        };

    // Exibindo inventário inicial
    Console.WriteLine("Itens no inventário inicial:");
    foreach (var item in inventario)
    {
        Console.WriteLine($"ID: {item.Key} - {item.Value}");
    }

    Console.WriteLine("---------------------");

    // Removendo um item (exemplo: ID 2)
    inventario.Remove(2);

    // Adicionando um novo item (exemplo: ID 4)
    inventario.Add(4, "Poção de Vida");

    // Exibindo inventário atualizado
    Console.WriteLine("Itens no inventário atualizado:");
    foreach (var item in inventario)
    {
        Console.WriteLine($"ID: {item.Key} - {item.Value}");
    }
}
