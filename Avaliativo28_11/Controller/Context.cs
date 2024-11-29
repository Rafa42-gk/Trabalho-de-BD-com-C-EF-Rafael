using Avaliativo28_11.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avaliativo28_11.Controller
{
    internal class Context : DbContext
    {
        public Context() : base(@"Server=JUN0675602W10-1\BDSENAC; Database=AvaliacaoLoja; user id=senaclivre; password = senaclivre")
        {
            // Desabilita a criação automática de tabelas
            Database.SetInitializer<Context>(null);
        }


        public DbSet<Vendas> Vendas { get; set; }
    }
}
