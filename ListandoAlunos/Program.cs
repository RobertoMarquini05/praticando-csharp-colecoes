using System;
using System.Collections.Generic;
/// <summary>
/// Programa para organizar notas finais de uma turma:
/// - Declarar um dicionário com informações de nome e nota de cada aluno.
/// - Iterar sobre o dicionário usando foreach.
/// - Exibir as notas na tela de forma clara.
///
/// Exemplo de entrada:
/// notas.Add("Ana", 8.75m);
/// notas.Add("Bruno", 6.90m);
/// notas.Add("Clara", 9.25m);
///
/// Saída esperada:
/// Aluno: Ana - Nota: 8,75
/// Aluno: Bruno - Nota: 6,90
/// Aluno: Clara - Nota: 9,25
/// </summary>
static void Main(string[] args)
{
    // Declarando o dicionário
    Dictionary<string, decimal> notas = new Dictionary<string, decimal>();

    // Adicionando alunos e notas
    notas.Add("Ana", 8.75m);
    notas.Add("Bruno", 6.90m);
    notas.Add("Clara", 9.25m);

    // Iterando sobre o dicionário e exibindo as notas
    foreach (var aluno in notas)
    {
        Console.WriteLine($"Aluno: {aluno.Key} - Nota: {aluno.Value:F2}");
    }
}
