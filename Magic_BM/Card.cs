using System;

namespace gta
{
    public class Card : IMagical
    {
        private String _name;
        public string Name {get { return _name; } }

        public Card(string name)
        {
            _name = name;
        }
    }
}