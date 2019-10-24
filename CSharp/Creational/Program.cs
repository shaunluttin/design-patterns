using System;
using DemoRunner;

namespace CreationalPatterns
{
    public class Program
    {
        private Runner _runner;

        public Program(Runner runner)
        {
            _runner = runner;
            _runner.Add("Naive Approach", () => WithNaiveApproach());
            _runner.Add("Abstract Factory", () => WithAbstractFactory());
            _runner.Add("Builder", () => WithBuilder());
            _runner.Add("Factory Method", () => WithFactoryMethod());
            _runner.Add("Singleton", () => WithSingleton());
            _runner.Start();
        }

        public static void Main(string[] args)
        {
            var program = new Program(new Runner());
        }

        private void WithNaiveApproach()
        {
            var mazeGame = new NaiveApproach.MazeGame();
            var maze = mazeGame.CreateMaze();
        }

        /*
         * We can now make different kinds of mazes without
         * modifying the `CreateMaze` method.
         */
        private void WithAbstractFactory()
        {
            var mazeGame = new AbstractFactory.MazeGame();

            var defaultMazeFactory = new AbstractFactory.MazeFactory();
            var defaultMaze = mazeGame.CreateMaze(defaultMazeFactory);

            var bombedMazeFactory = new AbstractFactory.BombedMazeFactory();
            var bombedMaze = mazeGame.CreateMaze(defaultMazeFactory);

            var enchantedMazeFactory = new AbstractFactory.EnchantedMazeFactory();
            var enchantedMaze = mazeGame.CreateMaze(enchantedMazeFactory);
        }

        private void WithBuilder()
        {
            var mazeGame = new Builder.MazeGame();

            var standardBuilder = new Builder.StandardMazeBuilder();
            var standardMaze = mazeGame.CreateMaze(standardBuilder);
            var standardComplexMaze = mazeGame.CreateComplexMaze(standardBuilder);

            var countingBuilder = new Builder.CountingMazeBuilder();
            mazeGame.CreateMaze(countingBuilder);
            var counts = countingBuilder.GetCounts();
            Console.WriteLine($"The maze has {counts.Rooms} rooms and {counts.Doors} doors.");
        }

        private void WithFactoryMethod()
        {
            var defaultMazeGame = new FactoryMethod.MazeGame();
            var defaultMaze = defaultMazeGame.CreateMaze();

            var enchantedMazeGame = new FactoryMethod.EnchantedMazeGame();
            var enchantedMaze = enchantedMazeGame.CreateMaze();

            var bombedMazeGame = new FactoryMethod.BombedMazeGame();
            var bombedMaze = bombedMazeGame.CreateMaze();
        }

        private void WithSingleton()
        {
            var mazeGame = new Singleton.MazeGame();

            Environment.SetEnvironmentVariable("MAZESTYLE", string.Empty);
            var defaultMaze = mazeGame.CreateMaze();

            Environment.SetEnvironmentVariable("MAZESTYLE", "bombed");
            var bombedMaze = mazeGame.CreateMaze();

            Environment.SetEnvironmentVariable("MAZESTYLE", "enchanted");
            var enchantedMaze = mazeGame.CreateMaze();
        }
    }
}
