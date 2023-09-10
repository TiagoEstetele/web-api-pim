using Microsoft.EntityFrameworkCore;

namespace TESTE_API.Infraestrutura
{
    public class ConnectionContext : DbContext
    {
        public DbSet<Funcionarios> Funcionarios { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)

        => optionsBuilder.UseNpgsql(
            "Server=containers-us-west-197.railway.app\r\n\r\n\r\n;" +
            "Port=6821;Database=railway;" +
            "User Id=postgres;" +
            "Password=8wn4rjXhUik4BtWw8epT;"
            );
    }
}
    