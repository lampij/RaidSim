using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RaidSim.Model.PlayerObjects;
using System.Threading.Tasks;

namespace RaidSim.Interface.PlayerObjects
{
    public interface IPlayerFactory
    {
        Task<Player> CreateRandomPlayer();

        Task<List<Player>> CreateRandomPlayer(int NumberOfPlayers);
    }
}
