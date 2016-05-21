using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploTemplate
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cidade { get; set; }

        public override string ToString()
        {
            return string.Format("{0} ({1})", Nome, Cidade);

        }

    }
}
