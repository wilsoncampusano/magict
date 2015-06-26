using System;

namespace gta
{
    public class Rabbit : IMagical
    {
        private String _name;

        public String Name
        {get { return _name; }}


        public Rabbit(string name)
        {
            if(name == null)
                throw new NullReferenceException("you should provide a name.");
            _name = name;
        }

        public override bool Equals(object obj)
        {
            if ((obj is Rabbit))
                return (obj as Rabbit).Name.Equals(_name);
            return false;
        }

        public override int GetHashCode()
        {
            return _name.GetHashCode();
        }
    }
}