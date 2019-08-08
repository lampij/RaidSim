using RaidSim.Interface.PlayerObjects;
using RaidSim.Model.PlayerObjects;
using RaidSim.Model.PlayerObjects.Internals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaidSim.Application.PlayerObjects
{
    public class PlayerFactory : IPlayerFactory
    {
        public Task<Player> CreateRandomPlayer()
        {
            Random r = new Random();
            return Task.FromResult(new Player()
            {
                CharacterBeingPlayed = new Toon()
                {
                    CharacterLevel = r.Next(1, 10),
                    Health = new Health(r.Next(75, 100)),
                    PrimaryResource = new Resource(r.Next(100, 150))
                }
            });
        }
    }
}
