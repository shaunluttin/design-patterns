namespace Structural.Adapter.ObjectAdapter
{
    public class TextShape : IShape
    {
        private readonly TextView _textView;

        public TextShape(TextView textView)
        {
            _textView = textView;
        }

        public void BoundingBox(out Point bottomLeft, out Point topRight)
        {
            int bottom, left, height, width = 0;

            _textView.GetOrigin(out bottom, out left);
            _textView.GetExtent(out width, out height);

            bottomLeft = new Point(bottom, left);
            topRight = new Point(bottom + height, left + width);
        }

        public Manipulator CreateManipulator()
        {
            return new TextManipulator(this);
        }

        public bool IsEmpty() => _textView.IsEmpty();
    }
}