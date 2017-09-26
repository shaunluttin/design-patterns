using System.Collections.Generic;

namespace Behavioral.Strategy
{
    public class Composition
    {
        private Compositor _compositor;

        private List<Component> _components = new List<Component>();

        private int _componentCount;

        private int _lineWidth;

        private int _lineBreaks;

        private int _lineCount;

        public Composition(Compositor compositor)
        {
            _compositor = compositor;
        }

        public void Repair()
        {
            
        }
    }
}