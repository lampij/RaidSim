using RaidSim.Interface.PlayerObjects;
using RaidSim.Interface.Routines;
using RaidSim.Model.PlayerObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using System.Threading.Tasks;

namespace RaidSim.Application.Routines
{
    public class GameStart : IGameStart
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(typeof(GameStart));
        IPlayerFactory _playerFactory;

        public GameStart(IPlayerFactory playerFactory)
        {
            _playerFactory = playerFactory;
        }

        public async Task StartGame()
        {
            Player[] players = await _playerFactory.CreateRandomPlayer(5);

#if DEBUG
            ///<remarks>This is only here so that I can debug the object array I'm working with.</remarks>
            Console.Write($"{JsonConvert.SerializeObject(players, Formatting.Indented)}");
            Console.ReadKey();
#endif
        }
    }
}
