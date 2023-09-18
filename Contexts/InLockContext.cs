using Microsoft.EntityFrameworkCore;
using webapi.Inlock.codeFirst.manha.Domain;

namespace webapi.Inlock.codeFirst.manha.Contexts
{
    public class InLockContext : DbContext
    {
        //Define as entidades do banco de dados
        public DbSet<Estudio> Estudio { get; set; }
        public DbSet<Jogo> Jogo { get; set; }
        public DbSet<TipoUsuario> TipoUsuario { get; set; }
        public DbSet<Usuario> Usuario { get; set; }

        //Define as opções de construcao do banco(String Conexão)

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=NOTE14-S15; Database=inlock_games_codeFirst_Manha;User Id=sa;Pwd=Senai@134; TrustServerCertificate=True");
            base.OnConfiguring(optionsBuilder);
        }
    }
}