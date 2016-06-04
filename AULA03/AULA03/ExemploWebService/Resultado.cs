using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ExemploWebService
{
    [DataContract]
    class Resultado
    {
        [DataMember(Name ="uf")]
        public string UF { get; set; }

        [DataMember(Name = "cidade")]
        public string Cidade { get; set; }

        [DataMember(Name = "bairro")]
        public string Bairro { get; set; }
    }
}
