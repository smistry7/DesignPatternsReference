using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Composite
{
    //to demo, new up this class and add soda's
    public class SodaDispenser
    {
        public Colas Colas { get; set; }
        public RootBeers RootBeers { get; set; }
        public SodaDispenser()
        {
            Colas = new Colas();
            RootBeers = new RootBeers();
        }
        public void DisplayCalories()
        {
            var sodas = new Dictionary<string, int>();
            foreach (var cola in Colas.AvailableFlavours)
            {
                sodas.Add(cola.GetType().Name, cola.Calories);
            }
            foreach(var rootBeer in RootBeers.AvailableFlavours)
            {
                sodas.Add(rootBeer.GetType().Name, rootBeer.Calories);
            }
            //output the names and calories.
        }
    }
    
}
