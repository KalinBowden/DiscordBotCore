using System;
using System.Collections.Generic;
using System.Text;
using Unity;
using Unity.Resolution;
using DiscordBotCore.Storage;
using Unity.Lifetime;

namespace DiscordBotCore
{
    public static class DiscordUnity
    {
        private static UnityContainer _container;


        public static UnityContainer Container
        {
            get
            {
                if(_container == null)
                {
                    RegisterTypes();
                }

                return _container;
            }
        }

        public static void RegisterTypes()
        {
            _container = new UnityContainer();
            _container.RegisterType<IDataStorage, InMemoryStorage>(new ContainerControlledLifetimeManager());
            _container.RegisterType<ILogger, Logger>(new ContainerControlledLifetimeManager());
        }

        public static T Resolve<T>()
        {
            return (T)Container.Resolve(typeof(T), string.Empty, new CompositeResolverOverride());
        }
    }
}
