using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace CadastroTarefas3.Models
{
    public class contexto : DbContext
    {
        public DbSet<tarefa> Tarefas { get; set; }
    }
}