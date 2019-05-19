using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;
using Unity.Injection;
using Unity.Resolution;
using Xunit;
namespace DesignPatterns.Creational.IOC
{

    public class Demo
    {
        
        private static void Main(string[] args)
        {
            IUnityContainer container = new UnityContainer();
            ContainerMagic.RegisterElements(container);

            IBattery battery = container.Resolve<IBattery>();

            Dial dial = container.Resolve<Dial>();

            ITuner tuner = container.Resolve<ITuner>();
            IRadio radio = container.Resolve<IRadio>(new ParameterOverride("radioBattery", battery),
                new ParameterOverride("radioTuner", tuner),
                new ParameterOverride("radioName", "BrokenRadio"));
            radio.Start();

        }
    }
    public class ContainerMagic
    {

        public static void RegisterElements(IUnityContainer container)
        {
            Dial dial = new Dial("Linear");
            container.RegisterInstance(dial);

            container.RegisterType<IBattery, Battery>();
            container.RegisterType<ITuner, Tuner>();

            var batteryType = typeof(IBattery);
            var tunerType = typeof(ITuner);
            container.RegisterType<IRadio, Radio>(new InjectionConstructor(batteryType, tunerType, typeof(string)));
        }
    }
}
