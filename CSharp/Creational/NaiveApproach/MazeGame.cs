using CreationalPatterns.Models;

namespace CreationalPatterns.NaiveApproach
{
    public class MazeGame
    {
        /*
         * "This function is pretty complicated, considering all it does 
         * is create a maze with two rooms." The problem is its 
         * inflexibility, because "it hard codes the maze layout." 
         * (Gamma et al, 1994) 
         */
        public Maze CreateMaze()
        {
            var aMaze = new Maze();
            var r1 = new Room(1);
            var r2 = new Room(2);
            var theDoor = new Door(r1, r2);

            aMaze.AddRoom(r1);
            aMaze.AddRoom(r2);

            r1.SetSide(Direction.North, new Wall());
            r1.SetSide(Direction.East, theDoor);
            r1.SetSide(Direction.South, new Wall());
            r1.SetSide(Direction.West, new Wall());

            r2.SetSide(Direction.North, new Wall());
            r2.SetSide(Direction.East, new Wall());
            r2.SetSide(Direction.South, new Wall());
            r2.SetSide(Direction.West, theDoor);

            return aMaze;
        }
    }
}