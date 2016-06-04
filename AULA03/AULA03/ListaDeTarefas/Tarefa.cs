using System;
using System.Collections.Generic;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaDeTarefas
{
    [Table]
    public class Tarefa
    {
        [Column(IsPrimaryKey =true, IsDbGenerated =true)]
        public int Id { get; set; }

        [Column()]
        public string Descricao { get; set; }

        [Column()]
        public bool Urgente { get; set; }

    }
}
