
using Microsoft.EntityFrameworkCore;
using webAPICodeFIrst.Domains;

namespace webAPICodeFIrst.Contexts
{
    public class InlockContext : DbContext
    {

        public DbSet<Estudio> Estudio { get; set; }
        public DbSet<Jogo> Jogo { get; set; }
        public DbSet<TipoUsuario> TipoUdsuario { get; set; }
        public DbSet<Usuario> Usuario { get; set; }

        //Define as opções de construção(String Conxão)
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=NOTE08-S14; Database=inlock_games_code_first_Manha;User Id=sa; Pwd=Senai@134; TrustServerCertificate=true;");
            base.OnConfiguring(optionsBuilder);
        }


    }
    
    
}
