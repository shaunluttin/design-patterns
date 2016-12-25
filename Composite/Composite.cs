using System;
using System.Collections.Generic;
using System.Linq;

public class Composite : IComponent
{
    private List<IComponent> _children = new List<IComponent>();

    public void Add(IComponent child)
    {
        _children.Add(child);
    }

    public void DoSomething(string message)
    {
        var random = new Random();
        Action<Stack<IComponent>> tellAllChildren = null;
        tellAllChildren = (stack) => {
            if(stack.Count != 0) {
                stack
                    .Pop()
                    .DoSomething(string.Concat(Enumerable.Repeat(message, random.Next(1, 5))));
                tellAllChildren(stack);
            }
        };

        tellAllChildren(new Stack<IComponent>(_children));
    }
}