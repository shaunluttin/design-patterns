using CreationalPatterns.Models;
using CreationalPatterns.AbstractFactory;

namespace CreationalPatterns.AbstractFactory
{
    public class MazeGame
    {
        public Maze CreateMaze(MazeFactory factory)
        {
            // All we did was a 
            // 1. inject a `MazeFactory` and
            // 2. find-replace `new ` with `factory.Make`.

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