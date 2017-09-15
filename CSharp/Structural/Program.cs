using System;

namespace Structural
{
    class Program
    {
        static void Main(string[] args)
        {
            var program = new Program();
        }

        public void Adapter() 
        {
            var editor = new Adapter.DrawingEditor();

            // class adapter
            var textShape01 = new Adapter.ClassAdapter.TextShape();

            // object adapter: more flexible at the cost of more code
            var textView = new Adapter.TextView();
            var textShape02 = new Adapter.ObjectAdapter.TextShape(textView);

            // Clients that expect an `IShape`
            // can now work with a `TextView`.
            editor.AddShape(textShape01);
        }
    }
}
