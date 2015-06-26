using System;
using System.Collections.Generic;
using System.Linq;

namespace gta
{
    public abstract class HatBase
    {
        protected Queue<IMagical> MagicalsInHat { get; set; }

        public HatBase()
        {
            MagicalsInHat = new Queue<IMagical>();
        }

        public static SimpleHat SimpleHat()
        {
            return new SimpleHat();
        }

        public static WonderHat MagicalHat(HatBase hat)
        {
            return new WonderHat(hat);
        }

        public void PutIn(IMagical magical)
        {
            if (magical == null)
            {
                throw new NullReferenceException("nulls are not allowed");
            }
            MagicalsInHat.Enqueue(magical);
        }

        public abstract IMagical Shazaam();

        public int RabbitsInHat()
        {
            return MagicalsInHat.Count();
        }
    }
}