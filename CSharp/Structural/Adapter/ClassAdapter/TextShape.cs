namespace Structural.Adapter.ClassAdapter
{
    public class TextShape : TextView, IShape
    {
        public void BoundingBox(out Point bottomLeft, out Point topRight)
        {
            int bottom, left, height, width = 0;

            GetOrigin(out bottom, out left);
            GetExtent(out width, out height);

            bottomLeft = new Point(bottom, left);
            topRight = new Point(bottom + height, left + width);
        }

        public Manipulator CreateManipulator()
        {
            return new TextManipulator(this);
        }

        /* 
         * Mimic private inheritance
         * See https://stackoverflow.com/a/33152/1108891
         */

        private new void GetOrigin(out int x, out int y)
        {
            (this as TextView).GetOrigin(out x, out y);
        }

        private new void GetExtent(out int width, out int height)
        {
            (this as TextView).GetExtent(out width, out height);
        }
    }
}