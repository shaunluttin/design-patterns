using System;
using System.Collections.Generic;
using System.Linq;

namespace DemoRunner
{
    public class Runner
    {
        private Dictionary<string, Action> _demosToRun = new Dictionary<string, Action>();

        public Action Stop { get; set; }

        public void Add(string name, Action demoToRun)
        {
            _demosToRun.Add(name, demoToRun);
        }

        public void Start()
        {
            while (true)
            {
                Console.WriteLine("Select a demo to run (Ctrl + C to quit):");

                var keys = _demosToRun.Keys.ToList();
                for (var i = 0; i < keys.Count(); i = i + 1)
                {
                    Console.WriteLine(i + ":" + keys[i]);
                }

                Console.Write(">");
                var userInput = Console.ReadLine();

                int selectedIndex;
                if (!int.TryParse(userInput, out selectedIndex) || selectedIndex >= keys.Count())
                {
                    Console.WriteLine($"{userInput} is not a number between 0 and {keys.Count() - 1}.");
                    Console.WriteLine();
                    continue;
                }

                Console.WriteLine("++++++++++++++++");
                Console.WriteLine();

                var choice = keys[selectedIndex];
                Console.WriteLine("Running " + choice);
                var action = _demosToRun[choice];
                action();

                Console.WriteLine();

                Console.WriteLine("Press any key to continue");
                Console.ReadKey();

                if (Stop != null)
                {
                    Stop();
                }

                Console.WriteLine("++++++++++++++++");
                Console.WriteLine();
            }
        }
    }
}
