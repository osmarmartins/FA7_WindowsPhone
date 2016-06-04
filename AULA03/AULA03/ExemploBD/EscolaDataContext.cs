using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploBD
{
    public class EscolaDataContext : DataContext
    {
        public EscolaDataContext(): base("isostore:/escola.sdf") { }
        public Table<Aluno> Alunos;
    }
}
