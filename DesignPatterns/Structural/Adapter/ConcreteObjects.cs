using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Adapter
{
    public class Squirtle : IWaterPokemon
    {
        public int WaterGun => 20;
        public int Tackle => 5;
    }
    public class Charmander : IFirePokemon
    {
        public int FlameWheel => 25;

        public int QuickAttack => 3;
    }
    public class Bulbasaw : IGrassPokemon
    {
        public int TailWhip => 0;

        public int BladeAttack => 30;
    }
}
