namespace Structural.Shared
{
    // The Coord type in the examples appears to
    // be a wrapper around an integer value.
    public struct Coord
    {
        private int _value;

        public Coord(int i)
        {
            _value = i;
        }

        public static implicit operator int(Coord c) => c._value;

        public static implicit operator Coord(int i) => new Coord(i);
    }
}
