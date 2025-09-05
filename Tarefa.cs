using AppGerenciadorDeTarefas.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppGerenciadorDeTarefas.Model
{
    public class Tarefa
    {
        public string descricao;
        public bool concluida;
        public Tarefa(string descricao)
        {
            this.descricao = descricao;
            concluida = false;
        }
    }
}