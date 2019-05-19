using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.Abstract
{

    /// <summary>  
    /// The 'ConcreteFactory1' class.  
    /// </summary>  
    class Nokia : IMobilePhoneFactory
    {
        public ISmartPhone GetSmartPhone()
        {
            return new NokiaPixel();
        }

        public INormalPhone GetNormalPhone()
        {
            return new Nokia1600();
        }
    }
    /// <summary>  
    /// The 'ProductA1' class  
    /// </summary>  
    class NokiaPixel : ISmartPhone
    {
        public string GetModelDetails()
        {
            return "Model: Nokia Pixel\nRAM: 3GB\nCamera: 8MP\n";
        }
    }

    class Nokia1600 : INormalPhone
    {
        public string GetModelDetails()
        {
            return "1600";
        }
    }
}
