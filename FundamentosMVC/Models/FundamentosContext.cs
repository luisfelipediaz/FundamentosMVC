using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentosMVC.Models
{
    public class FundamentosContext : DbContext
    {   
        public DbSet<Review> Reviews { get; set; }

        public DbSet<Album> Albums { get; set; }

        public DbSet<Artista> Artistas { get; set; }


    }
}
