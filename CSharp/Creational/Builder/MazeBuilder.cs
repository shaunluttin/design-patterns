using CreationalPatterns.Models;

namespace CreationalPatterns.Builder
{
    public abstract class MazeBuilder
    {
        /*
         * "All maze-building operations do nothing by default. They're not
         * declared pure virtual [abstract] to let derived classes override
         * only those methods in which they're interested." (Gamma et al) 
         */
        public virtual void BuildMaze() { }

        public virtual void BuildRoom(int room) { }

        public virtual void BuildDoor(int roomFrom, int roomTo) { }

        public abstract Maze GetMaze();
    }
}