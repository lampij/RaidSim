using RaidSim.Application.PlayerObjects;
using RaidSim.Application.Routines;
using RaidSim.Interface.PlayerObjects;
using RaidSim.Interface.Routines;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;
using Unity.Lifetime;

namespace RaidSim
{
    public class ContainerConfig
    {
        public static UnityContainer RegisterDependencies()
        {
            UnityContainer container = new UnityContainer();

            container.RegisterType<IGameStart, GameStart>(new HierarchicalLifetimeManager())
                .RegisterType<IPlayerFactory, PlayerFactory>(new HierarchicalLifetimeManager());

            return container;
        }
    }
}
