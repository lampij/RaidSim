using RaidSim.Interface.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaidSim.Application.Utils
{
    public class RandomNumberGenerator : IRandomNumberGenerator
    {
        public Random _randGen { get; set;}
        public RandomNumberGenerator()
        {
            _randGen = new Random();
        }
        public int GenerateRandomInteger(int min, int max)
        {
            return _randGen.Next(min, max);
        }
    }
}
