using Structural.Shared;

namespace Structural.Adapter.ClassAdapter
{
    // "The key to class adapters is to use one inheritance branch to inherit
    // the interface and another branch to inherit the implementation."
    // (Gamma et al, 1994)
    public class TextShape : TextView, IShape
    {
        public void BoundingBox(out Point bottomLeft, out Point topRight)
        {
            Coord bottom, left, height, width;

            GetOrigin(out bottom, out left);
            GetExtent(out width, out height);

            bottomLeft = new Point(bottom, left);
            topRight = new Point(bottom + height, left + width);
        }

        public override bool IsEmpty()
        {
            return this.IsEmpty();
        }

        public Manipulator CreateManipulator()
        {
            return new TextManipulator(this);
        }

        /* 
         * Use `private new` to mimic C++ private inheritance
         * See https://stackoverflow.com/a/33152/1108891
         */

        private new void GetOrigin(out Coord x, out Coord y)
        {
            this.GetOrigin(out x, out y);
        }

        private new void GetExtent(out Coord width, out Coord height)
        {
            this.GetExtent(out width, out height);
        }
    }
}