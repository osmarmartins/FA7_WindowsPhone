using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaDeTarefas
{
    public class TarefaDataContext : DataContext
    {
        public TarefaDataContext() : base("isostore:/tarefas.sdf") { }
        public Table<Tarefa> Tarefas { get; set; }
    }
}
