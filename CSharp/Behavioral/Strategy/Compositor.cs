namespace Behavioral.Strategy
{
    // Each subclass of Compositor "encapsulates a line breaking strategy."
    public abstract class Compositor
    {
        public abstract int Compose(
            Coord[] natural,
            Coord[] stretch,
            Coord[] shrink,
            int componentCount,
            int lineWidth,
            int[] breaks);
    }
}