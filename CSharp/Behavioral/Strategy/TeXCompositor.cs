namespace Behavioral.Strategy
{
    public class TeXCompositor : Compositor
    {
        // "... examines a paragraph at a time, taking into account
        // components' size and stretchability...
        // uses all the information passed into it..."
        // (Gamma et al, 1994)
        public override int Compose(Coord[] natural, Coord[] stretch, Coord[] shrink, int componentCount, int lineWidth, int[] breaks)
        {
            var breakCount = 100;
            return breakCount;
        }
    }
}