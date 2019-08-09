using RaidSim.Interface.PlayerObjects;
using RaidSim.Interface.Routines;
using RaidSim.Model.PlayerObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaidSim.Application.Routines
{
    public class GameStart : IGameStart
    {
        IPlayerFactory _playerFactory;

        public GameStart(IPlayerFactory playerFactory)
        {
            _playerFactory = playerFactory;
        }

        public async Task StartGame()
        {
            Player[] players = await _playerFactory.CreateRandomPlayer(5);
        }
    }
}
