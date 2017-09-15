using Structural.Shared;

namespace Structural.Adapter
{
    public class TextView
    {
        public void GetOrigin(out Coord x, out Coord y)
        {
            x = 0;
            y = 0;
        }

        public void GetExtent(out Coord width, out Coord height)
        {
            width = 0;
            height = 0;
        }

        public virtual bool IsEmpty()
        {
            throw new System.NotImplementedException();
        }
    }
}
