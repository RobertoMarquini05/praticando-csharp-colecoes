using System;
using System.Collections.Generic;
/// <summary>
/// Você está desenvolvendo um sistema de recompensas para uma plataforma de ensino. 
/// Quando alunos completam desafios difíceis, eles recebem mensagens secretas que só podem ser lidas quando decifradas. 
/// Para decifrar uma mensagem, é preciso invertê-la.
///
/// A mensagem atual é:
/// 'o', 'd', 'n', 'u', 'm', ' ', 'á', 'l', 'o'.
///
/// Crie um programa que:
/// - Inicialize uma lista com os caracteres descritos acima
/// - Decifre a mensagem dada pelos caracteres descritos
/// - Exiba o resultado
///
/// Saída esperada:
/// o
/// l
/// á
///  
/// m
/// u
/// n
/// d
/// o
/// </summary>
static void Main(string[] args)
{
    List<char> mensagem = new List<char> { 'o', 'd', 'n', 'u', 'm', ' ', 'á', 'l', 'o' };

    mensagem.Reverse(); // inverte a lista

    foreach (char c in mensagem)
    {
        Console.WriteLine(c);
    }
}