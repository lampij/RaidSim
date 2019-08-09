using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaidSim.Interface.Utils
{
    public interface IRandomNumberGenerator
    {
        int GenerateRandomInteger(int min, int max);
    }
}
