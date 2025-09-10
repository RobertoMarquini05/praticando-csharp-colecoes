﻿using System;

/// <summary>
/// Você está explorando um cofre cibernético. Ao chegar ao último corredor, você se depara com um cadeado inteligente 
/// que protege um artefato tecnológico perdido. O mecanismo de segurança exige que você decifre um código baseado em 
/// posições dentro da sequência numérica 5, 42, 8, 11, 23, 1, 14, 30, 19, 27, 36, 2, 50, 7, 18, 9.
///
/// O sistema gera uma combinação única a cada acesso, onde:
/// - O primeiro dígito é a posição onde o número 19 está localizado.
/// - O segundo dígito é a posição onde o número 42 está localizado.
/// - O terceiro dígito é a posição onde o número 7 está localizado.
///
/// Crie um programa que:
/// - Declare um array de números inteiros.
/// - Localize no array o índice de cada um dos números da combinação.
/// - Exiba a combinação no console.
///
/// Exemplo de entrada:
/// int[] numeros = { 5, 42, 8, 11, 23, 1, 14, 30, 19, 27, 36, 2, 50, 7, 18, 9 };
///
/// Saída esperada:
/// Combinação do cadeado: 8-1-13
/// </summary>
static void Main(string[] args)
{
    int[] numeros = { 5, 42, 8, 11, 23, 1, 14, 30, 19, 27, 36, 2, 50, 7, 18, 9 };

    int pos19 = Array.IndexOf(numeros, 19) + 1; // +1 pois queremos a posição (não o índice)
    int pos42 = Array.IndexOf(numeros, 42) + 1;
    int pos7 = Array.IndexOf(numeros, 7)  + 1;

    Console.WriteLine($"Combinação do cadeado: {pos19}-{pos42}-{pos7}");
}