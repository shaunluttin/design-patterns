namespace Structural.Adapter
{
    public class TextManipulator : Manipulator
    {
        public TextManipulator(ClassAdapter.TextShape textShape) : base(textShape) { }

        public TextManipulator(ObjectAdapter.TextShape textShape) : base(textShape) { }
    }
}
