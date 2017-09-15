using Structural.Shared;

namespace Structural.Adapter
{
    // For the class adapter pattern, we use an interface for shape,
    // because the "class adapter uses multiple inheritance to adapt interfaces."
    // (Gamma at al, 1994)
    public interface IShape
    {
        void BoundingBox(out Point bottomLeft, out Point topRight);

        Manipulator CreateManipulator();
    }

    // For the object adapter pattern, we can use a class, because
    // the object adapter uses composition instead of multiple inheritance.
    public abstract class Shape
    {
        public abstract void BoundingBox(out Point bottomLeft, out Point topRight);

        public abstract Manipulator CreateManipulator();
    }
}
