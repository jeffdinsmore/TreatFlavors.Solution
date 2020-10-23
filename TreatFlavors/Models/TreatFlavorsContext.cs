using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace TreatFlavors.Models
{
  public class TreatFlavorsContext : IdentityDbContext<ApplicationUser>
  {
    public virtual DbSet<Treat> Treats { get; set; }
    public virtual DbSet<Flavor> Flavors { get; set; }
    public virtual DbSet<FlavorTreat> FlavorTreats { get; set; }
    public TreatFlavorsContext(DbContextOptions options) : base(options) { }
  }
}