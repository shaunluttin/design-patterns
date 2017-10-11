using FoundationClasses;

namespace Structural.Adapter.ObjectAdapter
{
    // "The object adapter requires a little more effort to write,
    // but it's more flexible... the object adapter version... will
    // work equally well with subclasses of TextView - the client simply
    // passes an instance of a... subclass."
    public class TextShape : IShape
    {
        private readonly TextView _textView;

        public TextShape(TextView textView)
        {
            _textView = textView;
        }

        public void BoundingBox(out Point bottomLeft, out Point topRight)
        {
            float bottom, left, height, width;

            _textView.GetOrigin(out bottom, out left);
            _textView.GetExtent(out width, out height);

            bottomLeft = new Point(bottom, left);
            topRight = new Point(bottom + height, left + width);
        }

        public bool IsEmpty() => _textView.IsEmpty();

        public Manipulator CreateManipulator()
        {
            return new TextManipulator(this);
        }
    }
}
