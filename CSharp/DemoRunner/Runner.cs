using System;
using System.Collections.Generic;
using System.Linq;

namespace DemoRunner
{
    public class Runner
    {
        Dictionary<string, Action> demosToRun = 
            new Dictionary<string, Action>();

        public void Add(string name, Action demoToRun) 
        {
            demosToRun.Add(name, demoToRun);
        }

        public void Run()
        {
            while(true) 
            {
                Console.WriteLine("Please select the demo to run:");

                foreach (var demo in demosToRun)
                {
                    Console.WriteLine(demo.Key);
                }

                Console.Write(">");
                var response = Console.ReadLine();

                var choices = demosToRun.Keys.Where((key) => key.StartsWith(response));

                if (choices.Count() > 1)
                {
                    Console.WriteLine("Please disambiguate between...");
                    break;
                }

                if (choices.Count() == 0) 
                {
                    Console.WriteLine("Please use a letter that starts with...");
                    break;
                }

                var choice = choices.Single();

                Console.WriteLine("++++++++++++++++");
                Console.WriteLine();

                Console.WriteLine("Running " + choice);
                var action = demosToRun[choice];
                action();

                Console.WriteLine();
                Console.WriteLine("++++++++++++++++");
            }
        }
    }
}
