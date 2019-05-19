namespace DesignPatterns.Creational.Abstract
{
    class Samsung : IMobilePhoneFactory
    {
        public ISmartPhone GetSmartPhone()
        {
            return new SamsungGalaxy();
        }

        public INormalPhone GetNormalPhone()
        {
            return new SamsungGuru();
        }
    }

    class SamsungGalaxy : ISmartPhone
    {
        public string GetModelDetails()
        {
            return "galaxy";
        }
    }

    class SamsungGuru : INormalPhone
    {
        public string GetModelDetails()
        {
            return "Guru";
        }
    }
}