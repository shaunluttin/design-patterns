using CreationalPatterns.Models;

namespace CreationalPatterns.AbstractFactory
{
    public class BombedMazeFactory : MazeFactory
    {
        public override Room MakeRoom(int n)
        {
            return new RoomWithABomb(n);
        }

        public override Wall MakeWall()
        {
            return new BombedWall();
        }
    }
}