using System.Collections.Generic;

namespace TreatFlavors.Models
{
  public class Treat
  {
    public Treat()
    {
      this.Flavors = new HashSet<FlavorTreat>();
    }
    public int TreatId { get; set; }
    public string TreatName { get; set; }
    public virtual ICollection<FlavorTreat> Flavors { get; set; }
  }
}