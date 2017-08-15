using CreationalPatterns.Models;

namespace CreationalPatterns.AbstractFactory {

    public class EnchantedMazeFactory : MazeFactory
    {
        public override Door MakeDoor(Room room1, Room room2)
        {
            throw new System.NotImplementedException();
        }

        public override Maze MakeMaze()
        {
            throw new System.NotImplementedException();
        }

        public override Room MakeRoom(int n)
        {
            throw new System.NotImplementedException();
        }

        public override Wall MakeWall()
        {
            throw new System.NotImplementedException();
        }
    }
}