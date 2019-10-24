using System;

namespace Behavioral.TemplateMethod
{
    // "... supports drawing on the screen."
    // (Gamma et al, 1994)
    public abstract class View
    {
        // "... enforces the invariant that its subclasses can draw into a
        // view only after it becomes the focus..."
        // (Gamma et al, 1994)
        public void Display()
        {
            SetFocus();
            DoDisplay();
            ResetFocus();
        }

        protected abstract void DoDisplay();

        private void ResetFocus()
        {
            Console.WriteLine("Resetting the focus...");
        }

        private void SetFocus()
        {
            Console.WriteLine("Setting the focus...");
        }
    }
}