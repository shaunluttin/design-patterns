namespace Structural.Shared
{
    // TODO: Verify the structure of the Coord in the Design Patterns book.
    // In the sample code, Coord appears to be a wrapper around an integer value.
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
