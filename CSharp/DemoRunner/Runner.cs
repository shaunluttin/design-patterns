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
                var response = Console.ReadLine();

                int result;
                if (!int.TryParse(response, out result) || result >= keys.Count())
                {
                    Console.WriteLine($"{response} is not between 0 and {keys.Count() - 1}.");
                    Console.WriteLine();
                    continue;
                }

                Console.WriteLine("++++++++++++++++");
                Console.WriteLine();

                var choice = keys[result];
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
