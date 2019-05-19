
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Composite
{
    /// <summary>
    /// Soda abstract class (component)
    /// </summary>
    public abstract class SoftDrink
    {
        public int Calories { get; set; }
        public SoftDrink(int calories)
        {
            Calories = calories;
        }
    }
    // Leaf classes
    public class OriginalCola : SoftDrink
    {
        public OriginalCola(int calories) : base(calories) { }
    }
    public class CherryCola : SoftDrink
    {
        public CherryCola(int calories) : base (calories) { }
    }
    public class RootBeer : SoftDrink
    {
        public RootBeer(int calories) : base(calories) { }
    }
    public class VanillaRootBeer : SoftDrink
    {
        public VanillaRootBeer(int calories) : base(calories) { }
    }
    //Composite classes
    public class Colas
    {
        public List<SoftDrink> AvailableFlavours { get; set; }
        public Colas()
        {
            AvailableFlavours = new List<SoftDrink>();
        }
    }
    public class RootBeers
    {
        public List<SoftDrink> AvailableFlavours { get; set; }
        public RootBeers()
        {
            AvailableFlavours = new List<SoftDrink>();
        }
    }
}
