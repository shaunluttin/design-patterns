namespace Structural.Adapter
{
    // For the class adapter pattern,
    // we need to use an interface for shape,
    // in order to support multiple inheritance.
    // For the object adapter pattern, 
    // we could have used a class instead.
    public interface IShape
    {
        void BoundingBox(out Point bottomLeft, out Point topRight);

        Manipulator CreateManipulator();
    }
}
