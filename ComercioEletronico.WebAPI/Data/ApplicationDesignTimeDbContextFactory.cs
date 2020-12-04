using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace ComercioEletronico.WebAPI.Data
{
    public class ApplicationDesignTimeDbContextFactory : IDesignTimeDbContextFactory<ApplicationDbContext>
    {
        public ApplicationDbContext CreateDbContext(string[] args)
        {
            var connectionStringBuilder = new SqlConnectionStringBuilder("server=.;database=comercio_eletronico;user id=sa;trusted_connection=false;")
            {
                Password = "4e5de1cf-b4b0-4316-9bad-3dc36f905d8f"
            };

            var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseSqlServer(connectionStringBuilder.ConnectionString);

            return new ApplicationDbContext(optionsBuilder.Options);
        }
    }
}
