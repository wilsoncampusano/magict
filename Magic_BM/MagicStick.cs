using System;

namespace gta
{
    public class MagicStick 
    {
        public HatBase TurnMagical(HatBase simpleHat)
        {
            return HatBase.MagicalHat(simpleHat);
        }
    }
}