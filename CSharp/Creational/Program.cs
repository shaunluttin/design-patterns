using System;

namespace CreationalPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            var program = new Program();

            program.WithNaiveApproach();
            program.WithAbstractFactory();
        }

        public void WithNaiveApproach()
        {
            var mazeGame = new NaiveApproach.MazeGame();
            var maze = mazeGame.CreateMaze();
        }

        /* 
         * We can now make different kinds of mazes without 
         * modifying the `CreateMaze` method.
         */
        public void WithAbstractFactory()
        {
            var mazeGame = new AbstractFactory.MazeGame();

            var defaultMazeFactory = new AbstractFactory.MazeFactory();
            var defaultMaze = mazeGame.CreateMaze(defaultMazeFactory);

            var bombedMazeFactory = new AbstractFactory.BombedMazeFactory();
            var bombedMaze = mazeGame.CreateMaze(defaultMazeFactory);

            var enchantedMazeFactory = new AbstractFactory.EnchantedMazeFactory();
            var enchantedMaze = mazeGame.CreateMaze(enchantedMazeFactory);
        }
    }
}
