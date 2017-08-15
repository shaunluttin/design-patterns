using System;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            var builder = new ConcreteBuilder();
            var director = new Director(builder);
            director.BuildProductWithTwoArms();

            var product = builder.GetResult();

            foreach (var part in product.Parts)
            {
                Console.WriteLine(part);
                Console.WriteLine("Hello World!");
            }
        }
    }
}
