using System;
using System.Collections.Generic;
using System.Linq;
using DemoRunner;

namespace Structural
{
    public class Program
    {
        private Runner _runner;

        public Program(Runner runner)
        {
            _runner = runner;
            _runner.Add("Adapter", () => WithAdapter());
            _runner.Add("Composite", () => WithComposite());
            _runner.Add("Decorator", () => WithDecorator());
            _runner.Start();
        }

        public static void Main(string[] args)
        {
            var program = new Program(new Runner());
        }

        private void WithDecorator()
        {
            var window = new Decorator.Window();
            var textView = new Decorator.TextView();

            window.SetContents(
                new Decorator.BorderDecorator(
                    new Decorator.ScrollDecorator(textView), 1));

            window.Draw();
        }

        private void WithComposite()
        {
            var computerAssembler = new Composite.ComputerAssembler();
            computerAssembler.AssembleComputer();
        }

        private void WithAdapter()
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
