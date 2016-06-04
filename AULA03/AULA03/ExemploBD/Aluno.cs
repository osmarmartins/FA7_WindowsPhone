using System;
using System.Collections.Generic;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploBD
{
    [Table]
    public class Aluno
    {
        [Column(IsDbGenerated =true, IsPrimaryKey =true)]
        public int Id { get; set; }

        [Column()]
        public string Nome { get; set; }

        [Column()]
        public string Cidade { get; set; }
    }
}
