using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FESTA_FACIL.Models.Dominio
{
    public class Aluguel
    {
        public int ID { get; set; }
        public int IdCliente { get; set; }
        public int IDTema { get; set; }
        public DateTime Data_aluguel { get; set; }
        public DateTime Data_devolucao { get; set; }
        public float Valor { get; set; }


        //classe para formar o aluguel, juntando as classes, kit, tema, mobilia e cliente


    }
}
