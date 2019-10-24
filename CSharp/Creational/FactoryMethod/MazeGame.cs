using CreationalPatterns.Models;

namespace CreationalPatterns.FactoryMethod
{
    /*
     * "Maze game provides default implementations that return the
     * simplest kinds of maze, rooms, walls, and doors." (Gamma et al)
     */
    public class MazeGame
    {
        public Maze CreateMaze()
        {
            var aMaze = MakeMaze();
            var r1 = MakeRoom(1);
            var r2 = MakeRoom(2);
            var theDoor = MakeDoor(r1, r2);

            aMaze.AddRoom(r1);
            aMaze.AddRoom(r2);

            r1.SetSide(Direction.North, MakeWall());
            r1.SetSide(Direction.East, theDoor);
            r1.SetSide(Direction.South, MakeWall());
            r1.SetSide(Direction.West, MakeWall());

            r2.SetSide(Direction.North, MakeWall());
            r2.SetSide(Direction.East, MakeWall());
            r2.SetSide(Direction.South, MakeWall());
            r2.SetSide(Direction.West, theDoor);

            return aMaze;
        }

        protected virtual Maze MakeMaze()
        {
            return new Maze();
        }

        protected virtual Room MakeRoom(int n)
        {
            return new Room(n);
        }

        protected virtual Wall MakeWall()
        {
            return new Wall();
        }

        protected virtual Door MakeDoor(Room room1, Room room2)
        {
            return new Door(room1, room2);
        }
    }
}
