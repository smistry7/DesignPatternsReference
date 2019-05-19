using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Decorator
{
    public class AttackCar : ICar
    {
        private ICar _decoratedCar;
        public AttackCar(ICar decoratedCar)
        {
            _decoratedCar = decoratedCar;
        }
        public int Drive() => _decoratedCar.Drive() - 10;
        public int Attack() => _decoratedCar.Attack() + 30;
        public int Defence() => _decoratedCar.Defence() - 10;
    }
}
