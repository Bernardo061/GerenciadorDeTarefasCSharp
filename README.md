# 📋 Gerenciador de Tarefas (Console App em C#)

Este é um **aplicativo de console** em C# que permite ao usuário cadastrar um perfil simples e gerenciar suas tarefas do dia a dia.  
O sistema é totalmente interativo no console e foi feito com fins **educacionais**, para praticar conceitos básicos de programação em C#.

---

## 🚀Funcionalidades

- 👤 **Cadastro de usuário** com nome, e-mail e senha (sem criptografia, apenas exemplo didático).  
- ➕ **Adicionar tarefas** com descrição.  
- 📃 **Listar tarefas** mostrando status:  
  - `[ ]` = pendente  
  - `[X]` = concluída  
- 🗑️ **Remover tarefas** pelo número.  
- ✅ **Marcar tarefas como concluídas**.  
- 🔄 **Menu interativo** com loop até o usuário escolher sair.  

---

## 🛠️ Tecnologias Utilizadas

- **C#** (.NET 6 ou superior)  
- **Paradigma de Programação Orientada a Objetos (POO)**  
- **Coleções (`List<T>`)** para armazenar as tarefas  
- **Estruturas de controle** (`if/else`, `switch`, `do/while`)  
- **Entrada e saída** via `Console`

---

## 📂 Estrutura do Projeto

AppGerenciadorDeTarefas/

Model/

Tarefa.cs  // Classe que representa uma tarefa

Usuario.cs //  Classe que representa o usuário.

Program.cs // Programa principal com menu interativo

README.md //Documentação do projeto

---

## 📌 Exemplos de Uso

### Cadastro do Usuário
=== Cadastro de Usuário ===

Digite seu nome: João
Digite seu email: joao@email.com
Digite sua senha: 1234

Usuário cadastrado com sucesso!
Nome: João
Email: joao@email.com


### Menu de Tarefas
=== Gerenciador de Tarefas - Usuário: João ===

1 - Adicionar Tarefa
2 - Listar Tarefas
3 - Remover Tarefa
4 - Marcar Tarefa como Concluída
0 - Sair
Escolha uma opção:

---

## 🧑‍💻 Como Executar
Entre na pasta do projeto:

bash
Copiar código
cd AppGerenciadorDeTarefas
Compile e execute:

bash
Copiar código
dotnet run

📖 Aprendizados
Esse projeto foi desenvolvido para treinar:

Criação e uso de classes (Usuario, Tarefa)

Uso de listas genéricas (List<T>)

Organização de código em métodos auxiliares

Menu interativo em console com switch e do/while

⚠️ Observações
A senha do usuário não é criptografada → esse sistema é apenas educacional.
Não há persistência em banco de dados ou arquivos → todas as tarefas são apagadas ao encerrar o programa.

👨‍💻 Autor
Projeto desenvolvido para estudos de C# e POO(Programação Orientada a Objetos).
Feito por: João Bernardo Dias de Brito
