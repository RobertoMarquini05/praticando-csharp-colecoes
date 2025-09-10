using System;
using System.Collections.Generic;

/// <summary>
/// Programa para consolidar o inventário de uma loja de eletrônicos:
/// - Declarar duas listas distintas de produtos.
/// - Adicionar todos os elementos da lista secundária na lista principal.
/// - Exibir a lista principal com todos os produtos.
///
/// Exemplo de entrada:
/// List<string> produtosPrincipal = new List<string> { "Mouse", "Teclado", "Monitor", "Joystick" };  
/// List<string> produtosSecundaria = new List<string> { "Headset", "Webcam", "Smartphone", "Mousepad" };  
///
/// Saída esperada:
/// Lista consolidada:
/// Mouse
/// Teclado
/// Monitor
/// Joystick
/// Headset
/// Webcam
/// Smartphone
/// Mousepad
/// </summary>
static void Main(string[] args)
{
    List<string> produtosPrincipal = new List<string> { "Mouse", "Teclado", "Monitor", "Joystick" };
    List<string> produtosSecundaria = new List<string> { "Headset", "Webcam", "Smartphone", "Mousepad" };

    // Adiciona todos os produtos da lista secundária à principal
    produtosPrincipal.AddRange(produtosSecundaria);

    Console.WriteLine("Lista consolidada:");
    foreach (var produto in produtosPrincipal)
    {
        Console.WriteLine(produto);
    }
}
