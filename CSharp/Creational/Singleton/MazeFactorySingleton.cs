using System;
using CreationalPatterns.Models;
using CreationalPatterns.AbstractFactory;

namespace CreationalPatterns.Singleton
{
    public class MazeFactorySingleton : MazeFactory
    {
        private static MazeFactory _instance;

        private MazeFactorySingleton() { }

        public static MazeFactory Instance()
        {
            if (_instance == null)
            {
                _instance = new MazeFactory();
            }

            return _instance;
        }

        public static MazeFactory InstanceFromEnv()
        {
            if (_instance == null)
            {
                var env = Environment.GetEnvironmentVariable("MAZESTYLE");
                if (env == "bombed")
                {
                    _instance = new BombedMazeFactory();
                }
                else if (env == "enchanted")
                {
                    _instance = new EnchantedMazeFactory();
                }
                else
                {
                    _instance = new MazeFactory();
                }
            }

            return _instance;
        }
    }
}
