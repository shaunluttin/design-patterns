using Creational.Models;

namespace Creational.Singleton
{
    public class MazeGame
    {
        public Maze CreateMaze()
        {
            var factory = MazeFactorySingleton.Instance();

            var aMaze = factory.MakeMaze();
            var r1 = factory.MakeRoom(1);
            var r2 = factory.MakeRoom(2);
            var theDoor = factory.MakeDoor(r1, r2);

            aMaze.AddRoom(r1);
            aMaze.AddRoom(r2);

            r1.SetSide(Direction.North, factory.MakeWall());
            r1.SetSide(Direction.East, theDoor);
            r1.SetSide(Direction.South, factory.MakeWall());
            r1.SetSide(Direction.West, factory.MakeWall());

            r2.SetSide(Direction.North, factory.MakeWall());
            r2.SetSide(Direction.East, factory.MakeWall());
            r2.SetSide(Direction.South, factory.MakeWall());
            r2.SetSide(Direction.West, theDoor);

            return aMaze;
        }
    }
}
