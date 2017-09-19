using System;

namespace Structural
{
    class Program
    {
        public static void Main(string[] args)
        {
            var program = new Program();

            program.Adapter();
            program.Composite();
        }

        private void Composite()
        {
            var computerAssembler = new Composite.ComputerAssembler();
            computerAssembler.AssembleComputer();
        }

        public void Adapter()
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
