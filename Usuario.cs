using AppGerenciadorDeTarefas.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppGerenciadorDeTarefas.Usuário
{
    public class Usuario
    {
        public string nome;
        public string email;
        public string senha;
        public List<Tarefa> tarefas;

    }
}