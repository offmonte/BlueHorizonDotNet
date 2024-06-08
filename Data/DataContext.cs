using BlueHorizon.Models;
using Microsoft.EntityFrameworkCore;

namespace BlueHorizon.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> option) : base(option)
        {
        }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Atualizacao> Atualizacoes { get; set; } 
    }
}
