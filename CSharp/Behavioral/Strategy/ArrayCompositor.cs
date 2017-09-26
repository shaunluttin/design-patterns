namespace Behavioral.Strategy
{
    public class ArrayCompositor : Compositor
    {
        // "... breaks components into lines at regular intervals..."
        // "... ignores all the information passed into it..."
        // (Gamma et al, 1994)
        public override int Compose(Coord[] natural, Coord[] stretch, Coord[] shrink, int componentCount, int lineWidth, int[] breaks)
        {
            System.Console.WriteLine("Composing with the Array algorithm...");

            var breakCount = 100;
            return breakCount;
        }
    }
}