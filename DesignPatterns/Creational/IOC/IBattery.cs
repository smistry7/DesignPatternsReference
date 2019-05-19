namespace DesignPatterns.Creational.IOC
{
    public interface IBattery
    {
        bool SelfCheck();

        int ChargeRemaining();

        string Manufacturer();

        string SerialNumber();
    }
}