using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace gta
{
    public class Hat
    {
        
        private Queue<IMagical> MagicalsInHat { get; set; }

        public Hat()
        {
            MagicalsInHat = new Queue<IMagical>();
        }

        public void PutIn(IMagical magical)
        {
            if (magical == null)
            {
                throw new NullReferenceException("nulls are not allowed");
            }
            MagicalsInHat.Enqueue(magical);
        }

        public IMagical TurnDown()
        {
            return MagicalsInHat.Dequeue();
        }

        public int RabbitsInHat()
        {
            return MagicalsInHat.Count();
        }
    }
}
