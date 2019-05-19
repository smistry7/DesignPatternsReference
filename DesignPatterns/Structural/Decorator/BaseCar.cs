using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Decorator
{
    public class BaseCar : ICar
    {
        public int Defence()
        {
            return 20;
        }
        public int Attack()
        {
            return 30;
        }
        public int Drive()
        {
            return 30;
        }
    }
}
