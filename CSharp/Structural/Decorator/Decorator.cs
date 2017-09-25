namespace Structural.Decorator
{
    // "... we'll subclass [this] to obtain different decorations."
    public class Decorator : VisualComponent
    {
        // "Decorator decorates the VisualComponent... which is 
        // initialized in the contructor."
        private VisualComponent _component;

        protected Decorator(VisualComponent component)
        {
            _component = component;
        }

        // "For each operation in VisualComponent... Decorator defines
        // a default implementation that passes the request on to 
        // _component. Subclasses of Decorator [will] define specific
        // decorations."
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
