namespace Structural.Decorator
{
    public class Decorator : VisualComponent
    {
        private VisualComponent _component;

        protected Decorator(VisualComponent component)
        {
            _component = component;
        }

        public override void Draw()
        {
            _component.Draw();
        }

        public override void Resize()
        {
            _component.Resize();
        }
    }
}
