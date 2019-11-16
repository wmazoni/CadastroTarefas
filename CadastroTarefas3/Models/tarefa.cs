using System;

using System.ComponentModel.DataAnnotations;
namespace CadastroTarefas3.Models
{
    public class tarefa
    {
        [Key]
        public int ID { get; set; }
        public string nome { get; set; }
        public string descricao { get; set; }
        public DateTime data { get; set; }
    }
}