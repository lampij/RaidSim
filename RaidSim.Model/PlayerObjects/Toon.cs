using RaidSim.Model.PlayerObjects.Internals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaidSim.Model.PlayerObjects
{
    public class Toon
    {
        public int CharacterLevel { get; set; }
        public Health Health { get; set; }
        public Resource PrimaryResource { get; set; }
    }
}
