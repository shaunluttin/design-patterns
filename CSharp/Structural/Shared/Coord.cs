namespace Structural.Shared
{
    // The Coord type in the examples appears to
    // be a wrapper around an integer value.
    public struct Coord
    {
        private readonly int X;
        
        private readonly int Y;

        public Coord(int x, int y)
        {
            X = x;
            Y = y;
        }
    }
}
