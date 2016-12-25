using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World!");

        var root = new Composite();
        root.Add(new Leaf());

        var branch00 = new Composite();
        branch00.Add(new Leaf());
        branch00.Add(new Leaf());
        branch00.Add(new Leaf());
        branch00.Add(new Leaf());
        branch00.Add(new Leaf());
        branch00.Add(new Leaf());

        var branch01 = new Composite();
        branch01.Add(new Leaf());
        branch01.Add(new Leaf());
        branch01.Add(new Leaf());
        branch01.Add(branch00);
        branch01.Add(new Leaf());
        branch01.Add(new Leaf());

        var branch02 = new Composite();
        branch02.Add(new Leaf());
        branch02.Add(new Leaf());
        branch02.Add(new Leaf());
        branch02.Add(branch01);
        branch02.Add(new Leaf());
        branch02.Add(new Leaf());
        branch02.Add(branch01);

        root.Add(branch01);
        root.Add(branch02);

        root.DoSomething("~");
    }
}
