using Structural.Shared;

namespace Structural.Adapter
{
    // For the class adapter pattern,
    // we use an interface for shape,
    // in order to support multiple inheritance.
    // For the object adapter pattern, 
    // we could have used a class.
    // "A class adapter uses multiple inheritance to adapt interfaces."
    // (Gamma at al, 1994)
    public interface IShape
    {
        void BoundingBox(out Point bottomLeft, out Point topRight);

        Manipulator CreateManipulator();
    }
}
