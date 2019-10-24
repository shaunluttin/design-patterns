using FoundationClasses;
using Structural;

namespace Structural.Adapter.ClassAdapter
{
    // "The key to class adapters is to use one inheritance branch to inherit
    // the interface and another branch to inherit the implementation."
    // (Gamma et al, 1994)
    public class TextShape : TextView, IShape
    {
        public void BoundingBox(out Point bottomLeft, out Point topRight)
        {
            float bottom, left, height, width;

            GetOrigin(out bottom, out left);
            GetExtent(out width, out height);

            bottomLeft = new Point(bottom, left);
            topRight = new Point(bottom + height, left + width);
        }

        // IsEmpty "demonstrates the direct forwarding of requests
        // common in adapter implementations". (Gamma et al, 1994)
        public override bool IsEmpty()
        {
            return this.IsEmpty();
        }

        public Manipulator CreateManipulator()
        {
            return new TextManipulator(this);
        }

        // To mimic C++ private inheritance,
        // use `private new` to hide the public method,
        // and delegate to the base class to prevent a StackOverflowException.
        private new void GetOrigin(out float x, out float y)
        {
            base.GetOrigin(out x, out y);
        }

        private new void GetExtent(out float width, out float height)
        {
            base.GetExtent(out width, out height);
        }
    }
}
