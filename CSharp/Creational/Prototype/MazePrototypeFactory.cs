using CreationalPatterns.AbstractFactory;
using CreationalPatterns.Models;

namespace CreationalPatterns.Prototype
{
    /*
     * "MazePrototypeFactory will be initialized with prototypes of of the
     * objects it will create so that we don't have to subclass it just to
     * change the classes of the of walls or rooms it creates."
     * (Gamme et al)
     */
    public class MazePrototypeFactory : MazeFactory
    {
        private readonly Maze _maze;
        private readonly Wall _wall;
        private readonly Room _room;
        private readonly Door _door;

        public MazePrototypeFactory(Maze m, Wall w, Room r, Door d)
        {
            _maze = m;
            _wall = w;
            _room = r;
            _door = d;
        }

        public override Maze MakeMaze()
        {
            return _maze.Clone();
        }

        public override Wall MakeWall()
        {
            return _wall.Clone();
        }

        public override Room MakeRoom(int n)
        {
            var room = _room.Clone();
            room.Initialize(n);
            return room;
        }

        public override Door MakeDoor(Room room1, Room room2)
        {
            var door = _door.Clone();
            door.Initialize(room1, room2);
            return door;
        }
    }
}
