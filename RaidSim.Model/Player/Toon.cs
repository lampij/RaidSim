using RaidSim.Model.Player.Internals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaidSim.Model.Player
{
    public class Toon
    {
        public int CharacterLevel { get; set; }
        public Health Health { get; set; }
        public Resource PrimaryResource { get; set; }
    }
}
