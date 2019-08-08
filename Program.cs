using RaidSim.Interface.Routines;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;

namespace RaidSim
{
    class Program
    {
        static void Main(string[] args)
        {
            _ = ContainerConfig.RegisterDependencies().Resolve<IGameStart>().StartGame();
        }
    }
}
