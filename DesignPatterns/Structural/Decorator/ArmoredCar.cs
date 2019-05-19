using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Decorator
{
    //can be added to any ICar ie attack car could get an armour added to it
    public class ArmoredCar : ICar
    {
        private ICar _decoratedCar;
        public ArmoredCar(ICar decoratedCar)
        {
            _decoratedCar = decoratedCar;
        }
        public int Drive() => _decoratedCar.Drive() - 20;
        public int Defence() => _decoratedCar.Defence() + 40;
        public int Attack() => _decoratedCar.Attack();
    }
}
