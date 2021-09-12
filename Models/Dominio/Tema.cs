using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FESTA_FACIL.Models.Dominio
{
    public class Tema
    {
        public int ID { get; set; }
        public string NomeTema { get; set; }
        public Kit Kits { get; set; }
        public string Descricao { get; set; }
        public Mobilia Mobilia { get; set; }

        public int NumItens { get; set; }

    }
}
