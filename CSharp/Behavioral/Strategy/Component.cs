namespace Behavioral.Strategy
{
    // "... represents text and graphical elements in a document."
    // (Gamma et al, 1994)
    public class Component
    {
        public int NaturalSize { get; set; }

        public int Stretchability { get; set; }

        public int Shrinkability { get; set; }
    }
}