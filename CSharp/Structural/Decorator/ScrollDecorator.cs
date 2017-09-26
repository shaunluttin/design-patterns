namespace Structural.Decorator
{
    public class ScrollDecorator : Decorator
    {
        public ScrollDecorator(VisualComponent component)
        : base(component)
        {
        }

        public override void Draw()
        {
            base.Draw();
            DrawScrollbar();
        }

        private void DrawScrollbar()
        {
            System.Console.WriteLine("Drawing scroll bar...");
        }
    }
}