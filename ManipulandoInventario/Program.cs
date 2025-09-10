using System;
using System.Collections.Generic;

/// <summary>
/// Sistema de gerenciamento de tarefas para uma equipe:
/// - Inicializa um dicionário com algumas tarefas.
/// - Remove todas as tarefas do dicionário simulando o fim do sprint.
/// - Adiciona novas tarefas para o próximo sprint.
/// - Lista todas as atividades atualizadas para a equipe.
///
/// Dica: O método Clear() esvazia completamente o dicionário.
///
/// Exemplo de entrada:
/// Tarefas antigas:
/// Dictionary<string, string> tarefas = new Dictionary<string, string>()  
/// {  
///     { "Refatorar módulo de login", "Ana" },  
///     { "Testar API de pagamentos", "Pedro" }  
/// };
///
/// Novas tarefas:
/// tarefas.Add("Implementar autenticação OAuth", "João");  
/// tarefas.Add("Otimizar consultas SQL", "Maria");  
/// tarefas.Add("Atualizar documentação", "Carlos");
///
/// Saída esperada:
/// Tarefas do próximo sprint:
/// - Implementar autenticação OAuth: João
/// - Otimizar consultas SQL: Maria
/// - Atualizar documentação: Carlos
/// </summary>
static void Main(string[] args)
{
    // Inicializando o dicionário com tarefas antigas
    Dictionary<string, string> tarefas = new Dictionary<string, string>()
        {
            { "Refatorar módulo de login", "Ana" },
            { "Testar API de pagamentos", "Pedro" }
        };

    // Fim do sprint: limpar todas as tarefas
    tarefas.Clear();

    // Adicionando novas tarefas
    tarefas.Add("Implementar autenticação OAuth", "João");
    tarefas.Add("Otimizar consultas SQL", "Maria");
    tarefas.Add("Atualizar documentação", "Carlos");

    // Exibindo as novas tarefas
    Console.WriteLine("Tarefas do próximo sprint:");
    foreach (var tarefa in tarefas)
    {
        Console.WriteLine($"- {tarefa.Key}: {tarefa.Value}");
    }
}
