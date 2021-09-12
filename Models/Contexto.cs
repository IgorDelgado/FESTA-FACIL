using FESTA_FACIL.Models.Dominio;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FESTA_FACIL.Models
{
    public class Contexto:DbContext
    {


        public Contexto(DbContextOptions<Contexto> options) : base(options) { }
        public DbSet <Kit> Kits { get; set; }
        public DbSet <Tema> Temas { get; set; }

        public DbSet <Mobilia> Mobilias { get; set; }

        public DbSet   <Cliente> Clientes { get; set; }

      


    }
}
