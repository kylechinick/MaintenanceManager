using System;
using System.Collections.Generic;

namespace Factory.Models
{
  public class Engineer
  {
    public Engineer()
    {
      this.JoinEntities = new HashSet<MachineEngineer>();
    }

    public int EngineerId { get; set; }

    public string EngineerName { get; set; }

    public DateTime EngineerEmploymentStartDate { get; set; }

    public virtual ICollection<MachineEngineer> JoinEntities { get; }
  }
}
