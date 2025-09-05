using AppGerenciadorDeTarefas.Model;
using AppGerenciadorDeTarefas.Usuário;
using System;

string nome, email, senha, descricao;
double opcao;

Console.WriteLine("=== Cadastro de Usuário ===");
Console.Write("Digite seu nome: ");
nome = Console.ReadLine();

Console.Write("Digite seu email: ");
email = Console.ReadLine();

//Senha simples(Apenas para fins educacionais), sem segurança.
Console.Write("Digite sua senha: ");
senha = Console.ReadLine();

// Cria um objeto da classe Usuario já com os dados informados.
    Usuario usuario = new Usuario()
    {
        nome = nome,
        email = email,
        senha = senha,
        tarefas = new List<Tarefa>()
    };

Console.WriteLine("\nUsuário cadastrado com sucesso!");
Console.WriteLine($"Nome: {usuario.nome}");
Console.WriteLine($"Email: {usuario.email}");
Console.WriteLine("Pressione qualquer tecla para continuar...");
Console.ReadKey();

    do
        {
            Console.Clear(); // Limpa a tela a cada ciclo.
            Console.WriteLine($"=== Gerenciador de Tarefas - Usuário: {usuario.nome} ===");
            Console.WriteLine("1 - Adicionar Tarefa");
            Console.WriteLine("2 - Listar Tarefas");
            Console.WriteLine("3 - Remover Tarefa");
            Console.WriteLine("4 - Marcar Tarefa como Concluída");
            Console.WriteLine("0 - Sair");
            Console.Write("Escolha uma opção: ");

          // Validação de entrada (aceita apenas números de 0 a 4)
            if (!double.TryParse(Console.ReadLine(), out opcao))
            {
                Console.WriteLine("Opção inválida! Pressione Enter para continuar...");
                Console.ReadLine();
                continue;
            }

            switch (opcao)
            {
                case 1:
                    AdicionarTarefa(usuario);
                    break;
                case 2:
                    ListarTarefas(usuario);
                    break;
                case 3:
                    RemoverTarefa(usuario);
                    break;
                case 4:
                    MarcarConcluida(usuario);
                    break;
                case 0:
                    Console.WriteLine("Saindo do sistema...");
                    break;
                default:
                    Console.WriteLine("Opção inválida!");
                    break;
            }

            if (opcao != 0)
            {
                Console.WriteLine("\nPressione Enter para continuar...");
                Console.ReadLine();
            }

        } while (opcao != 0); // Repete até a opção escolhida ser "0".

   // vvvv Métodos auxiliares vvvv
    static void AdicionarTarefa(Usuario usuario)
    {
        Console.Write("Digite a descrição da tarefa: ");
        string descricao = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(descricao))
        {
            Console.WriteLine("Descrição não pode ser vazia!");
            return;
        }
        usuario.tarefas.Add(new Tarefa(descricao));
        Console.WriteLine("Tarefa adicionada com sucesso!");
    }

    static void ListarTarefas(Usuario usuario)
    {
        Console.WriteLine("\n=== Lista de Tarefas ===");
        if (usuario.tarefas.Count == 0)
        {
            Console.WriteLine("Nenhuma tarefa cadastrada.");
            return;
        }

        for (int i = 0; i < usuario.tarefas.Count; i++)
        {
            string status = usuario.tarefas[i].concluida ? "[X]" : "[ ]";
            Console.WriteLine($"{i + 1}. {status} {usuario.tarefas[i].descricao}");
        }
    }

    static void RemoverTarefa(Usuario usuario)
    {
        ListarTarefas(usuario);
        if (usuario.tarefas.Count == 0) return;

        Console.Write("Digite o número da tarefa para remover: ");
        if (int.TryParse(Console.ReadLine(), out int numero) && numero > 0 && numero <= usuario.tarefas.Count)
        {
            usuario.tarefas.RemoveAt(numero - 1);
            Console.WriteLine("Tarefa removida com sucesso!");
        }
        else
        {
            Console.WriteLine("Número inválido!");
        }
    }

    static void MarcarConcluida(Usuario usuario)
{
    ListarTarefas(usuario);
    if (usuario.tarefas.Count == 0) return;

    Console.Write("Digite o número da tarefa para marcar como concluída: ");
    if (int.TryParse(Console.ReadLine(), out int numero) && numero > 0 && numero <= usuario.tarefas.Count)
    {
        usuario.tarefas[numero - 1].concluida = true;
        Console.WriteLine("Tarefa marcada como concluída!");
    }
    else
    {
        Console.WriteLine("Número inválido!");
    }
}