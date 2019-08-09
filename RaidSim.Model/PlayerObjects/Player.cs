using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaidSim.Model.PlayerObjects
{
    /// <summary>
    /// The player represents both the character being played, and the player themselves. 
    /// </summary>
    public class Player
    {
        public Player()
        {

        }

        /// <summary>
        /// Represents the character that the player is logged in as and playing
        /// </summary>
        public Toon CharacterBeingPlayed { get; set; }

        public double PlayerSkillLevel { get; set; }

    }
}
