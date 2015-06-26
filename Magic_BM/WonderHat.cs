namespace gta
{
    public class WonderHat : HatBase
    {
        private HatBase _simpleHat;
        public WonderHat(HatBase simpleHat)
        {
            _simpleHat = simpleHat;
        }

        public override IMagical Shazaam()
        {
            return new Rabbit("Wonder Rabbit");
        }
    }
}