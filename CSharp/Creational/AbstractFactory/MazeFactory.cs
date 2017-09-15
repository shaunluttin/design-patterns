using CreationalPatterns.Models;

namespace CreationalPatterns.AbstractFactory
{
    /*
     * "Note that `MazeFactory` is just a collection of factory methods...
     * Also note that [it] is not an abstract class; thus it acts as both 
     * the AbstractFactory and the ConcreteFactory."
     * (Gamma et al)
     */
    public class MazeFactory
    {
        public virtual Maze MakeMaze()
        {
            return new Maze();
        }

        public virtual Wall MakeWall()
        {
            return new Wall();
        }

        public virtual Room MakeRoom(int n)
        {
            return new Room(n);
        }

        public virtual Door MakeDoor(Room room1, Room room2)
        {
            return new Door(room1, room2);
        }
    }
}