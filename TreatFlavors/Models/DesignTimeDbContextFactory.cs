using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace TreatFlavors.Models
{
  public class TreatFlavorsContextFactory : IDesignTimeDbContextFactory<TreatFlavorsContext>
  {
    TreatFlavorsContext IDesignTimeDbContextFactory<TreatFlavorsContext>.CreateDbContext(string[] args)
    {
      IConfigurationRoot configuration = new ConfigurationBuilder()
        .SetBasePath(Directory.GetCurrentDirectory())
        .AddJsonFile("appsettings.json")
        .Build();

      var builder = new DbContextOptionsBuilder<TreatFlavorsContext>();
      var connectionString = configuration.GetConnectionString("DefaultConnection");

      builder.UseMySql(connectionString);

      return new TreatFlavorsContext(builder.Options);
    }
  }
}