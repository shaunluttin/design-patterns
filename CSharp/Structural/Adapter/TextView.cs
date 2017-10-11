namespace Structural.Adapter
{
    public class TextView
    {
        public void GetOrigin(out float x, out float y)
        {
            x = 0;
            y = 0;
        }

        public void GetExtent(out float width, out float height)
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
