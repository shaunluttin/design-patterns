using System;
using System.Collections.Generic;
using System.Linq;

namespace Structural
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var program = new Program();
            program.RunDemo();
        }

        // TODO: Share this routine with the other Program.cs files.
        private void RunDemo()
        {
            var dictionary = new Dictionary<string, Action>();
            dictionary.Add("Adapter", () => WithAdapter());
            dictionary.Add("Composite", () => WithComposite());
            dictionary.Add("Decorator", () => WithDecorator());

            while (true)
            {
                Console.WriteLine("Choose a demo to run by its first letter(s):");
                Console.WriteLine();

                foreach (var pair in dictionary)
                {
                    Console.WriteLine($"{pair.Key}");
                }

                Console.WriteLine();
                Console.Write(">");
                var response = Console.ReadLine();

                var choices = dictionary
                    .Where((pair) => pair.Key.StartsWith(response));

                if (choices.Count() == 1)
                {
                    var choice = choices.First();
                    Console.WriteLine("+++++++++++++++");
                    Console.WriteLine($"Running {choice.Key}");

                    Console.WriteLine();
                    choice.Value();
                    Console.WriteLine();

                    Console.WriteLine("+++++++++++++++");
                }
            }
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
