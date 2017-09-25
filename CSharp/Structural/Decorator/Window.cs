using System;
using System.Collections.Generic;

namespace Structural.Decorator 
{
    public class Window
    {
        private List<VisualComponent> _contents = new List<VisualComponent>();

        public void SetContents(VisualComponent content)
        {
            _contents.Add(content);
        }

        public void Draw()
        {
            foreach(var c in _contents)
            {
                c.Draw();
            }
        }
    }
}