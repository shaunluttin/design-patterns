using System;
using System.Collections.Generic;
using System.Linq;

namespace Demo
{
    public class Program
    {
        private Dictionary<string, Action> _dictionary = new Dictionary<string, Action>();

        public static void Main(string[] args)
        {
            var program = new Program();
            program.RunDemo();

            foreach (var pair in Structural.Demo.Demos.Concat(Creational.Demo.Demos))
            {
                program._dictionary.Add(pair.Key, pair.Value);
            }
        }

        private void RunDemo()
        {
            while (true)
            {
                Console.WriteLine("Choose a demo to run by its first letter(s):");
                Console.WriteLine();

                foreach (var pair in _dictionary)
                {
                    Console.WriteLine($"{pair.Key}");
                }

                Console.WriteLine();
                Console.Write(">");
                var response = Console.ReadLine();

                var choices = _dictionary.Where((pair) =>
                    pair.Key.ToLower().StartsWith(response.ToLower()));

                if (choices.Count() > 1)
                {
                    Console.WriteLine("Unable to disambiguate among:");
                    foreach (var c in choices)
                    {
                        Console.WriteLine(c.Key);
                    }

                    Console.WriteLine();
                    continue;
                }

                var choice = choices.First();
                Console.WriteLine("+++++++++++++++");
                Console.WriteLine($"Running {choice.Key}");

                Console.WriteLine();
                choice.Value();
                Console.WriteLine();

                Console.WriteLine("+++++++++++++++");
            }
        }
    }
}
