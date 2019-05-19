using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.Abstract
{

    /// <summary>  
    /// The 'AbstractFactory' interface.  
    /// </summary>  
    interface IMobilePhoneFactory
    {
        ISmartPhone GetSmartPhone();
        INormalPhone GetNormalPhone();
    }


}
