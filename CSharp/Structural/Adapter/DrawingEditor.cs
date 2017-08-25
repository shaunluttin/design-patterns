using System.Collections.Generic;
using Structural.Shared;

namespace Structural.Adapter
{
    public class DrawingEditor
    {
        private List<IShape> _shapes = new List<IShape>();

        public void DoStuffWithAllShapes()
        {
            Point x, y;
            foreach (var shape in _shapes)
            {
                shape.BoundingBox(out x, out y);
                var manipulator = shape.CreateManipulator();
                // do stuff...
            }
        }

        public void AddTextView()
        {
            // class adapter
            var textShape01 = new ClassAdapter.TextShape();

            // object adapter: more flexible at the cost of more code
            var textView = new TextView();
            var textShape02 = new ObjectAdapter.TextShape(textView);

            // Clients that expect an `IShape`
            // can now work with a `TextView`.
            _shapes.Add(textShape01);
            _shapes.Add(textShape02);
        }
    }
}
