using System.Collections.Generic;

namespace Behavioral.Strategy
{
    public class Composition
    {
        private Compositor _compositor;

        // the list of components
        // the number of components (in C# both are in the List)
        private List<Component> _components = new List<Component>();

        // the Composition's line width
        private int _lineWidth;

        // the position of line breaks in components
        private int[] _lineBreaks;

        // the number of lines
        private int _lineCount;

        public Composition(Compositor compositor)
        {
            _compositor = compositor;
        }

        public void Repair()
        {
            Coord[] natural;
            Coord[] stretchability;
            Coord[] shrinkability;
            int componentCount;
            int[] breaks;

            // prepare the arrays with the desired component sizes
            // ...
            natural = new Coord[0];
            stretchability = new Coord[0];
            shrinkability = new Coord[0];
            componentCount = 0;
            breaks = new int[0];

            // determine where the breaks are
            int breakCount = _compositor.Compose(
                natural,
                stretchability,
                shrinkability,
                componentCount,
                _lineWidth,
                breaks);

            // lay out components according to line breaks
            // ...
        }
    }
}