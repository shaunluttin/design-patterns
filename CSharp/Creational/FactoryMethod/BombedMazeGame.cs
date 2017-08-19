using CreationalPatterns.Models;

namespace CreationalPatterns.FactoryMethod
{
    public class EnchantedMazeGame : MazeGame
    {
        protected override Room MakeRoom(int n)
        {
            return new RoomWithABomb(n);
        }

        protected override Wall MakeWall()
        {
            return new BombedWall();
        }
    }
}