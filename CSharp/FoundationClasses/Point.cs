namespace FoundationClasses
{
    public class Point
    {
        // In Design Patterns (Gamma et al, 1994), the Point class uses
        // a Coord as a synonym for float; since C# does not provide a typedef
        // equivalent, we use float directly.
        public Point(float x = 0.0F, float y = 0.0F)
        {
            X = x;
            Y = y;
        }

        public float X { get; set; }

        public float Y { get; set; }
    }
}
