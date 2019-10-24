namespace Structural.Decorator
{
    public class TextView : VisualComponent
    {
        public override void Draw()
        {
            System.Console.WriteLine($"Drawing a {nameof(TextView)}");
        }

        public override void Resize()
        {
            System.Console.WriteLine($"Resizing a {nameof(TextView)}");
        }
    }
}