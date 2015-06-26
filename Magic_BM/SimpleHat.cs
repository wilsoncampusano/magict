using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;

namespace gta
{
    public class SimpleHat : HatBase
    {

        public override IMagical Shazaam()
        {
            return MagicalsInHat.Dequeue();
        }
    }
}
