using Microsoft.EntityFrameworkCore;
using SisRHDefinitivo.Core.Models;



namespace SisRHDefinitivo.Core.Repository.Data
{
    public class BancoContext : DbContext
    {
        public BancoContext(DbContextOptions<BancoContext> options) : base(options) { }


        public DbSet<Funcionario> Funcionario { get; set; }
    }
}
