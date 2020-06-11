using Microsoft.EntityFrameworkCore;
using Parcial1_Ap2_Nuñez.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Parcial1_Ap2_Nuñez.DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Producto> productos{get ; set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source= DATA\ParcialApicada.db");
        }
    }

}
