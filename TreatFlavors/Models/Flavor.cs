using System.Collections.Generic;

namespace TreatFlavors.Models
{
  public class Flavor
  {
    public Flavor()
    {
      this.FlavorTreats = new HashSet<FlavorTreat>();
    }
    public int FlavorId { get; set; }
    public string FlavorName { get; set; }
    public virtual ICollection<FlavorTreat> FlavorTreats { get; set; }
  }
}