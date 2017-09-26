using System;

namespace Behavioral.TemplateMethod
{
    public class MyView : View
    {
        protected override void DoDisplay()
        {
            Console.WriteLine("Doing display...");
        }
    }
}