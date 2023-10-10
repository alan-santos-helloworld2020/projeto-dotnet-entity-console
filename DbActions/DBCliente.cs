using Microsoft.EntityFrameworkCore;
using Requisicao.Models;

namespace Requisicao.DBActions
{
    public class DBCliente : DbContext
    {
        public DbSet<Cliente> Clientes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source=banco.db");
        }

    }

}