namespace DesignPatterns.Structural.Adapter
{
    public interface IWaterPokemon
    {
        int WaterGun { get; }
        int Tackle { get; }
    }
    public interface IFirePokemon
    {
        int FlameWheel { get; }
        int QuickAttack { get; }
    }
    public interface IGrassPokemon
    {
        int TailWhip { get; }
        int BladeAttack { get; }
    }
    

}