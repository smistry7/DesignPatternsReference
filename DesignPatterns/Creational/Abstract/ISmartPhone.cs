using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.Abstract
{
    /// <summary>  
    /// The 'AbstractProductA' interface  
    /// </summary>
    interface ISmartPhone
    {
        string GetModelDetails();
    }
    /// <summary>  
    /// The 'AbstractProductB' interface  
    /// </summary> 
    interface INormalPhone
    {
        string GetModelDetails();
    }
}
