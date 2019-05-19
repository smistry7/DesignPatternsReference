using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Adapter
{

    //We don't care about pokemon type here
    public interface IPokemon
    {
        int SpecialAttack { get; }
        int BasicAttack { get; }
    }


    public class FirePokemonAdapter : IPokemon
    {
        private IFirePokemon _pokemon;
        public FirePokemonAdapter(IFirePokemon pokemon)
        {
            _pokemon = pokemon;
        }
        public int SpecialAttack => _pokemon.FlameWheel;
        public int BasicAttack => _pokemon.QuickAttack;

    }
    public class WaterPokemonAdapter : IPokemon
    {
        private IWaterPokemon _pokemon;
        public WaterPokemonAdapter(IWaterPokemon pokemon)
        {
            _pokemon = pokemon;
        }
        public int SpecialAttack => _pokemon.WaterGun;
        public int BasicAttack => _pokemon.Tackle;

    }
    public class GrassPokemonAdapter : IPokemon
    {
        private IGrassPokemon _pokemon;
        public GrassPokemonAdapter(IGrassPokemon pokemon)
        {
            _pokemon = pokemon;
        }
        public int SpecialAttack => _pokemon.BladeAttack;
        public int BasicAttack => _pokemon.TailWhip;
    }
}
