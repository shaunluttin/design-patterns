using System;
using System.Collections.Generic;
using System.Linq;

namespace Structural
{
    public static class Demo
    {
        public static Dictionary<string, Action> Demos = new Dictionary<string, Action>
        {
            { "Adapter", () => Structural.Demo.WithAdapter() },
            { "Composite", () => Structural.Demo.WithComposite() },
            { "Decorator", () => Structural.Demo.WithDecorator() },
        };

        private static void WithDecorator()
        {
            var window = new Decorator.Window();
            var textView = new Decorator.TextView();

            window.SetContents(
                new Decorator.BorderDecorator(
                    new Decorator.ScrollDecorator(textView), 1));

            window.Draw();
        }

        private static void WithComposite()
        {
            var computerAssembler = new Composite.ComputerAssembler();
            computerAssembler.AssembleComputer();
        }

        private static void WithAdapter()
        {
            var editor = new Adapter.DrawingEditor();

            // class adapter
            var textShape01 = new Adapter.ClassAdapter.TextShape();

            // object adapter: composition is more flexible at the cost of more code
            var textView = new Adapter.TextView();
            var textShape02 = new Adapter.ObjectAdapter.TextShape(textView);

            // Clients that expect an `IShape`
            // can now work with a `TextView`.
            editor.AddShape(textShape01);
            editor.AddShape(textShape02);

            editor.DoStuffWithAllShapes();
        }
    }
}
