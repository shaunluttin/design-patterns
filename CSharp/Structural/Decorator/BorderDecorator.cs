using System;

namespace Structural.Decorator
{
    public class BorderDecorator : Decorator
    {
        public BorderDecorator(VisualComponent component, int borderWidth) 
        : base(component)
        {
        }

        public override void Draw() 
        {
            base.Draw();
            DrawBorder();
        }

        private void DrawBorder()
        {
            System.Console.WriteLine("Drawing border...");
        }
    }
}