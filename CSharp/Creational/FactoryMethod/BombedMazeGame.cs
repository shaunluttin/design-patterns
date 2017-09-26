using Creational.Models;

namespace Creational.FactoryMethod
{
    public class BombedMazeGame : MazeGame
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
