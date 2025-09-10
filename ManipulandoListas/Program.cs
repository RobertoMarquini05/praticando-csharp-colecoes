using System;
using System.Collections.Generic;

/// <summary>
/// Sistema de sorteio para um evento beneficente:
/// - Declarar uma lista de nomes.
/// - Organizar a lista em ordem alfabética.
/// - Inverter a ordem da lista.
/// - Remover o primeiro elemento e adicioná-lo novamente no fim.
/// - Verificar quem está no índice 3 da lista e exibir no console.
///
/// Exemplo de entrada:
/// List<string> nomes = new List<string> { "Ana", "Carlos", "Mariana", "João", "Lúcia" };
///
/// Saída esperada:
/// Lista original:
/// Ana, Carlos, Mariana, João, Lúcia
///  
/// Após Sort (ordem alfabética):
/// Ana, Carlos, João, Lúcia, Mariana
///  
/// Após Reverse (ordem invertida):
/// Mariana, Lúcia, João, Carlos, Ana
///  
/// Após remover o primeiro e adicioná-lo no fim:
/// Lúcia, João, Carlos, Ana, Mariana
///  
/// A pessoa sorteada foi: Ana
/// </summary>
static void Main(string[] args)
{
    List<string> nomes = new List<string> { "Ana", "Carlos", "Mariana", "João", "Lúcia" };

    Console.WriteLine("Lista original:");
    Console.WriteLine(string.Join(", ", nomes));
    Console.WriteLine();

    nomes.Sort();
    Console.WriteLine("Após Sort (ordem alfabética):");
    Console.WriteLine(string.Join(", ", nomes));
    Console.WriteLine();

    nomes.Reverse();
    Console.WriteLine("Após Reverse (ordem invertida):");
    Console.WriteLine(string.Join(", ", nomes));
    Console.WriteLine();

    string primeiro = nomes[0];
    nomes.RemoveAt(0);
    nomes.Add(primeiro);

    Console.WriteLine("Após remover o primeiro e adicioná-lo no fim:");
    Console.WriteLine(string.Join(", ", nomes));
    Console.WriteLine();

    Console.WriteLine($"A pessoa sorteada foi: {nomes[3]}");
}
