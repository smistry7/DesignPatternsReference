using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
namespace DesignPatterns.Creational.Abstract
{
    public class AbstractFactoryDemo
    {
        [Fact]
        public void Demo()
        {
            IMobilePhoneFactory Nokia = new Nokia();
            MobileClient client = new MobileClient(Nokia);
            Console.WriteLine(client.GetNormalPhoneModelDetails());
            Console.WriteLine(Nokia.GetNormalPhone());

            IMobilePhoneFactory samsungMobilePhone = new Samsung();
            MobileClient samsungClient = new MobileClient(samsungMobilePhone);
            
            Console.WriteLine(samsungClient.GetSmartPhoneModelDetails());
            Console.WriteLine(samsungClient.GetNormalPhoneModelDetails());

        }
    }
}
