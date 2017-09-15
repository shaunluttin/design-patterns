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

        public void AddShape(IShape shape)
        {
            _shapes.Add(shape);
        }
    }
}
