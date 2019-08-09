using RaidSim.Interface.PlayerObjects;
using RaidSim.Interface.Utils;
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
        IRandomNumberGenerator _randomNumberGenerator;
        public PlayerFactory(IRandomNumberGenerator randomNumberGenerator)
        {
            _randomNumberGenerator = randomNumberGenerator;
        }
        public Task<Player> CreateRandomPlayer()
        {
            return Task.FromResult(new Player()
            {
                CharacterBeingPlayed = new Toon()
                {
                    CharacterLevel = _randomNumberGenerator.GenerateRandomInteger(1, 10),
                    Health = new Health(_randomNumberGenerator.GenerateRandomInteger(75, 100)),
                    PrimaryResource = new Resource(_randomNumberGenerator.GenerateRandomInteger(100, 150))
                },
                PlayerSkillLevel = _randomNumberGenerator.GenerateRandomDouble(0, 10)
            }); ;
        }

        public async Task<Player[]> CreateRandomPlayer(int NumberOfPlayers)
        {
            Player[] playersToGenerate = new Player[NumberOfPlayers];
            for (int i = 0; i < NumberOfPlayers; i++)
            {
                playersToGenerate[i] = await this.CreateRandomPlayer();
            }
            return playersToGenerate;
        }
    }
}
